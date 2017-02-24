using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternAssignment
{
    public class BaseApp : IApp
    {
        private IAppTechnology implementatiton;
        private double complexity = 10;
        public string Name;

        public BaseApp()
        {
            this.Name = "<<NewApp>>";
            this.implementatiton = null; 
        }

        virtual public double EvaluateSelf()
        {
            double addedComplexity = 0;
            if(this.implementatiton != null) // in case there's something
            {
                addedComplexity = this.implementatiton.GetAddedComplexity();
            }
            return this.complexity + addedComplexity;
        }

        public void SetTechnology(IAppTechnology atech)
        {
            this.implementatiton = atech;
        }

        public override string ToString()
        {
            return this.Name + " : using " + this.implementatiton.GetType().ToString() + "\n";
        }
    }

    // replaced by the strategy
    // 
    //public class WebApp: BaseApp
    //{
    //    public WebApp(): base() { }

    //    override public double EvaluateSelf()
    //    {
    //        return 2 + base.EvaluateSelf();
    //    }
    //}

    //public class DesktopApp: BaseApp
    //{
    //    public DesktopApp(): base() { }

    //    public override double EvaluateSelf()
    //    {
    //        return base.EvaluateSelf() + 1;
    //    }
    //}
}
