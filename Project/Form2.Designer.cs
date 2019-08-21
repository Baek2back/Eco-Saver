namespace Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.autorunCheckBox = new System.Windows.Forms.CheckBox();
            this.reservationComboBox = new System.Windows.Forms.ComboBox();
            this.autoshutdownCheckBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reservationSettingButton = new System.Windows.Forms.Button();
            this.autoshutdownSettingButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hotkeySettingButton = new System.Windows.Forms.Button();
            this.hotkeySettingCheckBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.hotkeyLabel = new System.Windows.Forms.Label();
            this.reservationCancelButton = new System.Windows.Forms.Button();
            this.autoshutdownCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "설정";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(65, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "예약 종료 시간 설정 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(65, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "자동 종료 시간 설정 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autorunCheckBox
            // 
            this.autorunCheckBox.AutoSize = true;
            this.autorunCheckBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorunCheckBox.ForeColor = System.Drawing.Color.White;
            this.autorunCheckBox.Location = new System.Drawing.Point(69, 376);
            this.autorunCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorunCheckBox.Name = "autorunCheckBox";
            this.autorunCheckBox.Size = new System.Drawing.Size(194, 24);
            this.autorunCheckBox.TabIndex = 4;
            this.autorunCheckBox.Text = "윈도우 시작 시 자동 실행";
            this.autorunCheckBox.UseVisualStyleBackColor = true;
            this.autorunCheckBox.CheckedChanged += new System.EventHandler(this.autorunCheckBox_CheckedChanged);
            // 
            // reservationComboBox
            // 
            this.reservationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationComboBox.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reservationComboBox.FormattingEnabled = true;
            this.reservationComboBox.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.reservationComboBox.Location = new System.Drawing.Point(292, 90);
            this.reservationComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservationComboBox.Name = "reservationComboBox";
            this.reservationComboBox.Size = new System.Drawing.Size(130, 27);
            this.reservationComboBox.TabIndex = 5;
            // 
            // autoshutdownCheckBox
            // 
            this.autoshutdownCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoshutdownCheckBox.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.autoshutdownCheckBox.FormattingEnabled = true;
            this.autoshutdownCheckBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.autoshutdownCheckBox.Location = new System.Drawing.Point(354, 192);
            this.autoshutdownCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoshutdownCheckBox.Name = "autoshutdownCheckBox";
            this.autoshutdownCheckBox.Size = new System.Drawing.Size(69, 27);
            this.autoshutdownCheckBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(427, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 64);
            this.label7.TabIndex = 7;
            this.label7.Text = "분 후 종료";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(427, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "시에 종료";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(288, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "매일";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reservationSettingButton
            // 
            this.reservationSettingButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reservationSettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationSettingButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationSettingButton.ForeColor = System.Drawing.Color.White;
            this.reservationSettingButton.Location = new System.Drawing.Point(532, 85);
            this.reservationSettingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservationSettingButton.Name = "reservationSettingButton";
            this.reservationSettingButton.Size = new System.Drawing.Size(58, 40);
            this.reservationSettingButton.TabIndex = 10;
            this.reservationSettingButton.Text = "설정";
            this.reservationSettingButton.UseVisualStyleBackColor = true;
            this.reservationSettingButton.Click += new System.EventHandler(this.Button_Handler);
            // 
            // autoshutdownSettingButton
            // 
            this.autoshutdownSettingButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.autoshutdownSettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoshutdownSettingButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoshutdownSettingButton.ForeColor = System.Drawing.Color.White;
            this.autoshutdownSettingButton.Location = new System.Drawing.Point(532, 183);
            this.autoshutdownSettingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoshutdownSettingButton.Name = "autoshutdownSettingButton";
            this.autoshutdownSettingButton.Size = new System.Drawing.Size(58, 40);
            this.autoshutdownSettingButton.TabIndex = 11;
            this.autoshutdownSettingButton.Text = "설정";
            this.autoshutdownSettingButton.UseVisualStyleBackColor = true;
            this.autoshutdownSettingButton.Click += new System.EventHandler(this.Button_Handler);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(65, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "단축키 변경 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hotkeySettingButton
            // 
            this.hotkeySettingButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hotkeySettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotkeySettingButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotkeySettingButton.ForeColor = System.Drawing.Color.White;
            this.hotkeySettingButton.Location = new System.Drawing.Point(547, 270);
            this.hotkeySettingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hotkeySettingButton.Name = "hotkeySettingButton";
            this.hotkeySettingButton.Size = new System.Drawing.Size(93, 54);
            this.hotkeySettingButton.TabIndex = 13;
            this.hotkeySettingButton.Text = "설정";
            this.hotkeySettingButton.UseVisualStyleBackColor = true;
            this.hotkeySettingButton.Click += new System.EventHandler(this.Button_Handler);
            // 
            // hotkeySettingCheckBox
            // 
            this.hotkeySettingCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotkeySettingCheckBox.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hotkeySettingCheckBox.FormattingEnabled = true;
            this.hotkeySettingCheckBox.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.hotkeySettingCheckBox.Location = new System.Drawing.Point(416, 284);
            this.hotkeySettingCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hotkeySettingCheckBox.Name = "hotkeySettingCheckBox";
            this.hotkeySettingCheckBox.Size = new System.Drawing.Size(111, 27);
            this.hotkeySettingCheckBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(322, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "LShift +";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(412, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "현재 단축키";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hotkeyLabel
            // 
            this.hotkeyLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotkeyLabel.ForeColor = System.Drawing.Color.White;
            this.hotkeyLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hotkeyLabel.Location = new System.Drawing.Point(518, 334);
            this.hotkeyLabel.Name = "hotkeyLabel";
            this.hotkeyLabel.Size = new System.Drawing.Size(122, 31);
            this.hotkeyLabel.TabIndex = 17;
            this.hotkeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reservationCancelButton
            // 
            this.reservationCancelButton.Enabled = false;
            this.reservationCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reservationCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationCancelButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationCancelButton.ForeColor = System.Drawing.Color.White;
            this.reservationCancelButton.Location = new System.Drawing.Point(596, 85);
            this.reservationCancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservationCancelButton.Name = "reservationCancelButton";
            this.reservationCancelButton.Size = new System.Drawing.Size(58, 40);
            this.reservationCancelButton.TabIndex = 18;
            this.reservationCancelButton.Text = "취소";
            this.reservationCancelButton.UseVisualStyleBackColor = true;
            this.reservationCancelButton.Click += new System.EventHandler(this.Button_Handler);
            // 
            // autoshutdownCancelButton
            // 
            this.autoshutdownCancelButton.Enabled = false;
            this.autoshutdownCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.autoshutdownCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoshutdownCancelButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoshutdownCancelButton.ForeColor = System.Drawing.Color.White;
            this.autoshutdownCancelButton.Location = new System.Drawing.Point(596, 183);
            this.autoshutdownCancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoshutdownCancelButton.Name = "autoshutdownCancelButton";
            this.autoshutdownCancelButton.Size = new System.Drawing.Size(58, 40);
            this.autoshutdownCancelButton.TabIndex = 19;
            this.autoshutdownCancelButton.Text = "취소";
            this.autoshutdownCancelButton.UseVisualStyleBackColor = true;
            this.autoshutdownCancelButton.Click += new System.EventHandler(this.Button_Handler);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(708, 620);
            this.Controls.Add(this.autoshutdownCancelButton);
            this.Controls.Add(this.reservationCancelButton);
            this.Controls.Add(this.hotkeyLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hotkeySettingCheckBox);
            this.Controls.Add(this.hotkeySettingButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.autoshutdownSettingButton);
            this.Controls.Add(this.reservationSettingButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.autoshutdownCheckBox);
            this.Controls.Add(this.reservationComboBox);
            this.Controls.Add(this.autorunCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox autorunCheckBox;
        private System.Windows.Forms.ComboBox reservationComboBox;
        private System.Windows.Forms.ComboBox autoshutdownCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reservationSettingButton;
        private System.Windows.Forms.Button autoshutdownSettingButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hotkeySettingButton;
        private System.Windows.Forms.ComboBox hotkeySettingCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label hotkeyLabel;
        private System.Windows.Forms.Button reservationCancelButton;
        private System.Windows.Forms.Button autoshutdownCancelButton;
    }
}