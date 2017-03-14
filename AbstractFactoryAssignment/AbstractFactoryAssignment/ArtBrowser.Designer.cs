namespace AbstractFactoryAssignment
{
    partial class ArtBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtBrowser));
            this.controlPane = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblSection = new System.Windows.Forms.Label();
            this.cmbxSection = new System.Windows.Forms.ComboBox();
            this.ViewPane = new System.Windows.Forms.Panel();
            this.btnSaveArtwork = new System.Windows.Forms.Button();
            this.tbArtistHeading = new System.Windows.Forms.TextBox();
            this.btnReadMore = new System.Windows.Forms.Button();
            this.tbSectionDesction = new System.Windows.Forms.TextBox();
            this.tbSectionHeading = new System.Windows.Forms.TextBox();
            this.btnChangeArtist = new System.Windows.Forms.Button();
            this.tbArtistDescription = new System.Windows.Forms.TextBox();
            this.tbFeaturedArtDesciption = new System.Windows.Forms.TextBox();
            this.pbArtist = new System.Windows.Forms.PictureBox();
            this.pbFeaturedArt = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownBtnSavedImages = new System.Windows.Forms.ToolStripDropDownButton();
            this.showSavedListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.controlPane.SuspendLayout();
            this.ViewPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeaturedArt)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPane
            // 
            this.controlPane.BackColor = System.Drawing.Color.LightGray;
            this.controlPane.Controls.Add(this.btnGo);
            this.controlPane.Controls.Add(this.lblSection);
            this.controlPane.Controls.Add(this.cmbxSection);
            this.controlPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPane.Location = new System.Drawing.Point(0, 0);
            this.controlPane.Name = "controlPane";
            this.controlPane.Size = new System.Drawing.Size(796, 36);
            this.controlPane.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGo.Location = new System.Drawing.Point(709, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(84, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSection.Location = new System.Drawing.Point(12, 9);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(56, 15);
            this.lblSection.TabIndex = 1;
            this.lblSection.Text = "Section: ";
            // 
            // cmbxSection
            // 
            this.cmbxSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxSection.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbxSection.FormattingEnabled = true;
            this.cmbxSection.Location = new System.Drawing.Point(82, 5);
            this.cmbxSection.Name = "cmbxSection";
            this.cmbxSection.Size = new System.Drawing.Size(621, 23);
            this.cmbxSection.TabIndex = 0;
            // 
            // ViewPane
            // 
            this.ViewPane.Controls.Add(this.btnSaveArtwork);
            this.ViewPane.Controls.Add(this.tbArtistHeading);
            this.ViewPane.Controls.Add(this.btnReadMore);
            this.ViewPane.Controls.Add(this.tbSectionDesction);
            this.ViewPane.Controls.Add(this.tbSectionHeading);
            this.ViewPane.Controls.Add(this.btnChangeArtist);
            this.ViewPane.Controls.Add(this.tbArtistDescription);
            this.ViewPane.Controls.Add(this.tbFeaturedArtDesciption);
            this.ViewPane.Controls.Add(this.pbArtist);
            this.ViewPane.Controls.Add(this.pbFeaturedArt);
            this.ViewPane.Controls.Add(this.statusStrip1);
            this.ViewPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPane.Location = new System.Drawing.Point(0, 36);
            this.ViewPane.Name = "ViewPane";
            this.ViewPane.Size = new System.Drawing.Size(796, 509);
            this.ViewPane.TabIndex = 2;
            // 
            // btnSaveArtwork
            // 
            this.btnSaveArtwork.FlatAppearance.BorderSize = 0;
            this.btnSaveArtwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveArtwork.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveArtwork.Location = new System.Drawing.Point(0, 461);
            this.btnSaveArtwork.Name = "btnSaveArtwork";
            this.btnSaveArtwork.Size = new System.Drawing.Size(331, 23);
            this.btnSaveArtwork.TabIndex = 12;
            this.btnSaveArtwork.Text = "Save";
            this.btnSaveArtwork.UseVisualStyleBackColor = true;
            this.btnSaveArtwork.Click += new System.EventHandler(this.btnSaveArtwork_Click);
            // 
            // tbArtistHeading
            // 
            this.tbArtistHeading.BackColor = System.Drawing.Color.White;
            this.tbArtistHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArtistHeading.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbArtistHeading.Location = new System.Drawing.Point(343, 178);
            this.tbArtistHeading.Multiline = true;
            this.tbArtistHeading.Name = "tbArtistHeading";
            this.tbArtistHeading.ReadOnly = true;
            this.tbArtistHeading.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbArtistHeading.Size = new System.Drawing.Size(450, 55);
            this.tbArtistHeading.TabIndex = 11;
            // 
            // btnReadMore
            // 
            this.btnReadMore.FlatAppearance.BorderSize = 0;
            this.btnReadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadMore.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReadMore.Location = new System.Drawing.Point(597, 145);
            this.btnReadMore.Name = "btnReadMore";
            this.btnReadMore.Size = new System.Drawing.Size(196, 23);
            this.btnReadMore.TabIndex = 10;
            this.btnReadMore.Text = "Read More...";
            this.btnReadMore.UseVisualStyleBackColor = true;
            this.btnReadMore.Click += new System.EventHandler(this.btnReadMore_Click);
            // 
            // tbSectionDesction
            // 
            this.tbSectionDesction.BackColor = System.Drawing.Color.White;
            this.tbSectionDesction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSectionDesction.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSectionDesction.Location = new System.Drawing.Point(343, 56);
            this.tbSectionDesction.Multiline = true;
            this.tbSectionDesction.Name = "tbSectionDesction";
            this.tbSectionDesction.ReadOnly = true;
            this.tbSectionDesction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSectionDesction.Size = new System.Drawing.Size(450, 83);
            this.tbSectionDesction.TabIndex = 9;
            // 
            // tbSectionHeading
            // 
            this.tbSectionHeading.BackColor = System.Drawing.Color.White;
            this.tbSectionHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSectionHeading.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSectionHeading.Location = new System.Drawing.Point(343, 6);
            this.tbSectionHeading.Multiline = true;
            this.tbSectionHeading.Name = "tbSectionHeading";
            this.tbSectionHeading.ReadOnly = true;
            this.tbSectionHeading.Size = new System.Drawing.Size(450, 44);
            this.tbSectionHeading.TabIndex = 8;
            // 
            // btnChangeArtist
            // 
            this.btnChangeArtist.FlatAppearance.BorderSize = 0;
            this.btnChangeArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeArtist.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeArtist.Location = new System.Drawing.Point(343, 461);
            this.btnChangeArtist.Name = "btnChangeArtist";
            this.btnChangeArtist.Size = new System.Drawing.Size(248, 23);
            this.btnChangeArtist.TabIndex = 7;
            this.btnChangeArtist.Text = "Random Artist";
            this.btnChangeArtist.UseVisualStyleBackColor = true;
            this.btnChangeArtist.Click += new System.EventHandler(this.btnChangeArtist_Click);
            // 
            // tbArtistDescription
            // 
            this.tbArtistDescription.BackColor = System.Drawing.Color.White;
            this.tbArtistDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArtistDescription.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbArtistDescription.Location = new System.Drawing.Point(343, 239);
            this.tbArtistDescription.Multiline = true;
            this.tbArtistDescription.Name = "tbArtistDescription";
            this.tbArtistDescription.ReadOnly = true;
            this.tbArtistDescription.Size = new System.Drawing.Size(248, 206);
            this.tbArtistDescription.TabIndex = 6;
            // 
            // tbFeaturedArtDesciption
            // 
            this.tbFeaturedArtDesciption.BackColor = System.Drawing.Color.White;
            this.tbFeaturedArtDesciption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFeaturedArtDesciption.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFeaturedArtDesciption.Location = new System.Drawing.Point(3, 334);
            this.tbFeaturedArtDesciption.Multiline = true;
            this.tbFeaturedArtDesciption.Name = "tbFeaturedArtDesciption";
            this.tbFeaturedArtDesciption.ReadOnly = true;
            this.tbFeaturedArtDesciption.Size = new System.Drawing.Size(331, 78);
            this.tbFeaturedArtDesciption.TabIndex = 5;
            // 
            // pbArtist
            // 
            this.pbArtist.Location = new System.Drawing.Point(597, 239);
            this.pbArtist.Name = "pbArtist";
            this.pbArtist.Size = new System.Drawing.Size(196, 245);
            this.pbArtist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArtist.TabIndex = 4;
            this.pbArtist.TabStop = false;
            // 
            // pbFeaturedArt
            // 
            this.pbFeaturedArt.Location = new System.Drawing.Point(3, 6);
            this.pbFeaturedArt.Name = "pbFeaturedArt";
            this.pbFeaturedArt.Size = new System.Drawing.Size(331, 322);
            this.pbFeaturedArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFeaturedArt.TabIndex = 3;
            this.pbFeaturedArt.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownBtnSavedImages});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(796, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel1.Text = "Saved Artworks:";
            // 
            // toolStripDropDownBtnSavedImages
            // 
            this.toolStripDropDownBtnSavedImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownBtnSavedImages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSavedListToolStripMenuItem});
            this.toolStripDropDownBtnSavedImages.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownBtnSavedImages.Image")));
            this.toolStripDropDownBtnSavedImages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownBtnSavedImages.Name = "toolStripDropDownBtnSavedImages";
            this.toolStripDropDownBtnSavedImages.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownBtnSavedImages.Text = "toolStripDropDownButton1";
            // 
            // showSavedListToolStripMenuItem
            // 
            this.showSavedListToolStripMenuItem.Name = "showSavedListToolStripMenuItem";
            this.showSavedListToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.showSavedListToolStripMenuItem.Text = "Show saved list";
            this.showSavedListToolStripMenuItem.Click += new System.EventHandler(this.showSavedListToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ArtBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 545);
            this.Controls.Add(this.ViewPane);
            this.Controls.Add(this.controlPane);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ArtBrowser";
            this.RightToLeftLayout = true;
            this.Text = "@ Art Factory";
            this.controlPane.ResumeLayout(false);
            this.controlPane.PerformLayout();
            this.ViewPane.ResumeLayout(false);
            this.ViewPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeaturedArt)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPane;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cmbxSection;
        private System.Windows.Forms.Panel ViewPane;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox tbSectionHeading;
        private System.Windows.Forms.Button btnChangeArtist;
        private System.Windows.Forms.TextBox tbArtistDescription;
        private System.Windows.Forms.TextBox tbFeaturedArtDesciption;
        private System.Windows.Forms.PictureBox pbArtist;
        private System.Windows.Forms.PictureBox pbFeaturedArt;
        private System.Windows.Forms.TextBox tbArtistHeading;
        private System.Windows.Forms.Button btnReadMore;
        private System.Windows.Forms.TextBox tbSectionDesction;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSaveArtwork;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownBtnSavedImages;
        private System.Windows.Forms.ToolStripMenuItem showSavedListToolStripMenuItem;
    }
}

