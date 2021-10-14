﻿namespace FurnitureFactoryView
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorSupplier = new System.Windows.Forms.ToolStripSeparator();
            this.callOgranizationTypesFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorOrganizationTypes = new System.Windows.Forms.ToolStripSeparator();
            this.createSimpleDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDocumentTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDocumentChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeUserControl1 = new WindowsFormsControlLibraryKalachikov.TreeUserControl();
            this.componentContextBigText = new ClassLibraryComponentsFilippov.ComponentContextBigText(this.components);
            this.docWithDiagram = new ComponentLibrary.DocWithDiagram();
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
            this.toolStripSeparatorSupplier,
            this.callOgranizationTypesFormToolStripMenuItem,
            this.toolStripSeparatorOrganizationTypes,
            this.createSimpleDocumentToolStripMenuItem,
            this.createDocumentTableToolStripMenuItem,
            this.createDocumentChartToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(254, 170);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddSupplier);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.updateToolStripMenuItem.Text = "Редактировать";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.UpdateSupplier);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteSupplier);
            // 
            // toolStripSeparatorSupplier
            // 
            this.toolStripSeparatorSupplier.Name = "toolStripSeparatorSupplier";
            this.toolStripSeparatorSupplier.Size = new System.Drawing.Size(250, 6);
            // 
            // callOgranizationTypesFormToolStripMenuItem
            // 
            this.callOgranizationTypesFormToolStripMenuItem.Name = "callOgranizationTypesFormToolStripMenuItem";
            this.callOgranizationTypesFormToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.callOgranizationTypesFormToolStripMenuItem.Text = "Типы организаций";
            this.callOgranizationTypesFormToolStripMenuItem.Click += new System.EventHandler(this.CallOrganizationTypesForm);
            // 
            // toolStripSeparatorOrganizationTypes
            // 
            this.toolStripSeparatorOrganizationTypes.Name = "toolStripSeparatorOrganizationTypes";
            this.toolStripSeparatorOrganizationTypes.Size = new System.Drawing.Size(250, 6);
            // 
            // createSimpleDocumentToolStripMenuItem
            // 
            this.createSimpleDocumentToolStripMenuItem.Name = "createSimpleDocumentToolStripMenuItem";
            this.createSimpleDocumentToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.createSimpleDocumentToolStripMenuItem.Text = "Создать простой документ";
            this.createSimpleDocumentToolStripMenuItem.Click += new System.EventHandler(this.CreateSimpleDocument);
            // 
            // createDocumentTableToolStripMenuItem
            // 
            this.createDocumentTableToolStripMenuItem.Name = "createDocumentTableToolStripMenuItem";
            this.createDocumentTableToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.createDocumentTableToolStripMenuItem.Text = "Создать документ с таблицей";
            this.createDocumentTableToolStripMenuItem.Click += new System.EventHandler(this.CreateDocumentTable);
            // 
            // createDocumentChartToolStripMenuItem
            // 
            this.createDocumentChartToolStripMenuItem.Name = "createDocumentChartToolStripMenuItem";
            this.createDocumentChartToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.createDocumentChartToolStripMenuItem.Text = "Создать документ с диаграммой";
            this.createDocumentChartToolStripMenuItem.Click += new System.EventHandler(this.CreateDocumentChart);
            // 
            // treeUserControl1
            // 
            this.treeUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.treeUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeUserControl1.Name = "treeUserControl1";
            this.treeUserControl1.SelectedBranch = -1;
            this.treeUserControl1.Size = new System.Drawing.Size(600, 293);
            this.treeUserControl1.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 293);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.treeUserControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(600, 330);
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

        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorSupplier;
        private WindowsFormsControlLibraryKalachikov.TreeUserControl treeUserControl1;
        private System.Windows.Forms.ToolStripMenuItem callOgranizationTypesFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOrganizationTypes;
        private ClassLibraryComponentsFilippov.ComponentContextBigText componentContextBigText;
        private ComponentLibrary.DocWithDiagram docWithDiagram;
    }
}

