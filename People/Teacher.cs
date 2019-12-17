using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Teacher: Student
    {
        protected string Position;
        protected string Chair;
        protected string WorkInstitut;
        public Teacher()
        {
            Position = "None";
            Chair = "None";
            WorkInstitut = "None";
        }
        public Teacher(int curse, int group, string faculty, string institut, string name, string surname, DateTime date, int zno, int document, string school, string position, string chair, string workInstitut)
            : base(curse, group, faculty, institut, name, surname, date, zno, document, school)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
            this.Curse = curse;
            Group = group;
            Faculty = faculty;
            Institut = institut;
            ZNO = zno;
            Document = document;
            School = school;
            Position = position;
            Chair = chair;
            WorkInstitut = workInstitut;
        }
        public Teacher(string name, string surname, int curse, int group, string faculty, string institut,  DateTime date, int zno, int document, string school, string position, string chair, string workInstitut)
            : base(curse, group, faculty, institut, name, surname, date, zno, document, school)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
            this.Curse = curse;
            Group = group;
            Faculty = faculty;
            Institut = institut;
            ZNO = zno;
            Document = document;
            School = school;
            Position = position;
            Chair = chair;
            WorkInstitut = workInstitut;
        }
        public Teacher(Teacher teacher)
        {
            name = teacher.name;
            surname = teacher.surname;
            date = teacher.date;
            Curse = teacher.Curse;
            Group = teacher.Group;
            Faculty = teacher.Faculty;
            Institut = teacher.Institut;
            ZNO = teacher.ZNO;
            Document = teacher.Document;
            School = teacher.School;
            Position = teacher.Position;
            Chair = teacher.Chair;
            WorkInstitut = teacher.WorkInstitut;
        }
        public string GetPosition()
        {
            return Position;
        }
        public string GetChair()
        {
            return Chair;
        }
        public string GetWorkInstitut()
        {
            return WorkInstitut;
        }
        public void SetPosition(string newPosition)
        {
            Position = newPosition;
        }
        public void SetChair(string newChair)
        {
            Chair = newChair;
        }
        public void SetWorkInstitut(string newWorkInstitut)
        {
            WorkInstitut = newWorkInstitut;
        }
        public void OutTeacher()
        {
            Console.WriteLine("Имя " + this.name + " Фамилия " + this.surname + " Посада " + this.Position + " Кафедра " + this.Chair + " Институт " + this.WorkInstitut);
        }
    }
}
