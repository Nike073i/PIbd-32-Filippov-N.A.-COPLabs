
namespace TelegramMessengerPlugin
{
    partial class FormDialogCode
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
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonCancele = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(13, 9);
            this.labelCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(144, 17);
            this.labelCode.TabIndex = 11;
            this.labelCode.Text = "Код подтверждения:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(17, 28);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(398, 22);
            this.textBoxCode.TabIndex = 10;
            // 
            // buttonCancele
            // 
            this.buttonCancele.Location = new System.Drawing.Point(315, 58);
            this.buttonCancele.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancele.Name = "buttonCancele";
            this.buttonCancele.Size = new System.Drawing.Size(100, 28);
            this.buttonCancele.TabIndex = 9;
            this.buttonCancele.Text = "Отмена";
            this.buttonCancele.UseVisualStyleBackColor = true;
            this.buttonCancele.Click += new System.EventHandler(this.buttonCancele_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(207, 58);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 28);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // FormDialogCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 101);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.buttonCancele);
            this.Controls.Add(this.buttonSend);
            this.Name = "FormDialogCode";
            this.Text = "Подтверждение подключения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonCancele;
        private System.Windows.Forms.Button buttonSend;
    }
}