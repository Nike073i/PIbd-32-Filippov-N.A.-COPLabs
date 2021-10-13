
namespace FurnitureFactoryView
{
    partial class FormSupplier
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelManufacturedFurniture = new System.Windows.Forms.Label();
            this.textBoxManufacturedFurniture = new System.Windows.Forms.TextBox();
            this.controlSelectedComboBoxOrganizationType = new ClassLibraryControlsFilippov.ControlSelectedComboBox();
            this.labelOrganizationType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(193, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название:";
            // 
            // labelManufacturedFurniture
            // 
            this.labelManufacturedFurniture.AutoSize = true;
            this.labelManufacturedFurniture.Location = new System.Drawing.Point(12, 52);
            this.labelManufacturedFurniture.Name = "labelManufacturedFurniture";
            this.labelManufacturedFurniture.Size = new System.Drawing.Size(177, 13);
            this.labelManufacturedFurniture.TabIndex = 2;
            this.labelManufacturedFurniture.Text = "Перечень производимой мебели:";
            // 
            // textBoxManufacturedFurniture
            // 
            this.textBoxManufacturedFurniture.Location = new System.Drawing.Point(12, 68);
            this.textBoxManufacturedFurniture.Name = "textBoxManufacturedFurniture";
            this.textBoxManufacturedFurniture.Size = new System.Drawing.Size(193, 20);
            this.textBoxManufacturedFurniture.TabIndex = 3;
            // 
            // controlSelectedComboBoxOrganizationType
            // 
            this.controlSelectedComboBoxOrganizationType.Location = new System.Drawing.Point(11, 111);
            this.controlSelectedComboBoxOrganizationType.Margin = new System.Windows.Forms.Padding(2);
            this.controlSelectedComboBoxOrganizationType.Name = "controlSelectedComboBoxOrganizationType";
            this.controlSelectedComboBoxOrganizationType.SelectedItem = "";
            this.controlSelectedComboBoxOrganizationType.Size = new System.Drawing.Size(196, 24);
            this.controlSelectedComboBoxOrganizationType.TabIndex = 4;
            // 
            // labelOrganizationType
            // 
            this.labelOrganizationType.AutoSize = true;
            this.labelOrganizationType.Location = new System.Drawing.Point(12, 91);
            this.labelOrganizationType.Name = "labelOrganizationType";
            this.labelOrganizationType.Size = new System.Drawing.Size(94, 13);
            this.labelOrganizationType.TabIndex = 5;
            this.labelOrganizationType.Text = "Тип организации";
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 198);
            this.Controls.Add(this.labelOrganizationType);
            this.Controls.Add(this.controlSelectedComboBoxOrganizationType);
            this.Controls.Add(this.textBoxManufacturedFurniture);
            this.Controls.Add(this.labelManufacturedFurniture);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormSupplier";
            this.Text = "Поставщик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelManufacturedFurniture;
        private System.Windows.Forms.TextBox textBoxManufacturedFurniture;
        private ClassLibraryControlsFilippov.ControlSelectedComboBox controlSelectedComboBoxOrganizationType;
        private System.Windows.Forms.Label labelOrganizationType;
    }
}