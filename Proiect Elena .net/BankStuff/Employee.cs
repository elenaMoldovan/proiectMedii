using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Elena
{
    internal class Employee : Person
    {
        public Employee(int id, string name, int age, string email, string address, string phoneNumber)
            : base(id, name, age, email, address, phoneNumber) { }

        public Employee() { }
    }
}
