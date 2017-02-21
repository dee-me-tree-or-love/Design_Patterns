namespace ObserverPatternAssignment
{
    partial class HAL9K
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKillHal = new System.Windows.Forms.Button();
            this.tbHalsWords = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStopObserving = new System.Windows.Forms.Button();
            this.btnStartObserving = new System.Windows.Forms.Button();
            this.lbReadings = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKillHal);
            this.panel1.Controls.Add(this.tbHalsWords);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 30);
            this.panel1.TabIndex = 0;
            // 
            // btnKillHal
            // 
            this.btnKillHal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKillHal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKillHal.Location = new System.Drawing.Point(229, 0);
            this.btnKillHal.Name = "btnKillHal";
            this.btnKillHal.Size = new System.Drawing.Size(55, 30);
            this.btnKillHal.TabIndex = 1;
            this.btnKillHal.Text = "kill";
            this.btnKillHal.UseVisualStyleBackColor = true;
            this.btnKillHal.Click += new System.EventHandler(this.btnKillHal_Click);
            // 
            // tbHalsWords
            // 
            this.tbHalsWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHalsWords.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbHalsWords.Location = new System.Drawing.Point(0, 0);
            this.tbHalsWords.Multiline = true;
            this.tbHalsWords.Name = "tbHalsWords";
            this.tbHalsWords.ReadOnly = true;
            this.tbHalsWords.Size = new System.Drawing.Size(194, 30);
            this.tbHalsWords.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnStopObserving);
            this.panel3.Controls.Add(this.btnStartObserving);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 30);
            this.panel3.TabIndex = 2;
            // 
            // btnStopObserving
            // 
            this.btnStopObserving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopObserving.Location = new System.Drawing.Point(181, 3);
            this.btnStopObserving.Name = "btnStopObserving";
            this.btnStopObserving.Size = new System.Drawing.Size(100, 23);
            this.btnStopObserving.TabIndex = 1;
            this.btnStopObserving.Text = "Stop Observing";
            this.btnStopObserving.UseVisualStyleBackColor = true;
            this.btnStopObserving.Click += new System.EventHandler(this.btnStopObserving_Click);
            // 
            // btnStartObserving
            // 
            this.btnStartObserving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartObserving.Location = new System.Drawing.Point(3, 3);
            this.btnStartObserving.Name = "btnStartObserving";
            this.btnStartObserving.Size = new System.Drawing.Size(100, 23);
            this.btnStartObserving.TabIndex = 0;
            this.btnStartObserving.Text = "Observe";
            this.btnStartObserving.UseVisualStyleBackColor = true;
            this.btnStartObserving.Click += new System.EventHandler(this.btnStartObserving_Click);
            // 
            // lbReadings
            // 
            this.lbReadings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbReadings.FormattingEnabled = true;
            this.lbReadings.HorizontalScrollbar = true;
            this.lbReadings.Location = new System.Drawing.Point(0, 277);
            this.lbReadings.Name = "lbReadings";
            this.lbReadings.Size = new System.Drawing.Size(284, 108);
            this.lbReadings.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ObserverPatternAssignment.Properties.Resources.HAL9k;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 217);
            this.panel2.TabIndex = 1;
            // 
            // HAL9K
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 385);
            this.Controls.Add(this.lbReadings);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(450, 100);
            this.Name = "HAL9K";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HAL 9000";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HAL9K_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lbReadings;
        private System.Windows.Forms.Button btnKillHal;
        private System.Windows.Forms.TextBox tbHalsWords;
        private System.Windows.Forms.Button btnStopObserving;
        private System.Windows.Forms.Button btnStartObserving;
    }
}