
namespace FurnitureFactoryView
{
    partial class FormReportPlugin
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
            this.comboBoxAvailablePlugins = new System.Windows.Forms.ComboBox();
            this.labelAvailablePlugins = new System.Windows.Forms.Label();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAvailablePlugins
            // 
            this.comboBoxAvailablePlugins.FormattingEnabled = true;
            this.comboBoxAvailablePlugins.Location = new System.Drawing.Point(12, 37);
            this.comboBoxAvailablePlugins.Name = "comboBoxAvailablePlugins";
            this.comboBoxAvailablePlugins.Size = new System.Drawing.Size(199, 21);
            this.comboBoxAvailablePlugins.TabIndex = 0;
            // 
            // labelAvailablePlugins
            // 
            this.labelAvailablePlugins.AutoSize = true;
            this.labelAvailablePlugins.Location = new System.Drawing.Point(9, 21);
            this.labelAvailablePlugins.Name = "labelAvailablePlugins";
            this.labelAvailablePlugins.Size = new System.Drawing.Size(113, 13);
            this.labelAvailablePlugins.TabIndex = 1;
            this.labelAvailablePlugins.Text = "Доступные плагины:";
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Location = new System.Drawing.Point(54, 75);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(114, 23);
            this.buttonCreateReport.TabIndex = 2;
            this.buttonCreateReport.Text = "Создать отчет";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // FormReportPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 119);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.labelAvailablePlugins);
            this.Controls.Add(this.comboBoxAvailablePlugins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormReportPlugin";
            this.Text = "Плагины отчетов";
            this.Load += new System.EventHandler(this.FormReportPlugin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAvailablePlugins;
        private System.Windows.Forms.Label labelAvailablePlugins;
        private System.Windows.Forms.Button buttonCreateReport;
    }
}