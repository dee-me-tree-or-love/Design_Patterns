using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
    /// <summary>
    /// Creates the art things based on the sections
    /// </summary>
    interface ISectionFactory
    {
        IFeaturedArticle CreateFeaturedArticle();
        IFeaturedArtist CreateFeaturedArtist();
        IFeaturedArtwork CreateFeaturedArtwork();
    }
}
