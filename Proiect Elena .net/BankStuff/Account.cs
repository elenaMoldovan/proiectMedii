using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Elena
{
    class Account
    {
        private string iban;
        private int customerID;

        private int employeeID;
        public string GetIban()
        {
            return this.iban;
        }
        public void SetIban(string iban)
        {
            this.iban = iban;
        }
        public void SetCustomerID(int customerID)
        {
            this.customerID = customerID;
        }
        public int GetCustomerID()
        {
            return this.customerID;
        }


        public void SetEmployeeID(int employeeID)
        {
            this.employeeID = employeeID;
        }
        public int GetEmployeeID()
        {
            return this.employeeID;
        }


        public Account() { }

        public Account(string iban, int customerID, int employeeID)
        {
            this.iban = iban;
            this.customerID = customerID;
            this.employeeID = employeeID;
        }
        public override string ToString()
        {
            return "Iban : " + iban + " Customer ID : " + customerID + " Employee ID : " + employeeID;
        }
    }
}
