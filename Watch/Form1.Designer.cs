namespace Watch
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.mnuShowReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GCTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lblTimeMs = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnMore = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.btnRecord = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.lblChoroMs = new System.Windows.Forms.Label();
            this.lblChoro = new System.Windows.Forms.Label();
            this.tblDayCounter = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblDays = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.tblDayCounter.SuspendLayout();
            this.SuspendLayout();
            // 
            // renderTimer
            // 
            this.renderTimer.Enabled = true;
            this.renderTimer.Interval = 1;
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowReport,
            this.toolStripSeparator2,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.重置ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 148);
            this.contextMenuStrip1.Style = MetroFramework.MetroColorStyle.Green;
            this.contextMenuStrip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mnuShowReport
            // 
            this.mnuShowReport.Name = "mnuShowReport";
            this.mnuShowReport.Size = new System.Drawing.Size(152, 22);
            this.mnuShowReport.Text = "查看时间报告";
            this.mnuShowReport.Click += new System.EventHandler(this.mnuShowReport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 重置ToolStripMenuItem
            // 
            this.重置ToolStripMenuItem.Name = "重置ToolStripMenuItem";
            this.重置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.重置ToolStripMenuItem.Text = "重置";
            this.重置ToolStripMenuItem.Click += new System.EventHandler(this.重置ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // GCTimer
            // 
            this.GCTimer.Enabled = true;
            this.GCTimer.Interval = 10000;
            this.GCTimer.Tick += new System.EventHandler(this.GCTimer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "计时器文件|*.tmr|可扩展计时器文件|*.tmrx";
            this.openFileDialog1.FilterIndex = 2;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "可扩展计时器文件|*.tmrx";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(358, 245);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 13;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lblTimeMs);
            this.metroTabPage1.Controls.Add(this.lblTime);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.ImageKey = "(none)";
            this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(350, 205);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "时钟";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // lblTimeMs
            // 
            this.lblTimeMs.AutoSize = true;
            this.lblTimeMs.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeMs.Font = new System.Drawing.Font("LESLIE", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeMs.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblTimeMs.Location = new System.Drawing.Point(263, 71);
            this.lblTimeMs.Margin = new System.Windows.Forms.Padding(0);
            this.lblTimeMs.Name = "lblTimeMs";
            this.lblTimeMs.Size = new System.Drawing.Size(69, 32);
            this.lblTimeMs.TabIndex = 6;
            this.lblTimeMs.Text = "888";
            this.lblTimeMs.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("LESLIE", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblTime.Location = new System.Drawing.Point(13, 37);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(270, 69);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "88:88:88";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.tblDayCounter);
            this.metroTabPage2.Controls.Add(this.btnMore);
            this.metroTabPage2.Controls.Add(this.btnSave);
            this.metroTabPage2.Controls.Add(this.btnRecord);
            this.metroTabPage2.Controls.Add(this.btnReset);
            this.metroTabPage2.Controls.Add(this.btnPlay);
            this.metroTabPage2.Controls.Add(this.lblChoroMs);
            this.metroTabPage2.Controls.Add(this.lblChoro);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(350, 203);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "计时";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.Transparent;
            this.btnMore.Image = global::Watch.Properties.Resources.ic_more;
            this.btnMore.Location = new System.Drawing.Point(256, 137);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(41, 41);
            this.btnMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMore.TabIndex = 15;
            this.btnMore.TabStop = false;
            this.btnMore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMore_MouseDown);
            this.btnMore.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMore_MouseUp);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = global::Watch.Properties.Resources.ic_report;
            this.btnSave.Location = new System.Drawing.Point(209, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(41, 41);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 15;
            this.btnSave.TabStop = false;
            this.btnSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMore_MouseDown);
            this.btnSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseUp);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnRecord.Image = global::Watch.Properties.Resources.btn_record;
            this.btnRecord.Location = new System.Drawing.Point(53, 137);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(41, 41);
            this.btnRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRecord.TabIndex = 15;
            this.btnRecord.TabStop = false;
            this.btnRecord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMore_MouseDown);
            this.btnRecord.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRecord_MouseUp);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Image = global::Watch.Properties.Resources.btn_reset;
            this.btnReset.Location = new System.Drawing.Point(100, 137);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(41, 41);
            this.btnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReset.TabIndex = 15;
            this.btnReset.TabStop = false;
            this.btnReset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMore_MouseDown);
            this.btnReset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseUp);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Image = global::Watch.Properties.Resources.ic_play;
            this.btnPlay.Location = new System.Drawing.Point(147, 129);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(56, 56);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 15;
            this.btnPlay.TabStop = false;
            this.btnPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMore_MouseDown);
            this.btnPlay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPlay_MouseUp);
            // 
            // lblChoroMs
            // 
            this.lblChoroMs.AutoSize = true;
            this.lblChoroMs.BackColor = System.Drawing.Color.Transparent;
            this.lblChoroMs.Font = new System.Drawing.Font("LESLIE", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoroMs.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblChoroMs.Location = new System.Drawing.Point(263, 71);
            this.lblChoroMs.Margin = new System.Windows.Forms.Padding(0);
            this.lblChoroMs.Name = "lblChoroMs";
            this.lblChoroMs.Size = new System.Drawing.Size(69, 32);
            this.lblChoroMs.TabIndex = 14;
            this.lblChoroMs.Text = "888";
            this.lblChoroMs.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblChoro
            // 
            this.lblChoro.BackColor = System.Drawing.Color.Transparent;
            this.lblChoro.Font = new System.Drawing.Font("LESLIE", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoro.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblChoro.Location = new System.Drawing.Point(13, 37);
            this.lblChoro.Margin = new System.Windows.Forms.Padding(0);
            this.lblChoro.Name = "lblChoro";
            this.lblChoro.Size = new System.Drawing.Size(270, 69);
            this.lblChoro.TabIndex = 13;
            this.lblChoro.Text = "88:88:88";
            this.lblChoro.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tblDayCounter
            // 
            this.tblDayCounter.Controls.Add(this.metroLabel1);
            this.tblDayCounter.Controls.Add(this.lblDays);
            this.tblDayCounter.HorizontalScrollbarBarColor = true;
            this.tblDayCounter.HorizontalScrollbarHighlightOnWheel = false;
            this.tblDayCounter.HorizontalScrollbarSize = 10;
            this.tblDayCounter.Location = new System.Drawing.Point(13, 9);
            this.tblDayCounter.Name = "tblDayCounter";
            this.tblDayCounter.Size = new System.Drawing.Size(319, 38);
            this.tblDayCounter.TabIndex = 16;
            this.tblDayCounter.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tblDayCounter.VerticalScrollbarBarColor = true;
            this.tblDayCounter.VerticalScrollbarHighlightOnWheel = false;
            this.tblDayCounter.VerticalScrollbarSize = 10;
            this.tblDayCounter.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Chartreuse;
            this.metroLabel1.Location = new System.Drawing.Point(272, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "days";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblDays
            // 
            this.lblDays.BackColor = System.Drawing.Color.Transparent;
            this.lblDays.Font = new System.Drawing.Font("LESLIE", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblDays.Location = new System.Drawing.Point(11, 6);
            this.lblDays.Margin = new System.Windows.Forms.Padding(0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(272, 32);
            this.lblDays.TabIndex = 15;
            this.lblDays.Text = "888";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 331);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Metro Watch";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.tblDayCounter.ResumeLayout(false);
            this.tblDayCounter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.Timer GCTimer;
        private MetroFramework.Controls.MetroContextMenu contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuShowReport;
        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Label lblTimeMs;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblChoroMs;
        private System.Windows.Forms.Label lblChoro;
        private System.Windows.Forms.PictureBox btnMore;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.PictureBox btnRecord;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.PictureBox btnPlay;
        private MetroFramework.Controls.MetroPanel tblDayCounter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label lblDays;
    }
}

