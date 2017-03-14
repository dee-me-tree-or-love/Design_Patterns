using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternAssignment
{
    public class Decorator : DesignPatternDecorator
    {
        public Decorator(IApp application)
        {
            this.theApplication = application;
        }

        override public double EvaluateSelf()
        {
            return this.theApplication.EvaluateSelf() + 3;
        }
    }

    public class Strategy : DesignPatternDecorator
    {
        public Strategy(IApp application)
        {
            this.theApplication = application;
        }

        override public double EvaluateSelf()
        {
            return this.theApplication.EvaluateSelf() + 3;
        }
    }

    public class Adapter : DesignPatternDecorator
    {
        public Adapter(IApp application)
        {
            this.theApplication = application;
        }

        override public double EvaluateSelf()
        {
            return this.theApplication.EvaluateSelf() + 2;
        }
    }

    public class AbstractFactory : DesignPatternDecorator
    {
        public AbstractFactory(IApp application)
        {
            this.theApplication = application;
        }

        override public double EvaluateSelf()
        {
            return this.theApplication.EvaluateSelf() + 4;
        }
    }

}
