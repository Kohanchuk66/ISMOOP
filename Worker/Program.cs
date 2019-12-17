using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            Company c = new Company("fg","sadrg",12);
            Worker w = new Worker();
            Worker[] work = new Worker[100];
            int max , min;
            w.SetWorkPlace(c);
            //Console.WriteLine(w.GetTotalMoney());
             work=ReadWorkersArray();
            // for(int i = 0; i < work.Length; i++)
            //{
            //   Console.WriteLine(work[i].GetName());
            //}
            //PrintWorker(w);
            GetWorkersInfo(work,out max,out min);
        }
        static Worker[] ReadWorkersArray()
        {
            Worker[] work = new Worker[100];
            Worker worker = new Worker();
            Company company = new Company();
            Console.WriteLine("Введите количество человек: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите имя {i} человекa: ");
                worker.SetName(Console.ReadLine());
                Console.WriteLine($"Введите год начала работы {i}-го человекa: ");
                worker.SetYear(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Введите месяц начала работы {i}-го человекa: ");
                worker.SetMonth(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Введите название компании {i} человекa: ");
                company.SetName(Console.ReadLine());
                Console.WriteLine($"Введите должность {i} человекa: ");
                company.SetPosition(Console.ReadLine());
                Console.WriteLine($"Введите зарплату {i} человекa: ");
                company.SetSalary(int.Parse(Console.ReadLine()));
                worker.SetWorkPlace(company);
                work[i]=new Worker(worker);
            }
            return work;
        }
        static void PrintWorker(Worker worker)
        {
            Console.WriteLine($"Имя работника: {worker.GetName()}");
            Console.WriteLine($"Год начала работы: {worker.GetYear()}");
            Console.WriteLine($"Месяц начала работы: {worker.GetMonth()}");
            Console.WriteLine($"Название компании: {worker.GetWorkPlace().GetName()}");
            Console.WriteLine($"Должность: {worker.GetWorkPlace().GetPosition()}");
            Console.WriteLine($"Зарплата: {worker.GetWorkPlace().GetSalary()}");
        }
        static void PrintWorkers(Worker[] worker)
        {
            for (int i = 0; i < worker.Length; i++)
            {
                Console.WriteLine($"Имя {i}-го работника: {worker[i].GetName()}");
                Console.WriteLine($"Год начала работы {i}-го работника: {worker[i].GetYear()}");
                Console.WriteLine($"Месяц начала работы {i}-го работника: {worker[i].GetMonth()}");
                Console.WriteLine($"Название компании {i}-го работника: {worker[i].GetWorkPlace().GetName()}");
                Console.WriteLine($"Должность {i}-го работника: {worker[i].GetWorkPlace().GetPosition()}");
                Console.WriteLine($"Зарплата {i}-го работника: {worker[i].GetWorkPlace().GetSalary()}");
            }
        }
        static void GetWorkersInfo(Worker[] worker,out int max, out int min)
        {
            max = 0;
            min = 0;
            for (int i = 0; i < worker.Length; i++)
            {
                if (worker[i].GetWorkPlace().GetSalary() > max)
                    max = worker[i].GetWorkPlace().GetSalary();
                if (worker[i].GetWorkPlace().GetSalary() < min)
                    min = worker[i].GetWorkPlace().GetSalary();
            }
        }
        static void SortWorkerBySalary(ref Worker[]  worker)
        {
            Worker sw;
            for(int i=0;i < worker.Length; i++)
            {
                for(int j=0;j< worker.Length; j++)
                {
                    if(worker[i].GetWorkPlace().GetSalary()< worker[i + 1].GetWorkPlace().GetSalary())
                    {
                        sw = new Worker(worker[i]);
                        worker[i] = new Worker(worker[i + 1]);
                        worker[i + 1] = new Worker(sw);
                    }
                }
            }
        }
        static void SortWorkerByWorkExperience(ref Worker[] worker)
        {
            Worker sw;
            for (int i = 0; i < worker.Length; i++)
            {
                for (int j = 0; j < worker.Length; j++)
                {
                    if (worker[i].GetWorkExperience() > worker[i + 1].GetWorkExperience())
                    {
                        sw = new Worker(worker[i]);
                        worker[i] = new Worker(worker[i + 1]);
                        worker[i + 1] = new Worker(sw);
                    }
                }
            }
        }
    }
}
