using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Elena
{
    internal class Person
    {
        private int id { get; set; }
        private int age { get; set; }
        private string name { get; set; }
        private string email { get; set; }
        private string address { get; set; }
        private string phoneNumber { get; set; }

        public Person() { }
        public Person(int id, string name, int age, string email, string address, string phoneNumber)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.email = email;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return "ID : " + id + " Name : " + name + " Age : "+ age + " Email : " + email +
                " Address : " + address + " Phone Number : " + phoneNumber;
        }

    }
}
