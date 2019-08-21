namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topBar = new System.Windows.Forms.Panel();
            this.disappearBox = new System.Windows.Forms.PictureBox();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.sleepButton = new System.Windows.Forms.Button();
            this.hibernateButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.suspendButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.settingButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.shutdownButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.mainBox = new System.Windows.Forms.PictureBox();
            this.contentsPanel = new System.Windows.Forms.Panel();
            this.hookingTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disappearBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.topBar.Controls.Add(this.disappearBox);
            this.topBar.Controls.Add(this.minimizeBox);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(900, 30);
            this.topBar.TabIndex = 0;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            // 
            // disappearBox
            // 
            this.disappearBox.Image = ((System.Drawing.Image)(resources.GetObject("disappearBox.Image")));
            this.disappearBox.Location = new System.Drawing.Point(867, 3);
            this.disappearBox.Name = "disappearBox";
            this.disappearBox.Size = new System.Drawing.Size(24, 20);
            this.disappearBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disappearBox.TabIndex = 1;
            this.disappearBox.TabStop = false;
            this.disappearBox.Click += new System.EventHandler(this.disappearBox_Click);
            // 
            // minimizeBox
            // 
            this.minimizeBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBox.Image")));
            this.minimizeBox.Location = new System.Drawing.Point(832, 3);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(24, 20);
            this.minimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBox.TabIndex = 0;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.minimizeBox_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuPanel.Controls.Add(this.exitBox);
            this.menuPanel.Controls.Add(this.panel8);
            this.menuPanel.Controls.Add(this.panel7);
            this.menuPanel.Controls.Add(this.sleepButton);
            this.menuPanel.Controls.Add(this.hibernateButton);
            this.menuPanel.Controls.Add(this.panel6);
            this.menuPanel.Controls.Add(this.suspendButton);
            this.menuPanel.Controls.Add(this.panel5);
            this.menuPanel.Controls.Add(this.settingButton);
            this.menuPanel.Controls.Add(this.panel4);
            this.menuPanel.Controls.Add(this.shutdownButton);
            this.menuPanel.Controls.Add(this.mainLabel);
            this.menuPanel.Controls.Add(this.mainBox);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 30);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(192, 620);
            this.menuPanel.TabIndex = 1;
            // 
            // exitBox
            // 
            this.exitBox.Image = ((System.Drawing.Image)(resources.GetObject("exitBox.Image")));
            this.exitBox.Location = new System.Drawing.Point(0, 569);
            this.exitBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(46, 40);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBox.TabIndex = 10;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(1, 258);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(4, 26);
            this.panel8.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(1, 218);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(4, 26);
            this.panel7.TabIndex = 9;
            // 
            // sleepButton
            // 
            this.sleepButton.FlatAppearance.BorderSize = 0;
            this.sleepButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.sleepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sleepButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepButton.ForeColor = System.Drawing.Color.White;
            this.sleepButton.Image = ((System.Drawing.Image)(resources.GetObject("sleepButton.Image")));
            this.sleepButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sleepButton.Location = new System.Drawing.Point(3, 138);
            this.sleepButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sleepButton.Name = "sleepButton";
            this.sleepButton.Size = new System.Drawing.Size(190, 26);
            this.sleepButton.TabIndex = 4;
            this.sleepButton.Text = "모니터 끄기";
            this.sleepButton.UseVisualStyleBackColor = true;
            this.sleepButton.Click += new System.EventHandler(this.Button_Handler);
            // 
            // hibernateButton
            // 
            this.hibernateButton.FlatAppearance.BorderSize = 0;
            this.hibernateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.hibernateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hibernateButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hibernateButton.ForeColor = System.Drawing.Color.White;
            this.hibernateButton.Image = ((System.Drawing.Image)(resources.GetObject("hibernateButton.Image")));
            this.hibernateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hibernateButton.Location = new System.Drawing.Point(3, 218);
            this.hibernateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hibernateButton.Name = "hibernateButton";
            this.hibernateButton.Size = new System.Drawing.Size(190, 26);
            this.hibernateButton.TabIndex = 8;
            this.hibernateButton.Text = "최대 절전모드";
            this.hibernateButton.UseVisualStyleBackColor = true;
            this.hibernateButton.Click += new System.EventHandler(this.Button_Handler);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(1, 178);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 26);
            this.panel6.TabIndex = 7;
            // 
            // suspendButton
            // 
            this.suspendButton.FlatAppearance.BorderSize = 0;
            this.suspendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.suspendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suspendButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspendButton.ForeColor = System.Drawing.Color.White;
            this.suspendButton.Image = ((System.Drawing.Image)(resources.GetObject("suspendButton.Image")));
            this.suspendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suspendButton.Location = new System.Drawing.Point(3, 178);
            this.suspendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suspendButton.Name = "suspendButton";
            this.suspendButton.Size = new System.Drawing.Size(190, 26);
            this.suspendButton.TabIndex = 6;
            this.suspendButton.Text = "대기모드";
            this.suspendButton.UseVisualStyleBackColor = true;
            this.suspendButton.Click += new System.EventHandler(this.Button_Handler);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(1, 138);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 26);
            this.panel5.TabIndex = 5;
            // 
            // settingButton
            // 
            this.settingButton.FlatAppearance.BorderSize = 0;
            this.settingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingButton.ForeColor = System.Drawing.Color.White;
            this.settingButton.Image = ((System.Drawing.Image)(resources.GetObject("settingButton.Image")));
            this.settingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingButton.Location = new System.Drawing.Point(3, 258);
            this.settingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(190, 26);
            this.settingButton.TabIndex = 4;
            this.settingButton.Text = "설정";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(1, 98);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 26);
            this.panel4.TabIndex = 3;
            // 
            // shutdownButton
            // 
            this.shutdownButton.FlatAppearance.BorderSize = 0;
            this.shutdownButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.shutdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdownButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownButton.ForeColor = System.Drawing.Color.White;
            this.shutdownButton.Image = ((System.Drawing.Image)(resources.GetObject("shutdownButton.Image")));
            this.shutdownButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shutdownButton.Location = new System.Drawing.Point(3, 98);
            this.shutdownButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.Size = new System.Drawing.Size(190, 26);
            this.shutdownButton.TabIndex = 2;
            this.shutdownButton.Text = "전원 종료";
            this.shutdownButton.UseVisualStyleBackColor = true;
            this.shutdownButton.Click += new System.EventHandler(this.Button_Handler);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.White;
            this.mainLabel.Location = new System.Drawing.Point(91, 38);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(88, 21);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Eco-Saver";
            // 
            // mainBox
            // 
            this.mainBox.Image = ((System.Drawing.Image)(resources.GetObject("mainBox.Image")));
            this.mainBox.Location = new System.Drawing.Point(10, 19);
            this.mainBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(77, 51);
            this.mainBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainBox.TabIndex = 0;
            this.mainBox.TabStop = false;
            this.mainBox.Click += new System.EventHandler(this.mainBox_Click);
            // 
            // contentsPanel
            // 
            this.contentsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.contentsPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentsPanel.Location = new System.Drawing.Point(192, 30);
            this.contentsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contentsPanel.Name = "contentsPanel";
            this.contentsPanel.Size = new System.Drawing.Size(708, 620);
            this.contentsPanel.TabIndex = 2;
            // 
            // hookingTimer
            // 
            this.hookingTimer.Interval = 2000;
            this.hookingTimer.Tick += new System.EventHandler(this.hookingTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Eco-Saver";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.contentsPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Eco-Saver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.disappearBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel contentsPanel;
        private System.Windows.Forms.Button shutdownButton;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.PictureBox mainBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button sleepButton;
        private System.Windows.Forms.Button hibernateButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button suspendButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.PictureBox disappearBox;
        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.Timer hookingTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

