namespace Watch
{
    partial class FormLongMsg
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtTimeTable = new MetroFramework.Controls.MetroTextBox();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFlow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.txtTimeParagraph = new MetroFramework.Controls.MetroTextBox();
            this.tabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.tabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.tabPage9 = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlow)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimeTable
            // 
            // 
            // 
            // 
            this.txtTimeTable.CustomButton.Image = null;
            this.txtTimeTable.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtTimeTable.CustomButton.Name = "";
            this.txtTimeTable.CustomButton.Size = new System.Drawing.Size(213, 213);
            this.txtTimeTable.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimeTable.CustomButton.TabIndex = 1;
            this.txtTimeTable.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimeTable.CustomButton.UseSelectable = true;
            this.txtTimeTable.CustomButton.Visible = false;
            this.txtTimeTable.Lines = new string[0];
            this.txtTimeTable.Location = new System.Drawing.Point(9, 10);
            this.txtTimeTable.Margin = new System.Windows.Forms.Padding(30);
            this.txtTimeTable.MaxLength = 32767;
            this.txtTimeTable.Multiline = true;
            this.txtTimeTable.Name = "txtTimeTable";
            this.txtTimeTable.PasswordChar = '\0';
            this.txtTimeTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTimeTable.SelectedText = "";
            this.txtTimeTable.SelectionLength = 0;
            this.txtTimeTable.SelectionStart = 0;
            this.txtTimeTable.ShortcutsEnabled = true;
            this.txtTimeTable.Size = new System.Drawing.Size(331, 215);
            this.txtTimeTable.TabIndex = 0;
            this.txtTimeTable.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTimeTable.UseSelectable = true;
            this.txtTimeTable.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimeTable.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chartPie
            // 
            this.chartPie.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.ReversedSeriesOrder;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chartPie.Legends.Add(legend1);
            this.chartPie.Location = new System.Drawing.Point(0, 0);
            this.chartPie.Name = "chartPie";
            this.chartPie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Label = "#VAL{N2}分钟";
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.LegendText = "#VALX";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chartPie.Series.Add(series1);
            this.chartPie.Size = new System.Drawing.Size(356, 226);
            this.chartPie.TabIndex = 0;
            this.chartPie.Text = "chart1";
            // 
            // chartLine
            // 
            this.chartLine.BackColor = System.Drawing.Color.Black;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chartLine.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.Black;
            legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend2.Enabled = false;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.ReversedSeriesOrder;
            legend2.Name = "Legend1";
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chartLine.Legends.Add(legend2);
            this.chartLine.Location = new System.Drawing.Point(20, 22);
            this.chartLine.Name = "chartLine";
            this.chartLine.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.IsValueShownAsLabel = true;
            series2.Label = "#VAL{N2}分钟";
            series2.LabelAngle = 45;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.White;
            series2.Name = "Series1";
            series2.ShadowOffset = 1;
            series2.YValuesPerPoint = 2;
            this.chartLine.Series.Add(series2);
            this.chartLine.Size = new System.Drawing.Size(482, 310);
            this.chartLine.TabIndex = 1;
            this.chartLine.Text = "chart1";
            // 
            // chartFlow
            // 
            this.chartFlow.BackColor = System.Drawing.Color.Black;
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.IsReversed = true;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.Interval = 1D;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IsMarginVisible = false;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.chartFlow.ChartAreas.Add(chartArea3);
            this.chartFlow.Cursor = System.Windows.Forms.Cursors.Default;
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend3.Enabled = false;
            legend3.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.ReversedSeriesOrder;
            legend3.Name = "Legend1";
            legend3.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chartFlow.Legends.Add(legend3);
            this.chartFlow.Location = new System.Drawing.Point(19, 16);
            this.chartFlow.Name = "chartFlow";
            this.chartFlow.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series3.Color = System.Drawing.Color.Green;
            series3.IsValueShownAsLabel = true;
            series3.Label = "#VALY3{N2}";
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.ShadowOffset = 1;
            series3.YValuesPerPoint = 6;
            this.chartFlow.Series.Add(series3);
            this.chartFlow.Size = new System.Drawing.Size(443, 294);
            this.chartFlow.TabIndex = 2;
            this.chartFlow.Text = "chart1";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage6);
            this.metroTabControl1.Controls.Add(this.tabPage7);
            this.metroTabControl1.Controls.Add(this.tabPage8);
            this.metroTabControl1.Controls.Add(this.tabPage9);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(493, 355);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtTimeTable);
            this.metroTabPage1.HorizontalScrollbarBarColor = false;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(485, 313);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "时间表";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = false;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txtTimeParagraph);
            this.tabPage6.HorizontalScrollbarBarColor = false;
            this.tabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage6.HorizontalScrollbarSize = 10;
            this.tabPage6.Location = new System.Drawing.Point(4, 38);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(485, 313);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "时间段";
            this.tabPage6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabPage6.VerticalScrollbarBarColor = false;
            this.tabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage6.VerticalScrollbarSize = 10;
            // 
            // txtTimeParagraph
            // 
            // 
            // 
            // 
            this.txtTimeParagraph.CustomButton.Image = null;
            this.txtTimeParagraph.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtTimeParagraph.CustomButton.Name = "";
            this.txtTimeParagraph.CustomButton.Size = new System.Drawing.Size(251, 251);
            this.txtTimeParagraph.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimeParagraph.CustomButton.TabIndex = 1;
            this.txtTimeParagraph.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimeParagraph.CustomButton.UseSelectable = true;
            this.txtTimeParagraph.CustomButton.Visible = false;
            this.txtTimeParagraph.Lines = new string[] {
        " "};
            this.txtTimeParagraph.Location = new System.Drawing.Point(0, 0);
            this.txtTimeParagraph.MaxLength = 32767;
            this.txtTimeParagraph.Multiline = true;
            this.txtTimeParagraph.Name = "txtTimeParagraph";
            this.txtTimeParagraph.PasswordChar = '\0';
            this.txtTimeParagraph.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTimeParagraph.SelectedText = "";
            this.txtTimeParagraph.SelectionLength = 0;
            this.txtTimeParagraph.SelectionStart = 0;
            this.txtTimeParagraph.ShortcutsEnabled = true;
            this.txtTimeParagraph.Size = new System.Drawing.Size(355, 253);
            this.txtTimeParagraph.TabIndex = 3;
            this.txtTimeParagraph.Text = " ";
            this.txtTimeParagraph.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTimeParagraph.UseSelectable = true;
            this.txtTimeParagraph.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimeParagraph.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.chartPie);
            this.tabPage7.HorizontalScrollbarBarColor = false;
            this.tabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage7.HorizontalScrollbarSize = 10;
            this.tabPage7.Location = new System.Drawing.Point(4, 38);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(485, 313);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "饼图";
            this.tabPage7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabPage7.VerticalScrollbarBarColor = false;
            this.tabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage7.VerticalScrollbarSize = 10;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.chartLine);
            this.tabPage8.HorizontalScrollbarBarColor = false;
            this.tabPage8.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage8.HorizontalScrollbarSize = 10;
            this.tabPage8.Location = new System.Drawing.Point(4, 38);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(485, 313);
            this.tabPage8.Style = MetroFramework.MetroColorStyle.Black;
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "折线图";
            this.tabPage8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabPage8.VerticalScrollbarBarColor = false;
            this.tabPage8.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage8.VerticalScrollbarSize = 10;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.chartFlow);
            this.tabPage9.HorizontalScrollbarBarColor = false;
            this.tabPage9.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage9.HorizontalScrollbarSize = 10;
            this.tabPage9.Location = new System.Drawing.Point(4, 38);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(485, 313);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "瀑布流";
            this.tabPage9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabPage9.VerticalScrollbarBarColor = false;
            this.tabPage9.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage9.VerticalScrollbarSize = 10;
            // 
            // FormLongMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 435);
            this.Controls.Add(this.metroTabControl1);
            this.MinimizeBox = false;
            this.Name = "FormLongMsg";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "显示报告";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLongMsg_FormClosed);
            this.Load += new System.EventHandler(this.FormLongMsg_Load);
            this.Resize += new System.EventHandler(this.FormLongMsg_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlow)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTextBox txtTimeTable;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartLine;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartFlow;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage tabPage6;
        private MetroFramework.Controls.MetroTabPage tabPage7;
        private MetroFramework.Controls.MetroTabPage tabPage8;
        private MetroFramework.Controls.MetroTabPage tabPage9;
        public MetroFramework.Controls.MetroTextBox txtTimeParagraph;
    }
}