
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
            this.groupBoxControlComboBox = new System.Windows.Forms.GroupBox();
            this.labelAdd = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelEnter = new System.Windows.Forms.Label();
            this.controlSelectedComboBoxTest = new ClassLibraryControlsFilippov.ControlSelectedComboBox();
            this.groupBoxInputTest = new System.Windows.Forms.GroupBox();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.buttonCreatePrompt = new System.Windows.Forms.Button();
            this.textBoxPrompt = new System.Windows.Forms.TextBox();
            this.labelPattern = new System.Windows.Forms.Label();
            this.buttonCreatePattern = new System.Windows.Forms.Button();
            this.textBoxPattern = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.controlInputRegexPhoneNumberTest = new ClassLibraryControlsFilippov.ControlInputRegexPhoneNumber();
            this.groupBoxControlComboBox.SuspendLayout();
            this.groupBoxInputTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(295, 72);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(116, 28);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "Выбрать";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // textBoxChooce
            // 
            this.textBoxChooce.Location = new System.Drawing.Point(19, 75);
            this.textBoxChooce.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxChooce.Name = "textBoxChooce";
            this.textBoxChooce.Size = new System.Drawing.Size(265, 22);
            this.textBoxChooce.TabIndex = 2;
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
            this.groupBoxControlComboBox.Location = new System.Drawing.Point(16, 15);
            this.groupBoxControlComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxControlComboBox.Name = "groupBoxControlComboBox";
            this.groupBoxControlComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxControlComboBox.Size = new System.Drawing.Size(433, 192);
            this.groupBoxControlComboBox.TabIndex = 3;
            this.groupBoxControlComboBox.TabStop = false;
            this.groupBoxControlComboBox.Text = "Тест компонента выбора";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(15, 105);
            this.labelAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(131, 17);
            this.labelAdd.TabIndex = 7;
            this.labelAdd.Text = "Добавить элемент";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(295, 119);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 28);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(19, 122);
            this.textBoxAdd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(265, 22);
            this.textBoxAdd.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(125, 154);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(175, 31);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистить список";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Location = new System.Drawing.Point(15, 58);
            this.labelEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(124, 17);
            this.labelEnter.TabIndex = 3;
            this.labelEnter.Text = "Выбрать элемент";
            // 
            // controlSelectedComboBoxTest
            // 
            this.controlSelectedComboBoxTest.Location = new System.Drawing.Point(18, 24);
            this.controlSelectedComboBoxTest.Margin = new System.Windows.Forms.Padding(5);
            this.controlSelectedComboBoxTest.Name = "controlSelectedComboBoxTest";
            this.controlSelectedComboBoxTest.SelectedItem = "";
            this.controlSelectedComboBoxTest.Size = new System.Drawing.Size(393, 34);
            this.controlSelectedComboBoxTest.TabIndex = 0;
            this.controlSelectedComboBoxTest.ComboBoxSelectedElementChange += new System.EventHandler(this.controlComboBoxSelected_ComboBoxSelectedElementChange);
            // 
            // groupBoxInputTest
            // 
            this.groupBoxInputTest.Controls.Add(this.labelPrompt);
            this.groupBoxInputTest.Controls.Add(this.buttonCreatePrompt);
            this.groupBoxInputTest.Controls.Add(this.textBoxPrompt);
            this.groupBoxInputTest.Controls.Add(this.labelPattern);
            this.groupBoxInputTest.Controls.Add(this.buttonCreatePattern);
            this.groupBoxInputTest.Controls.Add(this.textBoxPattern);
            this.groupBoxInputTest.Controls.Add(this.buttonEnter);
            this.groupBoxInputTest.Controls.Add(this.controlInputRegexPhoneNumberTest);
            this.groupBoxInputTest.Location = new System.Drawing.Point(481, 21);
            this.groupBoxInputTest.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInputTest.Name = "groupBoxInputTest";
            this.groupBoxInputTest.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInputTest.Size = new System.Drawing.Size(409, 185);
            this.groupBoxInputTest.TabIndex = 4;
            this.groupBoxInputTest.TabStop = false;
            this.groupBoxInputTest.Text = "Тест компонента ввода";
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Location = new System.Drawing.Point(12, 121);
            this.labelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(122, 17);
            this.labelPrompt.TabIndex = 12;
            this.labelPrompt.Text = "Задать описание";
            // 
            // buttonCreatePrompt
            // 
            this.buttonCreatePrompt.Location = new System.Drawing.Point(296, 140);
            this.buttonCreatePrompt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreatePrompt.Name = "buttonCreatePrompt";
            this.buttonCreatePrompt.Size = new System.Drawing.Size(100, 28);
            this.buttonCreatePrompt.TabIndex = 10;
            this.buttonCreatePrompt.Text = "Применить";
            this.buttonCreatePrompt.UseVisualStyleBackColor = true;
            this.buttonCreatePrompt.Click += new System.EventHandler(this.buttonCreatePrompt_Click);
            // 
            // textBoxPrompt
            // 
            this.textBoxPrompt.Location = new System.Drawing.Point(16, 143);
            this.textBoxPrompt.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrompt.Name = "textBoxPrompt";
            this.textBoxPrompt.Size = new System.Drawing.Size(265, 22);
            this.textBoxPrompt.TabIndex = 11;
            // 
            // labelPattern
            // 
            this.labelPattern.AutoSize = true;
            this.labelPattern.Location = new System.Drawing.Point(12, 64);
            this.labelPattern.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPattern.Name = "labelPattern";
            this.labelPattern.Size = new System.Drawing.Size(110, 17);
            this.labelPattern.TabIndex = 9;
            this.labelPattern.Text = "Задать шаблон";
            // 
            // buttonCreatePattern
            // 
            this.buttonCreatePattern.Location = new System.Drawing.Point(296, 84);
            this.buttonCreatePattern.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreatePattern.Name = "buttonCreatePattern";
            this.buttonCreatePattern.Size = new System.Drawing.Size(100, 28);
            this.buttonCreatePattern.TabIndex = 2;
            this.buttonCreatePattern.Text = "Применить";
            this.buttonCreatePattern.UseVisualStyleBackColor = true;
            this.buttonCreatePattern.Click += new System.EventHandler(this.buttonCreatePattern_Click);
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Location = new System.Drawing.Point(16, 86);
            this.textBoxPattern.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Size = new System.Drawing.Size(265, 22);
            this.textBoxPattern.TabIndex = 8;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(296, 28);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(100, 28);
            this.buttonEnter.TabIndex = 1;
            this.buttonEnter.Text = "Ввод";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // controlInputRegexPhoneNumberTest
            // 
            this.controlInputRegexPhoneNumberTest.Location = new System.Drawing.Point(15, 30);
            this.controlInputRegexPhoneNumberTest.Margin = new System.Windows.Forms.Padding(5);
            this.controlInputRegexPhoneNumberTest.Name = "controlInputRegexPhoneNumberTest";
            this.controlInputRegexPhoneNumberTest.Pattern = "";
            this.controlInputRegexPhoneNumberTest.Size = new System.Drawing.Size(266, 28);
            this.controlInputRegexPhoneNumberTest.TabIndex = 0;
            this.controlInputRegexPhoneNumberTest.Value = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBoxInputTest);
            this.Controls.Add(this.groupBoxControlComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Главное окно";
            this.groupBoxControlComboBox.ResumeLayout(false);
            this.groupBoxControlComboBox.PerformLayout();
            this.groupBoxInputTest.ResumeLayout(false);
            this.groupBoxInputTest.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxInputTest;
        private ClassLibraryControlsFilippov.ControlInputRegexPhoneNumber controlInputRegexPhoneNumberTest;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.Button buttonCreatePrompt;
        private System.Windows.Forms.TextBox textBoxPrompt;
        private System.Windows.Forms.Label labelPattern;
        private System.Windows.Forms.Button buttonCreatePattern;
        private System.Windows.Forms.TextBox textBoxPattern;
    }
}