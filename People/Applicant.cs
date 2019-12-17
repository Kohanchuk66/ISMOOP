using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Applicant : People
    {
        protected int ZNO;
        protected int Document;
        protected string School;
        public Applicant()
        {
            School = "None";
        }
        public Applicant(int zno, int document, string school, string name, string surname, DateTime date)
            : base(name, surname, date)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
            ZNO = zno;
            Document = document;
            School = school;
        }
        public Applicant(string school, int zno, int document, string name, string surname, DateTime date)
            : base(name, surname, date)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
            ZNO = zno;
            Document = document;
            School = school;
        }
        public Applicant(Applicant applicant)
        {
            ZNO = applicant.ZNO;
            Document = applicant.Document;
            School = applicant.School;
            name = applicant.name;
            surname = applicant.surname;
            date = applicant.date;
        }
        public void OutApplicant()
        {
            Console.WriteLine("Имя " + this.name + " Фамилия " + this.surname + " Дата рождения " + this.date + " Баллы за ЕГЕ " + this.ZNO + " Баллы за документ " + this.Document + " Название школы " + this.School);
        }
        public void SetZNO(int newZNO)
        {
            ZNO = newZNO;
        }
        public void SetDocument(int newDocument)
        {
            Document = newDocument;
        }
        public void SetSchool(string newSchool)
        {
            School = newSchool;
        }
        public int GetZNO()
        {
            return ZNO;
        }
        public int GetDocument()
        {
            return Document;
        }
        public string GetSchool()
        {
            return School;
        }
    }
}
