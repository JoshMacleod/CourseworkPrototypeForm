namespace FormPrototype
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInitialHeight = new System.Windows.Forms.TextBox();
            this.txtInitialVelocity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInitialAngle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtHorizontalVelocity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVerticalVelocity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimeToPeak = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDistanceToPeak = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPlotGraph = new System.Windows.Forms.Button();
            this.txtTotalVerticalDistance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimeToGround = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalHorizontalDistance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Height";
            // 
            // txtInitialHeight
            // 
            this.txtInitialHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialHeight.Location = new System.Drawing.Point(177, 9);
            this.txtInitialHeight.Name = "txtInitialHeight";
            this.txtInitialHeight.Size = new System.Drawing.Size(126, 35);
            this.txtInitialHeight.TabIndex = 1;
            // 
            // txtInitialVelocity
            // 
            this.txtInitialVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialVelocity.Location = new System.Drawing.Point(177, 50);
            this.txtInitialVelocity.Name = "txtInitialVelocity";
            this.txtInitialVelocity.Size = new System.Drawing.Size(126, 35);
            this.txtInitialVelocity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Initial Velocity";
            // 
            // txtInitialAngle
            // 
            this.txtInitialAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialAngle.Location = new System.Drawing.Point(177, 91);
            this.txtInitialAngle.Name = "txtInitialAngle";
            this.txtInitialAngle.Size = new System.Drawing.Size(126, 35);
            this.txtInitialAngle.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Initial Angle";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCalculate.Location = new System.Drawing.Point(344, 37);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(151, 61);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // chart1
            // 
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 145);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Projectile1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1268, 381);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // txtHorizontalVelocity
            // 
            this.txtHorizontalVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorizontalVelocity.Location = new System.Drawing.Point(1586, 154);
            this.txtHorizontalVelocity.Name = "txtHorizontalVelocity";
            this.txtHorizontalVelocity.ReadOnly = true;
            this.txtHorizontalVelocity.Size = new System.Drawing.Size(126, 35);
            this.txtHorizontalVelocity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1299, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Horizontal Velocity";
            // 
            // txtVerticalVelocity
            // 
            this.txtVerticalVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerticalVelocity.Location = new System.Drawing.Point(1586, 195);
            this.txtVerticalVelocity.Name = "txtVerticalVelocity";
            this.txtVerticalVelocity.ReadOnly = true;
            this.txtVerticalVelocity.Size = new System.Drawing.Size(126, 35);
            this.txtVerticalVelocity.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1299, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vertical Velocity";
            // 
            // txtTimeToPeak
            // 
            this.txtTimeToPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeToPeak.Location = new System.Drawing.Point(1586, 236);
            this.txtTimeToPeak.Name = "txtTimeToPeak";
            this.txtTimeToPeak.ReadOnly = true;
            this.txtTimeToPeak.Size = new System.Drawing.Size(126, 35);
            this.txtTimeToPeak.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1299, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Time to Peak";
            // 
            // txtDistanceToPeak
            // 
            this.txtDistanceToPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceToPeak.Location = new System.Drawing.Point(1586, 277);
            this.txtDistanceToPeak.Name = "txtDistanceToPeak";
            this.txtDistanceToPeak.ReadOnly = true;
            this.txtDistanceToPeak.Size = new System.Drawing.Size(126, 35);
            this.txtDistanceToPeak.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1299, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Distance to Peak";
            // 
            // btnPlotGraph
            // 
            this.btnPlotGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnPlotGraph.Location = new System.Drawing.Point(1428, 482);
            this.btnPlotGraph.Name = "btnPlotGraph";
            this.btnPlotGraph.Size = new System.Drawing.Size(151, 44);
            this.btnPlotGraph.TabIndex = 16;
            this.btnPlotGraph.Text = "Plot Graph";
            this.btnPlotGraph.UseVisualStyleBackColor = true;
            this.btnPlotGraph.Click += new System.EventHandler(this.btnPlotGraph_Click);
            // 
            // txtTotalVerticalDistance
            // 
            this.txtTotalVerticalDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVerticalDistance.Location = new System.Drawing.Point(1586, 318);
            this.txtTotalVerticalDistance.Name = "txtTotalVerticalDistance";
            this.txtTotalVerticalDistance.ReadOnly = true;
            this.txtTotalVerticalDistance.Size = new System.Drawing.Size(126, 35);
            this.txtTotalVerticalDistance.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1299, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Vertical Distance";
            // 
            // txtTimeToGround
            // 
            this.txtTimeToGround.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeToGround.Location = new System.Drawing.Point(1585, 359);
            this.txtTimeToGround.Name = "txtTimeToGround";
            this.txtTimeToGround.ReadOnly = true;
            this.txtTimeToGround.Size = new System.Drawing.Size(126, 35);
            this.txtTimeToGround.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1298, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Time to Ground";
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTime.Location = new System.Drawing.Point(1585, 400);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.ReadOnly = true;
            this.txtTotalTime.Size = new System.Drawing.Size(126, 35);
            this.txtTotalTime.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1298, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total Time";
            // 
            // txtTotalHorizontalDistance
            // 
            this.txtTotalHorizontalDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHorizontalDistance.Location = new System.Drawing.Point(1585, 441);
            this.txtTotalHorizontalDistance.Name = "txtTotalHorizontalDistance";
            this.txtTotalHorizontalDistance.ReadOnly = true;
            this.txtTotalHorizontalDistance.Size = new System.Drawing.Size(126, 35);
            this.txtTotalHorizontalDistance.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1298, 444);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 29);
            this.label11.TabIndex = 23;
            this.label11.Text = "Total Horizontal Distance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1723, 538);
            this.Controls.Add(this.txtTotalHorizontalDistance);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTimeToGround);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalVerticalDistance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPlotGraph);
            this.Controls.Add(this.txtDistanceToPeak);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimeToPeak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVerticalVelocity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHorizontalVelocity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInitialAngle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInitialVelocity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInitialHeight);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInitialHeight;
        private System.Windows.Forms.TextBox txtInitialVelocity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInitialAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtHorizontalVelocity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVerticalVelocity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimeToPeak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDistanceToPeak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPlotGraph;
        private System.Windows.Forms.TextBox txtTotalVerticalDistance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimeToGround;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalHorizontalDistance;
        private System.Windows.Forms.Label label11;
    }
}

