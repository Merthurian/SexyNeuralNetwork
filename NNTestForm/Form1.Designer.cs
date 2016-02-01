namespace NNTestForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonGo = new System.Windows.Forms.Button();
            this.labelTotalError = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonGenetic = new System.Windows.Forms.Button();
            this.buttonSexyTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(214, 59);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(767, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(44, 176);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(91, 27);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "Go Backprop";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // labelTotalError
            // 
            this.labelTotalError.AutoSize = true;
            this.labelTotalError.Location = new System.Drawing.Point(553, 380);
            this.labelTotalError.Name = "labelTotalError";
            this.labelTotalError.Size = new System.Drawing.Size(35, 13);
            this.labelTotalError.TabIndex = 2;
            this.labelTotalError.Text = "label1";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(44, 119);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonGenetic
            // 
            this.buttonGenetic.Location = new System.Drawing.Point(44, 226);
            this.buttonGenetic.Name = "buttonGenetic";
            this.buttonGenetic.Size = new System.Drawing.Size(91, 28);
            this.buttonGenetic.TabIndex = 4;
            this.buttonGenetic.Text = "Go Genetic";
            this.buttonGenetic.UseVisualStyleBackColor = true;
            this.buttonGenetic.Click += new System.EventHandler(this.buttonGenetic_Click);
            // 
            // buttonSexyTime
            // 
            this.buttonSexyTime.Location = new System.Drawing.Point(19, 329);
            this.buttonSexyTime.Name = "buttonSexyTime";
            this.buttonSexyTime.Size = new System.Drawing.Size(139, 55);
            this.buttonSexyTime.TabIndex = 5;
            this.buttonSexyTime.Text = "Sexy Time!";
            this.buttonSexyTime.UseVisualStyleBackColor = true;
            this.buttonSexyTime.Click += new System.EventHandler(this.buttonSexyTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 432);
            this.Controls.Add(this.buttonSexyTime);
            this.Controls.Add(this.buttonGenetic);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelTotalError);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label labelTotalError;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonGenetic;
        private System.Windows.Forms.Button buttonSexyTime;
    }
}

