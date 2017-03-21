namespace VisitorPatternAssignment
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
            this.panelGame = new System.Windows.Forms.Panel();
            this.btnStartAdventure = new System.Windows.Forms.Button();
            this.cmbxComplexity = new System.Windows.Forms.ComboBox();
            this.lblMapComplexity = new System.Windows.Forms.Label();
            this.rdbtnAdventerType = new System.Windows.Forms.RadioButton();
            this.pControl = new System.Windows.Forms.Panel();
            this.btnNextRoom = new System.Windows.Forms.Button();
            this.cmbxNextRoom = new System.Windows.Forms.ComboBox();
            this.lblNextRoom = new System.Windows.Forms.Label();
            this.pnlTransControl = new System.Windows.Forms.Panel();
            this.tbImpression = new System.Windows.Forms.TextBox();
            this.rdbtnExplorerType = new System.Windows.Forms.RadioButton();
            this.lbAdventureStatus = new System.Windows.Forms.ListBox();
            this.panelGame.SuspendLayout();
            this.pControl.SuspendLayout();
            this.pnlTransControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.lbAdventureStatus);
            this.panelGame.Controls.Add(this.pControl);
            this.panelGame.Controls.Add(this.tbImpression);
            this.panelGame.Controls.Add(this.pnlTransControl);
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(339, 412);
            this.panelGame.TabIndex = 1;
            // 
            // btnStartAdventure
            // 
            this.btnStartAdventure.Location = new System.Drawing.Point(227, 3);
            this.btnStartAdventure.Name = "btnStartAdventure";
            this.btnStartAdventure.Size = new System.Drawing.Size(103, 50);
            this.btnStartAdventure.TabIndex = 0;
            this.btnStartAdventure.Text = "Start Adventure";
            this.btnStartAdventure.UseVisualStyleBackColor = true;
            this.btnStartAdventure.Click += new System.EventHandler(this.btnStartAdventure_Click);
            // 
            // cmbxComplexity
            // 
            this.cmbxComplexity.FormattingEnabled = true;
            this.cmbxComplexity.Location = new System.Drawing.Point(100, 32);
            this.cmbxComplexity.Name = "cmbxComplexity";
            this.cmbxComplexity.Size = new System.Drawing.Size(121, 21);
            this.cmbxComplexity.TabIndex = 1;
            // 
            // lblMapComplexity
            // 
            this.lblMapComplexity.AutoSize = true;
            this.lblMapComplexity.Location = new System.Drawing.Point(12, 35);
            this.lblMapComplexity.Name = "lblMapComplexity";
            this.lblMapComplexity.Size = new System.Drawing.Size(81, 13);
            this.lblMapComplexity.TabIndex = 4;
            this.lblMapComplexity.Text = "Map Complexity";
            // 
            // rdbtnAdventerType
            // 
            this.rdbtnAdventerType.AutoSize = true;
            this.rdbtnAdventerType.Checked = true;
            this.rdbtnAdventerType.Location = new System.Drawing.Point(15, 7);
            this.rdbtnAdventerType.Name = "rdbtnAdventerType";
            this.rdbtnAdventerType.Size = new System.Drawing.Size(77, 17);
            this.rdbtnAdventerType.TabIndex = 5;
            this.rdbtnAdventerType.Text = "Adventurer";
            this.rdbtnAdventerType.UseVisualStyleBackColor = true;
            // 
            // pControl
            // 
            this.pControl.BackColor = System.Drawing.Color.Azure;
            this.pControl.Controls.Add(this.rdbtnExplorerType);
            this.pControl.Controls.Add(this.rdbtnAdventerType);
            this.pControl.Controls.Add(this.lblMapComplexity);
            this.pControl.Controls.Add(this.cmbxComplexity);
            this.pControl.Controls.Add(this.btnStartAdventure);
            this.pControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControl.Location = new System.Drawing.Point(0, 0);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(339, 59);
            this.pControl.TabIndex = 4;
            // 
            // btnNextRoom
            // 
            this.btnNextRoom.Location = new System.Drawing.Point(255, 5);
            this.btnNextRoom.Name = "btnNextRoom";
            this.btnNextRoom.Size = new System.Drawing.Size(75, 23);
            this.btnNextRoom.TabIndex = 0;
            this.btnNextRoom.Text = "Go!";
            this.btnNextRoom.UseVisualStyleBackColor = true;
            this.btnNextRoom.Click += new System.EventHandler(this.btnNextRoom_Click);
            // 
            // cmbxNextRoom
            // 
            this.cmbxNextRoom.FormattingEnabled = true;
            this.cmbxNextRoom.Location = new System.Drawing.Point(128, 6);
            this.cmbxNextRoom.Name = "cmbxNextRoom";
            this.cmbxNextRoom.Size = new System.Drawing.Size(121, 21);
            this.cmbxNextRoom.TabIndex = 1;
            // 
            // lblNextRoom
            // 
            this.lblNextRoom.AutoSize = true;
            this.lblNextRoom.Location = new System.Drawing.Point(12, 10);
            this.lblNextRoom.Name = "lblNextRoom";
            this.lblNextRoom.Size = new System.Drawing.Size(102, 13);
            this.lblNextRoom.TabIndex = 5;
            this.lblNextRoom.Text = "Choose Next Room:";
            // 
            // pnlTransControl
            // 
            this.pnlTransControl.BackColor = System.Drawing.Color.Azure;
            this.pnlTransControl.Controls.Add(this.lblNextRoom);
            this.pnlTransControl.Controls.Add(this.cmbxNextRoom);
            this.pnlTransControl.Controls.Add(this.btnNextRoom);
            this.pnlTransControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTransControl.Location = new System.Drawing.Point(0, 381);
            this.pnlTransControl.Name = "pnlTransControl";
            this.pnlTransControl.Size = new System.Drawing.Size(339, 31);
            this.pnlTransControl.TabIndex = 1;
            // 
            // tbImpression
            // 
            this.tbImpression.BackColor = System.Drawing.Color.LightYellow;
            this.tbImpression.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbImpression.Location = new System.Drawing.Point(0, 327);
            this.tbImpression.Multiline = true;
            this.tbImpression.Name = "tbImpression";
            this.tbImpression.ReadOnly = true;
            this.tbImpression.Size = new System.Drawing.Size(339, 54);
            this.tbImpression.TabIndex = 2;
            // 
            // rdbtnExplorerType
            // 
            this.rdbtnExplorerType.AutoSize = true;
            this.rdbtnExplorerType.Location = new System.Drawing.Point(128, 7);
            this.rdbtnExplorerType.Name = "rdbtnExplorerType";
            this.rdbtnExplorerType.Size = new System.Drawing.Size(63, 17);
            this.rdbtnExplorerType.TabIndex = 6;
            this.rdbtnExplorerType.Text = "Explorer";
            this.rdbtnExplorerType.UseVisualStyleBackColor = true;
            // 
            // lbAdventureStatus
            // 
            this.lbAdventureStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAdventureStatus.FormattingEnabled = true;
            this.lbAdventureStatus.Location = new System.Drawing.Point(0, 59);
            this.lbAdventureStatus.Name = "lbAdventureStatus";
            this.lbAdventureStatus.Size = new System.Drawing.Size(339, 268);
            this.lbAdventureStatus.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 412);
            this.Controls.Add(this.panelGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Graphgeon";
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.pControl.ResumeLayout(false);
            this.pControl.PerformLayout();
            this.pnlTransControl.ResumeLayout(false);
            this.pnlTransControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.RadioButton rdbtnExplorerType;
        private System.Windows.Forms.RadioButton rdbtnAdventerType;
        private System.Windows.Forms.Label lblMapComplexity;
        private System.Windows.Forms.ComboBox cmbxComplexity;
        private System.Windows.Forms.Button btnStartAdventure;
        private System.Windows.Forms.TextBox tbImpression;
        private System.Windows.Forms.Panel pnlTransControl;
        private System.Windows.Forms.Label lblNextRoom;
        private System.Windows.Forms.ComboBox cmbxNextRoom;
        private System.Windows.Forms.Button btnNextRoom;
        private System.Windows.Forms.ListBox lbAdventureStatus;
    }
}

