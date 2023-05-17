using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_6_Marushchak
{
    internal class EmployeeCollection<T> where T : Employee
    {

        private BindingList<T> employees;

        public BindingList<T> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public EmployeeCollection()
        {
            employees = new BindingList<T>();
        }

        public void AddEmployee(T employee)
        {
            employees.Add(employee);
        }

        public string DisplayEmployees()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T employee in employees)
            {
                sb.AppendLine($"Ім'я: {employee.Name}");
                sb.AppendLine($"Відділ: {employee.Office}");
                sb.AppendLine($"Посада: {employee.Position}");
                sb.AppendLine($"Стаж: {employee.Experience} років");
                sb.AppendLine($"Оклад: {employee.Salary}");
                sb.AppendLine($"Премія: {employee.Bonus}");
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public void SortEmployeesBySalary()
        {
            var sortedList = employees.OrderBy(emp => emp.Salary).ToList();
            Employees = new BindingList<T>(sortedList);
        }

        public BindingList<T> GetEmployeesByPosition(string position)
        {
            return new BindingList<T>(employees.Where(emp => emp.Position == position).ToList());
        }

        public void SaveToFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<T>));

            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fileStream, employees);
            }
        }

        public void LoadFromFile(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                using (XmlReader reader = XmlReader.Create(fileStream))
                {
                    DataContractSerializer serializer = new DataContractSerializer(typeof(BindingList<T>));
                    employees = (BindingList<T>)serializer.ReadObject(reader);
                }
            }
        }

    }

}
