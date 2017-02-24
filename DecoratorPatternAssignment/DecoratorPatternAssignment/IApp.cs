using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternAssignment
{
    public interface IApp
    {
        double EvaluateSelf();

        void SetTechnology(IAppTechnology atech);
    }
}
