using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
    /// <summary>
    /// For the featured artwork
    /// </summary>
    public interface IFeaturedArtwork
    {
        string getPictureUrl();
        string getDescription();
    }

    /// <summary>
    /// For the featured articles
    /// </summary>
    public interface IFeaturedArticle
    {
        string getHeader();
        string getBody();
        string getMoreUrl();
    }

    /// <summary>
    /// For the featured artists
    /// </summary>
    public interface IFeaturedArtist
    {
        string getPictureUrl();
        string getHeader();
        string getBody();
    }
}
