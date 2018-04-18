using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student1 = new Students();
            Subjects subj = new Subjects();
            Console.WriteLine("Welcome to Student grade system");
            string studentUsername = Console.ReadLine();
            string studentFirstname = Console.ReadLine();
            string studentlastname = Console.ReadLine();

            Console.WriteLine("Student username is {0}", studentUsername);
            Console.WriteLine("Student firstname is {0}", studentFirstname);
            Console.WriteLine("Student lastname is {0}", studentlastname);

            Console.WriteLine("Please Enter Student grade for username {0}:", studentUsername);
            string studentGrade = Console.ReadLine();
            Console.WriteLine("Student grade is {0}:", studentGrade);


            string s1 = subj.Subj1("science");
            string s2 = subj.Subj2("maths");
            //for (C)
            //{
            //    if (s1 == "science")
            //    {

            //        Console.WriteLine("For student");
            //    }
            //}
            

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }

    }
}
