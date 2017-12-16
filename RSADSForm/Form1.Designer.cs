namespace RSADSForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.singPathButton = new System.Windows.Forms.Button();
            this.signButton = new System.Windows.Forms.Button();
            this.SingPathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filePathButton = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.OpenKeyTextBox = new System.Windows.Forms.TextBox();
            this.openKeyPathButton = new System.Windows.Forms.Button();
            this.checkSignPathButton = new System.Windows.Forms.Button();
            this.checkSignTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkFilePathButton = new System.Windows.Forms.Button();
            this.checkFileTextBox = new System.Windows.Forms.TextBox();
            this.checkSignButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.wolframLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PoweredByLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generateKeyButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.codedByLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 197);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.singPathButton);
            this.tabPage1.Controls.Add(this.signButton);
            this.tabPage1.Controls.Add(this.SingPathTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.filePathButton);
            this.tabPage1.Controls.Add(this.fileNameTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 171);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Подписать";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // singPathButton
            // 
            this.singPathButton.Location = new System.Drawing.Point(436, 66);
            this.singPathButton.Name = "singPathButton";
            this.singPathButton.Size = new System.Drawing.Size(81, 21);
            this.singPathButton.TabIndex = 6;
            this.singPathButton.Text = "Обзор";
            this.singPathButton.UseVisualStyleBackColor = true;
            this.singPathButton.Click += new System.EventHandler(this.singPathButton_Click);
            // 
            // signButton
            // 
            this.signButton.Location = new System.Drawing.Point(10, 93);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(81, 23);
            this.signButton.TabIndex = 5;
            this.signButton.Text = "Подписать";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // SingPathTextBox
            // 
            this.SingPathTextBox.Location = new System.Drawing.Point(10, 67);
            this.SingPathTextBox.Name = "SingPathTextBox";
            this.SingPathTextBox.Size = new System.Drawing.Size(420, 20);
            this.SingPathTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите закрытый ключ:";
            // 
            // filePathButton
            // 
            this.filePathButton.Location = new System.Drawing.Point(436, 24);
            this.filePathButton.Name = "filePathButton";
            this.filePathButton.Size = new System.Drawing.Size(81, 20);
            this.filePathButton.TabIndex = 2;
            this.filePathButton.Text = "Обзор";
            this.filePathButton.UseVisualStyleBackColor = true;
            this.filePathButton.Click += new System.EventHandler(this.filePathButton_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(10, 24);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(420, 20);
            this.fileNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите путь к файлу:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.OpenKeyTextBox);
            this.tabPage2.Controls.Add(this.openKeyPathButton);
            this.tabPage2.Controls.Add(this.checkSignPathButton);
            this.tabPage2.Controls.Add(this.checkSignTextBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.checkFilePathButton);
            this.tabPage2.Controls.Add(this.checkFileTextBox);
            this.tabPage2.Controls.Add(this.checkSignButton);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 171);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Проверить подпись";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Выберите открытый ключ:";
            // 
            // OpenKeyTextBox
            // 
            this.OpenKeyTextBox.Location = new System.Drawing.Point(10, 111);
            this.OpenKeyTextBox.Name = "OpenKeyTextBox";
            this.OpenKeyTextBox.Size = new System.Drawing.Size(418, 20);
            this.OpenKeyTextBox.TabIndex = 8;
            // 
            // openKeyPathButton
            // 
            this.openKeyPathButton.Location = new System.Drawing.Point(434, 111);
            this.openKeyPathButton.Name = "openKeyPathButton";
            this.openKeyPathButton.Size = new System.Drawing.Size(81, 20);
            this.openKeyPathButton.TabIndex = 7;
            this.openKeyPathButton.Text = "Обзор";
            this.openKeyPathButton.UseVisualStyleBackColor = true;
            this.openKeyPathButton.Click += new System.EventHandler(this.openKeyPathButton_Click);
            // 
            // checkSignPathButton
            // 
            this.checkSignPathButton.Location = new System.Drawing.Point(434, 68);
            this.checkSignPathButton.Name = "checkSignPathButton";
            this.checkSignPathButton.Size = new System.Drawing.Size(81, 20);
            this.checkSignPathButton.TabIndex = 6;
            this.checkSignPathButton.Text = "Обзор";
            this.checkSignPathButton.UseVisualStyleBackColor = true;
            this.checkSignPathButton.Click += new System.EventHandler(this.checkSignPathButton_Click);
            // 
            // checkSignTextBox
            // 
            this.checkSignTextBox.Location = new System.Drawing.Point(10, 68);
            this.checkSignTextBox.Name = "checkSignTextBox";
            this.checkSignTextBox.Size = new System.Drawing.Size(418, 20);
            this.checkSignTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Выберите файл с подписью:";
            // 
            // checkFilePathButton
            // 
            this.checkFilePathButton.Location = new System.Drawing.Point(434, 24);
            this.checkFilePathButton.Name = "checkFilePathButton";
            this.checkFilePathButton.Size = new System.Drawing.Size(81, 20);
            this.checkFilePathButton.TabIndex = 3;
            this.checkFilePathButton.Text = "Обзор";
            this.checkFilePathButton.UseVisualStyleBackColor = true;
            this.checkFilePathButton.Click += new System.EventHandler(this.checkFilePathButton_Click);
            // 
            // checkFileTextBox
            // 
            this.checkFileTextBox.Location = new System.Drawing.Point(10, 24);
            this.checkFileTextBox.Name = "checkFileTextBox";
            this.checkFileTextBox.Size = new System.Drawing.Size(418, 20);
            this.checkFileTextBox.TabIndex = 2;
            // 
            // checkSignButton
            // 
            this.checkSignButton.Location = new System.Drawing.Point(10, 142);
            this.checkSignButton.Name = "checkSignButton";
            this.checkSignButton.Size = new System.Drawing.Size(75, 23);
            this.checkSignButton.TabIndex = 1;
            this.checkSignButton.Text = "Проверить";
            this.checkSignButton.UseVisualStyleBackColor = true;
            this.checkSignButton.Click += new System.EventHandler(this.checkSignButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Выберите путь к файлу:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.wolframLinkLabel);
            this.tabPage3.Controls.Add(this.PoweredByLable);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.generateKeyButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(522, 171);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сгенерировать ключи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // wolframLinkLabel
            // 
            this.wolframLinkLabel.AutoSize = true;
            this.wolframLinkLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wolframLinkLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wolframLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(11, 27);
            this.wolframLinkLabel.LinkColor = System.Drawing.SystemColors.Highlight;
            this.wolframLinkLabel.Location = new System.Drawing.Point(6, 45);
            this.wolframLinkLabel.Name = "wolframLinkLabel";
            this.wolframLinkLabel.Size = new System.Drawing.Size(172, 18);
            this.wolframLinkLabel.TabIndex = 7;
            this.wolframLinkLabel.TabStop = true;
            this.wolframLinkLabel.Text = "powered by Wolframalpha.com";
            this.wolframLinkLabel.UseCompatibleTextRendering = true;
            this.wolframLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.wolframLinkLabel_LinkClicked);
            // 
            // PoweredByLable
            // 
            this.PoweredByLable.AutoSize = true;
            this.PoweredByLable.Location = new System.Drawing.Point(6, 45);
            this.PoweredByLable.Name = "PoweredByLable";
            this.PoweredByLable.Size = new System.Drawing.Size(0, 13);
            this.PoweredByLable.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Для генерации чисел необходим доступ в интернет";
            // 
            // generateKeyButton
            // 
            this.generateKeyButton.Location = new System.Drawing.Point(6, 19);
            this.generateKeyButton.Name = "generateKeyButton";
            this.generateKeyButton.Size = new System.Drawing.Size(120, 23);
            this.generateKeyButton.TabIndex = 4;
            this.generateKeyButton.Text = "Сгенерировать";
            this.generateKeyButton.UseVisualStyleBackColor = true;
            this.generateKeyButton.Click += new System.EventHandler(this.generateKeyButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(17, 213);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 1;
            // 
            // codedByLinkLabel
            // 
            this.codedByLinkLabel.AutoSize = true;
            this.codedByLinkLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codedByLinkLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.codedByLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(9, 18);
            this.codedByLinkLabel.LinkColor = System.Drawing.SystemColors.Highlight;
            this.codedByLinkLabel.Location = new System.Drawing.Point(169, 213);
            this.codedByLinkLabel.Name = "codedByLinkLabel";
            this.codedByLinkLabel.Size = new System.Drawing.Size(204, 18);
            this.codedByLinkLabel.TabIndex = 2;
            this.codedByLinkLabel.TabStop = true;
            this.codedByLinkLabel.Text = "Coded by Aleksandr Bersenev 2017";
            this.codedByLinkLabel.UseCompatibleTextRendering = true;
            this.codedByLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.codedByLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.codedByLinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 232);
            this.Controls.Add(this.codedByLinkLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RSA Digital Sign";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.TextBox SingPathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button filePathButton;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button singPathButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button generateKeyButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button checkSignPathButton;
        private System.Windows.Forms.TextBox checkSignTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button checkFilePathButton;
        private System.Windows.Forms.TextBox checkFileTextBox;
        private System.Windows.Forms.Button checkSignButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OpenKeyTextBox;
        private System.Windows.Forms.Button openKeyPathButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel wolframLinkLabel;
        private System.Windows.Forms.Label PoweredByLable;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel codedByLinkLabel;
    }
}

