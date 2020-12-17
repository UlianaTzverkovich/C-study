namespace ITMO.WinForm.Lab3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxEMail();
            this.phoneNumber = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxNum();
            this.textBoxAge = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxNum();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneNumberIndex = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxNum();
            this.age = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxChar();
            this.textBoxName = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxChar();
            this.patronymic = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.textBoxSurname = new ITMO.WindowsApps.CSharp.Lab03_04.TextBoxChar();
            this.surname = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Controls.Add(this.textBoxAge);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.phoneNumberIndex);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.textBoxPatronymic);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.patronymic);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.surname);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(560, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные пользователя";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(120, 298);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(244, 34);
            this.textBoxEmail.TabIndex = 18;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(212, 249);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(153, 34);
            this.phoneNumber.TabIndex = 17;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(120, 177);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(93, 34);
            this.textBoxAge.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = ")";
            // 
            // phoneNumberIndex
            // 
            this.phoneNumberIndex.Location = new System.Drawing.Point(159, 249);
            this.phoneNumberIndex.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.phoneNumberIndex.Name = "phoneNumberIndex";
            this.phoneNumberIndex.Size = new System.Drawing.Size(38, 34);
            this.phoneNumberIndex.TabIndex = 14;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(9, 177);
            this.age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(72, 20);
            this.age.TabIndex = 13;
            this.age.Text = "Возраст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "+7 (";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(12, 305);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(51, 20);
            this.email.TabIndex = 10;
            this.email.Text = "e-mail";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(9, 255);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(79, 20);
            this.phone.TabIndex = 9;
            this.phone.Text = "Телефон";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(120, 135);
            this.textBoxPatronymic.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(430, 32);
            this.textBoxPatronymic.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(120, 94);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(430, 32);
            this.textBoxName.TabIndex = 7;
            // 
            // patronymic
            // 
            this.patronymic.AutoSize = true;
            this.patronymic.Location = new System.Drawing.Point(9, 135);
            this.patronymic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(83, 20);
            this.patronymic.TabIndex = 6;
            this.patronymic.Text = "Отчество";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(9, 94);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(40, 20);
            this.name.TabIndex = 5;
            this.name.Text = "Имя";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.AutoSize = true;
            this.textBoxSurname.Location = new System.Drawing.Point(120, 55);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(430, 35);
            this.textBoxSurname.TabIndex = 4;
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(9, 55);
            this.surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(81, 20);
            this.surname.TabIndex = 3;
            this.surname.Text = "Фамилия";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(586, 26);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(594, 355);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(34, 415);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(183, 57);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(610, 415);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(162, 57);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 509);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Данные о пользователях";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private TextBoxChar textBoxSurname;
        private System.Windows.Forms.Label surname;
        private TextBoxChar textBoxPatronymic;
        private TextBoxChar textBoxName;
        private System.Windows.Forms.Label patronymic;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label age;
        private TextBoxNum phoneNumberIndex;
        private TextBoxNum textBoxAge;
        private System.Windows.Forms.Label label8;
        private TextBoxNum phoneNumber;
        private TextBoxEMail textBoxEmail;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShow;
    }
}

