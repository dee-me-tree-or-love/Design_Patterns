using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactoryAssignment
{ 
    public partial class ArtBrowser : Form
    {
        private ISectionFactory factory = null;
        private IFeaturedArticle article = null;
        private IFeaturedArtist artsist = null;
        private IFeaturedArtwork artwork = null;
        private List<String> savedArtUrls = null;

        private void DetermineFactory()
        {
            try
            {
                SectionEnum SelectedEnum = (SectionEnum)this.cmbxSection.SelectedItem;
                switch (SelectedEnum)
                {
                    case SectionEnum.CONSTRUCTIVISM:
                        this.factory = new ConstrFactory();
                        break;
                    case SectionEnum.IMPRESSIONISM:
                        this.factory = new ImpFactory();
                        break;
                    case SectionEnum.UKIYOE:
                        this.factory = new UkiFactory();
                        break;
                }    
            }
            catch
            {
                this.factory = null;
            }
            finally
            {
                this.toolStripStatusLabel1.Text = "Saved Artworks:";
            }
            if(factory == null)
            {
                this.btnChangeArtist.Visible = false;
                this.btnSaveArtwork.Visible = false;
                this.btnReadMore.Visible = false;
            }
            else
            {
                this.btnChangeArtist.Visible = true;
                this.btnSaveArtwork.Visible = true;
                this.btnReadMore.Visible = true;
            }
        }

        private enum SectionEnum
        {
            IMPRESSIONISM,
            CONSTRUCTIVISM,
            UKIYOE, 
        }

        /// <summary>
        /// Download the picture from the web
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private System.Drawing.Image GetWebPicture(String url)
        {
            var request = WebRequest.Create(url);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                return Bitmap.FromStream(stream);
            }
        }

        /// <summary>
        /// A method that would be called in a different thread
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="url"></param>
        private void RetrievePicture(PictureBox pb, String url)
        {
            pb.Image = this.GetWebPicture(url);
        }

        public ArtBrowser()
        {
            InitializeComponent();
            this.btnChangeArtist.Visible = false;
            this.btnSaveArtwork.Visible = false;
            this.btnReadMore.Visible = false;
            // add options from the enum
            this.cmbxSection.Items.Add(SectionEnum.IMPRESSIONISM);
            this.cmbxSection.Items.Add(SectionEnum.CONSTRUCTIVISM);
            this.cmbxSection.Items.Add(SectionEnum.UKIYOE);

            this.DetermineFactory();
            savedArtUrls = new List<String>();
        }

        private void UpdateArtworkViews(IFeaturedArtwork aw = null, IFeaturedArtist at = null, IFeaturedArticle ac = null)
        {
            
            try
            {
                // if the artwork is specified
                if (aw != null)
                {
                    //this.pbArtist.ImageLocation = aw.getPictureUrl();
                    //this.pbFeaturedArt.Image = this.GetWebPicture(aw.getPictureUrl());
                    Thread td = new Thread(()=> this.RetrievePicture(this.pbFeaturedArt,aw.getPictureUrl()));
                    td.Start(); 
                    this.tbFeaturedArtDesciption.Text = aw.getDescription();
                }
                // if the artist is specified
                if (at != null)
                {
                    // oups, just noticed the java method naming used... sorry
                    this.tbArtistHeading.Text = at.getHeader();
                    this.tbArtistDescription.Text = at.getBody();
                    //this.pbArtist.Image = this.GetWebPicture(at.getPictureUrl());
                    Thread td = new Thread(() => this.RetrievePicture(this.pbArtist, at.getPictureUrl()));
                    td.Start();
                }
                if (ac != null)
                {
                    this.tbSectionHeading.Text = this.article.getHeader();
                    this.tbSectionDesction.Text = this.article.getBody()+"...";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.DetermineFactory(); // check what factory is selected
            if(this.factory != null) // if not null
            {
                this.article = factory.CreateFeaturedArticle();
                this.artsist = factory.CreateFeaturedArtist();
                this.artwork = factory.CreateFeaturedArtwork();
            }
            this.UpdateArtworkViews(at: this.artsist, aw: this.artwork, ac: this.article);
        }

        private void btnSaveArtwork_Click(object sender, EventArgs e)
        {
            // add artwork link to the dropdown
            if(this.artwork != null)
            {
                if (!this.savedArtUrls.Contains(this.artwork.getDescription() + ": " + this.artwork.getPictureUrl()))
                {
                    this.savedArtUrls.Add(this.artwork.getDescription() + ": " + this.artwork.getPictureUrl());
                    this.toolStripStatusLabel1.Text+="*";
                }
            }
        }

        // does not need to redetermine...
        private void cmbxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // needs not to redetermine 
        }

        /// <summary>
        /// When clicked to show the saved items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showSavedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string messageText = "Saved Artworks:\n";
            foreach(String fa in this.savedArtUrls)
            {
                messageText += "> "+ fa + "\n";
            }
            MessageBox.Show(messageText, "Your favorites");
        }

        private void btnChangeArtist_Click(object sender, EventArgs e)
        {
            this.UpdateArtworkViews(at: this.factory.CreateFeaturedArtist());
        }

        private void btnReadMore_Click(object sender, EventArgs e)
        {
            if(this.article != null)
            {
                MessageBox.Show("See more via the link here:\n" + this.article.getMoreUrl(), "Read More");
            }
        }
    }
}
