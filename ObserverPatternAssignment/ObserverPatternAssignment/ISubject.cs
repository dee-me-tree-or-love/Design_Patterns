using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternAssignment
{
    public interface ISubject
    {
        /// <summary>
        /// Attaches the new observer to the list of the susbcribers
        /// </summary>
        /// <param name="o"></param>
        void Attach(IObserver o);
        /// <summary>
        /// Detached the observer o from the list of the susbcribers
        /// </summary>
        /// <param name="o"></param>
        void Dettach(IObserver o);

        /// <summary>
        /// Notifies the clients
        /// </summary>
        void Notify();
    }
}
