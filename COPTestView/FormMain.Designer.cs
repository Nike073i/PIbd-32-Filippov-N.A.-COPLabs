
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
            this.groupBoxControlOutputTest = new System.Windows.Forms.GroupBox();
            this.buttonListAdd = new System.Windows.Forms.Button();
            this.labelPropertyValue = new System.Windows.Forms.Label();
            this.textBoxPropertyValue = new System.Windows.Forms.TextBox();
            this.labelPropertyName = new System.Windows.Forms.Label();
            this.textBoxPropertyName = new System.Windows.Forms.TextBox();
            this.labelRowIndex = new System.Windows.Forms.Label();
            this.textBoxRowIndex = new System.Windows.Forms.TextBox();
            this.controlOutputlListBox = new ClassLibraryControlsFilippov.ControlOutputlListBox();
            this.groupBoxControlComboBox.SuspendLayout();
            this.groupBoxInputTest.SuspendLayout();
            this.groupBoxControlOutputTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(221, 58);
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
            this.buttonAdd.Location = new System.Drawing.Point(221, 97);
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
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Location = new System.Drawing.Point(11, 47);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(97, 13);
            this.labelEnter.TabIndex = 3;
            this.labelEnter.Text = "Выбрать элемент";
            // 
            // controlSelectedComboBoxTest
            // 
            this.controlSelectedComboBoxTest.Location = new System.Drawing.Point(14, 20);
            this.controlSelectedComboBoxTest.Margin = new System.Windows.Forms.Padding(4);
            this.controlSelectedComboBoxTest.Name = "controlSelectedComboBoxTest";
            this.controlSelectedComboBoxTest.SelectedItem = "";
            this.controlSelectedComboBoxTest.Size = new System.Drawing.Size(295, 28);
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
            this.groupBoxInputTest.Location = new System.Drawing.Point(361, 17);
            this.groupBoxInputTest.Name = "groupBoxInputTest";
            this.groupBoxInputTest.Size = new System.Drawing.Size(307, 150);
            this.groupBoxInputTest.TabIndex = 4;
            this.groupBoxInputTest.TabStop = false;
            this.groupBoxInputTest.Text = "Тест компонента ввода";
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Location = new System.Drawing.Point(9, 98);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(94, 13);
            this.labelPrompt.TabIndex = 12;
            this.labelPrompt.Text = "Задать описание";
            // 
            // buttonCreatePrompt
            // 
            this.buttonCreatePrompt.Location = new System.Drawing.Point(222, 114);
            this.buttonCreatePrompt.Name = "buttonCreatePrompt";
            this.buttonCreatePrompt.Size = new System.Drawing.Size(75, 23);
            this.buttonCreatePrompt.TabIndex = 10;
            this.buttonCreatePrompt.Text = "Применить";
            this.buttonCreatePrompt.UseVisualStyleBackColor = true;
            this.buttonCreatePrompt.Click += new System.EventHandler(this.buttonCreatePrompt_Click);
            // 
            // textBoxPrompt
            // 
            this.textBoxPrompt.Location = new System.Drawing.Point(12, 116);
            this.textBoxPrompt.Name = "textBoxPrompt";
            this.textBoxPrompt.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrompt.TabIndex = 11;
            // 
            // labelPattern
            // 
            this.labelPattern.AutoSize = true;
            this.labelPattern.Location = new System.Drawing.Point(9, 52);
            this.labelPattern.Name = "labelPattern";
            this.labelPattern.Size = new System.Drawing.Size(84, 13);
            this.labelPattern.TabIndex = 9;
            this.labelPattern.Text = "Задать шаблон";
            // 
            // buttonCreatePattern
            // 
            this.buttonCreatePattern.Location = new System.Drawing.Point(222, 68);
            this.buttonCreatePattern.Name = "buttonCreatePattern";
            this.buttonCreatePattern.Size = new System.Drawing.Size(75, 23);
            this.buttonCreatePattern.TabIndex = 2;
            this.buttonCreatePattern.Text = "Применить";
            this.buttonCreatePattern.UseVisualStyleBackColor = true;
            this.buttonCreatePattern.Click += new System.EventHandler(this.buttonCreatePattern_Click);
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Location = new System.Drawing.Point(12, 70);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Size = new System.Drawing.Size(200, 20);
            this.textBoxPattern.TabIndex = 8;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(222, 23);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 1;
            this.buttonEnter.Text = "Ввод";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // controlInputRegexPhoneNumberTest
            // 
            this.controlInputRegexPhoneNumberTest.Location = new System.Drawing.Point(11, 24);
            this.controlInputRegexPhoneNumberTest.Margin = new System.Windows.Forms.Padding(4);
            this.controlInputRegexPhoneNumberTest.Name = "controlInputRegexPhoneNumberTest";
            this.controlInputRegexPhoneNumberTest.Pattern = "";
            this.controlInputRegexPhoneNumberTest.Size = new System.Drawing.Size(200, 23);
            this.controlInputRegexPhoneNumberTest.TabIndex = 0;
            this.controlInputRegexPhoneNumberTest.Value = "";
            // 
            // groupBoxControlOutputTest
            // 
            this.groupBoxControlOutputTest.Controls.Add(this.buttonListAdd);
            this.groupBoxControlOutputTest.Controls.Add(this.labelPropertyValue);
            this.groupBoxControlOutputTest.Controls.Add(this.textBoxPropertyValue);
            this.groupBoxControlOutputTest.Controls.Add(this.labelPropertyName);
            this.groupBoxControlOutputTest.Controls.Add(this.textBoxPropertyName);
            this.groupBoxControlOutputTest.Controls.Add(this.labelRowIndex);
            this.groupBoxControlOutputTest.Controls.Add(this.textBoxRowIndex);
            this.groupBoxControlOutputTest.Controls.Add(this.controlOutputlListBox);
            this.groupBoxControlOutputTest.Location = new System.Drawing.Point(84, 186);
            this.groupBoxControlOutputTest.Name = "groupBoxControlOutputTest";
            this.groupBoxControlOutputTest.Size = new System.Drawing.Size(515, 332);
            this.groupBoxControlOutputTest.TabIndex = 5;
            this.groupBoxControlOutputTest.TabStop = false;
            this.groupBoxControlOutputTest.Text = "Тест компонента вывода списка";
            // 
            // buttonListAdd
            // 
            this.buttonListAdd.Location = new System.Drawing.Point(299, 177);
            this.buttonListAdd.Name = "buttonListAdd";
            this.buttonListAdd.Size = new System.Drawing.Size(200, 23);
            this.buttonListAdd.TabIndex = 7;
            this.buttonListAdd.Text = "Вставить";
            this.buttonListAdd.UseVisualStyleBackColor = true;
            this.buttonListAdd.Click += new System.EventHandler(this.buttonListInsert_Click);
            // 
            // labelPropertyValue
            // 
            this.labelPropertyValue.AutoSize = true;
            this.labelPropertyValue.Location = new System.Drawing.Point(296, 128);
            this.labelPropertyValue.Name = "labelPropertyValue";
            this.labelPropertyValue.Size = new System.Drawing.Size(105, 13);
            this.labelPropertyValue.TabIndex = 6;
            this.labelPropertyValue.Text = "Значение свойства";
            // 
            // textBoxPropertyValue
            // 
            this.textBoxPropertyValue.Location = new System.Drawing.Point(299, 149);
            this.textBoxPropertyValue.Name = "textBoxPropertyValue";
            this.textBoxPropertyValue.Size = new System.Drawing.Size(200, 20);
            this.textBoxPropertyValue.TabIndex = 5;
            // 
            // labelPropertyName
            // 
            this.labelPropertyName.AutoSize = true;
            this.labelPropertyName.Location = new System.Drawing.Point(296, 78);
            this.labelPropertyName.Name = "labelPropertyName";
            this.labelPropertyName.Size = new System.Drawing.Size(107, 13);
            this.labelPropertyName.TabIndex = 4;
            this.labelPropertyName.Text = "Название свойства";
            // 
            // textBoxPropertyName
            // 
            this.textBoxPropertyName.Location = new System.Drawing.Point(299, 99);
            this.textBoxPropertyName.Name = "textBoxPropertyName";
            this.textBoxPropertyName.Size = new System.Drawing.Size(200, 20);
            this.textBoxPropertyName.TabIndex = 3;
            // 
            // labelRowIndex
            // 
            this.labelRowIndex.AutoSize = true;
            this.labelRowIndex.Location = new System.Drawing.Point(296, 29);
            this.labelRowIndex.Name = "labelRowIndex";
            this.labelRowIndex.Size = new System.Drawing.Size(83, 13);
            this.labelRowIndex.TabIndex = 2;
            this.labelRowIndex.Text = "Индекс строки";
            // 
            // textBoxRowIndex
            // 
            this.textBoxRowIndex.Location = new System.Drawing.Point(299, 50);
            this.textBoxRowIndex.Name = "textBoxRowIndex";
            this.textBoxRowIndex.Size = new System.Drawing.Size(200, 20);
            this.textBoxRowIndex.TabIndex = 1;
            // 
            // controlOutputlListBox
            // 
            this.controlOutputlListBox.Location = new System.Drawing.Point(17, 28);
            this.controlOutputlListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlOutputlListBox.Name = "controlOutputlListBox";
            this.controlOutputlListBox.SelectedIndex = -1;
            this.controlOutputlListBox.Size = new System.Drawing.Size(263, 288);
            this.controlOutputlListBox.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 557);
            this.Controls.Add(this.groupBoxControlOutputTest);
            this.Controls.Add(this.groupBoxInputTest);
            this.Controls.Add(this.groupBoxControlComboBox);
            this.Name = "FormMain";
            this.Text = "Главное окно";
            this.groupBoxControlComboBox.ResumeLayout(false);
            this.groupBoxControlComboBox.PerformLayout();
            this.groupBoxInputTest.ResumeLayout(false);
            this.groupBoxInputTest.PerformLayout();
            this.groupBoxControlOutputTest.ResumeLayout(false);
            this.groupBoxControlOutputTest.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxControlOutputTest;
        private System.Windows.Forms.Label labelRowIndex;
        private System.Windows.Forms.TextBox textBoxRowIndex;
        private ClassLibraryControlsFilippov.ControlOutputlListBox controlOutputlListBox;
        private System.Windows.Forms.Button buttonListAdd;
        private System.Windows.Forms.Label labelPropertyValue;
        private System.Windows.Forms.TextBox textBoxPropertyValue;
        private System.Windows.Forms.Label labelPropertyName;
        private System.Windows.Forms.TextBox textBoxPropertyName;
    }
}