namespace CommandPatternAssignment
{
    partial class Form1
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
            this.pbConductor = new System.Windows.Forms.PictureBox();
            this.btnSingB = new System.Windows.Forms.Button();
            this.btnSingA = new System.Windows.Forms.Button();
            this.btnSingC = new System.Windows.Forms.Button();
            this.pbFirstSinger = new System.Windows.Forms.PictureBox();
            this.pbSecondSInger = new System.Windows.Forms.PictureBox();
            this.pbThirdSinger = new System.Windows.Forms.PictureBox();
            this.tbSongText = new System.Windows.Forms.TextBox();
            this.cbRecordSong = new System.Windows.Forms.CheckBox();
            this.btnPlayRecordedSong = new System.Windows.Forms.Button();
            this.tmrSingerInvalidator = new System.Windows.Forms.Timer(this.components);
            this.btnChangeTrio = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbConductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstSinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondSInger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThirdSinger)).BeginInit();
            this.SuspendLayout();
            // 
            // pbConductor
            // 
            this.pbConductor.BackgroundImage = global::CommandPatternAssignment.Properties.Resources.conductor;
            this.pbConductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbConductor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbConductor.Location = new System.Drawing.Point(0, 0);
            this.pbConductor.Name = "pbConductor";
            this.pbConductor.Size = new System.Drawing.Size(978, 169);
            this.pbConductor.TabIndex = 0;
            this.pbConductor.TabStop = false;
            // 
            // btnSingB
            // 
            this.btnSingB.Location = new System.Drawing.Point(130, 175);
            this.btnSingB.Name = "btnSingB";
            this.btnSingB.Size = new System.Drawing.Size(75, 23);
            this.btnSingB.TabIndex = 1;
            this.btnSingB.Text = "Sing Middle";
            this.btnSingB.UseVisualStyleBackColor = true;
            this.btnSingB.Click += new System.EventHandler(this.btnSingB_Click);
            // 
            // btnSingA
            // 
            this.btnSingA.Location = new System.Drawing.Point(12, 175);
            this.btnSingA.Name = "btnSingA";
            this.btnSingA.Size = new System.Drawing.Size(75, 23);
            this.btnSingA.TabIndex = 2;
            this.btnSingA.Text = "Sing Left";
            this.btnSingA.UseVisualStyleBackColor = true;
            this.btnSingA.Click += new System.EventHandler(this.btnSingA_Click);
            // 
            // btnSingC
            // 
            this.btnSingC.Location = new System.Drawing.Point(239, 175);
            this.btnSingC.Name = "btnSingC";
            this.btnSingC.Size = new System.Drawing.Size(75, 23);
            this.btnSingC.TabIndex = 3;
            this.btnSingC.Text = "Sing Right";
            this.btnSingC.UseVisualStyleBackColor = true;
            this.btnSingC.Click += new System.EventHandler(this.btnSingC_Click);
            // 
            // pbFirstSinger
            // 
            this.pbFirstSinger.BackgroundImage = global::CommandPatternAssignment.Properties.Resources.silent1;
            this.pbFirstSinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFirstSinger.Location = new System.Drawing.Point(12, 269);
            this.pbFirstSinger.Name = "pbFirstSinger";
            this.pbFirstSinger.Size = new System.Drawing.Size(315, 328);
            this.pbFirstSinger.TabIndex = 4;
            this.pbFirstSinger.TabStop = false;
            // 
            // pbSecondSInger
            // 
            this.pbSecondSInger.BackgroundImage = global::CommandPatternAssignment.Properties.Resources.silent2;
            this.pbSecondSInger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSecondSInger.Location = new System.Drawing.Point(333, 269);
            this.pbSecondSInger.Name = "pbSecondSInger";
            this.pbSecondSInger.Size = new System.Drawing.Size(315, 328);
            this.pbSecondSInger.TabIndex = 5;
            this.pbSecondSInger.TabStop = false;
            // 
            // pbThirdSinger
            // 
            this.pbThirdSinger.BackgroundImage = global::CommandPatternAssignment.Properties.Resources.silent3;
            this.pbThirdSinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbThirdSinger.Location = new System.Drawing.Point(654, 269);
            this.pbThirdSinger.Name = "pbThirdSinger";
            this.pbThirdSinger.Size = new System.Drawing.Size(315, 328);
            this.pbThirdSinger.TabIndex = 6;
            this.pbThirdSinger.TabStop = false;
            // 
            // tbSongText
            // 
            this.tbSongText.Location = new System.Drawing.Point(333, 175);
            this.tbSongText.Multiline = true;
            this.tbSongText.Name = "tbSongText";
            this.tbSongText.Size = new System.Drawing.Size(636, 80);
            this.tbSongText.TabIndex = 7;
            // 
            // cbRecordSong
            // 
            this.cbRecordSong.AutoSize = true;
            this.cbRecordSong.Location = new System.Drawing.Point(12, 207);
            this.cbRecordSong.Name = "cbRecordSong";
            this.cbRecordSong.Size = new System.Drawing.Size(113, 17);
            this.cbRecordSong.TabIndex = 8;
            this.cbRecordSong.Text = "Add to the Record";
            this.cbRecordSong.UseVisualStyleBackColor = true;
            // 
            // btnPlayRecordedSong
            // 
            this.btnPlayRecordedSong.Location = new System.Drawing.Point(130, 203);
            this.btnPlayRecordedSong.Name = "btnPlayRecordedSong";
            this.btnPlayRecordedSong.Size = new System.Drawing.Size(184, 23);
            this.btnPlayRecordedSong.TabIndex = 9;
            this.btnPlayRecordedSong.Text = "Play Recorded Song";
            this.btnPlayRecordedSong.UseVisualStyleBackColor = true;
            this.btnPlayRecordedSong.Click += new System.EventHandler(this.btnPlayRecordedSong_Click);
            // 
            // tmrSingerInvalidator
            // 
            this.tmrSingerInvalidator.Interval = 1000;
            this.tmrSingerInvalidator.Tick += new System.EventHandler(this.tmrSingerInvalidator_Tick);
            // 
            // btnChangeTrio
            // 
            this.btnChangeTrio.Location = new System.Drawing.Point(12, 232);
            this.btnChangeTrio.Name = "btnChangeTrio";
            this.btnChangeTrio.Size = new System.Drawing.Size(112, 23);
            this.btnChangeTrio.TabIndex = 10;
            this.btnChangeTrio.Text = "Change Trio";
            this.btnChangeTrio.UseVisualStyleBackColor = true;
            this.btnChangeTrio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(130, 232);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(184, 23);
            this.btnClearHistory.TabIndex = 11;
            this.btnClearHistory.Text = "Clear Record";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 599);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.btnChangeTrio);
            this.Controls.Add(this.btnPlayRecordedSong);
            this.Controls.Add(this.cbRecordSong);
            this.Controls.Add(this.tbSongText);
            this.Controls.Add(this.pbThirdSinger);
            this.Controls.Add(this.pbSecondSInger);
            this.Controls.Add(this.pbFirstSinger);
            this.Controls.Add(this.btnSingC);
            this.Controls.Add(this.btnSingA);
            this.Controls.Add(this.btnSingB);
            this.Controls.Add(this.pbConductor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Orchestra Commander";
            ((System.ComponentModel.ISupportInitialize)(this.pbConductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstSinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondSInger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThirdSinger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbConductor;
        private System.Windows.Forms.Button btnSingB;
        private System.Windows.Forms.Button btnSingA;
        private System.Windows.Forms.Button btnSingC;
        private System.Windows.Forms.PictureBox pbFirstSinger;
        private System.Windows.Forms.PictureBox pbSecondSInger;
        private System.Windows.Forms.PictureBox pbThirdSinger;
        private System.Windows.Forms.TextBox tbSongText;
        private System.Windows.Forms.CheckBox cbRecordSong;
        private System.Windows.Forms.Button btnPlayRecordedSong;
        private System.Windows.Forms.Timer tmrSingerInvalidator;
        private System.Windows.Forms.Button btnChangeTrio;
        private System.Windows.Forms.Button btnClearHistory;
    }
}

