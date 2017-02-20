using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternAssignment
{
    /// <summary>
    /// For testing purposes and for being an abstract subject class - the parent of all subjects
    /// </summary>
    public class Subject : ISubject
    {
        protected List<IObserver> subscribers;

        public Subject()
        {
            this.subscribers = new List<IObserver>();
        }

        public void Attach(IObserver o)
        {
            if (!this.subscribers.Contains(o)) // so we don't have duplicates
            {
                try
                {
                    this.subscribers.Add(o);
                }
                catch (Exception e)
                {
                    ConsoleLogger.Log(e.Message, "From" + e.Source);
                }
            }
           

        }

        public void Dettach(IObserver o)
        {
            try
            {
                this.subscribers.Remove(o);
            }
            catch (Exception e)
            {
                ConsoleLogger.Log(e.Message, "From" + e.Source);
            }
        }

        /// <summary>
        /// Sends the data to the observer
        /// </summary>
        virtual public void Notify()
        {
            foreach(IObserver o in this.subscribers)
            {
                o.ReceiveNotification(this);
            }
        }

        public override string ToString()
        {
            return "parent subject";
        }

    }


    public class SubjectAstronaut : Subject
    { 
        private string name;
        private MedicalData medData;

        /// <summary>
        /// Creates a new instance of a subject and reads the first sensor values
        /// i.e randomizes the med. info
        /// </summary>
        /// <param name="_name"></param>
        public SubjectAstronaut(string _name)
            : base() 
        {
            this.name = _name;
            this.medData = new MedicalData();
        }

        /// <summary>
        /// Reads the sensor values
        /// </summary>
        public void ReadSensors()
        {
            // simply randomizes the data
            this.medData = new MedicalData();
            //int secondsSinceMidnight = Convert.ToInt32(DateTime.Now.Subtract(DateTime.Today).TotalSeconds);
            //Random _rnd = new Random(secondsSinceMidnight);
            //this.medData = new MedicalData(_rnd);
        }

        /// <summary>
        /// Gets the name of the astronaut
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Get's the gathered sensor data
        /// </summary>
        /// <returns></returns>
        public MedicalData GetGatheredSensorReadings()
        {
            return this.medData;
        }

        /// <summary>
        /// Sends the data to the subscribers, but first gets the new readings
        /// </summary>
        public override void Notify()
        {
            this.ReadSensors();
            base.Notify();
        }

        /// <summary>
        /// Gets the number of subscribed listeneres
        /// </summary>
        /// <returns></returns>
        public int GetSubscribersCount()
        {
            if(this.subscribers != null)
            {
                return this.subscribers.Count;
            }
            return 0;
            
        }

        /// <summary>
        /// Returns the name of the subject
        /// </summary>
        /// <returns>the name of the medical subject</returns>
        public override string ToString()
        {
            return this.name;
        }

        /// <summary>
        /// To unbind all the observers
        /// </summary>
        public void UnsubscribeAllObservers()
        {
            foreach(IObserver o in this.subscribers)
            {
                this.Dettach(o);
            }
        }

    }

    // Data to be transmitted
    public class MedicalData
    {
        public int BPM { get; private set; } // number of beats per minute - thus integer values
        public int[] BloodPressure { get; private set; } // Systolic - first index, Diastolic - second index
        public int BloodSugar { get; private set; } // in 0 - 400 range, measuring in mg/dL
        public double Temperture { get; private set; } // in celcius
        public int OxygenLevel { get; private set; } // in percentage
        private Random rnd = new Random(); // further I'd like to try to find out how to add the custom distribution to the random numbers, but I didn't manage to find time now

        /// <summary> 
        /// For the reasons of simplicity the data is randomized on every call to constructor -> therefore
        /// the subject imitates the device with no internal memory that reads random values on every interval of the timer
        /// the distirbution of the generated numbers is not anyhow adjusted, so the readings may get quite ridicoulous time to time
        /// </summary>
        public MedicalData()
        {
            //int secondsSinceMidnight = Convert.ToInt32(DateTime.Now.Subtract(DateTime.Today).TotalSeconds);
            //rnd = new Random(secondsSinceMidnight);
            this.BPM = rnd.Next(40, 220); // well, somewhere around that
            this.BloodPressure = new int[] { rnd.Next(90, 220), rnd.Next(50, 150) };
            this.BloodSugar = rnd.Next(30, 180); // well, let's not use the whole range
            this.OxygenLevel = rnd.Next(85, 100);
            this.Temperture = (double)rnd.Next(330, 400) / (double)10;
        }

        /// <summary>
        /// An overload of the medical data that takes the external randomizer
        /// </summary>
        /// <param name="_rnd"></param>
        public MedicalData(Random _rnd)
        {
            this.BPM = _rnd.Next(40, 220); // well, somewhere around that
            this.BloodPressure = new int[] { _rnd.Next(90, 220), _rnd.Next(50, 150) };
            this.BloodSugar = _rnd.Next(30, 350);
            this.OxygenLevel = _rnd.Next(85, 100);
            this.Temperture = (double)_rnd.Next(330, 400) / (double)10;
        }


        /// <summary>
        /// Representation of the readings in a string way
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return  "|| BPM: " + this.BPM 
                    + "; b.pres: ["+this.BloodPressure[0] +","+this.BloodPressure[1]+"]"
                    + "; b.sug: " + this.BloodSugar
                    + "; temp: " + this.Temperture
                    + "; ox: " + this.OxygenLevel + "%;||";
        }

    }

    
}
