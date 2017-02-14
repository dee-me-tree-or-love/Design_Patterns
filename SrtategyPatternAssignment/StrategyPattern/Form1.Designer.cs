namespace StrategyPattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRestTasks = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCurrentTask = new System.Windows.Forms.TextBox();
            this.trBrTasks = new System.Windows.Forms.TrackBar();
            this.rbFCFS = new System.Windows.Forms.RadioButton();
            this.rbSSTF = new System.Windows.Forms.RadioButton();
            this.rbSCAN = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbExplained = new System.Windows.Forms.TextBox();
            this.tmrDiskProcessing = new System.Windows.Forms.Timer(this.components);
            this.btnOneStep = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBrTasks)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbRestTasks);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 403);
            this.panel1.TabIndex = 1;
            // 
            // lbRestTasks
            // 
            this.lbRestTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRestTasks.FormattingEnabled = true;
            this.lbRestTasks.Location = new System.Drawing.Point(0, 132);
            this.lbRestTasks.Name = "lbRestTasks";
            this.lbRestTasks.Size = new System.Drawing.Size(87, 271);
            this.lbRestTasks.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOneStep);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbCurrentTask);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 132);
            this.panel2.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(0, 90);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(0, 39);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "\\/ all tasks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "/\\ current task";
            // 
            // tbCurrentTask
            // 
            this.tbCurrentTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCurrentTask.Location = new System.Drawing.Point(0, 0);
            this.tbCurrentTask.Name = "tbCurrentTask";
            this.tbCurrentTask.Size = new System.Drawing.Size(87, 20);
            this.tbCurrentTask.TabIndex = 0;
            // 
            // trBrTasks
            // 
            this.trBrTasks.AllowDrop = true;
            this.trBrTasks.Dock = System.Windows.Forms.DockStyle.Left;
            this.trBrTasks.Location = new System.Drawing.Point(87, 0);
            this.trBrTasks.Maximum = 100;
            this.trBrTasks.Name = "trBrTasks";
            this.trBrTasks.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trBrTasks.Size = new System.Drawing.Size(45, 403);
            this.trBrTasks.TabIndex = 2;
            // 
            // rbFCFS
            // 
            this.rbFCFS.AutoSize = true;
            this.rbFCFS.Checked = true;
            this.rbFCFS.Location = new System.Drawing.Point(3, 30);
            this.rbFCFS.Name = "rbFCFS";
            this.rbFCFS.Size = new System.Drawing.Size(139, 17);
            this.rbFCFS.TabIndex = 3;
            this.rbFCFS.TabStop = true;
            this.rbFCFS.Text = "First-Come, First-Served ";
            this.rbFCFS.UseVisualStyleBackColor = true;
            this.rbFCFS.CheckedChanged += new System.EventHandler(this.rbFCFS_CheckedChanged);
            // 
            // rbSSTF
            // 
            this.rbSSTF.AutoSize = true;
            this.rbSSTF.Location = new System.Drawing.Point(3, 54);
            this.rbSSTF.Name = "rbSSTF";
            this.rbSSTF.Size = new System.Drawing.Size(140, 17);
            this.rbSSTF.TabIndex = 4;
            this.rbSSTF.Text = "Shortest Seek Time first ";
            this.rbSSTF.UseVisualStyleBackColor = true;
            this.rbSSTF.CheckedChanged += new System.EventHandler(this.rbSSTF_CheckedChanged);
            // 
            // rbSCAN
            // 
            this.rbSCAN.AutoSize = true;
            this.rbSCAN.Location = new System.Drawing.Point(3, 78);
            this.rbSCAN.Name = "rbSCAN";
            this.rbSCAN.Size = new System.Drawing.Size(54, 17);
            this.rbSCAN.TabIndex = 5;
            this.rbSCAN.Text = "SCAN";
            this.rbSCAN.UseVisualStyleBackColor = true;
            this.rbSCAN.CheckedChanged += new System.EventHandler(this.rbSCAN_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.rbSSTF);
            this.panel3.Controls.Add(this.rbFCFS);
            this.panel3.Controls.Add(this.rbSCAN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(132, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 107);
            this.panel3.TabIndex = 7;
            // 
            // tbExplained
            // 
            this.tbExplained.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbExplained.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbExplained.Location = new System.Drawing.Point(132, 107);
            this.tbExplained.Multiline = true;
            this.tbExplained.Name = "tbExplained";
            this.tbExplained.ReadOnly = true;
            this.tbExplained.Size = new System.Drawing.Size(203, 296);
            this.tbExplained.TabIndex = 8;
            this.tbExplained.Text = resources.GetString("tbExplained.Text");
            // 
            // tmrDiskProcessing
            // 
            this.tmrDiskProcessing.Interval = 500;
            this.tmrDiskProcessing.Tick += new System.EventHandler(this.tmrDiskProcessing_Tick);
            // 
            // btnOneStep
            // 
            this.btnOneStep.Location = new System.Drawing.Point(0, 65);
            this.btnOneStep.Name = "btnOneStep";
            this.btnOneStep.Size = new System.Drawing.Size(87, 21);
            this.btnOneStep.TabIndex = 6;
            this.btnOneStep.Text = "One Step >";
            this.btnOneStep.UseVisualStyleBackColor = true;
            this.btnOneStep.Click += new System.EventHandler(this.btnOneStep_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Disk Strategy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 403);
            this.Controls.Add(this.tbExplained);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.trBrTasks);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Disk Scheduler";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBrTasks)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbRestTasks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCurrentTask;
        private System.Windows.Forms.TrackBar trBrTasks;
        private System.Windows.Forms.RadioButton rbFCFS;
        private System.Windows.Forms.RadioButton rbSSTF;
        private System.Windows.Forms.RadioButton rbSCAN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbExplained;
        private System.Windows.Forms.Timer tmrDiskProcessing;
        private System.Windows.Forms.Button btnOneStep;
        private System.Windows.Forms.Label label3;
    }
}

