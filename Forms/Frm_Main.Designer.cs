namespace SpeakingClock.Forms
{
    partial class Frm_Main
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
            this.Tim_Main = new System.Windows.Forms.Timer(this.components);
            this.Lb_RealTime = new System.Windows.Forms.Label();
            this.Num_AnnounceEvery = new System.Windows.Forms.NumericUpDown();
            this.Lb_Speak = new System.Windows.Forms.Label();
            this.Ch_AnnounceEvery = new System.Windows.Forms.CheckBox();
            this.Bg_Speak = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Num_AnnounceEvery)).BeginInit();
            this.SuspendLayout();
            // 
            // Tim_Main
            // 
            this.Tim_Main.Tick += new System.EventHandler(this.Tim_Main_Tick);
            // 
            // Lb_RealTime
            // 
            this.Lb_RealTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_RealTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lb_RealTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_RealTime.ForeColor = System.Drawing.Color.Red;
            this.Lb_RealTime.Location = new System.Drawing.Point(1, 1);
            this.Lb_RealTime.Margin = new System.Windows.Forms.Padding(0);
            this.Lb_RealTime.Name = "Lb_RealTime";
            this.Lb_RealTime.Size = new System.Drawing.Size(257, 23);
            this.Lb_RealTime.TabIndex = 0;
            this.Lb_RealTime.Text = "<yyyy-MM-dd hh:mm:ss.ff tt>";
            this.Lb_RealTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Num_AnnounceEvery
            // 
            this.Num_AnnounceEvery.BackColor = System.Drawing.Color.White;
            this.Num_AnnounceEvery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_AnnounceEvery.Enabled = false;
            this.Num_AnnounceEvery.ForeColor = System.Drawing.Color.Black;
            this.Num_AnnounceEvery.Location = new System.Drawing.Point(123, 25);
            this.Num_AnnounceEvery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Num_AnnounceEvery.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Num_AnnounceEvery.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_AnnounceEvery.Name = "Num_AnnounceEvery";
            this.Num_AnnounceEvery.Size = new System.Drawing.Size(35, 23);
            this.Num_AnnounceEvery.TabIndex = 1;
            this.Num_AnnounceEvery.TabStop = false;
            this.Num_AnnounceEvery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num_AnnounceEvery.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // Lb_Speak
            // 
            this.Lb_Speak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_Speak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_Speak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Speak.ForeColor = System.Drawing.Color.Blue;
            this.Lb_Speak.Location = new System.Drawing.Point(212, 25);
            this.Lb_Speak.Margin = new System.Windows.Forms.Padding(0);
            this.Lb_Speak.Name = "Lb_Speak";
            this.Lb_Speak.Size = new System.Drawing.Size(46, 23);
            this.Lb_Speak.TabIndex = 3;
            this.Lb_Speak.Text = "Speak";
            this.Lb_Speak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lb_Speak.Click += new System.EventHandler(this.Lb_Speak_Click);
            // 
            // Ch_AnnounceEvery
            // 
            this.Ch_AnnounceEvery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ch_AnnounceEvery.Location = new System.Drawing.Point(1, 25);
            this.Ch_AnnounceEvery.Margin = new System.Windows.Forms.Padding(0);
            this.Ch_AnnounceEvery.Name = "Ch_AnnounceEvery";
            this.Ch_AnnounceEvery.Size = new System.Drawing.Size(198, 23);
            this.Ch_AnnounceEvery.TabIndex = 4;
            this.Ch_AnnounceEvery.TabStop = false;
            this.Ch_AnnounceEvery.Text = "Announce every _____ mins";
            this.Ch_AnnounceEvery.UseVisualStyleBackColor = true;
            this.Ch_AnnounceEvery.CheckedChanged += new System.EventHandler(this.Ch_AnnounceEvery_CheckedChanged);
            // 
            // Bg_Speak
            // 
            this.Bg_Speak.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bg_Speak_DoWork);
            this.Bg_Speak.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Bg_Speak_RunWorkerCompleted);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(259, 49);
            this.Controls.Add(this.Num_AnnounceEvery);
            this.Controls.Add(this.Ch_AnnounceEvery);
            this.Controls.Add(this.Lb_Speak);
            this.Controls.Add(this.Lb_RealTime);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_Main";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Num_AnnounceEvery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Tim_Main;
        private System.Windows.Forms.Label Lb_RealTime;
        private System.Windows.Forms.NumericUpDown Num_AnnounceEvery;
        private System.Windows.Forms.Label Lb_Speak;
        private System.Windows.Forms.CheckBox Ch_AnnounceEvery;
        private System.ComponentModel.BackgroundWorker Bg_Speak;
    }
}