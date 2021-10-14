
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
            this.userControlDateLastDelivery = new WindowsFormsControlLibrary.UserControlDate();
            this.labelLastDelivery = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(12, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(193, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название:";
            // 
            // labelManufacturedFurniture
            // 
            this.labelManufacturedFurniture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelManufacturedFurniture.AutoSize = true;
            this.labelManufacturedFurniture.Location = new System.Drawing.Point(12, 82);
            this.labelManufacturedFurniture.Name = "labelManufacturedFurniture";
            this.labelManufacturedFurniture.Size = new System.Drawing.Size(177, 13);
            this.labelManufacturedFurniture.TabIndex = 2;
            this.labelManufacturedFurniture.Text = "Перечень производимой мебели:";
            // 
            // textBoxManufacturedFurniture
            // 
            this.textBoxManufacturedFurniture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxManufacturedFurniture.Location = new System.Drawing.Point(12, 98);
            this.textBoxManufacturedFurniture.Name = "textBoxManufacturedFurniture";
            this.textBoxManufacturedFurniture.Size = new System.Drawing.Size(193, 20);
            this.textBoxManufacturedFurniture.TabIndex = 3;
            // 
            // controlSelectedComboBoxOrganizationType
            // 
            this.controlSelectedComboBoxOrganizationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.controlSelectedComboBoxOrganizationType.Location = new System.Drawing.Point(11, 141);
            this.controlSelectedComboBoxOrganizationType.Margin = new System.Windows.Forms.Padding(2);
            this.controlSelectedComboBoxOrganizationType.Name = "controlSelectedComboBoxOrganizationType";
            this.controlSelectedComboBoxOrganizationType.SelectedItem = "";
            this.controlSelectedComboBoxOrganizationType.Size = new System.Drawing.Size(194, 24);
            this.controlSelectedComboBoxOrganizationType.TabIndex = 4;
            // 
            // labelOrganizationType
            // 
            this.labelOrganizationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOrganizationType.AutoSize = true;
            this.labelOrganizationType.Location = new System.Drawing.Point(12, 121);
            this.labelOrganizationType.Name = "labelOrganizationType";
            this.labelOrganizationType.Size = new System.Drawing.Size(94, 13);
            this.labelOrganizationType.TabIndex = 5;
            this.labelOrganizationType.Text = "Тип организации";
            // 
            // userControlDateLastDelivery
            // 
            this.userControlDateLastDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlDateLastDelivery.Location = new System.Drawing.Point(11, 183);
            this.userControlDateLastDelivery.Name = "userControlDateLastDelivery";
            this.userControlDateLastDelivery.Size = new System.Drawing.Size(194, 50);
            this.userControlDateLastDelivery.TabIndex = 6;
            // 
            // labelLastDelivery
            // 
            this.labelLastDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastDelivery.AutoSize = true;
            this.labelLastDelivery.Location = new System.Drawing.Point(12, 167);
            this.labelLastDelivery.Name = "labelLastDelivery";
            this.labelLastDelivery.Size = new System.Drawing.Size(140, 13);
            this.labelLastDelivery.TabIndex = 7;
            this.labelLastDelivery.Text = "Дата последней поставки";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(12, 239);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(112, 239);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 277);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelLastDelivery);
            this.Controls.Add(this.userControlDateLastDelivery);
            this.Controls.Add(this.labelOrganizationType);
            this.Controls.Add(this.controlSelectedComboBoxOrganizationType);
            this.Controls.Add(this.textBoxManufacturedFurniture);
            this.Controls.Add(this.labelManufacturedFurniture);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormSupplier";
            this.Text = "Поставщик";
            this.Load += new System.EventHandler(this.FormSupplier_Load);
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
        private WindowsFormsControlLibrary.UserControlDate userControlDateLastDelivery;
        private System.Windows.Forms.Label labelLastDelivery;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}