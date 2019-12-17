using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class People
    {
        protected string name;
        protected string surname;
        protected DateTime date;
        public People()
        {
            name = "None";
            surname = "None";
            date= new DateTime();
        }
        public People(string Name, string Surname, DateTime Date)
        {
            name = Name;
            surname = Surname;
            date = Date;
        }
        public People(DateTime Date, string Surname, string Name)
        {
            name = Name;
            surname = Surname;
            date = Date;
        }
        public People(People people)
        {
            name = people.name;
            surname = people.surname;
            date = people.date;
        }
        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public DateTime GetDate()
        {
            return date;
        }
        public void SetName(string newName)
        {
            if (newName.IndexOf(" ") == -1 && newName.Trim().Length > 0)
            {
                name = newName;
            }
            else
            {
                Console.WriteLine("Неправильное имя");
            }
        }
        public void SetDate(DateTime date)
        {
            this.date = date;
        }
        public void SetSurname(string newsSurname)
        {
            if (newsSurname.IndexOf(" ") == -1 && newsSurname.Trim().Length > 0)
            {
                surname = newsSurname;
            }
            else
            {
                Console.WriteLine("Неправильная фамилия");
            }
        }
        public void OutPeople()
        {
            Console.WriteLine("Имя " + this.name + " Фамилия " + this.surname + " Дата рождения " + this.date);
        }
        public void CopyPeople(People p)
        {
            this.SetName(p.name);
            this.SetSurname(p.surname);
            this.SetDate(p.date);
        }
    }
}
