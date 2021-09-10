
namespace COPTestView
{
    partial class FormMain
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
            this.buttonTest = new System.Windows.Forms.Button();
            this.textBoxChooce = new System.Windows.Forms.TextBox();
            this.controlSelectedComboBoxTest = new ClassLibraryControlsFilippov.ControlSelectedComboBox();
            this.groupBoxControlComboBox = new System.Windows.Forms.GroupBox();
            this.labelEnter = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelAdd = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.groupBoxControlComboBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(221, 60);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(87, 23);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "Выбрать";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // textBoxChooce
            // 
            this.textBoxChooce.Location = new System.Drawing.Point(14, 61);
            this.textBoxChooce.Name = "textBoxChooce";
            this.textBoxChooce.Size = new System.Drawing.Size(200, 20);
            this.textBoxChooce.TabIndex = 2;
            // 
            // controlSelectedComboBoxTest
            // 
            this.controlSelectedComboBoxTest.Location = new System.Drawing.Point(11, 19);
            this.controlSelectedComboBoxTest.Name = "controlSelectedComboBoxTest";
            this.controlSelectedComboBoxTest.SelectedItem = "";
            this.controlSelectedComboBoxTest.Size = new System.Drawing.Size(308, 28);
            this.controlSelectedComboBoxTest.TabIndex = 0;
            this.controlSelectedComboBoxTest.ComboBoxSelectedElementChange += new System.EventHandler(this.controlComboBoxSelected_ComboBoxSelectedElementChange);
            // 
            // groupBoxControlComboBox
            // 
            this.groupBoxControlComboBox.Controls.Add(this.labelAdd);
            this.groupBoxControlComboBox.Controls.Add(this.buttonAdd);
            this.groupBoxControlComboBox.Controls.Add(this.textBoxAdd);
            this.groupBoxControlComboBox.Controls.Add(this.buttonClear);
            this.groupBoxControlComboBox.Controls.Add(this.labelEnter);
            this.groupBoxControlComboBox.Controls.Add(this.buttonTest);
            this.groupBoxControlComboBox.Controls.Add(this.textBoxChooce);
            this.groupBoxControlComboBox.Controls.Add(this.controlSelectedComboBoxTest);
            this.groupBoxControlComboBox.Location = new System.Drawing.Point(12, 12);
            this.groupBoxControlComboBox.Name = "groupBoxControlComboBox";
            this.groupBoxControlComboBox.Size = new System.Drawing.Size(325, 156);
            this.groupBoxControlComboBox.TabIndex = 3;
            this.groupBoxControlComboBox.TabStop = false;
            this.groupBoxControlComboBox.Text = "Тест компонента выбора";
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Location = new System.Drawing.Point(11, 47);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(97, 13);
            this.labelEnter.TabIndex = 3;
            this.labelEnter.Text = "Выбрать элемент";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(94, 125);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(131, 25);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистить список";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(11, 85);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(103, 13);
            this.labelAdd.TabIndex = 7;
            this.labelAdd.Text = "Добавить элемент";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(221, 98);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(14, 99);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(200, 20);
            this.textBoxAdd.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxControlComboBox);
            this.Name = "FormMain";
            this.Text = "Главное окно";
            this.groupBoxControlComboBox.ResumeLayout(false);
            this.groupBoxControlComboBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibraryControlsFilippov.ControlSelectedComboBox controlSelectedComboBoxTest;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.TextBox textBoxChooce;
        private System.Windows.Forms.GroupBox groupBoxControlComboBox;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonClear;
    }
}