using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_C__LESSON_3._1
{
    public class Person
    {

        public Person() { }

        public Person(string nama, string surname, string email, string phone, DateTime dateTime)
        {
            this.name = nama;
            this.surname = surname;
            this.email = email;
            this.phone = phone;
            DateTime = dateTime;
        }

        public string name { get; set; }
        public string surname { get; set; } 
        public string email { get; set; }   
        public string phone { get; set; }
        public DateTime DateTime { get; set; }

        public override string ToString()
        {
            return $" {name} ";
        }

    }
}
