using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternAssignment
{
    public interface IObserver
    {
        /// <summary>
        /// Receives a notification from the ISubject subj with the p extra parameters.
        /// This way it can be asked for what data was received - the pull method
        /// </summary>
        /// <param name="p"></param>
        void ReceiveNotification(ISubject subj, params object[] p);
    }
}
