namespace Typist
{
    partial class veziRezultate
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(veziRezultate));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.inchide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CPMLabel = new System.Windows.Forms.Label();
            this.accurayLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gameModeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.greseliLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.corecteLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.veziRezultatePrieten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DimGray;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisX.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisX.Title = "Secunda";
            chartArea1.AxisX.TitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisX2.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisX2.LineWidth = 0;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.Title = "Valoare";
            chartArea1.AxisX2.TitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Title = "Valoare";
            chartArea1.AxisY.TitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisY2.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisY2.LineWidth = 0;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisY2.MinorTickMark.LineColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.BorderColor = System.Drawing.Color.BlanchedAlmond;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.DimGray;
            legend1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(151, 33);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Gold;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.LabelForeColor = System.Drawing.SystemColors.ControlLightLight;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series1.MarkerColor = System.Drawing.Color.RosyBrown;
            series1.Name = "Cuvinte";
            series1.ShadowColor = System.Drawing.Color.White;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.DarkOrange;
            series2.Legend = "Legend1";
            series2.Name = "Greseli";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(599, 247);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // inchide
            // 
            this.inchide.BackColor = System.Drawing.Color.Gold;
            this.inchide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inchide.Location = new System.Drawing.Point(689, 404);
            this.inchide.Name = "inchide";
            this.inchide.Size = new System.Drawing.Size(99, 34);
            this.inchide.TabIndex = 15;
            this.inchide.Text = "Inchide";
            this.inchide.UseVisualStyleBackColor = false;
            this.inchide.Click += new System.EventHandler(this.inchideButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "CPM";
            // 
            // CPMLabel
            // 
            this.CPMLabel.AutoSize = true;
            this.CPMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPMLabel.ForeColor = System.Drawing.Color.Gold;
            this.CPMLabel.Location = new System.Drawing.Point(11, 53);
            this.CPMLabel.Name = "CPMLabel";
            this.CPMLabel.Size = new System.Drawing.Size(39, 29);
            this.CPMLabel.TabIndex = 17;
            this.CPMLabel.Text = "60";
            // 
            // accurayLabel
            // 
            this.accurayLabel.AutoSize = true;
            this.accurayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accurayLabel.ForeColor = System.Drawing.Color.Gold;
            this.accurayLabel.Location = new System.Drawing.Point(11, 145);
            this.accurayLabel.Name = "accurayLabel";
            this.accurayLabel.Size = new System.Drawing.Size(61, 29);
            this.accurayLabel.TabIndex = 19;
            this.accurayLabel.Text = "90%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Acuratete";
            // 
            // gameModeLabel
            // 
            this.gameModeLabel.AutoSize = true;
            this.gameModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameModeLabel.ForeColor = System.Drawing.Color.Gold;
            this.gameModeLabel.Location = new System.Drawing.Point(11, 250);
            this.gameModeLabel.Name = "gameModeLabel";
            this.gameModeLabel.Size = new System.Drawing.Size(123, 29);
            this.gameModeLabel.TabIndex = 21;
            this.gameModeLabel.Text = "singur 15s";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mod joc";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Gold;
            this.timeLabel.Location = new System.Drawing.Point(475, 317);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(161, 29);
            this.timeLabel.TabIndex = 23;
            this.timeLabel.Text = "15s (max 15s)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(476, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Timp";
            // 
            // greseliLabel
            // 
            this.greseliLabel.AutoSize = true;
            this.greseliLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greseliLabel.ForeColor = System.Drawing.Color.Gold;
            this.greseliLabel.Location = new System.Drawing.Point(341, 317);
            this.greseliLabel.Name = "greseliLabel";
            this.greseliLabel.Size = new System.Drawing.Size(26, 29);
            this.greseliLabel.TabIndex = 25;
            this.greseliLabel.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(342, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Greseli";
            // 
            // corecteLabel
            // 
            this.corecteLabel.AutoSize = true;
            this.corecteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corecteLabel.ForeColor = System.Drawing.Color.Gold;
            this.corecteLabel.Location = new System.Drawing.Point(201, 317);
            this.corecteLabel.Name = "corecteLabel";
            this.corecteLabel.Size = new System.Drawing.Size(39, 29);
            this.corecteLabel.TabIndex = 29;
            this.corecteLabel.Text = "15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(202, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Corecte";
            // 
            // veziRezultatePrieten
            // 
            this.veziRezultatePrieten.BackColor = System.Drawing.Color.Gold;
            this.veziRezultatePrieten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veziRezultatePrieten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.veziRezultatePrieten.Location = new System.Drawing.Point(311, 404);
            this.veziRezultatePrieten.Name = "veziRezultatePrieten";
            this.veziRezultatePrieten.Size = new System.Drawing.Size(189, 34);
            this.veziRezultatePrieten.TabIndex = 30;
            this.veziRezultatePrieten.Text = "Vezi rezultatele prietenelui";
            this.veziRezultatePrieten.UseVisualStyleBackColor = false;
            this.veziRezultatePrieten.Click += new System.EventHandler(this.veziRezultatePrieten_Click);
            // 
            // veziRezultate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.veziRezultatePrieten);
            this.Controls.Add(this.corecteLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.greseliLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gameModeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.accurayLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CPMLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inchide);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "veziRezultate";
            this.Text = "Rezultate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
            this.Load += new System.EventHandler(this.veziRezultate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button inchide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CPMLabel;
        private System.Windows.Forms.Label accurayLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label gameModeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label greseliLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label corecteLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button veziRezultatePrieten;
    }
}