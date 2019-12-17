using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Worker
    {
        protected string Name;
        protected int Year;
        protected int Month;
        protected Company WorkPlace = new Company();
        public Worker() 
        {
            Name = "None";
            Month = 1;
        }
        public Worker(string Name, int Year, int Month) 
        {
            this.Name = Name;
            this.Year = Year;
            this.Month = Month;
        }
        public Worker(string Name, int Year, int Month, Company WorkPlace)
        {
            this.Name = Name;
            this.Year = Year;
            this.Month = Month;
            this.WorkPlace = WorkPlace;
        }
        public Worker(Worker newWorker)
        {
            Name = newWorker.Name;
            Year = newWorker.Year;
            Month = newWorker.Month;
            WorkPlace = newWorker.WorkPlace;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string newName)
        {
            if(newName.IndexOf(" ")==-1&&newName.Trim().Length>0)
            {
                Name = newName;
            }
            else
            {
                Console.WriteLine("Неправильное имя");
            }
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetYear(int newYear)
        {
            if (newYear>1820)//засноование компании
            {
                Year = newYear;
            }
            else
            {
                Console.WriteLine("Неправильный год");
            }
        }
        public int GetMonth()
        {
            return Month;
        }
        public void SetMonth(int newMonth)
        {
            if (newMonth > 0 && newMonth<13)//засноование компании
            {
                Month = newMonth;
            }
            else
            {
                Console.WriteLine("Неправильный месяц");
            }
        }
        public Company GetWorkPlace()
        {
            return WorkPlace;
        }
        public void SetWorkPlace(Company newWorkPlace)
        {
              WorkPlace = newWorkPlace;          
        }
        public int GetWorkExperience()
        {
            return DateTime.Now.Year * 12 + DateTime.Now.Month - Year * 12 - Month;
        }
        public int GetTotalMoney()
        {
            return (GetWorkExperience() * WorkPlace.GetSalary());
        }
    }
}
