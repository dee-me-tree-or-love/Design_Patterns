using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
    /// <summary>
    /// for the impressionism section
    /// </summary>
    class ImpArticle : IFeaturedArticle
    {
        private string textHeader;
        private DateTime publicationDate;
        // bad that it is hardcoded, yeah... 
        private string textBody;
        private string url;

        public ImpArticle()
        {
            this.textHeader = "Impressionism: 1860-1890";
            this.publicationDate = System.DateTime.Today;
            // bad that it is hardcoded, yeah... 
            this.textBody = "Term generally applied to a movement in art in France in the late 19th century. "
              + "The movement gave rise to such ancillaries as American Impressionism. "
              + "The primary use of the term Impressionist is for a group of French "
              + "painters who worked between around 1860 and 1900, ";
            this.url = "https://www.google.com/culturalinstitute/beta/u/0/entity/m03xj1?categoryId=art-movement";
        }

        public string getBody()
        {
            return this.textBody;
        }

        /// <summary>
        /// The Impressionist article is created with the headers and texts defined
        /// </summary>
        /// <returns></returns>
        public string getHeader()
        {
            return this.textHeader;
        }

        /// <summary>
        /// The url basically returns the property
        /// </summary>
        /// <returns></returns>
        public string getMoreUrl()
        {
            return this.url;
        }
    }

    /// <summary>
    /// for the constructivism section
    /// </summary>
    class ConstrArticle : IFeaturedArticle
    {
        /// all that stuff is just to make the differentiation between the different sections 
        private string textBody;
        private string artist;
        private int[] period;
        private string url;

        
        public ConstrArticle()
        {
            this.artist = "Vladimir Tatlin";
            this.period = new int[] { 1919, 1920 };
            this.textBody = "Design for the Monument to the Third International.\r\n"
                + " Monument to the Third International, also sometimes known simply as Tatlin's Tower, "
                + "is the artist's most famous work, as well as the most important spur to the formation of "
                + "the Constructivist movement. The Tower, which was never fully realized,";
            this.url = "http://www.theartstory.org/movement-constructivism.htm";
        }

        /// <summary>
        /// the body of the text is composed of a few additional properties
        /// the text is created by appending the extra data
        /// </summary>
        /// <returns></returns>
        public string getBody()
        {
            // append the artist and the dates 
            string text = "Artist: " + this.artist;
            text += "\r\n(" + this.period[0] + " - " + this.period[1] + ")";
            text += "\r\n\t" + this.textBody;
            return text.Substring(0, (text.Length * 2 / 3)) + "...";
        }
        
        /// <summary>
        /// All the headers will be the first sentences of the article.
        /// </summary>
        /// <returns></returns>
        public string getHeader()
        {
            // Works under the assumption there is a dot in the text

            // get's the index of the first dot 
            int index = this.textBody.IndexOf('.');
            // could be better to have a handler for the varying size
            return this.textBody.Substring(0, index-1);
        }

        public string getMoreUrl()
        {
            return this.url;
        }
    }

    // do some stuff with the transaltions...
    class UkiArticle : IFeaturedArticle
    {
        private string textbody = "Japanese for ‘pictures of the floating world’ and referring to transient everyday life, it provided a major source of imagery in Japanese art from the 17th to the 19th centuries. "
            +"From the middle of the 19th century and had a great influence on many avant-garde artists, including the Impressionists and Post-Impressionists.";
        private string url = "https://www.google.com/culturalinstitute/beta/u/0/entity/m0bwbv";
        private string header = "Ukiyo-e";
        private string land = "Japan";
        private string date = "1620-1912";

        public string getBody()
        {
            return this.land + "\r\n" + this.date+""+this.textbody;
        }

        public string getHeader()
        {
            return this.header;
        }

        public string getMoreUrl()
        {
            return this.url;
        }
    }
}
