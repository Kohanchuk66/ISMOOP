using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Company
    {
        protected string Name;
        protected string Position;
        protected int Salary;
        public Company()
        {
            Name = "None";
            Position = "None";
        }
        public Company(Company newCompany)
        {
            Name = newCompany.Name;
            Position = newCompany.Position;
            Salary = newCompany.Salary;
        }
        public Company(string Name,string Position)
        {
            this.Name = Name;
            this.Position = Position;
            this.Salary = 0;
        }
        public Company(string Name, string Position,int Salary)
        {
            this.Name = Name;
            this.Position = Position;
            this.Salary = Salary;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string newName)
        {
            if (newName.IndexOf(" ") == -1 && newName.Trim().Length > 0)
            {
                Name = newName;
            }
            else
            {
                Console.WriteLine("Неправильное имя");
            }
        }
        public string GetPosition()
        {
            return Position;
        }
        public void SetPosition(string newPosition)
        {
            if (newPosition.Trim().Length > 0)
            {
                Position = newPosition;
            }
            else
            {
                Console.WriteLine("Неправильная должность");
            }
        }
        public int GetSalary()
        {
            return Salary;
        }
        public void SetSalary(int newSalary)
        {
            if (newSalary > 3000)//мин зп
            {
                Salary = newSalary;
            }
            else
            {
                Console.WriteLine("Неправильная зарплата");
            }
        }
    }
}
