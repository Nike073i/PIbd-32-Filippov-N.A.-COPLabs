
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
            this.groupBoxWorkWithList = new System.Windows.Forms.GroupBox();
            this.buttonListAdd = new System.Windows.Forms.Button();
            this.labelPropertyValue = new System.Windows.Forms.Label();
            this.textBoxPropertyValue = new System.Windows.Forms.TextBox();
            this.labelPropertyName = new System.Windows.Forms.Label();
            this.textBoxPropertyName = new System.Windows.Forms.TextBox();
            this.labelRowIndex = new System.Windows.Forms.Label();
            this.textBoxRowIndex = new System.Windows.Forms.TextBox();
            this.groupBoxSaveXML = new System.Windows.Forms.GroupBox();
            this.buttonSaveXml = new System.Windows.Forms.Button();
            this.groupBoxExcelReport = new System.Windows.Forms.GroupBox();
            this.checkBoxHorizontalOrientation = new System.Windows.Forms.CheckBox();
            this.buttonCreateExcelReport = new System.Windows.Forms.Button();
            this.groupBoхPdfDiagram = new System.Windows.Forms.GroupBox();
            this.labelPropertyNamePdf = new System.Windows.Forms.Label();
            this.textBoxPropertyNamePdf = new System.Windows.Forms.TextBox();
            this.buttonCreateDiagram = new System.Windows.Forms.Button();
            this.controlOutputlListBox = new ClassLibraryControlsFilippov.ControlOutputlListBox();
            this.componentSaveDataXmlTest = new ClasslLibraryComponentsFilippov.ComponentSaveDataXml(this.components);
            this.componentExcelReport = new ClasslLibraryComponentsFilippov.ComponentExcelReport(this.components);
            this.componentPdfDiagram = new ClasslLibraryComponentsFilippov.ComponentPdfDiagram(this.components);
            this.groupBoxWorkWithList.SuspendLayout();
            this.groupBoxSaveXML.SuspendLayout();
            this.groupBoxExcelReport.SuspendLayout();
            this.groupBoхPdfDiagram.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxWorkWithList
            // 
            this.groupBoxWorkWithList.Controls.Add(this.buttonListAdd);
            this.groupBoxWorkWithList.Controls.Add(this.labelPropertyValue);
            this.groupBoxWorkWithList.Controls.Add(this.textBoxPropertyValue);
            this.groupBoxWorkWithList.Controls.Add(this.labelPropertyName);
            this.groupBoxWorkWithList.Controls.Add(this.textBoxPropertyName);
            this.groupBoxWorkWithList.Controls.Add(this.labelRowIndex);
            this.groupBoxWorkWithList.Controls.Add(this.textBoxRowIndex);
            this.groupBoxWorkWithList.Controls.Add(this.controlOutputlListBox);
            this.groupBoxWorkWithList.Location = new System.Drawing.Point(12, 12);
            this.groupBoxWorkWithList.Name = "groupBoxWorkWithList";
            this.groupBoxWorkWithList.Size = new System.Drawing.Size(696, 245);
            this.groupBoxWorkWithList.TabIndex = 0;
            this.groupBoxWorkWithList.TabStop = false;
            this.groupBoxWorkWithList.Text = "Работа с данными";
            // 
            // buttonListAdd
            // 
            this.buttonListAdd.Location = new System.Drawing.Point(16, 180);
            this.buttonListAdd.Name = "buttonListAdd";
            this.buttonListAdd.Size = new System.Drawing.Size(361, 23);
            this.buttonListAdd.TabIndex = 14;
            this.buttonListAdd.Text = "Вставить";
            this.buttonListAdd.UseVisualStyleBackColor = true;
            this.buttonListAdd.Click += new System.EventHandler(this.buttonListInsert_Click);
            // 
            // labelPropertyValue
            // 
            this.labelPropertyValue.AutoSize = true;
            this.labelPropertyValue.Location = new System.Drawing.Point(13, 131);
            this.labelPropertyValue.Name = "labelPropertyValue";
            this.labelPropertyValue.Size = new System.Drawing.Size(105, 13);
            this.labelPropertyValue.TabIndex = 13;
            this.labelPropertyValue.Text = "Значение свойства";
            // 
            // textBoxPropertyValue
            // 
            this.textBoxPropertyValue.Location = new System.Drawing.Point(16, 152);
            this.textBoxPropertyValue.Name = "textBoxPropertyValue";
            this.textBoxPropertyValue.Size = new System.Drawing.Size(361, 20);
            this.textBoxPropertyValue.TabIndex = 12;
            // 
            // labelPropertyName
            // 
            this.labelPropertyName.AutoSize = true;
            this.labelPropertyName.Location = new System.Drawing.Point(13, 81);
            this.labelPropertyName.Name = "labelPropertyName";
            this.labelPropertyName.Size = new System.Drawing.Size(107, 13);
            this.labelPropertyName.TabIndex = 11;
            this.labelPropertyName.Text = "Название свойства";
            // 
            // textBoxPropertyName
            // 
            this.textBoxPropertyName.Location = new System.Drawing.Point(16, 102);
            this.textBoxPropertyName.Name = "textBoxPropertyName";
            this.textBoxPropertyName.Size = new System.Drawing.Size(361, 20);
            this.textBoxPropertyName.TabIndex = 10;
            // 
            // labelRowIndex
            // 
            this.labelRowIndex.AutoSize = true;
            this.labelRowIndex.Location = new System.Drawing.Point(13, 32);
            this.labelRowIndex.Name = "labelRowIndex";
            this.labelRowIndex.Size = new System.Drawing.Size(83, 13);
            this.labelRowIndex.TabIndex = 9;
            this.labelRowIndex.Text = "Индекс строки";
            // 
            // textBoxRowIndex
            // 
            this.textBoxRowIndex.Location = new System.Drawing.Point(16, 53);
            this.textBoxRowIndex.Name = "textBoxRowIndex";
            this.textBoxRowIndex.Size = new System.Drawing.Size(361, 20);
            this.textBoxRowIndex.TabIndex = 8;
            // 
            // groupBoxSaveXML
            // 
            this.groupBoxSaveXML.Controls.Add(this.buttonSaveXml);
            this.groupBoxSaveXML.Location = new System.Drawing.Point(10, 278);
            this.groupBoxSaveXML.Name = "groupBoxSaveXML";
            this.groupBoxSaveXML.Size = new System.Drawing.Size(217, 120);
            this.groupBoxSaveXML.TabIndex = 1;
            this.groupBoxSaveXML.TabStop = false;
            this.groupBoxSaveXML.Text = "Сохранение данных в XML";
            // 
            // buttonSaveXml
            // 
            this.buttonSaveXml.Location = new System.Drawing.Point(46, 73);
            this.buttonSaveXml.Name = "buttonSaveXml";
            this.buttonSaveXml.Size = new System.Drawing.Size(114, 34);
            this.buttonSaveXml.TabIndex = 16;
            this.buttonSaveXml.Text = "Сохранить в Xml";
            this.buttonSaveXml.UseVisualStyleBackColor = true;
            this.buttonSaveXml.Click += new System.EventHandler(this.buttonSaveXml_Click);
            // 
            // groupBoxExcelReport
            // 
            this.groupBoxExcelReport.Controls.Add(this.checkBoxHorizontalOrientation);
            this.groupBoxExcelReport.Controls.Add(this.buttonCreateExcelReport);
            this.groupBoxExcelReport.Location = new System.Drawing.Point(243, 278);
            this.groupBoxExcelReport.Name = "groupBoxExcelReport";
            this.groupBoxExcelReport.Size = new System.Drawing.Size(217, 120);
            this.groupBoxExcelReport.TabIndex = 17;
            this.groupBoxExcelReport.TabStop = false;
            this.groupBoxExcelReport.Text = "Отчет Excel";
            // 
            // checkBoxHorizontalOrientation
            // 
            this.checkBoxHorizontalOrientation.AutoSize = true;
            this.checkBoxHorizontalOrientation.Checked = true;
            this.checkBoxHorizontalOrientation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHorizontalOrientation.Location = new System.Drawing.Point(6, 23);
            this.checkBoxHorizontalOrientation.Name = "checkBoxHorizontalOrientation";
            this.checkBoxHorizontalOrientation.Size = new System.Drawing.Size(144, 17);
            this.checkBoxHorizontalOrientation.TabIndex = 17;
            this.checkBoxHorizontalOrientation.Text = "Горизонтальная шапка";
            this.checkBoxHorizontalOrientation.UseVisualStyleBackColor = true;
            // 
            // buttonCreateExcelReport
            // 
            this.buttonCreateExcelReport.Location = new System.Drawing.Point(47, 73);
            this.buttonCreateExcelReport.Name = "buttonCreateExcelReport";
            this.buttonCreateExcelReport.Size = new System.Drawing.Size(114, 34);
            this.buttonCreateExcelReport.TabIndex = 16;
            this.buttonCreateExcelReport.Text = "Создать отчет";
            this.buttonCreateExcelReport.UseVisualStyleBackColor = true;
            this.buttonCreateExcelReport.Click += new System.EventHandler(this.buttonCreateExcelReport_Click);
            // 
            // groupBoхPdfDiagram
            // 
            this.groupBoхPdfDiagram.Controls.Add(this.labelPropertyNamePdf);
            this.groupBoхPdfDiagram.Controls.Add(this.textBoxPropertyNamePdf);
            this.groupBoхPdfDiagram.Controls.Add(this.buttonCreateDiagram);
            this.groupBoхPdfDiagram.Location = new System.Drawing.Point(475, 278);
            this.groupBoхPdfDiagram.Name = "groupBoхPdfDiagram";
            this.groupBoхPdfDiagram.Size = new System.Drawing.Size(228, 120);
            this.groupBoхPdfDiagram.TabIndex = 17;
            this.groupBoхPdfDiagram.TabStop = false;
            this.groupBoхPdfDiagram.Text = "Диаграмма в Pdf";
            // 
            // labelPropertyNamePdf
            // 
            this.labelPropertyNamePdf.AutoSize = true;
            this.labelPropertyNamePdf.Location = new System.Drawing.Point(3, 23);
            this.labelPropertyNamePdf.Name = "labelPropertyNamePdf";
            this.labelPropertyNamePdf.Size = new System.Drawing.Size(107, 13);
            this.labelPropertyNamePdf.TabIndex = 18;
            this.labelPropertyNamePdf.Text = "Название свойства";
            // 
            // textBoxPropertyNamePdf
            // 
            this.textBoxPropertyNamePdf.Location = new System.Drawing.Point(6, 44);
            this.textBoxPropertyNamePdf.Name = "textBoxPropertyNamePdf";
            this.textBoxPropertyNamePdf.Size = new System.Drawing.Size(200, 20);
            this.textBoxPropertyNamePdf.TabIndex = 17;
            // 
            // buttonCreateDiagram
            // 
            this.buttonCreateDiagram.Location = new System.Drawing.Point(50, 73);
            this.buttonCreateDiagram.Name = "buttonCreateDiagram";
            this.buttonCreateDiagram.Size = new System.Drawing.Size(131, 34);
            this.buttonCreateDiagram.TabIndex = 16;
            this.buttonCreateDiagram.Text = "Создать диаграмму";
            this.buttonCreateDiagram.UseVisualStyleBackColor = true;
            this.buttonCreateDiagram.Click += new System.EventHandler(this.buttonCreateDiagram_Click);
            // 
            // controlOutputlListBox
            // 
            this.controlOutputlListBox.Location = new System.Drawing.Point(400, 18);
            this.controlOutputlListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlOutputlListBox.Name = "controlOutputlListBox";
            this.controlOutputlListBox.SelectedIndex = -1;
            this.controlOutputlListBox.Size = new System.Drawing.Size(291, 222);
            this.controlOutputlListBox.TabIndex = 0;
            // 
            // componentExcelReport
            // 
            this.componentExcelReport.HeaderOrientation = ClasslLibraryComponentsFilippov.Enums.HeaderOrientation.Horizontal;
            // 
            // componentPdfDiagram
            // 
            this.componentPdfDiagram.DataLabelType = ClasslLibraryComponentsFilippov.Enums.PdfDataLabelType.None;
            // 
            // FormWorkWithComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.groupBoхPdfDiagram);
            this.Controls.Add(this.groupBoxExcelReport);
            this.Controls.Add(this.groupBoxSaveXML);
            this.Controls.Add(this.groupBoxWorkWithList);
            this.Name = "FormWorkWithComponents";
            this.Text = "Работа с невизуальными компонентами";
            this.groupBoxWorkWithList.ResumeLayout(false);
            this.groupBoxWorkWithList.PerformLayout();
            this.groupBoxSaveXML.ResumeLayout(false);
            this.groupBoxExcelReport.ResumeLayout(false);
            this.groupBoxExcelReport.PerformLayout();
            this.groupBoхPdfDiagram.ResumeLayout(false);
            this.groupBoхPdfDiagram.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ClasslLibraryComponentsFilippov.ComponentSaveDataXml componentSaveDataXmlTest;
        private ClasslLibraryComponentsFilippov.ComponentExcelReport componentExcelReport;
        private ClasslLibraryComponentsFilippov.ComponentPdfDiagram componentPdfDiagram;
        private System.Windows.Forms.GroupBox groupBoxWorkWithList;
        private ClassLibraryControlsFilippov.ControlOutputlListBox controlOutputlListBox;
        private System.Windows.Forms.Button buttonListAdd;
        private System.Windows.Forms.Label labelPropertyValue;
        private System.Windows.Forms.TextBox textBoxPropertyValue;
        private System.Windows.Forms.Label labelPropertyName;
        private System.Windows.Forms.TextBox textBoxPropertyName;
        private System.Windows.Forms.Label labelRowIndex;
        private System.Windows.Forms.TextBox textBoxRowIndex;
        private System.Windows.Forms.GroupBox groupBoxSaveXML;
        private System.Windows.Forms.Button buttonSaveXml;
        private System.Windows.Forms.GroupBox groupBoxExcelReport;
        private System.Windows.Forms.CheckBox checkBoxHorizontalOrientation;
        private System.Windows.Forms.Button buttonCreateExcelReport;
        private System.Windows.Forms.GroupBox groupBoхPdfDiagram;
        private System.Windows.Forms.Button buttonCreateDiagram;
        private System.Windows.Forms.Label labelPropertyNamePdf;
        private System.Windows.Forms.TextBox textBoxPropertyNamePdf;
    }
}