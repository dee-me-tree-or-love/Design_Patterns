using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternAssignment
{
    abstract public class DesignPatternDecorator: IApp
    {
        protected IApp theApplication;

        abstract public double EvaluateSelf();

        /// <summary>
        /// Not to be overriden
        /// </summary>
        /// <param name="atech"></param>
        public void SetTechnology(IAppTechnology atech)
        {
            this.theApplication.SetTechnology(atech);
        }

        public override string ToString()
        {
            return this.theApplication.ToString() + this.GetType().ToString() + "\n";
        }
    }
}
