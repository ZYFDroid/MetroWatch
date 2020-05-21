
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using MetroFramework;
using MetroFramework.Forms;
using System.Drawing;
using System.Drawing.Text;

namespace Watch
{
    public partial class Form1 : MetroForm
    {

        #region baseLogic
        public class TimeSpot {
            public long timePosition;
            public string comment;
        }

        const string tempFilename = "currentTimer.tmrx";

        private DateTime offset = new DateTime(2019, 1, 1);
        public long SystemClock { get { return (long)(DateTime.Now - offset).TotalMilliseconds; } }
        public List<TimeSpot> timers = new List<TimeSpot>();

        public long getTotalTime()
        {
            long time = 0;

            long systemClock = SystemClock;
            long lastStartTime = systemClock;
            for (int i = 0; i < timers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    lastStartTime = timers[i].timePosition;
                }
                else
                {
                    time += (timers[i].timePosition - lastStartTime);
                    lastStartTime = systemClock;
                }
            }
            time += (systemClock - lastStartTime);
            return time;
        }
        
        public void saveTime(string path)
        {
            StringBuilder sbuilder = new StringBuilder();
            for (int i = 0; i < timers.Count; i++)
            {
                TimeSpot timeObj = timers[i];
                sbuilder.Append(timeObj.timePosition);
                if (null != timeObj.comment && "" != timeObj.comment) {
                    sbuilder.Append("#").Append(timeObj.comment);
                }
                if (i < timers.Count - 1) { sbuilder.Append("\n"); }
            }
            File.WriteAllText(path, sbuilder.ToString(), Encoding.UTF8);
        }

        char[] separator = { '#' };

