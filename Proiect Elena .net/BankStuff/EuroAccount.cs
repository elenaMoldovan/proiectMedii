
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Elena
{
    class EuroAccount : Account
    {

        public EuroAccount() { }

        public EuroAccount(string iban, int customerID, int employeeID) :base(iban, customerID, employeeID) 
        {

        }
    }
}
