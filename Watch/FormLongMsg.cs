using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch
{
    public partial class FormLongMsg : MetroForm
    {
        Form frmOwner;
        Boolean ownerTopMost;
        public FormLongMsg(Form owner)
        {
            frmOwner = owner;
            ownerTopMost = owner.TopMost;
            owner.TopMost = false;
            InitializeComponent();
        }

        List<Control> matchParents = new List<Control>();

        private void FormLongMsg_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;
            matchParents.Add(txtTimeTable);
            matchParents.Add(txtTimeParagraph);
            matchParents.Add(chartFlow);
            matchParents.Add(chartPie);
            matchParents.Add(chartLine);
            matchParent();

            metroTabControl1.SelectedTab = metroTabPage1;
        }

        public void matchParent() {
            foreach (var item in matchParents)
            {
                Control parent = item.Parent;
                item.Top = 1;
                item.Left = 1;
                item.Width = parent.Width - 2;
                item.Height = parent.Height - 2;
            }
        }

        private void FormLongMsg_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOwner.TopMost = ownerTopMost;
        }

        private void FormLongMsg_Resize(object sender, EventArgs e)
        {
            matchParent();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            matchParent();
        }
    }
}
