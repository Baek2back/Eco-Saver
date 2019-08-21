namespace Project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.shutdownProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardTimer = new System.Windows.Forms.Timer(this.components);
            this.FirstTimerLabel1 = new System.Windows.Forms.Label();
            this.FirstTimerLabel2 = new System.Windows.Forms.Label();
            this.FirstTimerLabel3 = new System.Windows.Forms.Label();
            this.SecondTimerLabel3 = new System.Windows.Forms.Label();
            this.SecondTimerLabel2 = new System.Windows.Forms.Label();
            this.SecondTimerLabel1 = new System.Windows.Forms.Label();
            this.sleepProgressBar = new CircularProgressBar.CircularProgressBar();
            this.ThirdTimerLabel3 = new System.Windows.Forms.Label();
            this.ThirdTimerLabel2 = new System.Windows.Forms.Label();
            this.ThirdTimerLabel1 = new System.Windows.Forms.Label();
            this.suspendProgressBar = new CircularProgressBar.CircularProgressBar();
            this.FourthTimerLabel3 = new System.Windows.Forms.Label();
            this.FourthTimerLabel2 = new System.Windows.Forms.Label();
            this.FourthTimerLabel1 = new System.Windows.Forms.Label();
            this.hibernateProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bootingTimeProgressBar = new CircularProgressBar.CircularProgressBar();
            this.FifthTimerLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bootingTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shutdownProgressBar
            // 
            this.shutdownProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.shutdownProgressBar.AnimationSpeed = 500;
            this.shutdownProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.shutdownProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownProgressBar.ForeColor = System.Drawing.Color.White;
            this.shutdownProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.shutdownProgressBar.InnerMargin = 2;
            this.shutdownProgressBar.InnerWidth = -1;
            this.shutdownProgressBar.Location = new System.Drawing.Point(60, 82);
            this.shutdownProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shutdownProgressBar.MarqueeAnimationSpeed = 2000;
            this.shutdownProgressBar.Maximum = 60;
            this.shutdownProgressBar.Name = "shutdownProgressBar";
            this.shutdownProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.shutdownProgressBar.OuterMargin = -25;
            this.shutdownProgressBar.OuterWidth = 26;
            this.shutdownProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(219)))), ((int)(((byte)(166)))));
            this.shutdownProgressBar.ProgressWidth = 10;
            this.shutdownProgressBar.SecondaryFont = new System.Drawing.Font("굴림", 36F);
            this.shutdownProgressBar.Size = new System.Drawing.Size(234, 212);
            this.shutdownProgressBar.StartAngle = 270;
            this.shutdownProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.shutdownProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.shutdownProgressBar.SubscriptText = "";
            this.shutdownProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.shutdownProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.shutdownProgressBar.SuperscriptText = "";
            this.shutdownProgressBar.TabIndex = 0;
            this.shutdownProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.shutdownProgressBar.Value = 60;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASH BOARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashboardTimer
            // 
            this.dashboardTimer.Tick += new System.EventHandler(this.dashboardTimer_Tick);
            // 
            // FirstTimerLabel1
            // 
            this.FirstTimerLabel1.Font = new System.Drawing.Font("Arial", 18F);
            this.FirstTimerLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(219)))), ((int)(((byte)(166)))));
            this.FirstTimerLabel1.Location = new System.Drawing.Point(161, 109);
            this.FirstTimerLabel1.Name = "FirstTimerLabel1";
            this.FirstTimerLabel1.Size = new System.Drawing.Size(43, 28);
            this.FirstTimerLabel1.TabIndex = 3;
            // 
            // FirstTimerLabel2
            // 
            this.FirstTimerLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstTimerLabel2.ForeColor = System.Drawing.Color.White;
            this.FirstTimerLabel2.Location = new System.Drawing.Point(117, 214);
            this.FirstTimerLabel2.Name = "FirstTimerLabel2";
            this.FirstTimerLabel2.Size = new System.Drawing.Size(126, 24);
            this.FirstTimerLabel2.TabIndex = 4;
            this.FirstTimerLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstTimerLabel3
            // 
            this.FirstTimerLabel3.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FirstTimerLabel3.ForeColor = System.Drawing.Color.White;
            this.FirstTimerLabel3.Location = new System.Drawing.Point(117, 238);
            this.FirstTimerLabel3.Name = "FirstTimerLabel3";
            this.FirstTimerLabel3.Size = new System.Drawing.Size(124, 21);
            this.FirstTimerLabel3.TabIndex = 5;
            this.FirstTimerLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondTimerLabel3
            // 
            this.SecondTimerLabel3.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SecondTimerLabel3.ForeColor = System.Drawing.Color.White;
            this.SecondTimerLabel3.Location = new System.Drawing.Point(451, 238);
            this.SecondTimerLabel3.Name = "SecondTimerLabel3";
            this.SecondTimerLabel3.Size = new System.Drawing.Size(124, 21);
            this.SecondTimerLabel3.TabIndex = 9;
            this.SecondTimerLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondTimerLabel2
            // 
            this.SecondTimerLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondTimerLabel2.ForeColor = System.Drawing.Color.White;
            this.SecondTimerLabel2.Location = new System.Drawing.Point(451, 214);
            this.SecondTimerLabel2.Name = "SecondTimerLabel2";
            this.SecondTimerLabel2.Size = new System.Drawing.Size(126, 24);
            this.SecondTimerLabel2.TabIndex = 8;
            this.SecondTimerLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondTimerLabel1
            // 
            this.SecondTimerLabel1.Font = new System.Drawing.Font("Arial", 18F);
            this.SecondTimerLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SecondTimerLabel1.Location = new System.Drawing.Point(495, 109);
            this.SecondTimerLabel1.Name = "SecondTimerLabel1";
            this.SecondTimerLabel1.Size = new System.Drawing.Size(43, 28);
            this.SecondTimerLabel1.TabIndex = 7;
            // 
            // sleepProgressBar
            // 
            this.sleepProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.sleepProgressBar.AnimationSpeed = 500;
            this.sleepProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.sleepProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepProgressBar.ForeColor = System.Drawing.Color.White;
            this.sleepProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.sleepProgressBar.InnerMargin = 2;
            this.sleepProgressBar.InnerWidth = -1;
            this.sleepProgressBar.Location = new System.Drawing.Point(394, 82);
            this.sleepProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sleepProgressBar.MarqueeAnimationSpeed = 2000;
            this.sleepProgressBar.Maximum = 60;
            this.sleepProgressBar.Name = "sleepProgressBar";
            this.sleepProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.sleepProgressBar.OuterMargin = -25;
            this.sleepProgressBar.OuterWidth = 26;
            this.sleepProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sleepProgressBar.ProgressWidth = 10;
            this.sleepProgressBar.SecondaryFont = new System.Drawing.Font("굴림", 36F);
            this.sleepProgressBar.Size = new System.Drawing.Size(234, 212);
            this.sleepProgressBar.StartAngle = 270;
            this.sleepProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.sleepProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.sleepProgressBar.SubscriptText = "";
            this.sleepProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.sleepProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.sleepProgressBar.SuperscriptText = "";
            this.sleepProgressBar.TabIndex = 6;
            this.sleepProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.sleepProgressBar.Value = 60;
            // 
            // ThirdTimerLabel3
            // 
            this.ThirdTimerLabel3.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ThirdTimerLabel3.ForeColor = System.Drawing.Color.White;
            this.ThirdTimerLabel3.Location = new System.Drawing.Point(117, 523);
            this.ThirdTimerLabel3.Name = "ThirdTimerLabel3";
            this.ThirdTimerLabel3.Size = new System.Drawing.Size(124, 21);
            this.ThirdTimerLabel3.TabIndex = 13;
            this.ThirdTimerLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThirdTimerLabel2
            // 
            this.ThirdTimerLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdTimerLabel2.ForeColor = System.Drawing.Color.White;
            this.ThirdTimerLabel2.Location = new System.Drawing.Point(117, 499);
            this.ThirdTimerLabel2.Name = "ThirdTimerLabel2";
            this.ThirdTimerLabel2.Size = new System.Drawing.Size(126, 24);
            this.ThirdTimerLabel2.TabIndex = 12;
            this.ThirdTimerLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThirdTimerLabel1
            // 
            this.ThirdTimerLabel1.Font = new System.Drawing.Font("Arial", 18F);
            this.ThirdTimerLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ThirdTimerLabel1.Location = new System.Drawing.Point(161, 394);
            this.ThirdTimerLabel1.Name = "ThirdTimerLabel1";
            this.ThirdTimerLabel1.Size = new System.Drawing.Size(43, 28);
            this.ThirdTimerLabel1.TabIndex = 11;
            // 
            // suspendProgressBar
            // 
            this.suspendProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.suspendProgressBar.AnimationSpeed = 500;
            this.suspendProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.suspendProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspendProgressBar.ForeColor = System.Drawing.Color.White;
            this.suspendProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.suspendProgressBar.InnerMargin = 2;
            this.suspendProgressBar.InnerWidth = -1;
            this.suspendProgressBar.Location = new System.Drawing.Point(60, 367);
            this.suspendProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suspendProgressBar.MarqueeAnimationSpeed = 2000;
            this.suspendProgressBar.Maximum = 60;
            this.suspendProgressBar.Name = "suspendProgressBar";
            this.suspendProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.suspendProgressBar.OuterMargin = -25;
            this.suspendProgressBar.OuterWidth = 26;
            this.suspendProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.suspendProgressBar.ProgressWidth = 10;
            this.suspendProgressBar.SecondaryFont = new System.Drawing.Font("굴림", 36F);
            this.suspendProgressBar.Size = new System.Drawing.Size(234, 212);
            this.suspendProgressBar.StartAngle = 270;
            this.suspendProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.suspendProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.suspendProgressBar.SubscriptText = "";
            this.suspendProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.suspendProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.suspendProgressBar.SuperscriptText = "";
            this.suspendProgressBar.TabIndex = 10;
            this.suspendProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.suspendProgressBar.Value = 60;
            // 
            // FourthTimerLabel3
            // 
            this.FourthTimerLabel3.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FourthTimerLabel3.ForeColor = System.Drawing.Color.White;
            this.FourthTimerLabel3.Location = new System.Drawing.Point(451, 523);
            this.FourthTimerLabel3.Name = "FourthTimerLabel3";
            this.FourthTimerLabel3.Size = new System.Drawing.Size(124, 21);
            this.FourthTimerLabel3.TabIndex = 17;
            this.FourthTimerLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FourthTimerLabel2
            // 
            this.FourthTimerLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourthTimerLabel2.ForeColor = System.Drawing.Color.White;
            this.FourthTimerLabel2.Location = new System.Drawing.Point(451, 499);
            this.FourthTimerLabel2.Name = "FourthTimerLabel2";
            this.FourthTimerLabel2.Size = new System.Drawing.Size(126, 24);
            this.FourthTimerLabel2.TabIndex = 16;
            this.FourthTimerLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FourthTimerLabel1
            // 
            this.FourthTimerLabel1.Font = new System.Drawing.Font("Arial", 18F);
            this.FourthTimerLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FourthTimerLabel1.Location = new System.Drawing.Point(493, 394);
            this.FourthTimerLabel1.Name = "FourthTimerLabel1";
            this.FourthTimerLabel1.Size = new System.Drawing.Size(43, 28);
            this.FourthTimerLabel1.TabIndex = 15;
            // 
            // hibernateProgressBar
            // 
            this.hibernateProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.hibernateProgressBar.AnimationSpeed = 500;
            this.hibernateProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.hibernateProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hibernateProgressBar.ForeColor = System.Drawing.Color.White;
            this.hibernateProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.hibernateProgressBar.InnerMargin = 2;
            this.hibernateProgressBar.InnerWidth = -1;
            this.hibernateProgressBar.Location = new System.Drawing.Point(396, 367);
            this.hibernateProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hibernateProgressBar.MarqueeAnimationSpeed = 2000;
            this.hibernateProgressBar.Maximum = 60;
            this.hibernateProgressBar.Name = "hibernateProgressBar";
            this.hibernateProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.hibernateProgressBar.OuterMargin = -25;
            this.hibernateProgressBar.OuterWidth = 26;
            this.hibernateProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.hibernateProgressBar.ProgressWidth = 10;
            this.hibernateProgressBar.SecondaryFont = new System.Drawing.Font("굴림", 36F);
            this.hibernateProgressBar.Size = new System.Drawing.Size(234, 212);
            this.hibernateProgressBar.StartAngle = 270;
            this.hibernateProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.hibernateProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.hibernateProgressBar.SubscriptText = "";
            this.hibernateProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.hibernateProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.hibernateProgressBar.SuperscriptText = "";
            this.hibernateProgressBar.TabIndex = 14;
            this.hibernateProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.hibernateProgressBar.Value = 60;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Shutdown";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(362, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sleep";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(22, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Suspend";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(362, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hibernate";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bootingTimeProgressBar
            // 
            this.bootingTimeProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.bootingTimeProgressBar.AnimationSpeed = 500;
            this.bootingTimeProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.bootingTimeProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bootingTimeProgressBar.ForeColor = System.Drawing.Color.White;
            this.bootingTimeProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.bootingTimeProgressBar.InnerMargin = 2;
            this.bootingTimeProgressBar.InnerWidth = -1;
            this.bootingTimeProgressBar.Location = new System.Drawing.Point(616, 3);
            this.bootingTimeProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bootingTimeProgressBar.MarqueeAnimationSpeed = 2000;
            this.bootingTimeProgressBar.Maximum = 60;
            this.bootingTimeProgressBar.Name = "bootingTimeProgressBar";
            this.bootingTimeProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.bootingTimeProgressBar.OuterMargin = -25;
            this.bootingTimeProgressBar.OuterWidth = 26;
            this.bootingTimeProgressBar.ProgressColor = System.Drawing.Color.White;
            this.bootingTimeProgressBar.ProgressWidth = 10;
            this.bootingTimeProgressBar.SecondaryFont = new System.Drawing.Font("굴림", 36F);
            this.bootingTimeProgressBar.Size = new System.Drawing.Size(70, 70);
            this.bootingTimeProgressBar.StartAngle = 270;
            this.bootingTimeProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bootingTimeProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.bootingTimeProgressBar.SubscriptText = "";
            this.bootingTimeProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.bootingTimeProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.bootingTimeProgressBar.SuperscriptText = "";
            this.bootingTimeProgressBar.TabIndex = 22;
            this.bootingTimeProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.bootingTimeProgressBar.Value = 60;
            // 
            // FifthTimerLabel
            // 
            this.FifthTimerLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FifthTimerLabel.ForeColor = System.Drawing.Color.White;
            this.FifthTimerLabel.Location = new System.Drawing.Point(639, 28);
            this.FifthTimerLabel.Name = "FifthTimerLabel";
            this.FifthTimerLabel.Size = new System.Drawing.Size(26, 18);
            this.FifthTimerLabel.TabIndex = 23;
            this.FifthTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(345, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "Booting";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bootingTimeLabel
            // 
            this.bootingTimeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bootingTimeLabel.ForeColor = System.Drawing.Color.White;
            this.bootingTimeLabel.Location = new System.Drawing.Point(445, 21);
            this.bootingTimeLabel.Name = "bootingTimeLabel";
            this.bootingTimeLabel.Size = new System.Drawing.Size(157, 23);
            this.bootingTimeLabel.TabIndex = 25;
            this.bootingTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(708, 620);
            this.Controls.Add(this.bootingTimeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FifthTimerLabel);
            this.Controls.Add(this.bootingTimeProgressBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FourthTimerLabel3);
            this.Controls.Add(this.FourthTimerLabel2);
            this.Controls.Add(this.FourthTimerLabel1);
            this.Controls.Add(this.hibernateProgressBar);
            this.Controls.Add(this.ThirdTimerLabel3);
            this.Controls.Add(this.ThirdTimerLabel2);
            this.Controls.Add(this.ThirdTimerLabel1);
            this.Controls.Add(this.suspendProgressBar);
            this.Controls.Add(this.SecondTimerLabel3);
            this.Controls.Add(this.SecondTimerLabel2);
            this.Controls.Add(this.SecondTimerLabel1);
            this.Controls.Add(this.sleepProgressBar);
            this.Controls.Add(this.FirstTimerLabel3);
            this.Controls.Add(this.FirstTimerLabel2);
            this.Controls.Add(this.FirstTimerLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shutdownProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar shutdownProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer dashboardTimer;
        private System.Windows.Forms.Label FirstTimerLabel1;
        private System.Windows.Forms.Label FirstTimerLabel2;
        private System.Windows.Forms.Label FirstTimerLabel3;
        private System.Windows.Forms.Label SecondTimerLabel3;
        private System.Windows.Forms.Label SecondTimerLabel2;
        private System.Windows.Forms.Label SecondTimerLabel1;
        private CircularProgressBar.CircularProgressBar sleepProgressBar;
        private System.Windows.Forms.Label ThirdTimerLabel3;
        private System.Windows.Forms.Label ThirdTimerLabel2;
        private System.Windows.Forms.Label ThirdTimerLabel1;
        private CircularProgressBar.CircularProgressBar suspendProgressBar;
        private System.Windows.Forms.Label FourthTimerLabel3;
        private System.Windows.Forms.Label FourthTimerLabel2;
        private System.Windows.Forms.Label FourthTimerLabel1;
        private CircularProgressBar.CircularProgressBar hibernateProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CircularProgressBar.CircularProgressBar bootingTimeProgressBar;
        private System.Windows.Forms.Label FifthTimerLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bootingTimeLabel;
    }
}