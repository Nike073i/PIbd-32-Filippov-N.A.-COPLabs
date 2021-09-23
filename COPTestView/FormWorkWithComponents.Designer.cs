
namespace COPTestView
{
    partial class FormWorkWithComponents
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
            this.textBoxContextText = new System.Windows.Forms.TextBox();
            this.buttonCreatePdfContext = new System.Windows.Forms.Button();
            this.textBoxContextTitle = new System.Windows.Forms.TextBox();
            this.labelContentText = new System.Windows.Forms.Label();
            this.labelContentTitle = new System.Windows.Forms.Label();
            this.groupBoxPdfContent = new System.Windows.Forms.GroupBox();
            this.componentContextBigText = new ClassLibraryComponentsFilippov.ComponentContextBigText(this.components);
            this.groupBoxPdfContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxContextText
            // 
            this.textBoxContextText.Location = new System.Drawing.Point(6, 78);
            this.textBoxContextText.Multiline = true;
            this.textBoxContextText.Name = "textBoxContextText";
            this.textBoxContextText.Size = new System.Drawing.Size(251, 138);
            this.textBoxContextText.TabIndex = 0;
            // 
            // buttonCreatePdfContext
            // 
            this.buttonCreatePdfContext.Location = new System.Drawing.Point(79, 222);
            this.buttonCreatePdfContext.Name = "buttonCreatePdfContext";
            this.buttonCreatePdfContext.Size = new System.Drawing.Size(108, 29);
            this.buttonCreatePdfContext.TabIndex = 1;
            this.buttonCreatePdfContext.Text = "Создать pdf";
            this.buttonCreatePdfContext.UseVisualStyleBackColor = true;
            this.buttonCreatePdfContext.Click += new System.EventHandler(this.buttonCreatePdfContext_Click);
            // 
            // textBoxContextTitle
            // 
            this.textBoxContextTitle.Location = new System.Drawing.Point(6, 39);
            this.textBoxContextTitle.Name = "textBoxContextTitle";
            this.textBoxContextTitle.Size = new System.Drawing.Size(251, 20);
            this.textBoxContextTitle.TabIndex = 2;
            // 
            // labelContentText
            // 
            this.labelContentText.AutoSize = true;
            this.labelContentText.Location = new System.Drawing.Point(6, 62);
            this.labelContentText.Name = "labelContentText";
            this.labelContentText.Size = new System.Drawing.Size(40, 13);
            this.labelContentText.TabIndex = 3;
            this.labelContentText.Text = "Текст:";
            // 
            // labelContentTitle
            // 
            this.labelContentTitle.AutoSize = true;
            this.labelContentTitle.Location = new System.Drawing.Point(6, 23);
            this.labelContentTitle.Name = "labelContentTitle";
            this.labelContentTitle.Size = new System.Drawing.Size(64, 13);
            this.labelContentTitle.TabIndex = 4;
            this.labelContentTitle.Text = "Заголовок:";
            // 
            // groupBoxPdfContent
            // 
            this.groupBoxPdfContent.Controls.Add(this.labelContentTitle);
            this.groupBoxPdfContent.Controls.Add(this.labelContentText);
            this.groupBoxPdfContent.Controls.Add(this.textBoxContextTitle);
            this.groupBoxPdfContent.Controls.Add(this.buttonCreatePdfContext);
            this.groupBoxPdfContent.Controls.Add(this.textBoxContextText);
            this.groupBoxPdfContent.Location = new System.Drawing.Point(64, 52);
            this.groupBoxPdfContent.Name = "groupBoxPdfContent";
            this.groupBoxPdfContent.Size = new System.Drawing.Size(263, 264);
            this.groupBoxPdfContent.TabIndex = 5;
            this.groupBoxPdfContent.TabStop = false;
            this.groupBoxPdfContent.Text = "Тест компонента с контентом";
            // 
            // FormWorkWithComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxPdfContent);
            this.Name = "FormWorkWithComponents";
            this.Text = "Тестовое окно";
            this.groupBoxPdfContent.ResumeLayout(false);
            this.groupBoxPdfContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContextText;
        private System.Windows.Forms.Button buttonCreatePdfContext;
        private System.Windows.Forms.TextBox textBoxContextTitle;
        private System.Windows.Forms.Label labelContentText;
        private System.Windows.Forms.Label labelContentTitle;
        private System.Windows.Forms.GroupBox groupBoxPdfContent;
        private ClassLibraryComponentsFilippov.ComponentContextBigText componentContextBigText;
    }
}