using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Student: Applicant
    {
        protected int Curse;
        protected int Group;
        protected string Faculty;
        protected string Institut;
        public Student() 
        {
            Faculty = "None";
            Institut = "None";
        }
        public Student(int curse, int group, string faculty, string institut, string name, string surname, DateTime date,int zno, int document, string school) 
            : base(zno, document, school, name, surname, date)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
            Curse = curse;
            Group = group;
            Faculty = faculty;
            Institut = institut;
            ZNO = zno;
            Document = document;
            School = school;
        }
        public Student( DateTime date, int curse, int group, string faculty, string institut, string name, string surname, int zno, int document, string school)
            : base(zno, document, school, name, surname, date)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
            Curse = curse;
            Group = group;
            Faculty = faculty;
            Institut = institut;
            ZNO = zno;
            Document = document;
            School = school;
        }
        public Student(Student student) 
        {
            name = student.name;
            surname = student.surname;
            date = student.date;
            Curse = student.Curse;
            Group = student.Group;
            Faculty = student.Faculty;
            Institut = student.Institut;
            ZNO = student.ZNO;
            Document = student.Document;
            School = student.School;
        }
        public void OutStudent()
        {
            Console.WriteLine("Имя " + this.name + " Фамилия " + this.surname + " Дата рождения " + this.date + " Баллы за ЕГЕ " + this.ZNO + " Баллы за документ " + this.Document + " Название школы " + this.School + " Курс " + this.Curse + " Група " + this.Group + " Факультет " + this.Faculty + " Назва вузу " + this.Institut);
        }
        public void SetInstitut(string newInstitut)
        {
            Institut = newInstitut;
        }
        public void SetFaculty(string newFaculty)
        {
            Faculty = newFaculty;
        }
        public void SetCurse(int newCurse)
        {
            Curse = newCurse;
        }
        public void SetGroup(int newGroup)
        {
            Group = newGroup;
        }
        public string GetInstitut()
        {
            return Institut;
        }
        public string GetFaculty()
        {
            return Faculty;
        }
        public int GetCurse()
        {
            return Curse;
        }
        public int GetGroup()
        {
            return Group;
        }
    }
}
