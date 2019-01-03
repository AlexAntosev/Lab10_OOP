using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_antosev_ip71.Models
{
    enum Education
    {
        Master,
        Bachelor,
        SecondEducation,
        PhD
    }

    class Student : Person
    {
        public Education Education { get; set; }
        public string Group { get; set; }
        public int AccountBook { get; set; }
        public List<Examination> Examinations { get; set; }

        public Student(string firstname, string lastname, DateTime birthday) : base(firstname, lastname, birthday)
        {
            Examinations = new List<Examination>();
        }

        public int AverageMark
        {
            get
            {
                int average = 0;
                foreach (var exam in Examinations)
                {
                    average += exam.Mark;
                }

                average /= Examinations.Count;
                return average;
            }
            private set { }
        }

        public void AddExams(Examination[] examList)
        {
            foreach (var exam in examList)
            {
                Examinations.Add(exam);
            }
        }

        public override string ToString()
        {
            return "Firstname: " + Firstname +  "\nLastname: " + Lastname + "\nGroup: " + Group + "\n";
        }

        public override void PrintFullInfo()
        {
            Console.WriteLine("Firstname: {0}\nLastname: {1}\nBirthday: {2}\nEducation: {3}\nGroup: {4}\nAccountBook: {5}", Firstname, Lastname, Birthday, Education, Group, AccountBook);
            Console.WriteLine("Exams:");
            foreach (var exam in Examinations)
            {
                Console.WriteLine(exam.ToString());
            }
        }

        public string PrintExamsWithMarkLowerThen(int mark)
        {
            string fullInfo = "";
            foreach (var exam in Examinations)
            {
                if (exam.Mark < mark)
                    fullInfo += exam.ToString();
            }

            return fullInfo;
        }

        public string PrintOnlyExams()
        {
            string fullInfo = "";
            foreach (var exam in Examinations)
            {
                if (exam.Differentiated)
                    fullInfo += exam.ToString();
            }

            return fullInfo;
        }
    }
}
