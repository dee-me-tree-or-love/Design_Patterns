using System;
using System.Windows.Forms;

namespace ObserverPatternAssignment
{
    public partial class PHA : Form, IObserver
    {
        private ISubject bcasterSubject;

        public PHA(ISubject _bcstr)
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
            if (_subj is SubjectAstronaut)
            {
                SubjectAstronaut _fromSubj = (SubjectAstronaut)_subj;
                this.pbBPM.Value = _fromSubj.GetGatheredSensorReadings().BPM;
                this.pbBPRESsys.Value = _fromSubj.
                    GetGatheredSensorReadings().BloodPressure[0];

                this.pbBPRESdys.Value = _fromSubj.
                    GetGatheredSensorReadings().BloodPressure[1];

                this.pbBSUG.Value = _fromSubj.GetGatheredSensorReadings().BloodSugar;
                this.pbOX.Value = _fromSubj.GetGatheredSensorReadings().OxygenLevel;
                this.pbTEMP.Value = Convert.ToInt32(_fromSubj.GetGatheredSensorReadings().Temperture);

            }
        }

        private void btnStopObserving_Click(object sender, EventArgs e)
        {
            this.bcasterSubject.Dettach(this);
            this.lblConnectionInfo.Text = "Not connected...";
        }

        private void btnStartObserving_Click(object sender, EventArgs e)
        {
            this.bcasterSubject.Attach(this);
            this.lblConnectionInfo.Text = "Listening...";
        }

        private void PHA_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.bcasterSubject.Dettach(this);
        }
    }
}
