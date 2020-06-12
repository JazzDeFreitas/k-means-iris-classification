namespace K_means {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cluster1TextBox = new System.Windows.Forms.RichTextBox();
            this.cluster2TextBox = new System.Windows.Forms.RichTextBox();
            this.cluster3TextBox = new System.Windows.Forms.RichTextBox();
            this.cluster1Label = new System.Windows.Forms.Label();
            this.cluster2Label = new System.Windows.Forms.Label();
            this.cluster3Label = new System.Windows.Forms.Label();
            this.traceLog = new System.Windows.Forms.RichTextBox();
            this.cluster1CentroidLabel = new System.Windows.Forms.Label();
            this.cluster2CentroidLabel = new System.Windows.Forms.Label();
            this.cluster3CentroidLabel = new System.Windows.Forms.Label();
            this.traceLogLabel = new System.Windows.Forms.Label();
            this.dataToUseLabel = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckedListBox();
            this.trainPercentageSlider = new System.Windows.Forms.TrackBar();
            this.sliderLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.percentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.accuracyLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.trainingLabel = new System.Windows.Forms.Label();
            this.testBox1 = new System.Windows.Forms.RichTextBox();
            this.testBox2 = new System.Windows.Forms.RichTextBox();
            this.testBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trainPercentageSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cluster1TextBox
            // 
            this.cluster1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cluster1TextBox.Location = new System.Drawing.Point(12, 60);
            this.cluster1TextBox.Name = "cluster1TextBox";
            this.cluster1TextBox.ReadOnly = true;
            this.cluster1TextBox.Size = new System.Drawing.Size(280, 232);
            this.cluster1TextBox.TabIndex = 0;
            this.cluster1TextBox.Text = "";
            // 
            // cluster2TextBox
            // 
            this.cluster2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cluster2TextBox.Location = new System.Drawing.Point(302, 60);
            this.cluster2TextBox.Name = "cluster2TextBox";
            this.cluster2TextBox.ReadOnly = true;
            this.cluster2TextBox.Size = new System.Drawing.Size(280, 232);
            this.cluster2TextBox.TabIndex = 0;
            this.cluster2TextBox.Text = "";
            // 
            // cluster3TextBox
            // 
            this.cluster3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cluster3TextBox.Location = new System.Drawing.Point(592, 60);
            this.cluster3TextBox.Name = "cluster3TextBox";
            this.cluster3TextBox.ReadOnly = true;
            this.cluster3TextBox.Size = new System.Drawing.Size(280, 232);
            this.cluster3TextBox.TabIndex = 0;
            this.cluster3TextBox.Text = "";
            // 
            // cluster1Label
            // 
            this.cluster1Label.AutoSize = true;
            this.cluster1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cluster1Label.Location = new System.Drawing.Point(7, 34);
            this.cluster1Label.Name = "cluster1Label";
            this.cluster1Label.Size = new System.Drawing.Size(99, 26);
            this.cluster1Label.TabIndex = 1;
            this.cluster1Label.Text = "Cluster 1";
            // 
            // cluster2Label
            // 
            this.cluster2Label.AutoSize = true;
            this.cluster2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cluster2Label.Location = new System.Drawing.Point(297, 34);
            this.cluster2Label.Name = "cluster2Label";
            this.cluster2Label.Size = new System.Drawing.Size(99, 26);
            this.cluster2Label.TabIndex = 1;
            this.cluster2Label.Text = "Cluster 2";
            // 
            // cluster3Label
            // 
            this.cluster3Label.AutoSize = true;
            this.cluster3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cluster3Label.Location = new System.Drawing.Point(587, 34);
            this.cluster3Label.Name = "cluster3Label";
            this.cluster3Label.Size = new System.Drawing.Size(99, 26);
            this.cluster3Label.TabIndex = 1;
            this.cluster3Label.Text = "Cluster 3";
            // 
            // traceLog
            // 
            this.traceLog.Location = new System.Drawing.Point(12, 472);
            this.traceLog.Name = "traceLog";
            this.traceLog.ReadOnly = true;
            this.traceLog.Size = new System.Drawing.Size(697, 69);
            this.traceLog.TabIndex = 0;
            this.traceLog.Text = "";
            // 
            // cluster1CentroidLabel
            // 
            this.cluster1CentroidLabel.AutoSize = true;
            this.cluster1CentroidLabel.Location = new System.Drawing.Point(9, 295);
            this.cluster1CentroidLabel.Name = "cluster1CentroidLabel";
            this.cluster1CentroidLabel.Size = new System.Drawing.Size(123, 13);
            this.cluster1CentroidLabel.TabIndex = 2;
            this.cluster1CentroidLabel.Text = "Cluster 1 Centroid Value:";
            // 
            // cluster2CentroidLabel
            // 
            this.cluster2CentroidLabel.AutoSize = true;
            this.cluster2CentroidLabel.Location = new System.Drawing.Point(299, 295);
            this.cluster2CentroidLabel.Name = "cluster2CentroidLabel";
            this.cluster2CentroidLabel.Size = new System.Drawing.Size(123, 13);
            this.cluster2CentroidLabel.TabIndex = 2;
            this.cluster2CentroidLabel.Text = "Cluster 2 Centroid Value:";
            // 
            // cluster3CentroidLabel
            // 
            this.cluster3CentroidLabel.AutoSize = true;
            this.cluster3CentroidLabel.Location = new System.Drawing.Point(589, 295);
            this.cluster3CentroidLabel.Name = "cluster3CentroidLabel";
            this.cluster3CentroidLabel.Size = new System.Drawing.Size(123, 13);
            this.cluster3CentroidLabel.TabIndex = 2;
            this.cluster3CentroidLabel.Text = "Cluster 3 Centroid Value:";
            // 
            // traceLogLabel
            // 
            this.traceLogLabel.AutoSize = true;
            this.traceLogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traceLogLabel.Location = new System.Drawing.Point(8, 449);
            this.traceLogLabel.Name = "traceLogLabel";
            this.traceLogLabel.Size = new System.Drawing.Size(80, 20);
            this.traceLogLabel.TabIndex = 2;
            this.traceLogLabel.Text = "Trace Log";
            // 
            // dataToUseLabel
            // 
            this.dataToUseLabel.AutoSize = true;
            this.dataToUseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataToUseLabel.Location = new System.Drawing.Point(21, 547);
            this.dataToUseLabel.Name = "dataToUseLabel";
            this.dataToUseLabel.Size = new System.Drawing.Size(96, 20);
            this.dataToUseLabel.TabIndex = 2;
            this.dataToUseLabel.Text = "Data to use:";
            // 
            // checkBox
            // 
            this.checkBox.BackColor = System.Drawing.SystemColors.Menu;
            this.checkBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkBox.CheckOnClick = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.FormattingEnabled = true;
            this.checkBox.Items.AddRange(new object[] {
            "Sepal Length (cm)",
            "Sepal Width (cm)",
            "Petal Length (cm)",
            "Petal Width (cm)"});
            this.checkBox.Location = new System.Drawing.Point(25, 570);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(156, 84);
            this.checkBox.TabIndex = 4;
            // 
            // trainPercentageSlider
            // 
            this.trainPercentageSlider.LargeChange = 20;
            this.trainPercentageSlider.Location = new System.Drawing.Point(260, 591);
            this.trainPercentageSlider.Maximum = 90;
            this.trainPercentageSlider.Minimum = 10;
            this.trainPercentageSlider.Name = "trainPercentageSlider";
            this.trainPercentageSlider.Size = new System.Drawing.Size(366, 45);
            this.trainPercentageSlider.SmallChange = 10;
            this.trainPercentageSlider.TabIndex = 5;
            this.trainPercentageSlider.TickFrequency = 10;
            this.trainPercentageSlider.Value = 70;
            this.trainPercentageSlider.ValueChanged += new System.EventHandler(this.trainPercentageSlider_ValueChanged);
            // 
            // sliderLabel
            // 
            this.sliderLabel.AutoSize = true;
            this.sliderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderLabel.Location = new System.Drawing.Point(263, 561);
            this.sliderLabel.Name = "sliderLabel";
            this.sliderLabel.Size = new System.Drawing.Size(363, 20);
            this.sliderLabel.TabIndex = 6;
            this.sliderLabel.Text = "Percentage of dataset used for training:               %\r\n";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(710, 547);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(162, 107);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // percentNumericUpDown
            // 
            this.percentNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentNumericUpDown.Location = new System.Drawing.Point(556, 559);
            this.percentNumericUpDown.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.percentNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.percentNumericUpDown.Name = "percentNumericUpDown";
            this.percentNumericUpDown.Size = new System.Drawing.Size(46, 26);
            this.percentNumericUpDown.TabIndex = 9;
            this.percentNumericUpDown.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.percentNumericUpDown.ValueChanged += new System.EventHandler(this.percentNumericUpDown_ValueChanged);
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.AutoSize = true;
            this.accuracyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracyLabel.Location = new System.Drawing.Point(743, 472);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(108, 26);
            this.accuracyLabel.TabIndex = 10;
            this.accuracyLabel.Text = "Accuracy:";
            this.accuracyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsLabel.Location = new System.Drawing.Point(386, 632);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(109, 20);
            this.itemsLabel.TabIndex = 11;
            this.itemsLabel.Text = "105/150 items";
            this.itemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trainingLabel
            // 
            this.trainingLabel.AutoSize = true;
            this.trainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingLabel.Location = new System.Drawing.Point(407, 4);
            this.trainingLabel.Name = "trainingLabel";
            this.trainingLabel.Size = new System.Drawing.Size(95, 26);
            this.trainingLabel.TabIndex = 1;
            this.trainingLabel.Text = "Training:";
            // 
            // testBox1
            // 
            this.testBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testBox1.Location = new System.Drawing.Point(12, 335);
            this.testBox1.Name = "testBox1";
            this.testBox1.ReadOnly = true;
            this.testBox1.Size = new System.Drawing.Size(280, 111);
            this.testBox1.TabIndex = 0;
            this.testBox1.Text = "";
            // 
            // testBox2
            // 
            this.testBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testBox2.Location = new System.Drawing.Point(302, 335);
            this.testBox2.Name = "testBox2";
            this.testBox2.ReadOnly = true;
            this.testBox2.Size = new System.Drawing.Size(280, 111);
            this.testBox2.TabIndex = 0;
            this.testBox2.Text = "";
            // 
            // testBox3
            // 
            this.testBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testBox3.Location = new System.Drawing.Point(592, 335);
            this.testBox3.Name = "testBox3";
            this.testBox3.ReadOnly = true;
            this.testBox3.Size = new System.Drawing.Size(280, 111);
            this.testBox3.TabIndex = 0;
            this.testBox3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Testing:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.accuracyLabel);
            this.Controls.Add(this.percentNumericUpDown);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.sliderLabel);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.cluster3CentroidLabel);
            this.Controls.Add(this.cluster2CentroidLabel);
            this.Controls.Add(this.dataToUseLabel);
            this.Controls.Add(this.traceLogLabel);
            this.Controls.Add(this.cluster1CentroidLabel);
            this.Controls.Add(this.cluster3Label);
            this.Controls.Add(this.cluster2Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainingLabel);
            this.Controls.Add(this.cluster1Label);
            this.Controls.Add(this.testBox3);
            this.Controls.Add(this.cluster3TextBox);
            this.Controls.Add(this.testBox2);
            this.Controls.Add(this.cluster2TextBox);
            this.Controls.Add(this.traceLog);
            this.Controls.Add(this.testBox1);
            this.Controls.Add(this.cluster1TextBox);
            this.Controls.Add(this.trainPercentageSlider);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 900);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Iris Plant Species Classification with K-means Clustering";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainPercentageSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox cluster1TextBox;
        private System.Windows.Forms.RichTextBox cluster2TextBox;
        private System.Windows.Forms.RichTextBox cluster3TextBox;
        private System.Windows.Forms.Label cluster1Label;
        private System.Windows.Forms.Label cluster2Label;
        private System.Windows.Forms.Label cluster3Label;
        private System.Windows.Forms.RichTextBox traceLog;
        private System.Windows.Forms.Label cluster1CentroidLabel;
        private System.Windows.Forms.Label cluster2CentroidLabel;
        private System.Windows.Forms.Label cluster3CentroidLabel;
        private System.Windows.Forms.Label traceLogLabel;
        private System.Windows.Forms.Label dataToUseLabel;
        private System.Windows.Forms.CheckedListBox checkBox;
        private System.Windows.Forms.TrackBar trainPercentageSlider;
        private System.Windows.Forms.Label sliderLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.NumericUpDown percentNumericUpDown;
        private System.Windows.Forms.Label accuracyLabel;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.Label trainingLabel;
        private System.Windows.Forms.RichTextBox testBox1;
        private System.Windows.Forms.RichTextBox testBox2;
        private System.Windows.Forms.RichTextBox testBox3;
        private System.Windows.Forms.Label label1;
    }
}