        public void loadTime(string path)
        {
            if (File.Exists(path))
            {
                timers.Clear();
                string[] lines = File.ReadAllLines(path,Encoding.UTF8);
                for (int i = 0; i < lines.Length; i++)
                {
                    TimeSpot timeObj = new TimeSpot();
                    string str = lines[i];
                    if (str.Contains("#"))
                    {
                        string[] strs = str.Split(separator, 2);
                        timeObj.timePosition = Int64.Parse(strs[0]);
                        timeObj.comment = strs[1];
                    }
                    else
                    {
                        timeObj.timePosition = Int64.Parse(lines[i]);
                    }

                    if (lines[i].Trim() != "")
                    {
                        timers.Add(timeObj);
                    }
                }
            }
            btnPlay.Image = IsPaused ? imgPlay : imgPause;

        }


        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        FontFamily digital;
        public FontFamily GetResoruceFont()
        {
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            if (File.Exists("DIGITAL.TTF"))
            {
                pfc.AddFontFile("DIGITAL.TTF");
            }
            else if(File.Exists(Path.Combine(Path.GetTempPath(),"MetroWatch","DIGITAL.TTF"))) {
                pfc.AddFontFile(Path.Combine(Path.GetTempPath(), "MetroWatch", "DIGITAL.TTF"));
            }
            return (pfc.Families[0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;
            digital = GetResoruceFont();
            lblTime.Font = new Font(digital, 48);
            lblTimeMs.Font = new Font(digital, 24);
            lblChoro.Font = new Font(digital, 48);
            lblChoroMs.Font = new Font(digital, 24);
            lblDays.Font = new Font(digital, 24);
            metroTabControl1.SelectedTab = metroTabPage1;
            if (File.Exists(tempFilename))
            {
                loadTime(tempFilename);
                metroTabControl1.SelectedTab = metroTabPage2;
            }
            if (null != Program.requestFileInfo) {
                loadTime(Program.requestFileInfo.FullName);
                metroTabControl1.SelectedTab = metroTabPage2;

            }
        }
        
        private void renderTimer_Tick(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab == metroTabPage1)
            {
                lblTime.Text = DateTime.Now.ToString("HH\\:mm\\:ss");
                lblTimeMs.Text = DateTime.Now.ToString("fff");
            }
            if (metroTabControl1.SelectedTab == metroTabPage2)
            {
                TimeSpan ts = TimeSpan.FromMilliseconds(getTotalTime());
                lblChoro.Text = ts.ToString("hh\\:mm\\:ss");
                lblChoroMs.Text = ts.ToString("fff");
                tblDayCounter.Visible = ts.Days > 0;
                lblDays.Text = ts.Days.ToString();
            }
        }
        
        private void GCTimer_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }
        
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool tmp = this.TopMost;
            this.TopMost = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (getTotalTime() != 0)
                {
                    if (MetroMessageBox.Show(this,"是否覆盖当前的计时？", "打开计时", MessageBoxButtons.YesNo) != DialogResult.Yes) { return; }
                    
                }
                loadTime(openFileDialog1.FileName);
            }
            this.TopMost = tmp;
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool tmp = this.TopMost;
            this.TopMost = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (getTotalTime() == 0)
                {

                    MetroMessageBox.Show(this,"计时尚未开始，因此不能保存计时", "保存计时");
                    return;
                }
                saveTime(saveFileDialog1.FileName);

                MetroMessageBox.Show(this,"保存成功","");

            }
            this.TopMost = tmp;
        }

        private void 重置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool tmp = this.TopMost;
            this.TopMost = false;
            
            if (MetroMessageBox.Show(this,"是否重置计时？", "是否重置计时", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                File.Delete(tempFilename);
                timers.Clear();
                toolStripMenuItem3.Enabled = true;
                btnPlay.Image = IsPaused ? imgPlay : imgPause;
            }
            this.TopMost = tmp;
        }
        

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,"该计时器通过保存每次开始和停止的时间来实现在不启用程序的情况下持续计时，因此计时器启动之后，即使程序关闭、电脑关机，也能继续准确计时，计时过程中请不要修改系统时间。临时计时文件保存在程序目录下的" + tempFilename + "中\r\n可以保存和打开已有的计时器记录，包括已完成计时的以及正在计时的\r\n\r\nMetro版计时器和怀表版计时器存档通用", "帮助");
            
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,"非易失性计时器\r\n版本 " + Application.ProductVersion + " Metro版\r\nZYFDroid", "关于");
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            renderTimer.Enabled = (WindowState != FormWindowState.Minimized);
        }

        public bool IsPaused {
            get { return timers.Count % 2 == 0; }
        }

        private void mnuRecordTimeComment_Click(object sender, EventArgs e)
        {
            bool tmp = this.TopMost;
            this.TopMost = false;
            bool paused = IsPaused;
            bool haveTime = timers.Count > 0;
            if (!haveTime) { MetroMessageBox.Show(this,"尚未开始计时",""); return; }

            if (!paused)
            {
                TimeSpot timeObj = new TimeSpot();
                timeObj.timePosition = SystemClock;
                timers.Add(timeObj);
            }
            else {
                TimeSpot timeObj = new TimeSpot();
                timeObj.timePosition = SystemClock;
                timers.Add(timeObj);
                timeObj = new TimeSpot();
                timeObj.timePosition = SystemClock;
                timers.Add(timeObj);
            }


            string msg;
            InputBox ipb = new InputBox(this);
            if (ipb.GetInput(out msg) == DialogResult.OK) {
                (timers[timers.Count - 1]).comment = msg;
            }
            ipb.Dispose();
            if (!paused) {
                TimeSpot timeObj = new TimeSpot();
                timeObj.timePosition = SystemClock;
                timers.Add(timeObj);
            }
            saveTime(tempFilename);
            this.TopMost = tmp;
        }

        #region Report

        private void mnuShowReport_Click(object sender, EventArgs e)
        {

            bool tmp = this.TopMost;
            this.TopMost = false;
            if (timers.Count == 0) {  MetroMessageBox.Show(this,"尚未开始计时",""); this.TopMost = tmp; return; }
            FormLongMsg flm = new FormLongMsg(this);
            flm.txtTimeTable.Text = makeTimeTable();
            flm.txtTimeTable.ReadOnly = true;
            flm.txtTimeParagraph.Text = makeTimeParagraph();
            flm.txtTimeParagraph.ReadOnly = true;
            Application.DoEvents();
            flm.txtTimeTable.SelectionStart = 0;
            flm.txtTimeTable.SelectionLength = 0;
            flm.txtTimeParagraph.SelectionStart = 0;
            flm.txtTimeParagraph.SelectionLength = 0;

            makePieChart(flm.chartPie);
            makePieChart(flm.chartLine);
            makeFlowChart(flm.chartFlow);

            flm.ShowDialog();
            flm.Dispose();
            this.TopMost = tmp;
        }

        string makeTimeTable() {
            StringBuilder timeTable = new StringBuilder();
            timeTable.Append(">>>计时开始>>>").Append("\r\n");
            long time = 0;
            long lastStartTime = SystemClock;
            for (int i = 0; i < timers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    lastStartTime = timers[i].timePosition;
                }
                else
                {
                    time += (timers[i].timePosition - lastStartTime);
                    lastStartTime = SystemClock;
                }
                if (null != timers[i].comment && "" != timers[i].comment)
                {
                    timeTable.Append("[").Append(longToTimeStr(time)).Append("] ").Append(timers[i].comment).Append("\r\n");
                }

            }
            time += (SystemClock - lastStartTime);
            if (!IsPaused)
            {
                timeTable.Append("<<<计时尚未结束<<<");
            }
            else
            {
                timeTable.Append("[").Append(longToTimeStr(time)).Append("] <<<计时结束<<<");
            }
            return timeTable.ToString();
        }

        string makeTimeParagraph() {
            StringBuilder timeParagrapgh = new StringBuilder();
            timeParagrapgh.Append(">>>计时开始>>>").Append("\r\n");
            long time = 0;
            long lastStartTime = SystemClock;

            long lastNoteTime = 0;

            for (int i = 0; i < timers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    lastStartTime = timers[i].timePosition;
                }
                else
                {
                    time += (timers[i].timePosition - lastStartTime);
                    lastStartTime = SystemClock;
                }
                if (null != timers[i].comment && "" != timers[i].comment)
                {
                    timeParagrapgh.Append("[").Append(longToTimeStr(time-lastNoteTime)).Append("] ").Append(timers[i].comment).Append("\r\n");
                    lastNoteTime = time;
                }

            }
            time += (SystemClock - lastStartTime);
            if (!IsPaused)
            {
                timeParagrapgh.Append("<<<计时尚未结束<<<");
            }
            else
            {
                timeParagrapgh.Append("[").Append(longToTimeStr(time)).Append("] <<<计时结束，总时间<<<");
            }
            return timeParagrapgh.ToString();
        }

        void makePieChart(Chart chart)
        {
            long time = 0;
            long lastStartTime = SystemClock;

            long lastNoteTime = 0;

            List<string> xVal = new List<string>();
            List<double> yVal = new List<double>(); 

            for (int i = 0; i < timers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    lastStartTime = timers[i].timePosition;
                }
                else
                {
                    time += (timers[i].timePosition - lastStartTime);
                    lastStartTime = SystemClock;
                }
                if (null != timers[i].comment && "" != timers[i].comment)
                {
                    //timeParagrapgh.Append("[").Append(longToTimeStr(time - lastNoteTime)).Append("] ").Append(timers[i].comment).Append("\r\n");

                    xVal.Add(timers[i].comment);
                    yVal.Add(((time - lastNoteTime) / 1000d / 60d));

                    lastNoteTime = time;
                }

            }
            time += (SystemClock - lastStartTime);

            chart.Series.First().Points.DataBindXY(xVal, yVal);
        }


        void makeFlowChart(Chart chart)
        {
            long time = 0;
            long lastStartTime = SystemClock;

            long lastNoteTime = 0;

            List<string> xVal = new List<string>();
            List<double> yVal = new  List<double>();
            List<double> yVal2 = new List<double>();
            List<double> yVal3 = new List<double>();
            for (int i = 0; i < timers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    lastStartTime = timers[i].timePosition;
                }
                else
                {
                    time += (timers[i].timePosition - lastStartTime);
                    lastStartTime = SystemClock;
                }
                if (null != timers[i].comment && "" != timers[i].comment)
                {
                    //timeParagrapgh.Append("[").Append(longToTimeStr(time - lastNoteTime)).Append("] ").Append(timers[i].comment).Append("\r\n");

                    xVal.Add(timers[i].comment);
                    yVal.Add(((lastNoteTime) / 1000d / 60d));
                    yVal2.Add(((time) / 1000d / 60d));
                    yVal3.Add(((time - lastNoteTime) / 60d / 1000d));
                    lastNoteTime = time;
                }

            }
            time += (SystemClock - lastStartTime);

            chart.Series.First().Points.DataBindXY(xVal, yVal,yVal2,yVal3);
        }
        public string longToTimeStr(long input)
        {
            if (input < 0)
            {
                return "-" + longToTimeStr(-input);
            }

            int hour = 0;
            int minute = 0;
            int second = 0;
            int millisecond = 0;
            long time = input;
            millisecond = (int)(time % 1000L);
            time -= millisecond;
            time = time / 1000;
            second = (int)(time % 60L);
            time -= second;
            time = time / 60;
            minute = (int)(time % 60L);
            time -= minute;
            time = time / 60;
            hour = (int)time;
            if (input + 1 % 1000 == 0) { GC.Collect(); }

            return toBitString(hour, 2) + ":" + toBitString(minute, 2) + ":" + toBitString(second, 2) + "." + toBitString(millisecond, 3);

        }

        public string toBitString(int num, int len)
        {
            string s = num.ToString();
            while (s.Length < len)
            {
                s = "0" + s;
            }
            return s;
        }

        #endregion
        
      

        Bitmap imgPause = Properties.Resources.ic_pause;
        Bitmap imgPlay = Properties.Resources.ic_play;

        private void btnPlay_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(e.Button == MouseButtons.Left && mouseDown)) { return; }
            mouseDown = false;
            TimeSpot timeObj = new TimeSpot();
            timeObj.timePosition = SystemClock;
            timers.Add(timeObj);
            saveTime(tempFilename);
            btnPlay.Image = IsPaused ? imgPlay : imgPause;
        }

        private void btnReset_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(e.Button == MouseButtons.Left && mouseDown)){return;}
            mouseDown = false;
            重置ToolStripMenuItem_Click(sender, e);
        }
        

        private void btnMore_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(e.Button == MouseButtons.Left && mouseDown)) { return; }
            mouseDown = false;
            contextMenuStrip1.Show(btnMore, e.Location);
        }
        

        private bool mouseDown = false;
        private void btnMore_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void btnSave_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(e.Button == MouseButtons.Left && mouseDown)) { return; }
            mouseDown = false;
            mouseDown = false;
            mnuShowReport_Click(sender, e);
        }

        private void btnRecord_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(e.Button == MouseButtons.Left && mouseDown)) { return; }
            mouseDown = false;
            mnuRecordTimeComment_Click(sender, e);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            renderTimer.Interval = 1;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            renderTimer.Interval = 50;
        }
    }
    
}


