namespace SendMail
{
    partial class HomePage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Interface = new System.Windows.Forms.TabControl();
            this.SendScreen = new System.Windows.Forms.TabPage();
            this.MailScrren = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.TimerPanelOpen = new System.Windows.Forms.Timer(this.components);
            this.TimerPanelClose = new System.Windows.Forms.Timer(this.components);
            this.TextSender = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.RichTextBody = new System.Windows.Forms.RichTextBox();
            this.TextBuyer = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TextTittle = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelMenu2 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnMailScreen = new System.Windows.Forms.Button();
            this.BtnMenu2 = new System.Windows.Forms.Button();
            this.BtnExit2 = new System.Windows.Forms.Button();
            this.BtnSendScreen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnMailDelete = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            this.Interface.SuspendLayout();
            this.SendScreen.SuspendLayout();
            this.MailScrren.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.PanelMenu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Interface
            // 
            this.Interface.Controls.Add(this.SendScreen);
            this.Interface.Controls.Add(this.MailScrren);
            this.Interface.Location = new System.Drawing.Point(-21, -28);
            this.Interface.Name = "Interface";
            this.Interface.SelectedIndex = 0;
            this.Interface.Size = new System.Drawing.Size(736, 803);
            this.Interface.TabIndex = 0;
            // 
            // SendScreen
            // 
            this.SendScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendScreen.Controls.Add(this.BtnSend);
            this.SendScreen.Controls.Add(this.panel5);
            this.SendScreen.Controls.Add(this.TextTittle);
            this.SendScreen.Controls.Add(this.panel4);
            this.SendScreen.Controls.Add(this.panel3);
            this.SendScreen.Controls.Add(this.panel2);
            this.SendScreen.Controls.Add(this.TextBuyer);
            this.SendScreen.Controls.Add(this.RichTextBody);
            this.SendScreen.Controls.Add(this.TextPassword);
            this.SendScreen.Controls.Add(this.TextSender);
            this.SendScreen.Controls.Add(this.PanelMenu);
            this.SendScreen.Controls.Add(this.label1);
            this.SendScreen.Location = new System.Drawing.Point(4, 22);
            this.SendScreen.Name = "SendScreen";
            this.SendScreen.Padding = new System.Windows.Forms.Padding(3);
            this.SendScreen.Size = new System.Drawing.Size(728, 777);
            this.SendScreen.TabIndex = 0;
            this.SendScreen.Text = "SendScreen";
            // 
            // MailScrren
            // 
            this.MailScrren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MailScrren.Controls.Add(this.BtnShow);
            this.MailScrren.Controls.Add(this.BtnMailDelete);
            this.MailScrren.Controls.Add(this.dataGridView1);
            this.MailScrren.Controls.Add(this.PanelMenu2);
            this.MailScrren.Controls.Add(this.label2);
            this.MailScrren.Location = new System.Drawing.Point(4, 22);
            this.MailScrren.Name = "MailScrren";
            this.MailScrren.Padding = new System.Windows.Forms.Padding(3);
            this.MailScrren.Size = new System.Drawing.Size(728, 777);
            this.MailScrren.TabIndex = 1;
            this.MailScrren.Text = "MailScreen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEND MAİL";
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.BtnMenu);
            this.PanelMenu.Controls.Add(this.BtnExit);
            this.PanelMenu.Controls.Add(this.BtnMailScreen);
            this.PanelMenu.Location = new System.Drawing.Point(621, 18);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(80, 240);
            this.PanelMenu.TabIndex = 1;
            // 
            // TimerPanelOpen
            // 
            this.TimerPanelOpen.Interval = 10;
            this.TimerPanelOpen.Tick += new System.EventHandler(this.TimerPanelOpen_Tick);
            // 
            // TimerPanelClose
            // 
            this.TimerPanelClose.Interval = 10;
            this.TimerPanelClose.Tick += new System.EventHandler(this.TimerPanelClose_Tick);
            // 
            // TextSender
            // 
            this.TextSender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextSender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextSender.Location = new System.Drawing.Point(151, 133);
            this.TextSender.Multiline = true;
            this.TextSender.Name = "TextSender";
            this.TextSender.Size = new System.Drawing.Size(373, 41);
            this.TextSender.TabIndex = 2;
            this.TextSender.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextSender_MouseDown);
            // 
            // TextPassword
            // 
            this.TextPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextPassword.Location = new System.Drawing.Point(151, 208);
            this.TextPassword.Multiline = true;
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(373, 41);
            this.TextPassword.TabIndex = 3;
            this.TextPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextPassword_MouseDown);
            // 
            // RichTextBody
            // 
            this.RichTextBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RichTextBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RichTextBody.ForeColor = System.Drawing.Color.White;
            this.RichTextBody.Location = new System.Drawing.Point(92, 474);
            this.RichTextBody.Name = "RichTextBody";
            this.RichTextBody.Size = new System.Drawing.Size(525, 200);
            this.RichTextBody.TabIndex = 4;
            this.RichTextBody.Text = "";
            this.RichTextBody.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RichTextBody_MouseDown);
            // 
            // TextBuyer
            // 
            this.TextBuyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBuyer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBuyer.Location = new System.Drawing.Point(151, 296);
            this.TextBuyer.Multiline = true;
            this.TextBuyer.Name = "TextBuyer";
            this.TextBuyer.Size = new System.Drawing.Size(373, 41);
            this.TextBuyer.TabIndex = 5;
            this.TextBuyer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBuyer_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(154, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 2);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(154, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 2);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(154, 330);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 2);
            this.panel4.TabIndex = 8;
            // 
            // TextTittle
            // 
            this.TextTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextTittle.Location = new System.Drawing.Point(154, 378);
            this.TextTittle.Multiline = true;
            this.TextTittle.Name = "TextTittle";
            this.TextTittle.Size = new System.Drawing.Size(373, 41);
            this.TextTittle.TabIndex = 9;
            this.TextTittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextTittle_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(154, 415);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(371, 2);
            this.panel5.TabIndex = 9;
            // 
            // BtnSend
            // 
            this.BtnSend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSend.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSend.ForeColor = System.Drawing.Color.White;
            this.BtnSend.Location = new System.Drawing.Point(207, 707);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(266, 34);
            this.BtnSend.TabIndex = 10;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "SHOW MAİL";
            // 
            // PanelMenu2
            // 
            this.PanelMenu2.Controls.Add(this.BtnMenu2);
            this.PanelMenu2.Controls.Add(this.BtnExit2);
            this.PanelMenu2.Controls.Add(this.BtnSendScreen);
            this.PanelMenu2.Location = new System.Drawing.Point(625, 18);
            this.PanelMenu2.Name = "PanelMenu2";
            this.PanelMenu2.Size = new System.Drawing.Size(80, 240);
            this.PanelMenu2.TabIndex = 2;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Image = global::SendMail.Properties.Resources.menu;
            this.BtnMenu.Location = new System.Drawing.Point(0, 160);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(80, 80);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = global::SendMail.Properties.Resources.log_out;
            this.BtnExit.Location = new System.Drawing.Point(0, 82);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(80, 80);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnMailScreen
            // 
            this.BtnMailScreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMailScreen.FlatAppearance.BorderSize = 0;
            this.BtnMailScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMailScreen.Image = global::SendMail.Properties.Resources.mail__1_;
            this.BtnMailScreen.Location = new System.Drawing.Point(0, 0);
            this.BtnMailScreen.Name = "BtnMailScreen";
            this.BtnMailScreen.Size = new System.Drawing.Size(80, 80);
            this.BtnMailScreen.TabIndex = 0;
            this.BtnMailScreen.UseVisualStyleBackColor = true;
            this.BtnMailScreen.Click += new System.EventHandler(this.BtnMailScreen_Click);
            // 
            // BtnMenu2
            // 
            this.BtnMenu2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMenu2.FlatAppearance.BorderSize = 0;
            this.BtnMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu2.Image = global::SendMail.Properties.Resources.menu;
            this.BtnMenu2.Location = new System.Drawing.Point(0, 160);
            this.BtnMenu2.Name = "BtnMenu2";
            this.BtnMenu2.Size = new System.Drawing.Size(80, 80);
            this.BtnMenu2.TabIndex = 2;
            this.BtnMenu2.UseVisualStyleBackColor = true;
            this.BtnMenu2.Click += new System.EventHandler(this.BtnMenu2_Click);
            // 
            // BtnExit2
            // 
            this.BtnExit2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnExit2.FlatAppearance.BorderSize = 0;
            this.BtnExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit2.Image = global::SendMail.Properties.Resources.log_out;
            this.BtnExit2.Location = new System.Drawing.Point(0, 86);
            this.BtnExit2.Name = "BtnExit2";
            this.BtnExit2.Size = new System.Drawing.Size(80, 80);
            this.BtnExit2.TabIndex = 1;
            this.BtnExit2.UseVisualStyleBackColor = true;
            this.BtnExit2.Click += new System.EventHandler(this.BtnExit2_Click);
            // 
            // BtnSendScreen
            // 
            this.BtnSendScreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSendScreen.FlatAppearance.BorderSize = 0;
            this.BtnSendScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSendScreen.Image = global::SendMail.Properties.Resources.paper_plane__1_;
            this.BtnSendScreen.Location = new System.Drawing.Point(0, 0);
            this.BtnSendScreen.Name = "BtnSendScreen";
            this.BtnSendScreen.Size = new System.Drawing.Size(80, 80);
            this.BtnSendScreen.TabIndex = 0;
            this.BtnSendScreen.UseVisualStyleBackColor = true;
            this.BtnSendScreen.Click += new System.EventHandler(this.BtnSendScreen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 281);
            this.dataGridView1.TabIndex = 3;
            // 
            // BtnMailDelete
            // 
            this.BtnMailDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMailDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMailDelete.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMailDelete.ForeColor = System.Drawing.Color.White;
            this.BtnMailDelete.Location = new System.Drawing.Point(41, 616);
            this.BtnMailDelete.Name = "BtnMailDelete";
            this.BtnMailDelete.Size = new System.Drawing.Size(266, 34);
            this.BtnMailDelete.TabIndex = 11;
            this.BtnMailDelete.Text = "Delete";
            this.BtnMailDelete.UseVisualStyleBackColor = true;
            this.BtnMailDelete.Click += new System.EventHandler(this.BtnMailDelete_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShow.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnShow.ForeColor = System.Drawing.Color.White;
            this.BtnShow.Location = new System.Drawing.Point(373, 616);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(266, 34);
            this.BtnShow.TabIndex = 12;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 760);
            this.Controls.Add(this.Interface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.Interface.ResumeLayout(false);
            this.SendScreen.ResumeLayout(false);
            this.SendScreen.PerformLayout();
            this.MailScrren.ResumeLayout(false);
            this.MailScrren.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Interface;
        private System.Windows.Forms.TabPage SendScreen;
        private System.Windows.Forms.TabPage MailScrren;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMailScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RichTextBody;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.TextBox TextSender;
        private System.Windows.Forms.Timer TimerPanelOpen;
        private System.Windows.Forms.Timer TimerPanelClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBuyer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TextTittle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Panel PanelMenu2;
        private System.Windows.Forms.Button BtnMenu2;
        private System.Windows.Forms.Button BtnExit2;
        private System.Windows.Forms.Button BtnSendScreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnMailDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

