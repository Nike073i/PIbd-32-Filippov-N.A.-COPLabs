
namespace FurnitureFactoryView
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.createSimpleDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDocumentTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDocumentChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator,
            this.createSimpleDocumentToolStripMenuItem,
            this.createDocumentTableToolStripMenuItem,
            this.createDocumentChartToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(306, 182);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(305, 24);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddSupplier);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(305, 24);
            this.updateToolStripMenuItem.Text = "Редактировать";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.UpdateSupplier);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(305, 24);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteSupplier);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(302, 6);
            // 
            // createSimpleDocumentToolStripMenuItem
            // 
            this.createSimpleDocumentToolStripMenuItem.Name = "createSimpleDocumentToolStripMenuItem";
            this.createSimpleDocumentToolStripMenuItem.Size = new System.Drawing.Size(305, 24);
            this.createSimpleDocumentToolStripMenuItem.Text = "Создать простой документ";
            this.createSimpleDocumentToolStripMenuItem.Click += new System.EventHandler(this.CreateSimpleDocument);
            // 
            // createDocumentTableToolStripMenuItem
            // 
            this.createDocumentTableToolStripMenuItem.Name = "createDocumentTableToolStripMenuItem";
            this.createDocumentTableToolStripMenuItem.Size = new System.Drawing.Size(305, 24);
            this.createDocumentTableToolStripMenuItem.Text = "Создать документ с таблицей";
            this.createDocumentTableToolStripMenuItem.Click += new System.EventHandler(this.CreateDocumentTable);
            // 
            // createDocumentChartToolStripMenuItem
            // 
            this.createDocumentChartToolStripMenuItem.Name = "createDocumentChartToolStripMenuItem";
            this.createDocumentChartToolStripMenuItem.Size = new System.Drawing.Size(305, 24);
            this.createDocumentChartToolStripMenuItem.Text = "Создать документ с диаграммой";
            this.createDocumentChartToolStripMenuItem.Click += new System.EventHandler(this.CreateDocumentChart);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Name = "FormMain";
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSimpleDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDocumentTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDocumentChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    }
}

