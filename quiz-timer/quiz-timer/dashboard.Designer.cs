namespace quiz_timer
{
    partial class dashboard
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
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.logopanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.sidepanel.SuspendLayout();
            this.logopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.sidepanel.Controls.Add(this.radioButton1);
            this.sidepanel.Controls.Add(this.button1);
            this.sidepanel.Controls.Add(this.logopanel);
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(174, 525);
            this.sidepanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(180, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 100);
            this.panel1.TabIndex = 1;
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(174, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(623, 47);
            this.headerpanel.TabIndex = 1;
            // 
            // logopanel
            // 
            this.logopanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logopanel.Controls.Add(this.pictureBox1);
            this.logopanel.Controls.Add(this.label1);
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(174, 47);
            this.logopanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gold System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quiz_timer.Properties.Resources.cv_pic;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 24);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-15, -15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(797, 525);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.logopanel.ResumeLayout(false);
            this.logopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
    }
}