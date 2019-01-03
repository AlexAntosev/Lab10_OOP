using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_10_antosev_ip71.Models;

namespace Lab_10_antosev_ip71
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main Task
            Student student = new Student("Alex","Antosev", new DateTime(2000,01,17));
            student.Group = "ip71";
            student.AccountBook = 7102;
            student.Education = Education.Bachelor;

            student.ToString();

            Examination exam1 = new Examination(3,"OOP","Mukha I.P.", 100, true, new DateTime(2019,01,09));
            Examination exam2 = new Examination(3, "Probability Theory", "Garko I.I.", 95, true, new DateTime(2019, 01, 14));
            Examination exam3 = new Examination(3, "AC", "Kogan A.V.", 80, false, new DateTime(2019, 01, 18));
            Examination[] exams = new Examination[3] { exam1, exam2, exam3 };

            student.AddExams(exams);
            student.ToString();
            student.PrintFullInfo();

            //Task 2
            Console.WriteLine("Task 2");
            Person p1 = new Person("Alex", "Antosev", new DateTime(2000,01,17));
            Person p2 = new Person("Mark", "Zubach", new DateTime(2000, 05, 30));
            Person p3 = new Person("Alex", "Antosev", new DateTime(2000, 01, 17));

            Console.WriteLine("Person 1:");
            p1.PrintFullInfo();
            Console.WriteLine("Person 2:");
            p2.PrintFullInfo();
            Console.WriteLine("Person 3:");
            p3.PrintFullInfo();

            Console.WriteLine("Method Equals(Person 1 and Person 2): {0}", p1.Equals(p2));
            Console.WriteLine("Method Equals(Person 1 and Person 3): {0}", p1.Equals(p3));

            Console.WriteLine("Operation == (Person 1 and Person 2): {0}", p1 == p2);
            Console.WriteLine("Operation == (Person 1 and Person 3): {0}", p1 == p3);

            Console.WriteLine("Operation != (Person 1 and Person 2): {0}", p1 != p2);
            Console.WriteLine("Operation != (Person 1 and Person 3): {0}", p1 != p3);

            //Task 5
            Console.WriteLine("Task 5");
            Console.WriteLine("Exams with mark lower than: ");
            int mark;
            try
            {
                mark = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Mark must be integer value");
                throw;
            }

            Console.WriteLine(student.PrintExamsWithMarkLowerThen(mark));

            //Task 8
            Console.WriteLine("Task 8");
            Console.WriteLine("Only exams:");
            Console.WriteLine(student.PrintOnlyExams());

            //Task 11
            Console.WriteLine("Task 11");
            
            p1.ToString();
            p1.PrintFullInfo();
            Console.WriteLine("Person age is: {0}", p1.CurrentAge().ToString());

            Console.ReadKey();
        }
    }
}
