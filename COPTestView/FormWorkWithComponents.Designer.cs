
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
            this.componentSaveDataXmlTest = new ClasslLibraryComponentsFilippov.ComponentSaveDataXml(this.components);
            this.componentExcelReport = new ClasslLibraryComponentsFilippov.ComponentExcelReport(this.components);
            this.componentPdfDiagram = new ClasslLibraryComponentsFilippov.ComponentPdfDiagram(this.components);
            this.SuspendLayout();
            // 
            // componentExcelReport
            // 
            this.componentExcelReport.HeaderOrientation = ClasslLibraryComponentsFilippov.Enums.HeaderOrientation.Horizontal;
            // 
            // FormWorkWithComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormWorkWithComponents";
            this.Text = "Работа с невизуальными компонентами";
            this.ResumeLayout(false);

        }

        #endregion

        private ClasslLibraryComponentsFilippov.ComponentSaveDataXml componentSaveDataXmlTest;
        private ClasslLibraryComponentsFilippov.ComponentExcelReport componentExcelReport;
        private ClasslLibraryComponentsFilippov.ComponentPdfDiagram componentPdfDiagram;
    }
}