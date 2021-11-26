
namespace TelegramMessengerPlugin
{
    partial class FormTelegramMessenger
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
            this.groupBoxMessenger = new System.Windows.Forms.GroupBox();
            this.labelRecipients = new System.Windows.Forms.Label();
            this.listBoxRecipients = new System.Windows.Forms.ListBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBoxMessenger.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMessenger
            // 
            this.groupBoxMessenger.Controls.Add(this.labelRecipients);
            this.groupBoxMessenger.Controls.Add(this.listBoxRecipients);
            this.groupBoxMessenger.Controls.Add(this.labelMessage);
            this.groupBoxMessenger.Controls.Add(this.textBoxMessage);
            this.groupBoxMessenger.Controls.Add(this.buttonSend);
            this.groupBoxMessenger.Location = new System.Drawing.Point(13, 13);
            this.groupBoxMessenger.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMessenger.Name = "groupBoxMessenger";
            this.groupBoxMessenger.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMessenger.Size = new System.Drawing.Size(745, 360);
            this.groupBoxMessenger.TabIndex = 5;
            this.groupBoxMessenger.TabStop = false;
            this.groupBoxMessenger.Text = "Мессенджер";
            // 
            // labelRecipients
            // 
            this.labelRecipients.AutoSize = true;
            this.labelRecipients.Location = new System.Drawing.Point(8, 37);
            this.labelRecipients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecipients.Name = "labelRecipients";
            this.labelRecipients.Size = new System.Drawing.Size(92, 17);
            this.labelRecipients.TabIndex = 6;
            this.labelRecipients.Text = "Получатели:";
            // 
            // listBoxRecipients
            // 
            this.listBoxRecipients.FormattingEnabled = true;
            this.listBoxRecipients.ItemHeight = 16;
            this.listBoxRecipients.Location = new System.Drawing.Point(12, 57);
            this.listBoxRecipients.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxRecipients.Name = "listBoxRecipients";
            this.listBoxRecipients.Size = new System.Drawing.Size(159, 260);
            this.listBoxRecipients.TabIndex = 5;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(189, 37);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(88, 17);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "Сообщение:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(193, 57);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(531, 256);
            this.textBoxMessage.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(625, 321);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 28);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // FormTelegramMessenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 382);
            this.Controls.Add(this.groupBoxMessenger);
            this.Name = "FormTelegramMessenger";
            this.Text = "Телеграм мессенджер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTelegramMessenger_FormClosed);
            this.Load += new System.EventHandler(this.FormTelegramMessenger_Load);
            this.groupBoxMessenger.ResumeLayout(false);
            this.groupBoxMessenger.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMessenger;
        private System.Windows.Forms.Label labelRecipients;
        private System.Windows.Forms.ListBox listBoxRecipients;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
    }
}