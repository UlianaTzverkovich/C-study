namespace ITMO.WinForm.Lab4_Task2
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
            this.personsListView = new System.Windows.Forms.ListView();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personsListView
            // 
            this.personsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstName,
            this.lastName,
            this.age});
            this.personsListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.personsListView.HideSelection = false;
            this.personsListView.Location = new System.Drawing.Point(0, 0);
            this.personsListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.personsListView.Name = "personsListView";
            this.personsListView.Size = new System.Drawing.Size(658, 450);
            this.personsListView.TabIndex = 0;
            this.personsListView.UseCompatibleStateImageBehavior = false;
            this.personsListView.View = System.Windows.Forms.View.Details;
            // 
            // firstName
            // 
            this.firstName.Text = "Имя";
            this.firstName.Width = 118;
            // 
            // lastName
            // 
            this.lastName.Text = "Фамилия";
            this.lastName.Width = 175;
            // 
            // age
            // 
            this.age.Text = "Возраст";
            this.age.Width = 142;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(108, 495);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(135, 52);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.Location = new System.Drawing.Point(393, 495);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(153, 52);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 595);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.personsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Список сотрудников";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView personsListView;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
    }
}

