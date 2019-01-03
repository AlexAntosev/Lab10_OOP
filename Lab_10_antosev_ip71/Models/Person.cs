using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_antosev_ip71.Models
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }

        public Person()
        {
            Firstname = "John";
            Lastname = "Smith";
            Birthday = new DateTime(2000,01,01);
        }

        public Person(string firstname, string lastname, DateTime birthday)
        {
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
        }

        public virtual void PrintFullInfo()
        {
            Console.WriteLine("Firstname: {0}\nLastname: {1}\nBirthday: {2}",Firstname, Lastname, Birthday);
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Person person = (Person)obj;
                return (Firstname == person.Firstname) && (Lastname == person.Lastname) && (Birthday == person.Birthday);
            }
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return (p1.Firstname == p2.Firstname) && (p1.Lastname == p2.Lastname) && (p1.Birthday == p2.Birthday);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1.Firstname == p2.Firstname) && !(p1.Lastname == p2.Lastname) && !(p1.Birthday == p2.Birthday);
        }

        public int CurrentAge()
        {
            DateTime now = DateTime.Now;
            return (now - Birthday).Days / 365;
        }
    }
}
