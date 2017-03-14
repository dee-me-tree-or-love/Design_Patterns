using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
    // the 'products' differ by the description parameters

    /// <summary>
    /// for the impressionism section
    /// </summary>
    class ImpArtwork : IFeaturedArtwork
    {
        private string name;
        private string country;
        private string material;
        private string artistName;
        private int year;
        private string picUrl;

        public ImpArtwork()
        {
            // TO DO: provide the data
            this.name = "Poppy Field";
            this.country = "France";
            this.artistName = "Claude Monet";
            this.material = "Oil on canvas";
            this.year = 1873;
            this.picUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Claude_Monet_-_Poppy_Field_-_Google_Art_Project.jpg/1280px-Claude_Monet_-_Poppy_Field_-_Google_Art_Project.jpg";
        }

        public string getDescription()
        {
            string desc = this.name + "\r\n"
                + "By : " + this.artistName
                + this.year.ToString() + ", " + this.country +"\r\n"
                + this.material;
            return desc;
        }

        public string getPictureUrl()
        {
            return this.picUrl;
        }
    }

    /// <summary>
    /// for the constructivism section
    /// </summary>
    class ConstrArtwork : IFeaturedArtwork
    {
        private string name;
        private string description; // more like a quote/extract from the description
        private string descriptionAuthor;
        private string url;

        public ConstrArtwork()
        {
            this.name = "Archer";
            this.description = "Theo van Doesburg began his career as a self-taught artist. His early landscapes and portraits, painted prior to 1915, manifest the influence of German Expressionism, and first and foremost Wassily Kandinsky.";
            this.descriptionAuthor = "Theo van Doesburg";
            this.url = "https://upload.wikimedia.org/wikipedia/commons/e/e4/Theo_van_Doesburg_-_Archer_-_Google_Art_Project.jpg";
        }

        public string getDescription()
        {
            return this.name + "\r\n---------\r\n"
                + this.description + "\r\n"
                + "\t-- " + this.descriptionAuthor;
        }

        public string getPictureUrl()
        {
            return this.url;
        }
    }

    /// <summary>
    /// for the ukiyo-e section
    /// </summary>
    class UkiArtwork : IFeaturedArtwork
    {
        // will contain a number of artworks
        /// <summary>
        /// Defines the base of an artwork to which this featerude artwork corresponds
        /// </summary>
        private class Art
        {
            private string url;
            private string name;
            private string author;
            private string period;
            private string region;
            private int year;

            public Art(string _name, string _auth, string _per, string _reg, int _yr, string _url)
            {
                this.author = _auth;
                this.name = _name;
                this.period = _per;
                this.region = _reg;
                this.year = _yr;
                this.url = _url;
            }

            /// <summary>
            /// Creates a description of the work in a templated way
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                string desc = "'" + this.name + "'";
                desc += "\r\nBy " + this.author;
                desc += "\r\n"+this.author+" created this beatiful artork in " + this.period + " period in the region of " + this.region;
                return desc;
            }
            public string GetUrl()
            {
                return this.url;
            }
        }

        private static List<Art> works = new List<Art>()
        {
            new Art("Thirty-six Views of Mount Fuji: The Great Wave off Kanagawa", "Hokusai","1830-32","Mount Fuji",1830,"https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Great_Wave_off_Kanagawa2.jpg/1920px-Great_Wave_off_Kanagawa2.jpg"),
            new Art("Sudden Shower over Shin-Ohashi Bridge and Atake", "Hiroshage","...","...",1857,"https://upload.wikimedia.org/wikipedia/commons/thumb/7/72/Hiroshige,_Sudden_shower_over_Shin-%C5%8Chashi_bridge_and_Atake,_1857.jpg/300px-Hiroshige,_Sudden_shower_over_Shin-%C5%8Chashi_bridge_and_Atake,_1857.jpg"),
        };
        private Art work;

        /// <summary>
        /// The work is radnomly chosen
        /// </summary>
        public UkiArtwork()
        {
            // Potentially it could have been replaced with some 
            // web request to the api and a factory method to create the work based on the retrieved data
            this.work = works[(new Random().Next(0,666)%UkiArtwork.works.Count)];
        }

        public string getDescription()
        {
            // since to string already creates the format
            return this.work.ToString();
        }

        public string getPictureUrl()
        {
            return this.work.GetUrl();
        }
    }
}
