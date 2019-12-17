using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            People p=new People(new DateTime(2015, 7, 20), "gjk","jfgh");
            People s = new People(p);           
            s.SetName("1234");
            p.OutPeople();
            s.OutPeople();
            Console.WriteLine("////////////////////");
            Applicant a = new Applicant();
            a.SetName("12");
            a.OutApplicant();
            a.SetSchool("urt");
            a.SetDocument(12);
            a.SetZNO(200);
            a.OutApplicant();
            Console.WriteLine("////////////////////");
            Student q = new Student();
            q.SetCurse(2);
            q.SetGroup(25);
            q.OutStudent();
            Console.WriteLine("////////////////////");
            Teacher t = new Teacher();
            Console.WriteLine(t.GetChair());
            t.OutTeacher();
            Console.WriteLine("////////////////////");
            Library_user j = new Library_user();
            j.SetName("Jake");
            j.SetInstitut("Agro");
            j.SetCost(1000);
            j.OutLibrary_User();
            Console.WriteLine(j.GetInstitut());
        }
    }
}
