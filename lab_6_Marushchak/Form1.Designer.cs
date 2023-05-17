namespace lab_6_Marushchak
{
    partial class Form1
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
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Office = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Experience = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Position = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_View = new System.Windows.Forms.Button();
            this.textBox_sorted = new System.Windows.Forms.TextBox();
            this.button_Sort = new System.Windows.Forms.Button();
            this.button_SaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(53, 202);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 52);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Додати";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(53, 66);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ПІБ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Відділ";
            // 
            // textBox_Office
            // 
            this.textBox_Office.Location = new System.Drawing.Point(53, 121);
            this.textBox_Office.Name = "textBox_Office";
            this.textBox_Office.Size = new System.Drawing.Size(100, 20);
            this.textBox_Office.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Стаж";
            // 
            // textBox_Experience
            // 
            this.textBox_Experience.Location = new System.Drawing.Point(53, 150);
            this.textBox_Experience.Name = "textBox_Experience";
            this.textBox_Experience.Size = new System.Drawing.Size(100, 20);
            this.textBox_Experience.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Оклад";
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Location = new System.Drawing.Point(53, 176);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(100, 20);
            this.textBox_Salary.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Посада";
            // 
            // textBox_Position
            // 
            this.textBox_Position.Location = new System.Drawing.Point(53, 95);
            this.textBox_Position.Name = "textBox_Position";
            this.textBox_Position.Size = new System.Drawing.Size(100, 20);
            this.textBox_Position.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 134);
            this.textBox1.TabIndex = 11;
            // 
            // button_View
            // 
            this.button_View.Location = new System.Drawing.Point(194, 202);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(137, 52);
            this.button_View.TabIndex = 12;
            this.button_View.Text = "Переглянути";
            this.button_View.UseVisualStyleBackColor = true;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // textBox_sorted
            // 
            this.textBox_sorted.Location = new System.Drawing.Point(346, 62);
            this.textBox_sorted.Multiline = true;
            this.textBox_sorted.Name = "textBox_sorted";
            this.textBox_sorted.Size = new System.Drawing.Size(108, 134);
            this.textBox_sorted.TabIndex = 13;
            // 
            // button_Sort
            // 
            this.button_Sort.Location = new System.Drawing.Point(346, 202);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(108, 52);
            this.button_Sort.TabIndex = 14;
            this.button_Sort.Text = "Сортувати";
            this.button_Sort.UseVisualStyleBackColor = true;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // button_SaveFile
            // 
            this.button_SaveFile.Location = new System.Drawing.Point(346, 260);
            this.button_SaveFile.Name = "button_SaveFile";
            this.button_SaveFile.Size = new System.Drawing.Size(108, 52);
            this.button_SaveFile.TabIndex = 15;
            this.button_SaveFile.Text = "Зберегти у файл";
            this.button_SaveFile.UseVisualStyleBackColor = true;
            this.button_SaveFile.Click += new System.EventHandler(this.button_SaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_SaveFile);
            this.Controls.Add(this.button_Sort);
            this.Controls.Add(this.textBox_sorted);
            this.Controls.Add(this.button_View);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Position);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Experience);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Office);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Office;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Experience;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Position;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.TextBox textBox_sorted;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.Button button_SaveFile;
    }
}

