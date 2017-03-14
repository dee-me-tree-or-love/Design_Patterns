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
    class ImpFeaturedArtist : IFeaturedArtist
    {
        // an inner class just to make use of it.
        private class Impressionist
        {
            public Impressionist(string _name, string _country, int[] _lifeperiod, string _url)
            {
                this.Name = _name;
                this.lifeperiod = _lifeperiod;
                this.country = _country;
                this.pictureUrl = _url;
            }
            private string country;
            public string Name;
            private int[] lifeperiod;
            private string pictureUrl;

            /// <summary>
            /// A dump function to represent the life period of the artist
            /// </summary>
            /// <returns></returns>
            public string GetLifePeriod()
            {
                string per = "(";
                if (this.lifeperiod.Length > 0)
                {
                    per += this.lifeperiod[0].ToString() + " - ";
                }
                else
                {
                    per = "(n/a)";
                    return per;
                }
                if (this.lifeperiod.Length > 1)
                {
                    per += this.lifeperiod[1].ToString() + ")";
                }
                else
                {
                    per += "n/a)";
                }
                return per;
            }
            /// <summary>
            /// To be used to create the description
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return this.Name + "\r\n" + this.GetLifePeriod() + "\r\n" + this.country;
            }

            public string GetPictureUrl()
            {
                return this.pictureUrl;
            }
        }

        /// <summary>
        /// A static list of impressionists to randomly to selected from
        /// </summary>
        private static List<Impressionist> authors = new List<Impressionist>()
        {
            new Impressionist("Berthe Morisot","France", new int[] {1841,1895 },"https://upload.wikimedia.org/wikipedia/commons/2/2c/Edouard_Manet_-_Berthe_Morisot_With_a_Bouquet_of_Violets_-_Google_Art_Project.jpg"),
            new Impressionist("Edouard Manet","France", new int[] {1832, 1883 },"https://www.biography.com/.image/c_fill,cs_srgb,dpr_1.0,g_face,h_300,q_80,w_300/MTIwNjA4NjMzOTAzMTU0NzAw/edouard-manet-9397188-1-402.jpg"),
            new Impressionist("Camille Pissarro", "Danish West Indies, France", new int[] { 1930,1903},"https://www.biography.com/.image/c_fill,cs_srgb,dpr_1.0,g_face,h_300,q_80,w_300/MTE4MDAzNDEwNjU3NzczMDcw/camille-pissarro-wc-9441740-1-402.jpg"),
        };

        private Impressionist currentArtist;

        public ImpFeaturedArtist()
        {
            //the current artist is randomized on initialization
            Random rnd = new Random();
            this.currentArtist = authors[(rnd.Next(0,981)%authors.Count)];
        }

        // The body of the featured artist
        // returns all the values of the current! artist - i.e one of the 3 random
        public string getBody()
        {
            return this.currentArtist.ToString();
        }

        public string getHeader()
        {
            return this.currentArtist.Name;
        }

        public string getPictureUrl()
        {
            return this.currentArtist.GetPictureUrl();
        }
    }



    /// <summary>
    /// for the constructivism section
    /// will feature only one article about the artist but with n related pictures
    /// </summary>
    class ConstrFeaturedArtist : IFeaturedArtist
    {
        private List<String> pictureUrls = new List<string>()
        {
            "https://upload.wikimedia.org/wikipedia/commons/c/c3/Thomaz_Farkas_%284863767074%29.jpg",
            "https://artblart.files.wordpress.com/2015/06/tf25-web.jpg",
            "https://upload.wikimedia.org/wikipedia/pt/0/07/Acv_imglista_1412366748.jpg",
            "https://s-media-cache-ak0.pinimg.com/736x/e7/53/0e/e7530e8dc9b72497adab8277f7606082.jpg",
            "http://cultura.estadao.com.br/blogs/luiz-zanin/wp-content/uploads/sites/107/2011/03/thomaz.jpg",
            "https://s-media-cache-ak0.pinimg.com/736x/d5/6b/87/d56b87724039ddb461ac4cef4067a5ea.jpg",
        };
        private string currentUrl;
        private string txtBody;
        private DateTime publishDate;
        private string header;

        public ConstrFeaturedArtist()
        {
            this.txtBody = "circa 1945\r\nThrough a partnership with the artist himself, the IMS took on the protection and preservation of the photographic works of Thomaz Farkas, comprising over 34,000 images that range from 1940-1990. A multifaceted figure who also made a profound mark on the Brazilian cultural scene as a businessman – at the head of Fotoptica, the company inherited from his father – and a man of cinema, Farkas composed a vast photographical oeuvre with a strong authorial voice that would be appreciated as a whole only late in his life, in the 1990s. ";
            this.header = "Thomaz Farkas, Rio de Janeiro, RJ. Brazil";
            this.publishDate = System.DateTime.Today;
            // list of urls is populated by default
            // random picture
            Random rnd = new Random();
            this.currentUrl = this.pictureUrls[(rnd.Next(0,549) %pictureUrls.Count)];
        }

        // get the body of the artist description
        public string getBody()
        {
            return this.txtBody;
        }

        // get the header, simply returns the default header
        public string getHeader()
        {
            return this.header;
        }

        /// <summary>
        /// Gets a random picture URL from the list
        /// </summary>
        /// <returns></returns>
        public string getPictureUrl()
        {
            return this.currentUrl; // was randomized on initialization
        }
    }

    /// <summary>
    /// for the ukiyo-e section
    /// </summary>
    class UkiFeaturedArtist : IFeaturedArtist
    {
        // Typical subjects included theatre scenes, with actors in well-known roles, and views of the night-life of Edo (as Tokyo was then called)

        private class JapArtist
        {
            public String Name { private set; get; }
            public String Motto { private set; get; }
            public String LifePeriod { private set; get; }
            public String Description { private set; get; }
            public List<String> ArtworkNames { private set; get; }
            private List<string> ArtworkUrls;
            public JapArtist(String _name, String _motto, String _lfp, String _desc,List<String> _arts, List<String> _urls)
            {
                this.Name = _name;
                this.Motto = _motto;
                this.LifePeriod = _lfp;
                this.Description = _desc;
                this.ArtworkNames = _arts;
                this.ArtworkUrls = _urls;
            }
            public String getUrl()
            {
                Random rnd = new Random();
                return this.ArtworkUrls[(rnd.Next(0,361)%ArtworkUrls.Count)];
            }
        }

        // a pool of artists to select from
        private static List<JapArtist> authors = new List<JapArtist>()
        {
            new JapArtist("Utagawa Hiroshige","the last great master","1797 - Oct 12, 1858","Utagawa Hiroshige, also Andō Hiroshige was a Japanese ukiyo-e artist, considered the last great master of that tradition. \r\n Hiroshige is best known for his landscapes.",new List<string>()
            {
                "The Fifty-three Stations","Sixty-nine Stations","Kiso Kaidō"
            },new List<string>()
            {
                "https://data.ukiyo-e.org/mfa/images/sc141904.jpg","https://upload.wikimedia.org/wikipedia/commons/c/cf/Portrait_%C3%A0_la_m%C3%A9moire_d%27Hiroshige_par_Kunisada.jpg","https://upload.wikimedia.org/wikipedia/commons/thumb/9/90/03_-_Sukiyagahsi.jpg/800px-03_-_Sukiyagahsi.jpg"
            }),

            new JapArtist("Hokusai","of the Edo period","1760 - May 10, 1849","Katsushika Hokusai was a Japanese artist, ukiyo-e painter and printmaker of the Edo period. He was influenced by such painters as Sesshu, and other styles of Chinese painting. Born in Edo, Hokusai is best known as author of the woodblock print series which includes the internationally recognized print created during the 1820s.",new List<string>()
            {
                "Thirty-Six Views","The Great Wave off Kanagawa","Lost-love shell"
            },new List<string>()
            {
                "https://upload.wikimedia.org/wikipedia/commons/f/f4/Katsushika_Hokusai_-_Lost-love_shell_(Katashigai)_-_from_the_series_'A_shell-matching_game_with_Genroku_thirty-six_linked..._-_Google_Art_Project.jpg","http://lh3.ggpht.com/4P46-k5doNj5F9vNO9EAxxoVyzZT4R6yHDtSQqWLLjmabWzcj-6XtWSN4j515w=s1200","https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTkjciha-zGpo0qomVA9I2BBi4QX_WMC-4Ho-LlF0bDWlzDZpWbFAkdPok"
            }),

            new JapArtist("Kobayashi Kiyochika","japan modernizing","Sep 10, 1847 - 1915","Kobayashi Kiyochika was a Japanese ukiyo-e artist, best-known for his ukiyo-e colour woodblock prints and newspaper illustrations. His work documents the rapid modernization and Westernization Japanese underwent during the Meiji period and employs a sense of light and shade called kōsen-ga inspired by Western art techniques. ",new List<string>()
            {
                "War at sea",""
            },new List<string>()
            {
                "https://ocw.mit.edu/ans7870/21f/21f.027/throwing_off_asia_01/image/2000_107_l.jpg","https://lh6.ggpht.com/BTqMGoPpoaBaIv68LgqiSbsceuyAyghSZsNOPIT9i5N4OVvTYfWo1euCrg","https://images-na.ssl-images-amazon.com/images/I/A1H-OVFmAdL._SY450_.jpg","https://printsofjapan.files.wordpress.com/2016/09/ritsumeikan_kiyochika_1884_hell_courtesan_7_detail2.jpg?w=623&h=910"
            }),

            // limited to 3

            //new JapArtist("","","","",new List<string>()
            //{
            //    "",""
            //},new List<string>()
            //{
            //    "",""
            //}),

            //new JapArtist("","","","",new List<string>()
            //{
            //    "",""
            //},new List<string>()
            //{
            //    "",""
            //}),

        };

        private JapArtist currentAuthor;
        public UkiFeaturedArtist()
        {
            this.currentAuthor = authors[(new Random().Next(0, 389)%authors.Count)];
        }

        public string getBody()
        {
            string collection = "";
            foreach (string artwork in this.currentAuthor.ArtworkNames)
            {
                collection += "\r\n\t"+ artwork;
            }
            return this.currentAuthor.LifePeriod + "\r\n" + this.currentAuthor.Description 
                + collection;
        }

        public string getHeader()
        {

            return this.currentAuthor.Name + " : " + this.currentAuthor.Motto;
        }

        public string getPictureUrl()
        {
            // it is randomized in the getUrl handler
            return this.currentAuthor.getUrl();
        }
    }
}
