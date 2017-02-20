using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPatternAssignment
{
    public partial class Form1 : Form
    {
        static private SubjectAstronaut astronautBcaster = new SubjectAstronaut("Dave"); //made static so that there exists only 1 instance of Dave
        private bool tickBCastScheduled = true;

        public Form1()
        {
            InitializeComponent();
            Form1.astronautBcaster = new SubjectAstronaut("Dave");
            this.tickBCastScheduled = true;
            this.pbBcst.Visible = false;
        }

        /// <summary>
        /// Returns the subject associated with the form
        /// </summary>
        /// <returns></returns>
        public ISubject GetSubject()
        {
            return Form1.astronautBcaster;
        }

        /// <summary>
        /// Checks if the timer is running or not and triggers it
        /// </summary>
        private void btnStartStopTimer_Click(object sender, EventArgs e)
        {
            if (this.tmrTelCom.Enabled)
            {
                this.tmrTelCom.Stop();
                this.pbBcst.Visible = false;
                this.tbTelComStatus.Text = "broadcast halted";
            }
            else
            {
                this.tmrTelCom.Start();
                this.pbBcst.Visible = true;
            }
        }

        /// <summary>
        /// On tick two things can happen - broadcast or status refresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrTelCom_Tick(object sender, EventArgs e)
        {
            if (this.tickBCastScheduled)
            {
                Form1.astronautBcaster.Notify();
                this.tickBCastScheduled = false;
                this.tbTelComStatus.Text = "data sent...";
            }
            else
            {
                this.tbTelComStatus.Text = "transmitted to " + Form1.astronautBcaster.GetSubscribersCount() + " listeners";
                this.tickBCastScheduled = true;
            }
        }
    }
}
