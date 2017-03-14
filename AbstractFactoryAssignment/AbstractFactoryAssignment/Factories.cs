using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
    public class ImpFactory : ISectionFactory
    {
        public IFeaturedArticle CreateFeaturedArticle()
        {
            return new ImpArticle();
        }

        public IFeaturedArtist CreateFeaturedArtist()
        {
            return new ImpFeaturedArtist();
        }

        public IFeaturedArtwork CreateFeaturedArtwork()
        {
            return new ImpArtwork();
        }
    }

    public class ConstrFactory : ISectionFactory
    {
        public IFeaturedArticle CreateFeaturedArticle()
        {
            return new ConstrArticle();
        }

        public IFeaturedArtist CreateFeaturedArtist()
        {
            return new ConstrFeaturedArtist();
        }

        public IFeaturedArtwork CreateFeaturedArtwork()
        {
            return new ConstrArtwork();
        }
    }

    public class UkiFactory : ISectionFactory
    {
        public IFeaturedArticle CreateFeaturedArticle()
        {
            return new UkiArticle();
        }

        public IFeaturedArtist CreateFeaturedArtist()
        {
            return new UkiFeaturedArtist();
        }

        public IFeaturedArtwork CreateFeaturedArtwork()
        {
            return new UkiArtwork();
        }
    }
}
