using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Library_user : Teacher
    {
        protected int Number;
        protected int Cost;
        protected DateTime DateIssue;
        public Library_user()
        {}
        public Library_user(int curse, int group, string faculty, string institut, string name, string surname, DateTime date, int zno, int document, string school, string position, string chair, string workInstitut, int number, int cost, DateTime dateIssue)
            : base(curse, group, faculty, institut, name, surname, date, zno, document, school, position, chair, workInstitut)
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
            DateIssue = dateIssue;
            Number = number;
            Cost = cost;
        }
        public Library_user(string name, string surname, int curse, int group, string faculty, string institut,  DateTime date, int zno, int document, string school, string position, string chair, string workInstitut, int number, int cost, DateTime dateIssue)
            : base(curse, group, faculty, institut, name, surname, date, zno, document, school, position, chair, workInstitut)
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
            DateIssue = dateIssue;
            Number = number;
            Cost = cost;
        }
        public int GetNumber()
        {
            return Number;
        }
        public DateTime GetDateIssue()
        {
            return DateIssue;
        }
        public int GetCost()
        {
            return Cost;
        }
        public void SetNumber(int newNumber)
        {
            Number = newNumber;
        }
        public void SetDateIssue(DateTime newDateIssue)
        {
            DateIssue = newDateIssue;
        }
        public void SetCost(int newCost)
        {
            Cost = newCost;
        }
        public void OutLibrary_User()
        {
            Console.WriteLine("Имя " + this.name + " Фамилия " + this.surname + " Номер билета " + this.Number + " Дата выдачи " + this.DateIssue + " Цена " + this.Cost);
        }
    }
}
