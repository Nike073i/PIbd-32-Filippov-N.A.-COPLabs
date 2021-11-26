
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
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.groupBoxMessengerConnect = new System.Windows.Forms.GroupBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.groupBoxMessengerConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAvailablePlugin
            // 
            this.labelAvailablePlugin.AutoSize = true;
            this.labelAvailablePlugin.Location = new System.Drawing.Point(8, 23);
            this.labelAvailablePlugin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvailablePlugin.Name = "labelAvailablePlugin";
            this.labelAvailablePlugin.Size = new System.Drawing.Size(145, 17);
            this.labelAvailablePlugin.TabIndex = 0;
            this.labelAvailablePlugin.Text = "Доступные плагины:";
            // 
            // comboBoxAvailablePlugin
            // 
            this.comboBoxAvailablePlugin.FormattingEnabled = true;
            this.comboBoxAvailablePlugin.Location = new System.Drawing.Point(8, 43);
            this.comboBoxAvailablePlugin.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAvailablePlugin.Name = "comboBoxAvailablePlugin";
            this.comboBoxAvailablePlugin.Size = new System.Drawing.Size(265, 24);
            this.comboBoxAvailablePlugin.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(87, 122);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(121, 28);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(8, 73);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(70, 17);
            this.labelPhoneNumber.TabIndex = 4;
            this.labelPhoneNumber.Text = "Номер т.:";
            // 
            // groupBoxMessengerConnect
            // 
            this.groupBoxMessengerConnect.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxMessengerConnect.Controls.Add(this.labelPhoneNumber);
            this.groupBoxMessengerConnect.Controls.Add(this.buttonConnect);
            this.groupBoxMessengerConnect.Controls.Add(this.comboBoxAvailablePlugin);
            this.groupBoxMessengerConnect.Controls.Add(this.labelAvailablePlugin);
            this.groupBoxMessengerConnect.Location = new System.Drawing.Point(13, 13);
            this.groupBoxMessengerConnect.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMessengerConnect.Name = "groupBoxMessengerConnect";
            this.groupBoxMessengerConnect.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMessengerConnect.Size = new System.Drawing.Size(292, 171);
            this.groupBoxMessengerConnect.TabIndex = 5;
            this.groupBoxMessengerConnect.TabStop = false;
            this.groupBoxMessengerConnect.Text = "Подключение";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(8, 92);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(265, 22);
            this.textBoxPhoneNumber.TabIndex = 5;
            // 
            // FormMessengerPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 191);
            this.Controls.Add(this.groupBoxMessengerConnect);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMessengerPlugin";
            this.Text = "Мессенджер";
            this.Load += new System.EventHandler(this.FormMessengerPlugin_Load);
            this.groupBoxMessengerConnect.ResumeLayout(false);
            this.groupBoxMessengerConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAvailablePlugin;
        private System.Windows.Forms.ComboBox comboBoxAvailablePlugin;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.GroupBox groupBoxMessengerConnect;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
    }
}