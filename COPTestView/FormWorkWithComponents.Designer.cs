
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
            this.groupBoxContentPdf = new System.Windows.Forms.GroupBox();
            this.groupBoxTablePdf = new System.Windows.Forms.GroupBox();
            this.labelTableTitle = new System.Windows.Forms.Label();
            this.textBoxTableTitle = new System.Windows.Forms.TextBox();
            this.buttonCreateTablePdf = new System.Windows.Forms.Button();
            this.groupBoxDiagramPdf = new System.Windows.Forms.GroupBox();
            this.labelDiagramPdfDiagramName = new System.Windows.Forms.Label();
            this.textBoxDiagramPdfDiagramName = new System.Windows.Forms.TextBox();
            this.labelDiagramPdfDocTitle = new System.Windows.Forms.Label();
            this.textBoxDiagramPdfDocTitle = new System.Windows.Forms.TextBox();
            this.buttonCreateDiagramPdf = new System.Windows.Forms.Button();
            this.componentContextBigText = new ClassLibraryComponentsFilippov.ComponentContextBigText(this.components);
            this.componentTablePdf = new ClassLibraryComponentsFilippov.ComponentTablePdf(this.components);
            this.componentDiagramPdf = new ClassLibraryComponentsFilippov.ComponentDiagramPdf(this.components);
            this.groupBoxContentPdf.SuspendLayout();
            this.groupBoxTablePdf.SuspendLayout();
            this.groupBoxDiagramPdf.SuspendLayout();
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
            // groupBoxContentPdf
            // 
            this.groupBoxContentPdf.Controls.Add(this.labelContentTitle);
            this.groupBoxContentPdf.Controls.Add(this.labelContentText);
            this.groupBoxContentPdf.Controls.Add(this.textBoxContextTitle);
            this.groupBoxContentPdf.Controls.Add(this.buttonCreatePdfContext);
            this.groupBoxContentPdf.Controls.Add(this.textBoxContextText);
            this.groupBoxContentPdf.Location = new System.Drawing.Point(12, 12);
            this.groupBoxContentPdf.Name = "groupBoxContentPdf";
            this.groupBoxContentPdf.Size = new System.Drawing.Size(263, 264);
            this.groupBoxContentPdf.TabIndex = 5;
            this.groupBoxContentPdf.TabStop = false;
            this.groupBoxContentPdf.Text = "Тест компонента с контентом";
            // 
            // groupBoxTablePdf
            // 
            this.groupBoxTablePdf.Controls.Add(this.labelTableTitle);
            this.groupBoxTablePdf.Controls.Add(this.textBoxTableTitle);
            this.groupBoxTablePdf.Controls.Add(this.buttonCreateTablePdf);
            this.groupBoxTablePdf.Location = new System.Drawing.Point(291, 12);
            this.groupBoxTablePdf.Name = "groupBoxTablePdf";
            this.groupBoxTablePdf.Size = new System.Drawing.Size(263, 109);
            this.groupBoxTablePdf.TabIndex = 6;
            this.groupBoxTablePdf.TabStop = false;
            this.groupBoxTablePdf.Text = "Тест компонента с таблицей";
            // 
            // labelTableTitle
            // 
            this.labelTableTitle.AutoSize = true;
            this.labelTableTitle.Location = new System.Drawing.Point(6, 23);
            this.labelTableTitle.Name = "labelTableTitle";
            this.labelTableTitle.Size = new System.Drawing.Size(64, 13);
            this.labelTableTitle.TabIndex = 4;
            this.labelTableTitle.Text = "Заголовок:";
            // 
            // textBoxTableTitle
            // 
            this.textBoxTableTitle.Location = new System.Drawing.Point(6, 39);
            this.textBoxTableTitle.Name = "textBoxTableTitle";
            this.textBoxTableTitle.Size = new System.Drawing.Size(251, 20);
            this.textBoxTableTitle.TabIndex = 2;
            // 
            // buttonCreateTablePdf
            // 
            this.buttonCreateTablePdf.Location = new System.Drawing.Point(78, 65);
            this.buttonCreateTablePdf.Name = "buttonCreateTablePdf";
            this.buttonCreateTablePdf.Size = new System.Drawing.Size(108, 29);
            this.buttonCreateTablePdf.TabIndex = 1;
            this.buttonCreateTablePdf.Text = "Создать pdf";
            this.buttonCreateTablePdf.UseVisualStyleBackColor = true;
            this.buttonCreateTablePdf.Click += new System.EventHandler(this.buttonCreateTablePdf_Click);
            // 
            // groupBoxDiagramPdf
            // 
            this.groupBoxDiagramPdf.Controls.Add(this.labelDiagramPdfDiagramName);
            this.groupBoxDiagramPdf.Controls.Add(this.textBoxDiagramPdfDiagramName);
            this.groupBoxDiagramPdf.Controls.Add(this.labelDiagramPdfDocTitle);
            this.groupBoxDiagramPdf.Controls.Add(this.textBoxDiagramPdfDocTitle);
            this.groupBoxDiagramPdf.Controls.Add(this.buttonCreateDiagramPdf);
            this.groupBoxDiagramPdf.Location = new System.Drawing.Point(288, 127);
            this.groupBoxDiagramPdf.Name = "groupBoxDiagramPdf";
            this.groupBoxDiagramPdf.Size = new System.Drawing.Size(263, 149);
            this.groupBoxDiagramPdf.TabIndex = 7;
            this.groupBoxDiagramPdf.TabStop = false;
            this.groupBoxDiagramPdf.Text = "Тест компонента с диаграммой";
            // 
            // labelDiagramPdfDiagramName
            // 
            this.labelDiagramPdfDiagramName.AutoSize = true;
            this.labelDiagramPdfDiagramName.Location = new System.Drawing.Point(6, 65);
            this.labelDiagramPdfDiagramName.Name = "labelDiagramPdfDiagramName";
            this.labelDiagramPdfDiagramName.Size = new System.Drawing.Size(126, 13);
            this.labelDiagramPdfDiagramName.TabIndex = 6;
            this.labelDiagramPdfDiagramName.Text = "Заголовок диаграммы:";
            // 
            // textBoxDiagramPdfDiagramName
            // 
            this.textBoxDiagramPdfDiagramName.Location = new System.Drawing.Point(6, 81);
            this.textBoxDiagramPdfDiagramName.Name = "textBoxDiagramPdfDiagramName";
            this.textBoxDiagramPdfDiagramName.Size = new System.Drawing.Size(251, 20);
            this.textBoxDiagramPdfDiagramName.TabIndex = 5;
            // 
            // labelDiagramPdfDocTitle
            // 
            this.labelDiagramPdfDocTitle.AutoSize = true;
            this.labelDiagramPdfDocTitle.Location = new System.Drawing.Point(6, 23);
            this.labelDiagramPdfDocTitle.Name = "labelDiagramPdfDocTitle";
            this.labelDiagramPdfDocTitle.Size = new System.Drawing.Size(130, 13);
            this.labelDiagramPdfDocTitle.TabIndex = 4;
            this.labelDiagramPdfDocTitle.Text = "Заголовок в документе:";
            // 
            // textBoxDiagramPdfDocTitle
            // 
            this.textBoxDiagramPdfDocTitle.Location = new System.Drawing.Point(6, 39);
            this.textBoxDiagramPdfDocTitle.Name = "textBoxDiagramPdfDocTitle";
            this.textBoxDiagramPdfDocTitle.Size = new System.Drawing.Size(251, 20);
            this.textBoxDiagramPdfDocTitle.TabIndex = 2;
            // 
            // buttonCreateDiagramPdf
            // 
            this.buttonCreateDiagramPdf.Location = new System.Drawing.Point(71, 107);
            this.buttonCreateDiagramPdf.Name = "buttonCreateDiagramPdf";
            this.buttonCreateDiagramPdf.Size = new System.Drawing.Size(108, 29);
            this.buttonCreateDiagramPdf.TabIndex = 1;
            this.buttonCreateDiagramPdf.Text = "Создать pdf";
            this.buttonCreateDiagramPdf.UseVisualStyleBackColor = true;
            this.buttonCreateDiagramPdf.Click += new System.EventHandler(this.buttonCreateDiagramPdf_Click);
            // 
            // FormWorkWithComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 289);
            this.Controls.Add(this.groupBoxDiagramPdf);
            this.Controls.Add(this.groupBoxTablePdf);
            this.Controls.Add(this.groupBoxContentPdf);
            this.Name = "FormWorkWithComponents";
            this.Text = "Тестовое окно";
            this.groupBoxContentPdf.ResumeLayout(false);
            this.groupBoxContentPdf.PerformLayout();
            this.groupBoxTablePdf.ResumeLayout(false);
            this.groupBoxTablePdf.PerformLayout();
            this.groupBoxDiagramPdf.ResumeLayout(false);
            this.groupBoxDiagramPdf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContextText;
        private System.Windows.Forms.Button buttonCreatePdfContext;
        private System.Windows.Forms.TextBox textBoxContextTitle;
        private System.Windows.Forms.Label labelContentText;
        private System.Windows.Forms.Label labelContentTitle;
        private System.Windows.Forms.GroupBox groupBoxContentPdf;
        private ClassLibraryComponentsFilippov.ComponentContextBigText componentContextBigText;
        private System.Windows.Forms.GroupBox groupBoxTablePdf;
        private System.Windows.Forms.Label labelTableTitle;
        private System.Windows.Forms.TextBox textBoxTableTitle;
        private System.Windows.Forms.Button buttonCreateTablePdf;
        private ClassLibraryComponentsFilippov.ComponentTablePdf componentTablePdf;
        private System.Windows.Forms.GroupBox groupBoxDiagramPdf;
        private System.Windows.Forms.Label labelDiagramPdfDocTitle;
        private System.Windows.Forms.TextBox textBoxDiagramPdfDocTitle;
        private System.Windows.Forms.Button buttonCreateDiagramPdf;
        private System.Windows.Forms.Label labelDiagramPdfDiagramName;
        private System.Windows.Forms.TextBox textBoxDiagramPdfDiagramName;
        private ClassLibraryComponentsFilippov.ComponentDiagramPdf componentDiagramPdf;
    }
}