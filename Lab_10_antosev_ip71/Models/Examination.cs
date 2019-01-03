using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_antosev_ip71.Models
{
    public class Examination
    {
        public int Semester { get; set; }
        public string Subject { get; set; }
        public string Teacher { get; set; }
        public int Mark { get; set; }
        public bool Differentiated { get; set; }
        public DateTime Date { get; set; }

        public Examination()
        {
            Semester = 1;
            Subject = "Programming";
            Teacher = "David J. Malan";
            Mark = 0;
            Differentiated = true;
            Date = new DateTime(2018,12,24);
        }

        public Examination(int semester,
                           string subject,
                           string teacher,
                           int mark,
                           bool differentiated,
                           DateTime date)
        {
            Semester = semester;
            Subject = subject;
            Teacher = teacher;
            Mark = mark;
            Differentiated = differentiated;
            Date = date;
        }

        public override string ToString()
        {
            return "Subject: " + Subject + "\nTeacher: " + Teacher + "\nMark: " + Mark + "\n";
        }
    }
}
