using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternAssignment
{
    public class WebTechnology: IAppTechnology
    {
        public double GetAddedComplexity()
        {
            return 2.0;
        }
    }

    public class DesktopTechnology : IAppTechnology
    {
        public double GetAddedComplexity()
        {
            return 1.0;
        }
    }

    public class EmbeddedTechnology : IAppTechnology
    {
        public double GetAddedComplexity()
        {
            return 3.0;
        }
    }
}
