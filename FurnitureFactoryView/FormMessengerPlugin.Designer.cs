
namespace FurnitureFactoryView
{
    partial class FormMessengerPlugin
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
            this.labelAvailablePlugin = new System.Windows.Forms.Label();
            this.comboBoxAvailablePlugin = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBoxMessenger = new System.Windows.Forms.GroupBox();
            this.labelRecipients = new System.Windows.Forms.Label();
            this.listBoxRecipients = new System.Windows.Forms.ListBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.groupBoxMessengerConnect = new System.Windows.Forms.GroupBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.groupBoxMessenger.SuspendLayout();
            this.groupBoxMessengerConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAvailablePlugin
            // 
            this.labelAvailablePlugin.AutoSize = true;
            this.labelAvailablePlugin.Location = new System.Drawing.Point(6, 19);
            this.labelAvailablePlugin.Name = "labelAvailablePlugin";
            this.labelAvailablePlugin.Size = new System.Drawing.Size(113, 13);
            this.labelAvailablePlugin.TabIndex = 0;
            this.labelAvailablePlugin.Text = "Доступные плагины:";
            // 
            // comboBoxAvailablePlugin
            // 
            this.comboBoxAvailablePlugin.FormattingEnabled = true;
            this.comboBoxAvailablePlugin.Location = new System.Drawing.Point(6, 35);
            this.comboBoxAvailablePlugin.Name = "comboBoxAvailablePlugin";
            this.comboBoxAvailablePlugin.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAvailablePlugin.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(6, 101);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(91, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBoxMessenger
            // 
            this.groupBoxMessenger.Controls.Add(this.labelRecipients);
            this.groupBoxMessenger.Controls.Add(this.listBoxRecipients);
            this.groupBoxMessenger.Controls.Add(this.labelMessage);
            this.groupBoxMessenger.Controls.Add(this.textBoxMessage);
            this.groupBoxMessenger.Controls.Add(this.buttonSend);
            this.groupBoxMessenger.Enabled = false;
            this.groupBoxMessenger.Location = new System.Drawing.Point(12, 157);
            this.groupBoxMessenger.Name = "groupBoxMessenger";
            this.groupBoxMessenger.Size = new System.Drawing.Size(550, 290);
            this.groupBoxMessenger.TabIndex = 3;
            this.groupBoxMessenger.TabStop = false;
            this.groupBoxMessenger.Text = "Мессенджер";
            // 
            // labelRecipients
            // 
            this.labelRecipients.AutoSize = true;
            this.labelRecipients.Location = new System.Drawing.Point(6, 30);
            this.labelRecipients.Name = "labelRecipients";
            this.labelRecipients.Size = new System.Drawing.Size(69, 13);
            this.labelRecipients.TabIndex = 6;
            this.labelRecipients.Text = "Получатели:";
            // 
            // listBoxRecipients
            // 
            this.listBoxRecipients.FormattingEnabled = true;
            this.listBoxRecipients.Location = new System.Drawing.Point(9, 46);
            this.listBoxRecipients.Name = "listBoxRecipients";
            this.listBoxRecipients.Size = new System.Drawing.Size(120, 212);
            this.listBoxRecipients.TabIndex = 5;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(142, 30);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(68, 13);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "Сообщение:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(145, 46);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(399, 209);
            this.textBoxMessage.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(469, 261);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(6, 59);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(55, 13);
            this.labelPhoneNumber.TabIndex = 4;
            this.labelPhoneNumber.Text = "Номер т.:";
            // 
            // groupBoxMessengerConnect
            // 
            this.groupBoxMessengerConnect.Controls.Add(this.buttonDisconnect);
            this.groupBoxMessengerConnect.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxMessengerConnect.Controls.Add(this.labelPhoneNumber);
            this.groupBoxMessengerConnect.Controls.Add(this.buttonConnect);
            this.groupBoxMessengerConnect.Controls.Add(this.comboBoxAvailablePlugin);
            this.groupBoxMessengerConnect.Controls.Add(this.labelAvailablePlugin);
            this.groupBoxMessengerConnect.Location = new System.Drawing.Point(177, 12);
            this.groupBoxMessengerConnect.Name = "groupBoxMessengerConnect";
            this.groupBoxMessengerConnect.Size = new System.Drawing.Size(219, 140);
            this.groupBoxMessengerConnect.TabIndex = 5;
            this.groupBoxMessengerConnect.TabStop = false;
            this.groupBoxMessengerConnect.Text = "Подключение";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(115, 101);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(91, 23);
            this.buttonDisconnect.TabIndex = 6;
            this.buttonDisconnect.Text = "Отключиться";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(6, 75);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.textBoxPhoneNumber.TabIndex = 5;
            // 
            // FormMessengerPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 459);
            this.Controls.Add(this.groupBoxMessengerConnect);
            this.Controls.Add(this.groupBoxMessenger);
            this.Name = "FormMessengerPlugin";
            this.Text = "Мессенджер";
            this.Load += new System.EventHandler(this.FormMessengerPlugin_Load);
            this.groupBoxMessenger.ResumeLayout(false);
            this.groupBoxMessenger.PerformLayout();
            this.groupBoxMessengerConnect.ResumeLayout(false);
            this.groupBoxMessengerConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAvailablePlugin;
        private System.Windows.Forms.ComboBox comboBoxAvailablePlugin;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBoxMessenger;
        private System.Windows.Forms.Label labelRecipients;
        private System.Windows.Forms.ListBox listBoxRecipients;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.GroupBox groupBoxMessengerConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
    }
}