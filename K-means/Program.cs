using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace K_means {
    public static class Program {
        static void Main() {
            // start GUI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // method for running the k-means algorithm, called by the GUI
        public static object[] kMeans(bool[] checkBoxes, double trainPercent) {
            Random rand = new Random(); // initialize random variable

            bool sameCentroids = false; // keeps track of if the previous centroids are the same as the current centroids in while loop

            int k = 3; // number of clusters
            int spliceIndex; // index of train dataset to splice for test dataset
            int correctCount = 0; // number of correctly assigned test dataset objects
            int numChecked = 0; // number of data field checkboxes checked

            string traceLog = ""; // long string containing the tracelog for this run
            string[] labels = new string[] { "Iris-setosa", "Iris-versicolor", "Iris-virginica" }; // the 3 possible cluster labels
            string[] clusterModes = new string[k]; // array that stores the most common label for each cluster

            List<DSObject> dataSet = new List<DSObject>(); // list of DSObjects to train with
            List<DSObject> testSet; // list of DSObjects to test with
            List<DSObject> centroids = new List<DSObject>(); // list of DSObjects that represent the centroids
            List<DSObject>[] clusters = new List<DSObject>[k]; // array of lists that represent the clusters

            // count number of data field checkboxes checked
            for (int i = 0; i < checkBoxes.Length; i++)
                if (checkBoxes[i])
                    numChecked++;

            // if there are none checked, don't run
            if (numChecked < 1)
                return new object[] {
                    null,
                    null,
                    null,
                    null,
                    "You must check at least 1 data type.",
                };

            // import dataset objects from Iris.csv using streamreader
            traceLog += "Importing dataset from Iris.csv";
            try {
                using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + @"..\..\..\..\dataset\Iris.csv")) {
                    reader.ReadLine();
                    while (!reader.EndOfStream) {
                        string[] lineValues = reader.ReadLine().Split(',');
                        List<double> DSObjectData = new List<double>();
                        for (int i = 0; i < 4; i++)
                            if (checkBoxes[i])
                                DSObjectData.Add(double.Parse(lineValues[i + 1]));

                        dataSet.Add(new DSObject(DSObjectData.ToArray(), lineValues[0], lineValues[5]));
                    }
                }
            } catch (FileNotFoundException e) {
                return new object[] {
                    null,
                    null,
                    null,
                    null,
                    "Dataset file Iris.csv not found. Place the file in the 'dataset' directory.",
                };
            }

            // randomize dataset so we can correctly splice it
            traceLog += "\nRandomizing dataset";
            for (int i = dataSet.Count - 1; i > 1; i--) {
                int swapIndex = rand.Next(i + 1);
                DSObject swap = dataSet[swapIndex];
                dataSet[swapIndex] = dataSet[i];
                dataSet[i] = swap;
            }

            // splice dataset and put spliced values into testset for training
            spliceIndex = (int)(trainPercent * dataSet.Count);
            traceLog += "\nsetting apart " + (dataSet.Count - spliceIndex) + " values for testing";
            testSet = dataSet.GetRange(spliceIndex, dataSet.Count - spliceIndex);
            dataSet.RemoveRange(spliceIndex, dataSet.Count - spliceIndex);

            traceLog += "\nusing k-means++ to determine initial centroids";

            // choose random data point for centroid 0
            centroids.Add(dataSet[rand.Next(dataSet.Count)].cloneThis());
            traceLog += "\npoint " + centroids[0] + " chosen as centroid 0";

            // determine initial centroids with k-means++
            for (int i = 1; i < k; i++) {
                double distanceSum = 0;
                for (int j = 0; j < dataSet.Count; j++) {
                    // use findNearestCentroid to set the DSObject's nearest centroid distance,
                    // and find the sum of these distances squared for weighted probability distribution calculation
                    dataSet[j].findNearestCentroid(centroids);
                    distanceSum += Math.Pow(dataSet[j].nearestCentroidDistance, 2);
                }

                // sort DSObjects by centroid distance for weighted probability distribution calculation
                dataSet.Sort(delegate (DSObject x, DSObject y) {
                    return x.nearestCentroidDistance.CompareTo(y.nearestCentroidDistance);
                });

                // choose random data point for new centroid using weighted probability distribution
                // proportional to the nearestCentroidDistance of the point squared.
                double random = rand.NextDouble();
                for (int j = 0; j < dataSet.Count; j++) {
                    if ((random -= (Math.Pow(dataSet[j].nearestCentroidDistance, 2) / distanceSum)) < 0) {
                        centroids.Add(dataSet[j].cloneThis());
                        traceLog += "\npoint " + centroids[i] + " chosen as initial centroid " + i;
                        break;
                    }
                }
            }
            
            // while loop for running the k-means clustering algorithm
            traceLog += "\nstarting k-means loop";
            while (!sameCentroids) {
                // initialize empty clusters for the loop
                for (int i = 0; i < clusters.Length; i++)
                    clusters[i] = new List<DSObject>();

                // add dataset objects to the cluster with the centroid closest to them
                for (int i = 0; i < dataSet.Count; i++)
                    clusters[dataSet[i].findNearestCentroid(centroids)].Add(dataSet[i]);

                // for each cluster,
                sameCentroids = true; // set boolean sameCentroids as true
                for (int i = 0; i < clusters.Length; i++) {
                    // get a new centroid that is the average of all of the dataset objects in the cluster
                    DSObject newCentroid = DSObject.getCentroidFromCluster(clusters[i]);

                    // if the cluster is empty, use the previous centroid
                    if (newCentroid == null)
                        newCentroid = centroids[i];

                    // if previous centroid is NOT the same as new centroid, set sameCentroids to false and assign new centroid
                    if (!centroids[i].Equals(newCentroid)) {
                        sameCentroids = false;
                        centroids[i] = newCentroid;
                    } // if all previous centroids were the same as all new centroids, sameCentroids will be true

                    // report values in clusters to tracelog
                    traceLog += "\ncluster " + i + ": [ ";
                    for (int j = 0; j < clusters[i].Count; j++)
                        traceLog += clusters[i][j] + " ";
                    traceLog += "]\n";
                }

                // report centroids to tracelog
                for (int i = 0; i < centroids.Count; i++) {
                    if (sameCentroids)
                        traceLog += "final";
                    else
                        traceLog += "new";
                    traceLog += " centroid " + i + ": " + centroids[i].ToString() + "\n";
                }
            }

            // for each cluster, calculate which label appears the most
            traceLog += "\ncalculating majority label for clusters";
            for (int i = 0; i < clusters.Length; i++) {
                int[] labelCounts = new int[] { 0, 0, 0 };
                string mode = "";
                for (int j = 0; j < clusters[i].Count; j++) {
                    for (int m = 0; m < labelCounts.Length; m++) {
                        if (clusters[i][j].label == labels[m]) {
                            labelCounts[m]++;
                            if (labelCounts[m] > labelCounts[(m + 1) % 3] && labelCounts[m] > labelCounts[(m + 2) % 3])
                                mode = labels[m];
                        }
                    }
                }
                clusterModes[i] = mode; // record the majority label in clusterModes
            }

            // test DSObjects in testSet with final clusters
            traceLog += "\ntesting " + testSet.Count + " remaining dataset values";
            for (int i = 0; i < testSet.Count; i++) {
                // add test DSObject to closest cluster
                int centroidIndex = testSet[i].findNearestCentroid(centroids);
                clusters[centroidIndex].Add(testSet[i]);

                // if test DSObject label matches majority cluster label, increment correct count
                if (testSet[i].label == clusterModes[centroidIndex]) {
                    testSet[i].correct = 1;
                    correctCount++;
                } else {
                    testSet[i].correct = -1;
                }
            } // the 'correct' property tells the GUI how to display the DSObject

            traceLog += "\nAccuracy is " + correctCount / (double)testSet.Count * 100;

            // return results from k-means clustering for displaying in the GUI
            return new object[] {
                clusters,
                centroids,
                clusterModes,
                correctCount / (double)testSet.Count * 100,
                traceLog,
            };
        }

        // class for DataSet Objects
        public class DSObject {
            private double[] data; // the data values for this dataset object

            public string ID; // the ID for this dataset object, provided by the dataset (1-150)
            public string label; // the label for this dataset object, provided by the dataset

            public double nearestCentroidDistance; // distance to the nearest centroid, set by findNearestCentroid

            public int correct = 0; // 1 = this DSObject tested correctly, -1 = this DSObject tested incorrectly, 0 = this is not a test DSObject

            // constructor
            public DSObject(double[] newData, string newID = null, string newLabel = null) {
                data = newData;
                ID = newID;
                label = newLabel;
            }

            // method to get the euclidean distance from another given DSObject
            public double getDistanceFrom(DSObject centroid) {
                double total = 0;
                for (int i = 0; i < data.Length; i++)
                    total += Math.Pow(data[i] - centroid.data[i], 2);
                return Math.Sqrt(total);
            }

            // method to find the nearest centroid's index from a list of centroids
            public int findNearestCentroid(List<DSObject> centroids) {
                double minDistance = getDistanceFrom(centroids[0]);
                int minDistanceIndex = 0;
                for (int j = 0; j < centroids.Count; j++) {
                    double distance = getDistanceFrom(centroids[j]);
                    if (minDistance > distance) {
                        minDistance = distance;
                        minDistanceIndex = j;
                    }
                }
                nearestCentroidDistance = minDistance; // this method also sets the property nearestCentroidDistance
                return minDistanceIndex;
            }

            // method to generate a new centroid DSObject that is the average of a list of DSObjects
            public static DSObject getCentroidFromCluster(List<DSObject> cluster) {
                if (cluster.Count == 0) // if cluster is empty, return null
                    return null;
                double[] centroidData = new double[cluster[0].data.Length];
                for (int i = 0; i < cluster[0].data.Length; i++) {
                    double sum = 0;
                    for (int j = 0; j < cluster.Count; j++)
                        sum += cluster[j].data[i];
                    centroidData[i] = sum / cluster.Count;
                }
                return new DSObject(centroidData);
            }

            // method to generate a copy of this DSObject
            public DSObject cloneThis() {
                double[] newData = new double[data.Length];
                data.CopyTo(newData, 0);
                return new DSObject(newData, null, label);
            }

            // override method for displaying a DSObject as a string (includes the ID, label, and data values)
            public override string ToString() {
                string s = "";
                if (ID != null)
                    s += "ID:" + ID + " ";
                if (label != null)
                    s += "Label:" + label + " ";
                s += "Value:(" + data[0].ToString("0.#");
                for (int i = 1; i < data.Length; i++)
                    s += ", " + data[i].ToString("0.#");
                return s + ")";
            }

            // override method for comparing two DSObjects (only compares data values)
            public override bool Equals(object o) {
                for (int i = 0; i < data.Length; i++)
                    if (data[i] != ((DSObject)o).data[i])
                        return false;
                return true;
            }
        }
    }
}