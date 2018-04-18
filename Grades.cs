using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudentGrades
{
    public class Grades
    {
        public void Marks()
        {
            double science, maths, social, total;
            string grade;
            Console.WriteLine("Enter Three subject Marks:");
            science = Convert.ToDouble(Console.ReadLine());
            maths = Convert.ToDouble(Console.ReadLine());
            social = Convert.ToDouble(Console.ReadLine());

            if (science >= 35 && maths >= 35 && social >= 35)
            {
                Console.WriteLine("Result is Pass");
                total = science + maths + social;
                if (total>=240)
                {
                    Console.WriteLine("Grade is A");
                }else if (total >= 180)
                {
                    Console.WriteLine("Grade is B");
                }else 
                {
                    Console.WriteLine("Grade is C");
                }
            }
            else
            {
                Console.WriteLine("Result is Fail");
                if (science<35)
                {
                    Console.WriteLine("Failed in Science");
                }
                if (maths < 35)
                {
                    Console.WriteLine("Failed in Maths");
                }
                if (social < 35)
                {
                    Console.WriteLine("Failed in Social");
                }
            }
            Console.ReadLine();

        }
    }
}
