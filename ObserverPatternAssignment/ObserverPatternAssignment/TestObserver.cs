using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternAssignment
{
    public class TestObserver: IObserver
    {
        //private String receivedText = "";
        private String subject = "";

        public void ReceiveNotification(ISubject subj, params object[] p)
        {
            this.subject = subj.ToString();
        }

        public string GetSubjectString()
        {
            return this.subject;
        }
    }
}
