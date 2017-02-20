namespace ObserverPatternAssignment
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbTelComStatus = new System.Windows.Forms.TextBox();
            this.btnStartStopTimer = new System.Windows.Forms.Button();
            this.tmrTelCom = new System.Windows.Forms.Timer(this.components);
            this.pbBcst = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBcst)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbTelComStatus);
            this.panel2.Controls.Add(this.btnStartStopTimer);
            this.panel2.Controls.Add(this.pbBcst);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 142);
            this.panel2.TabIndex = 1;
            // 
            // tbTelComStatus
            // 
            this.tbTelComStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbTelComStatus.Location = new System.Drawing.Point(0, 122);
            this.tbTelComStatus.Name = "tbTelComStatus";
            this.tbTelComStatus.ReadOnly = true;
            this.tbTelComStatus.Size = new System.Drawing.Size(200, 20);
            this.tbTelComStatus.TabIndex = 3;
            // 
            // btnStartStopTimer
            // 
            this.btnStartStopTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStopTimer.Location = new System.Drawing.Point(33, 87);
            this.btnStartStopTimer.Name = "btnStartStopTimer";
            this.btnStartStopTimer.Size = new System.Drawing.Size(128, 29);
            this.btnStartStopTimer.TabIndex = 2;
            this.btnStartStopTimer.Text = "Start/Stop Broadcast";
            this.btnStartStopTimer.UseVisualStyleBackColor = true;
            this.btnStartStopTimer.Click += new System.EventHandler(this.btnStartStopTimer_Click);
            // 
            // tmrTelCom
            // 
            this.tmrTelCom.Interval = 500;
            this.tmrTelCom.Tick += new System.EventHandler(this.tmrTelCom_Tick);
            // 
            // pbBcst
            // 
            this.pbBcst.Image = global::ObserverPatternAssignment.Properties.Resources.brdcst;
            this.pbBcst.Location = new System.Drawing.Point(59, 6);
            this.pbBcst.Name = "pbBcst";
            this.pbBcst.Size = new System.Drawing.Size(76, 75);
            this.pbBcst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBcst.TabIndex = 0;
            this.pbBcst.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ObserverPatternAssignment.Properties.Resources.Dave;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 342);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(150, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dave";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBcst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbTelComStatus;
        private System.Windows.Forms.Button btnStartStopTimer;
        private System.Windows.Forms.PictureBox pbBcst;
        private System.Windows.Forms.Timer tmrTelCom;
    }
}

