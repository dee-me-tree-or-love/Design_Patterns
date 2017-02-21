namespace ObserverPatternAssignment
{
    partial class PHA
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
            this.pbBPM = new System.Windows.Forms.ProgressBar();
            this.pbBPRESsys = new System.Windows.Forms.ProgressBar();
            this.pbBSUG = new System.Windows.Forms.ProgressBar();
            this.pbTEMP = new System.Windows.Forms.ProgressBar();
            this.pbOX = new System.Windows.Forms.ProgressBar();
            this.pbBPRESdys = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStartObserving = new System.Windows.Forms.Button();
            this.btnStopObserving = new System.Windows.Forms.Button();
            this.lblConnectionInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ObserverPatternAssignment.Properties.Resources.Nasa;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(397, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 208);
            this.panel1.TabIndex = 0;
            // 
            // pbBPM
            // 
            this.pbBPM.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.pbBPM.Location = new System.Drawing.Point(68, 20);
            this.pbBPM.Maximum = 250;
            this.pbBPM.Name = "pbBPM";
            this.pbBPM.Size = new System.Drawing.Size(311, 23);
            this.pbBPM.TabIndex = 1;
            // 
            // pbBPRESsys
            // 
            this.pbBPRESsys.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.pbBPRESsys.Location = new System.Drawing.Point(106, 49);
            this.pbBPRESsys.Maximum = 250;
            this.pbBPRESsys.Name = "pbBPRESsys";
            this.pbBPRESsys.Size = new System.Drawing.Size(100, 23);
            this.pbBPRESsys.TabIndex = 2;
            // 
            // pbBSUG
            // 
            this.pbBSUG.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.pbBSUG.Location = new System.Drawing.Point(68, 78);
            this.pbBSUG.Maximum = 300;
            this.pbBSUG.Name = "pbBSUG";
            this.pbBSUG.Size = new System.Drawing.Size(311, 23);
            this.pbBSUG.TabIndex = 3;
            // 
            // pbTEMP
            // 
            this.pbTEMP.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.pbTEMP.Location = new System.Drawing.Point(68, 107);
            this.pbTEMP.Maximum = 42;
            this.pbTEMP.Name = "pbTEMP";
            this.pbTEMP.Size = new System.Drawing.Size(311, 23);
            this.pbTEMP.TabIndex = 4;
            // 
            // pbOX
            // 
            this.pbOX.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.pbOX.Location = new System.Drawing.Point(68, 136);
            this.pbOX.Name = "pbOX";
            this.pbOX.Size = new System.Drawing.Size(311, 23);
            this.pbOX.TabIndex = 5;
            // 
            // pbBPRESdys
            // 
            this.pbBPRESdys.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.pbBPRESdys.Location = new System.Drawing.Point(279, 49);
            this.pbBPRESdys.Maximum = 180;
            this.pbBPRESdys.Name = "pbBPRESdys";
            this.pbBPRESdys.Size = new System.Drawing.Size(100, 23);
            this.pbBPRESdys.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "BPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "BPRES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "BSUG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "TEMP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "OX.LEV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "sys";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "dys";
            // 
            // btnStartObserving
            // 
            this.btnStartObserving.Location = new System.Drawing.Point(10, 173);
            this.btnStartObserving.Name = "btnStartObserving";
            this.btnStartObserving.Size = new System.Drawing.Size(100, 23);
            this.btnStartObserving.TabIndex = 14;
            this.btnStartObserving.Text = "Start Connection";
            this.btnStartObserving.UseVisualStyleBackColor = true;
            this.btnStartObserving.Click += new System.EventHandler(this.btnStartObserving_Click);
            // 
            // btnStopObserving
            // 
            this.btnStopObserving.Location = new System.Drawing.Point(279, 173);
            this.btnStopObserving.Name = "btnStopObserving";
            this.btnStopObserving.Size = new System.Drawing.Size(100, 23);
            this.btnStopObserving.TabIndex = 15;
            this.btnStopObserving.Text = "Stop Connection";
            this.btnStopObserving.UseVisualStyleBackColor = true;
            this.btnStopObserving.Click += new System.EventHandler(this.btnStopObserving_Click);
            // 
            // lblConnectionInfo
            // 
            this.lblConnectionInfo.AutoSize = true;
            this.lblConnectionInfo.Location = new System.Drawing.Point(155, 178);
            this.lblConnectionInfo.Name = "lblConnectionInfo";
            this.lblConnectionInfo.Size = new System.Drawing.Size(88, 13);
            this.lblConnectionInfo.TabIndex = 16;
            this.lblConnectionInfo.Text = "Not Connected...";
            // 
            // PHA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 208);
            this.Controls.Add(this.lblConnectionInfo);
            this.Controls.Add(this.btnStopObserving);
            this.Controls.Add(this.btnStartObserving);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBPRESdys);
            this.Controls.Add(this.pbOX);
            this.Controls.Add(this.pbTEMP);
            this.Controls.Add(this.pbBSUG);
            this.Controls.Add(this.pbBPRESsys);
            this.Controls.Add(this.pbBPM);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(170, 550);
            this.Name = "PHA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Personal Health Advisor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PHA_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar pbBPM;
        private System.Windows.Forms.ProgressBar pbBPRESsys;
        private System.Windows.Forms.ProgressBar pbBSUG;
        private System.Windows.Forms.ProgressBar pbTEMP;
        private System.Windows.Forms.ProgressBar pbOX;
        private System.Windows.Forms.ProgressBar pbBPRESdys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStartObserving;
        private System.Windows.Forms.Button btnStopObserving;
        private System.Windows.Forms.Label lblConnectionInfo;
    }
}