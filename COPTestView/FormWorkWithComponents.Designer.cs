
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.componentTablePdf1 = new ClassLibraryComponentsFilippov.ComponentTablePdf(this.components);
            this.groupBoxPdfContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(396, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 264);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тест компонента с контентом";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Заголовок:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текст:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Создать pdf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 78);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 138);
            this.textBox2.TabIndex = 0;
            // 
            // FormWorkWithComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxPdfContent);
            this.Name = "FormWorkWithComponents";
            this.Text = "Тестовое окно";
            this.groupBoxPdfContent.ResumeLayout(false);
            this.groupBoxPdfContent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private ClassLibraryComponentsFilippov.ComponentTablePdf componentTablePdf1;
    }
}