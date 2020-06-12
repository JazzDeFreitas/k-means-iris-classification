using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static K_means.Program;

namespace K_means {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public double getTrainPercent() {
            return (double)percentNumericUpDown.Value / 100;
        }

        private void setTraceLog(string s) {
            try {
                if (traceLog.Text == "")
                    traceLog.AppendText(s);
                else {
                    traceLog.AppendText("\n" + s);
                }
                traceLog.ScrollToCaret();
            } catch (Exception e) { };
        }

        private void Form1_Load(object sender, EventArgs e) {
            checkBox.SetItemChecked(0, true);
            checkBox.SetItemChecked(1, true);
            checkBox.SetItemChecked(2, true);
            checkBox.SetItemChecked(3, true);
        }

        private void trainPercentageSlider_ValueChanged(object sender, EventArgs e) {
            percentNumericUpDown.Value = trainPercentageSlider.Value;
            itemsLabel.Text = (int)(getTrainPercent() * 150) + " / 150 items";
        }

        private void percentNumericUpDown_ValueChanged(object sender, EventArgs e) {
            trainPercentageSlider.Value = (int)percentNumericUpDown.Value;
            itemsLabel.Text = (int)(getTrainPercent() * 150) + " / 150 items";
        }

        private void startBtn_Click(object sender, EventArgs e) {
            RichTextBox[] clusterBoxes = new RichTextBox[] {
                    cluster1TextBox, cluster2TextBox, cluster3TextBox,
            };
            RichTextBox[] testBoxes = new RichTextBox[] {
                    testBox1, testBox2, testBox3,
            };
            Label[] centroidLabels = new Label[] {
                    cluster1CentroidLabel, cluster2CentroidLabel, cluster3CentroidLabel,
            };
            Label[] clusterLabels = new Label[] {
                    cluster1Label, cluster2Label, cluster3Label,
            };
            traceLog.Clear();
            accuracyLabel.Text = "";
            object[] results = Program.kMeans(new bool[] {
                checkBox.GetItemChecked(0),
                checkBox.GetItemChecked(1),
                checkBox.GetItemChecked(2),
                checkBox.GetItemChecked(3),
            }, getTrainPercent());

            if (results[0] == null) {
                traceLog.Text = (string)results[4];
                accuracyLabel.Text = "Accuracy:";
                for (int i = 0; i < clusterBoxes.Length; i++) {
                    clusterBoxes[i].Clear();
                    testBoxes[i].Clear();
                    centroidLabels[i].Text = "Cluster " + (i + 1) + " Centroid Value:";
                    clusterLabels[i].Text = "Cluster " + (i + 1);
                }
            } else {
                List<DSObject>[] clusters = (List<DSObject>[])results[0];
                List<DSObject> centroid = (List<DSObject>)results[1];
                string[] clusterModes = (string[])results[2];
                double accuracy = (double)results[3];
                string traceLogString = (string)results[4];

                for (int i = 0; i < clusterBoxes.Length; i++) {
                    clusterBoxes[i].Clear();
                    testBoxes[i].Clear();
                    for (int j = 0; j < clusters[i].Count; j++) {
                        if (clusters[i][j].correct == 0) {
                            clusterBoxes[i].AppendText(clusters[i][j] + "\n");
                        } else {
                            if (clusters[i][j].correct == 1) {
                                testBoxes[i].SelectionColor = Color.Green;
                            } else {
                                testBoxes[i].SelectionColor = Color.Red;
                            }
                            testBoxes[i].SelectionStart = testBoxes[i].TextLength;
                            testBoxes[i].SelectionLength = 0;
                            testBoxes[i].AppendText(clusters[i][j] + "\n");
                            testBoxes[i].SelectionColor = testBoxes[i].ForeColor;
                        }
                    }
                    clusterLabels[i].Text = "Cluster " + (i + 1) + " (" + clusterModes[i] + ")";
                    centroidLabels[i].Text = "Cluster " + (i + 1) + " Centroid " + centroid[i];
                }

                accuracyLabel.Text = "Accuracy:\n" + accuracy.ToString("0.##") + "%";
                traceLog.AppendText(traceLogString);
                traceLog.ScrollToCaret();
            }
        }
    }
}