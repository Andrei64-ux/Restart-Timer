namespace ShutdownTimer
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.userControl1 = new ShutdownTimer.UserControl1();
            this.userControl2 = new ShutdownTimer.UserControl2();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnRestart = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnShutdown = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSleep = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnHibernate = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSwitchUser = new Bunifu.Framework.UI.BunifuTileButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 43);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(692, 4);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shut Down Windows";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.panel);
            this.panel2.Controls.Add(this.bunifuImageButton4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 284);
            this.panel2.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.userControl1);
            this.panel.Controls.Add(this.userControl2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(728, 241);
            this.panel.TabIndex = 5;
            // 
            // userControl1
            // 
            this.userControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.userControl1.CheckBoxSelectedTime_Value = true;
            this.userControl1.CheckBoxTotalTime_Value = true;
            this.userControl1.Date = new System.DateTime(2018, 3, 28, 19, 49, 2, 7);
            this.userControl1.Hours = 26;
            this.userControl1.Location = new System.Drawing.Point(0, 0);
            this.userControl1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl1.Minutes = 26;
            this.userControl1.Name = "userControl1";
            this.userControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userControl1.Seconds = 26;
            this.userControl1.Size = new System.Drawing.Size(728, 245);
            this.userControl1.TabIndex = 2;
            this.userControl1.TotalHours = 0;
            this.userControl1.TotalMinutes = 0;
            this.userControl1.TotalSeconds = 60;
            this.userControl1.TotalHours_KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserControl1_TotalHours_KeyPress);
            this.userControl1.TotalMinutes_KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserControl1_TotalMinutes_KeyPress);
            this.userControl1.TotalSeconds_KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserControl1_TotalSeconds_KeyPress);
            this.userControl1.Hours_KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserControl1_Hours_KeyPress);
            this.userControl1.Minutes_KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserControl1_Minutes_KeyPress);
            this.userControl1.Seconds_KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserControl1_Seconds_KeyPress);
            this.userControl1.CheckBoxTotalTime_OnChange += new System.EventHandler(this.UserControl1_CheckBoxTotalTime_OnChange);
            this.userControl1.CheckBoxSelectedTime_OnChange += new System.EventHandler(this.UserControl1_CheckBoxSelectedTime_OnChange);
            // 
            // userControl2
            // 
            this.userControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.userControl2.CircleDays_MaxValue = 59;
            this.userControl2.CircleDays_MinValue = 0;
            this.userControl2.CircleDays_Value = 30;
            this.userControl2.CircleHours_Value = 23;
            this.userControl2.CircleMinutes_Value = 30;
            this.userControl2.CircleSeconds_Value = 30;
            this.userControl2.Days = 0;
            this.userControl2.Hours = 0;
            this.userControl2.Location = new System.Drawing.Point(0, 0);
            this.userControl2.Margin = new System.Windows.Forms.Padding(5);
            this.userControl2.Minutes = 0;
            this.userControl2.Name = "userControl2";
            this.userControl2.Seconds = 0;
            this.userControl2.Size = new System.Drawing.Size(728, 241);
            this.userControl2.TabIndex = 1;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(681, 245);
            this.bunifuImageButton4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(40, 37);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton4.TabIndex = 3;
            this.bunifuImageButton4.TabStop = false;
            this.toolTip1.SetToolTip(this.bunifuImageButton4, "About me");
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.BunifuImageButton4_Click);
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.White;
            this.panelButton.Controls.Add(this.btnCancel);
            this.panelButton.Controls.Add(this.btnRestart);
            this.panelButton.Controls.Add(this.btnShutdown);
            this.panelButton.Controls.Add(this.btnSleep);
            this.panelButton.Controls.Add(this.btnHibernate);
            this.panelButton.Controls.Add(this.btnSwitchUser);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 43);
            this.panelButton.Margin = new System.Windows.Forms.Padding(4);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(728, 124);
            this.panelButton.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnCancel.color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnCancel.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImagePosition = 14;
            this.btnCancel.ImageZoom = 40;
            this.btnCancel.LabelPosition = 29;
            this.btnCancel.LabelText = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(609, 12);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 98);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnRestart.color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnRestart.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))));
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Image = ((System.Drawing.Image)(resources.GetObject("btnRestart.Image")));
            this.btnRestart.ImagePosition = 14;
            this.btnRestart.ImageZoom = 40;
            this.btnRestart.LabelPosition = 29;
            this.btnRestart.LabelText = "Restart";
            this.btnRestart.Location = new System.Drawing.Point(492, 12);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(5);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(107, 98);
            this.btnRestart.TabIndex = 11;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnShutdown.color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnShutdown.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))));
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutdown.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnShutdown.ForeColor = System.Drawing.Color.White;
            this.btnShutdown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutdown.Image")));
            this.btnShutdown.ImagePosition = 14;
            this.btnShutdown.ImageZoom = 40;
            this.btnShutdown.LabelPosition = 29;
            this.btnShutdown.LabelText = "Shut down";
            this.btnShutdown.Location = new System.Drawing.Point(373, 12);
            this.btnShutdown.Margin = new System.Windows.Forms.Padding(5);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(107, 98);
            this.btnShutdown.TabIndex = 10;
            this.btnShutdown.Click += new System.EventHandler(this.BtnShutdown_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnSleep.color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnSleep.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))));
            this.btnSleep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSleep.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSleep.ForeColor = System.Drawing.Color.White;
            this.btnSleep.Image = ((System.Drawing.Image)(resources.GetObject("btnSleep.Image")));
            this.btnSleep.ImagePosition = 14;
            this.btnSleep.ImageZoom = 40;
            this.btnSleep.LabelPosition = 29;
            this.btnSleep.LabelText = "Sleep";
            this.btnSleep.Location = new System.Drawing.Point(255, 12);
            this.btnSleep.Margin = new System.Windows.Forms.Padding(5);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(107, 98);
            this.btnSleep.TabIndex = 9;
            this.btnSleep.Click += new System.EventHandler(this.BtnSleep_Click);
            // 
            // btnHibernate
            // 
            this.btnHibernate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnHibernate.color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnHibernate.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))));
            this.btnHibernate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHibernate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnHibernate.ForeColor = System.Drawing.Color.White;
            this.btnHibernate.Image = ((System.Drawing.Image)(resources.GetObject("btnHibernate.Image")));
            this.btnHibernate.ImagePosition = 14;
            this.btnHibernate.ImageZoom = 40;
            this.btnHibernate.LabelPosition = 29;
            this.btnHibernate.LabelText = "Hibernate";
            this.btnHibernate.Location = new System.Drawing.Point(135, 12);
            this.btnHibernate.Margin = new System.Windows.Forms.Padding(5);
            this.btnHibernate.Name = "btnHibernate";
            this.btnHibernate.Size = new System.Drawing.Size(107, 98);
            this.btnHibernate.TabIndex = 8;
            this.btnHibernate.Click += new System.EventHandler(this.BtnHibernate_Click);
            // 
            // btnSwitchUser
            // 
            this.btnSwitchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnSwitchUser.color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnSwitchUser.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(160)))), ((int)(((byte)(40)))));
            this.btnSwitchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchUser.ForeColor = System.Drawing.Color.White;
            this.btnSwitchUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchUser.Image")));
            this.btnSwitchUser.ImagePosition = 14;
            this.btnSwitchUser.ImageZoom = 40;
            this.btnSwitchUser.LabelPosition = 29;
            this.btnSwitchUser.LabelText = "Switch user";
            this.btnSwitchUser.Location = new System.Drawing.Point(15, 12);
            this.btnSwitchUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSwitchUser.Name = "btnSwitchUser";
            this.btnSwitchUser.Size = new System.Drawing.Size(107, 98);
            this.btnSwitchUser.TabIndex = 7;
            this.btnSwitchUser.Click += new System.EventHandler(this.BtnSwitchUser_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.Panel panelButton;
        private Bunifu.Framework.UI.BunifuTileButton btnShutdown;
        private Bunifu.Framework.UI.BunifuTileButton btnSleep;
        private Bunifu.Framework.UI.BunifuTileButton btnHibernate;
        private Bunifu.Framework.UI.BunifuTileButton btnSwitchUser;
        private System.Windows.Forms.Panel panel;
        private Bunifu.Framework.UI.BunifuTileButton btnRestart;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuTileButton btnCancel;
        private UserControl2 userControl2;
        private UserControl1 userControl1;
        private System.Windows.Forms.Timer timer1;
    }
}

