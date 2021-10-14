
namespace FurnitureFactoryView
{
    partial class FormOrganizationTypes
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
            this.dataGridViewOrganizationTypes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizationTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrganizationTypes
            // 
            this.dataGridViewOrganizationTypes.AllowUserToAddRows = false;
            this.dataGridViewOrganizationTypes.AllowUserToDeleteRows = false;
            this.dataGridViewOrganizationTypes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOrganizationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrganizationTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrganizationTypes.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOrganizationTypes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrganizationTypes.Name = "dataGridViewOrganizationTypes";
            this.dataGridViewOrganizationTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrganizationTypes.Size = new System.Drawing.Size(437, 254);
            this.dataGridViewOrganizationTypes.TabIndex = 0;
            this.dataGridViewOrganizationTypes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            // 
            // FormOrganizationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 254);
            this.Controls.Add(this.dataGridViewOrganizationTypes);
            this.KeyPreview = true;
            this.Name = "FormOrganizationTypes";
            this.Text = "Типы организаций";
            this.Load += new System.EventHandler(this.FormOrganizationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizationTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrganizationTypes;
    }
}