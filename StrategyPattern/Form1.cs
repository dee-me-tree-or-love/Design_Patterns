using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        private DiskDrive mainDD;
        public Form1()
        {
            InitializeComponent();
            this.mainDD = new DiskDrive();
            this.RefreshControls(this.mainDD.GetCurrentTask());
            this.mainDD.OnHeadChange += this.RefreshControls;
        }

        private void RefreshControls(int _newCurrentTask)
        {
            this.tbCurrentTask.Text = _newCurrentTask.ToString();
            this.RefreshTaskDisplays();
            this.trBrTasks.Value = _newCurrentTask;
        }

        private void RefreshTaskDisplays()
        {
            this.lbRestTasks.Items.Clear();
            foreach(int t in this.mainDD.GetTasks())
            {
                this.lbRestTasks.Items.Add(t);
            }
            this.trBrTasks.Maximum = this.mainDD.GetTasks().Max();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.mainDD.Run();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.mainDD.Stop();
        }
    }
}
