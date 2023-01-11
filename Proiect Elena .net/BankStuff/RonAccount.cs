using Proiect_Elena;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Elena
{
    class RonAccount : Account
    {
        public RonAccount() { }

        public RonAccount(string iban, int customerID, int employeeID) : base(iban, customerID, employeeID)
        {

        }
    }
}
