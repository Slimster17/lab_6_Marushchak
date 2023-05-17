using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6_Marushchak
{
    public partial class Form1 : Form
    {
        EmployeeCollection<Employee> employeeCollection = new EmployeeCollection<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Name.Text) || String.IsNullOrEmpty(textBox_Position.Text) || String.IsNullOrEmpty(textBox_Office.Text)
                || String.IsNullOrEmpty(textBox_Salary.Text) || String.IsNullOrEmpty(textBox_Experience.Text))
            {
                MessageBox.Show("Введiть усi дані!");
            }
            else
            {
                int salaty;
                if (!int.TryParse(textBox_Salary.Text, out salaty))
                {
                    MessageBox.Show("weight must be a digit");
                    return;
                }

                int experience;
                if (!int.TryParse(textBox_Experience.Text, out experience))
                {
                    MessageBox.Show("paymentPerDay must be a digit");
                    return;
                }

                string name = textBox_Name.Text;
                string position = textBox_Position.Text;
                string office = textBox_Office.Text;



                try
                {
                   

                    employeeCollection.AddEmployee(new Employee(name, position, office, experience, salaty));
                   

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_View_Click(object sender, EventArgs e)
        {
            textBox1.Text = employeeCollection.DisplayEmployees();
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            employeeCollection.SortEmployeesBySalary();
            textBox_sorted.Text = employeeCollection.DisplayEmployees();
        }

        private void button_SaveFile_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employees.xml");
            employeeCollection.SaveToFile(filePath);
        }
    }
}
