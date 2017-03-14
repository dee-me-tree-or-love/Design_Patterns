namespace DecoratorPatternAssignment
{
    partial class Apper
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
            this.cmbPatternsToAdd = new System.Windows.Forms.ComboBox();
            this.tbAppName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbGeneratedDesctiption = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeploy = new System.Windows.Forms.Button();
            this.tbComplexityScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbWeb = new System.Windows.Forms.RadioButton();
            this.rbDesktop = new System.Windows.Forms.RadioButton();
            this.rbEmbedded = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPatternsToAdd
            // 
            this.cmbPatternsToAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPatternsToAdd.FormattingEnabled = true;
            this.cmbPatternsToAdd.Location = new System.Drawing.Point(12, 112);
            this.cmbPatternsToAdd.Name = "cmbPatternsToAdd";
            this.cmbPatternsToAdd.Size = new System.Drawing.Size(221, 21);
            this.cmbPatternsToAdd.TabIndex = 0;
            // 
            // tbAppName
            // 
            this.tbAppName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAppName.Location = new System.Drawing.Point(12, 29);
            this.tbAppName.Name = "tbAppName";
            this.tbAppName.Size = new System.Drawing.Size(309, 20);
            this.tbAppName.TabIndex = 1;
            this.tbAppName.TextChanged += new System.EventHandler(this.tbAppName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Application Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Patterns To Add";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(246, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGeneratedDesctiption
            // 
            this.tbGeneratedDesctiption.Location = new System.Drawing.Point(12, 200);
            this.tbGeneratedDesctiption.Multiline = true;
            this.tbGeneratedDesctiption.Name = "tbGeneratedDesctiption";
            this.tbGeneratedDesctiption.ReadOnly = true;
            this.tbGeneratedDesctiption.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGeneratedDesctiption.Size = new System.Drawing.Size(309, 102);
            this.tbGeneratedDesctiption.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Generated Description";
            // 
            // btnDeploy
            // 
            this.btnDeploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeploy.Location = new System.Drawing.Point(12, 322);
            this.btnDeploy.Name = "btnDeploy";
            this.btnDeploy.Size = new System.Drawing.Size(309, 31);
            this.btnDeploy.TabIndex = 7;
            this.btnDeploy.Text = "Deploy Application";
            this.btnDeploy.UseVisualStyleBackColor = true;
            this.btnDeploy.Click += new System.EventHandler(this.btnDeploy_Click);
            // 
            // tbComplexityScore
            // 
            this.tbComplexityScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbComplexityScore.Location = new System.Drawing.Point(136, 152);
            this.tbComplexityScore.Name = "tbComplexityScore";
            this.tbComplexityScore.ReadOnly = true;
            this.tbComplexityScore.Size = new System.Drawing.Size(185, 20);
            this.tbComplexityScore.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Complexity Score";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DecoratorPatternAssignment.Properties.Resources.basic_keyboard;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(115, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 85);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // rbWeb
            // 
            this.rbWeb.AutoSize = true;
            this.rbWeb.Location = new System.Drawing.Point(70, 55);
            this.rbWeb.Name = "rbWeb";
            this.rbWeb.Size = new System.Drawing.Size(48, 17);
            this.rbWeb.TabIndex = 11;
            this.rbWeb.TabStop = true;
            this.rbWeb.Text = "Web";
            this.rbWeb.UseVisualStyleBackColor = true;
            this.rbWeb.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbDesktop
            // 
            this.rbDesktop.AutoSize = true;
            this.rbDesktop.Location = new System.Drawing.Point(124, 55);
            this.rbDesktop.Name = "rbDesktop";
            this.rbDesktop.Size = new System.Drawing.Size(65, 17);
            this.rbDesktop.TabIndex = 12;
            this.rbDesktop.TabStop = true;
            this.rbDesktop.Text = "Desktop";
            this.rbDesktop.UseVisualStyleBackColor = true;
            this.rbDesktop.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbEmbedded
            // 
            this.rbEmbedded.AutoSize = true;
            this.rbEmbedded.Location = new System.Drawing.Point(195, 55);
            this.rbEmbedded.Name = "rbEmbedded";
            this.rbEmbedded.Size = new System.Drawing.Size(76, 17);
            this.rbEmbedded.TabIndex = 13;
            this.rbEmbedded.TabStop = true;
            this.rbEmbedded.Text = "Embedded";
            this.rbEmbedded.UseVisualStyleBackColor = true;
            this.rbEmbedded.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // Apper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 472);
            this.Controls.Add(this.rbEmbedded);
            this.Controls.Add(this.rbDesktop);
            this.Controls.Add(this.rbWeb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbComplexityScore);
            this.Controls.Add(this.btnDeploy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGeneratedDesctiption);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAppName);
            this.Controls.Add(this.cmbPatternsToAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Apper";
            this.Text = "Apper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPatternsToAdd;
        private System.Windows.Forms.TextBox tbAppName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbGeneratedDesctiption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeploy;
        private System.Windows.Forms.TextBox tbComplexityScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbWeb;
        private System.Windows.Forms.RadioButton rbDesktop;
        private System.Windows.Forms.RadioButton rbEmbedded;
    }
}

