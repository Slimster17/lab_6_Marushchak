using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab_6_Marushchak
{
    [Serializable]
    internal class Employee : ICloneable, IComparable<Employee>, ISerializable
    {
        private string name;
        private string office;
        private string position;
        private int experience;
        private double salary;
        private double bonus;
        [XmlAttribute]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [XmlAttribute]
        public string Office
        {
            get { return office; }
            set { office = value; }
        }
        [XmlAttribute]
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        [XmlAttribute]
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        [XmlAttribute]
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        [XmlAttribute]
        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public Employee(string name, string office, string position, int experience, double salary)
        {
            Name = name;
            Office = office;
            Position = position;
            Experience = experience;
            Salary = salary;
            CalculateBonus();
        }

        public Employee(string name, string office, string position, int experience, double salary, double bonus)
        {
            Name = name;
            Office = office;
            Position = position;
            Experience = experience;
            Salary = salary;
            Bonus = bonus;
        }

        private void CalculateBonus()
        {
            if (Experience >= 7)
            {
                Bonus = Salary * 0.3;
            }
            else if (Experience >= 5)
            {
                Bonus = Salary * 0.2;
            }
            else if (Experience >= 3)
            {
                Bonus = Salary * 0.1;
            }
            else
            {
                Bonus = 0;
            }
        }

        public object Clone()
        {
            return new Employee(Name,Office, Position, Experience, Salary, Bonus);
        }

        public int CompareTo(Employee other)
        {
            return Salary.CompareTo(other.Salary);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Office", Office);
            info.AddValue("Position", Position);
            info.AddValue("Experience", Experience);
            info.AddValue("Salary", Salary);
            info.AddValue("Bonus", Bonus);
        }

        // Конструктор десеріалізації для ISerializable
        public Employee(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Office = info.GetString("Office");
            Position = info.GetString("Position");
            Experience = info.GetInt32("Experience");
            Salary = info.GetDouble("Salary");
            Bonus = info.GetDouble("Bonus");
        }
    }

}
