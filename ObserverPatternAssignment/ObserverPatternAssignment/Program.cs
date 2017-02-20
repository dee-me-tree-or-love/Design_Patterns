using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPatternAssignment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 _formDave = new Form1();
            // observer 1
            HAL9K _formHal = new HAL9K(_formDave.GetSubject());
            PHA _formPHA = new PHA(_formDave.GetSubject());
            _formPHA.Show();
            _formHal.Show();
            Application.Run(_formDave);
            

        }
    }
}
