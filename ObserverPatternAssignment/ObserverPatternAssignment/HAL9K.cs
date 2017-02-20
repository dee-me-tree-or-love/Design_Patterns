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
    public partial class HAL9K : Form, IObserver
    {
        private ISubject bcasterSubject;

        public HAL9K(ISubject _bcstr)
        {
            InitializeComponent();
            this.bcasterSubject = _bcstr;
        }


        /// <summary>
        /// Get the notifications from the astronaut
        /// </summary>
        /// <param name="_subj"></param>
        /// <param name="_input"></param>
        public void ReceiveNotification(ISubject _subj, params object[] _input)
        {
            this.lbReadings.Items.Insert(0, "");
            this.lbReadings.Items.Insert(0, "<<");
            if (_subj is SubjectAstronaut)
            {
                this.lbReadings.Items.Insert(0, ((SubjectAstronaut)_subj).GetGatheredSensorReadings().ToString()); //adds the medical data
            }
            this.lbReadings.Items.Insert(0, "From: " + _subj.ToString());
            this.lbReadings.Items.Insert(0, ">>" + System.DateTime.Now.ToString() + ":");

        }

        /// <summary>
        /// Sometimes unplugging the cable is the only way
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKillHal_Click(object sender, EventArgs e)
        {
            this.bcasterSubject.Dettach(this);
            this.tbHalsWords.Text = "...seat of a bicycle built for two...";
            this.lbReadings.Items.Clear();
            this.lbReadings.Items.Add(">> Press observe to restart");
        }

        /// <summary>
        /// Hal is not easy on commands... 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopObserving_Click(object sender, EventArgs e)
        {
            this.tbHalsWords.Text = "I can't do this, Dave...";
        }

        /// <summary>
        /// Subscribes Hal to the subject
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartObserving_Click(object sender, EventArgs e)
        {
            this.bcasterSubject.Attach(this);
            string _name = "";
            try
            {
                _name = ((SubjectAstronaut)this.bcasterSubject).ToString();
                this.tbHalsWords.Text = "Affirmative, " + _name + ". I read you.";
            }
            catch
            {
                this.tbHalsWords.Text = "I'm afraid I can't do that.";
            }

            
        }

        /// <summary>
        /// Dettach a subscriber on form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HAL9K_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.bcasterSubject.Dettach(this);
        }
    }
}
