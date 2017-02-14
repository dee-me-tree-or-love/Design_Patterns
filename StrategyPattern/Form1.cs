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
            //this.mainDD.OnHeadChange += this.RefreshControls;
        }

        /// <summary>
        /// To refresh controls with a new state
        /// </summary>
        /// <param name="_newCurrentTask"></param>
        private void RefreshControls(int _newCurrentTask)
        {
            this.tbCurrentTask.Text = _newCurrentTask.ToString();
            this.RefreshTaskDisplays();
            this.trBrTasks.Value = _newCurrentTask;
        }

        /// <summary>
        /// To display new data on screen's listbox and pointer bar controls
        /// </summary>
        private void RefreshTaskDisplays()
        {
            this.lbRestTasks.Items.Clear();
            foreach(int t in this.mainDD.GetTasks())
            {
                this.lbRestTasks.Items.Add(t);
            }
            this.trBrTasks.Maximum = this.mainDD.GetTasks().Max()+10; //just to be safe
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.mainDD.Run();
            this.tmrDiskProcessing.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.mainDD.Stop();
            this.tmrDiskProcessing.Stop();
        }

        private void tmrDiskProcessing_Tick(object sender, EventArgs e)
        {
            this.MakeDiscStep();
        }

        /// <summary>
        /// To do a single step by the disc
        /// </summary>
        private void MakeDiscStep()
        {
            this.mainDD.OnTimedAction();
            this.RefreshControls(this.mainDD.GetCurrentTask());
        }

        /// <summary>
        /// Checks which strategy should be applied
        /// </summary>
        private void DetermineStrategy()
        {
            if (this.rbFCFS.Checked)
            {
                FCFSDiskStrategy fcds = new FCFSDiskStrategy();
                this.mainDD.SetStrategy(fcds);
            }
            if (this.rbSCAN.Checked)
            {
                SCANDiskStrategy fcds = new SCANDiskStrategy();
                this.mainDD.SetStrategy(fcds);
            }
            if (this.rbSSTF.Checked)
            {
                SSTFDiskStrategy fcds = new SSTFDiskStrategy();
                this.mainDD.SetStrategy(fcds);
            }
        }

        private void rbFCFS_CheckedChanged(object sender, EventArgs e)
        {
            this.DetermineStrategy();
        }

        private void rbSSTF_CheckedChanged(object sender, EventArgs e)
        {
            this.DetermineStrategy();
        }

        private void rbSCAN_CheckedChanged(object sender, EventArgs e)
        {
            this.DetermineStrategy();
        }

        private void btnOneStep_Click(object sender, EventArgs e)
        {
            this.MakeDiscStep();
        }
    }
}
