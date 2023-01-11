using IbanGeneratorLibrary;
using MySqlConnector;
using Org.BouncyCastle.Tls;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proiect_Elena
{
    internal class Menu
    {
        const string myConnectionString = "server=localhost;uid=root;" +
                "pwd=informatica?!12;database=verobank";
        private static void Main(string[] args)
        {
            menu();
        }

        private static void menu()
        {
            int a;

            do
            {
                showOptions();
                Console.Write("Choose Option : ");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    //Exit
                    case 0:
                        Console.Write("Closing");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        break;
                    //Show All Employees
                    case 1:
                        showAllEmployees();
                        break;
                    //Add Employee
                    case 2:
                        addEmployee();
                        break;
                    //Show All Customers
                    case 3:
                        showAllCustomers();
                        break;
                    //Add Customer
                    case 4:
                        addCustomer();
                        break;
                    //Show All Euro Account
                    case 5:
                        showAllEuroAccount();
                        break;
                    //Add Euro Account
                    case 6:
                        addEuroAccount();
                        break;
                    //Show All Ron Account
                    case 7:
                        showAllRonAccount();
                        break;
                    //Add Ron Account
                    case 8:
                        addRonAccount();
                        break;

                    default:
                        break;

                }
            } while (a != 0);
        }
        private static void showOptions()
        {
            Console.WriteLine("\t\t\t\t\t\tMenu:\n\t\t\t1.Show All Employees\n\t\t\t2.Add Employee\n\t\t\t3.Show all Customers\n" +
                "\t\t\t4.Add Customer\n\t\t\t5.Show All Euro Account\n\t\t\t6.Create Euro Account\n\t\t\t7.Show all Ron Account\n" +
                "\t\t\t8.Create Ron Account\n\t\t\t0.Exit");
        }

        private static void showAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            MySqlConnection conn;

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("Select * from customer", conn);
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        customers.Add(new Customer(mySqlDataReader.GetInt16(0), mySqlDataReader.GetString(1), mySqlDataReader.GetInt16(2),
                           mySqlDataReader.GetString(3), mySqlDataReader.GetString(4), mySqlDataReader.GetString(5)));
                    }
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message);
            }
            foreach(Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        private static void addCustomer()
        {
            MySqlConnection conn;
            string name, address, phoneNumber, email;
            int age;

            Console.Write("Customer Name : ");
            name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Customer Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Customer Address : ");
            address = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Customer Phone Number : ");
            phoneNumber = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Customer Email : ");
            email = Console.ReadLine();
            Console.WriteLine();

            conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO customer(name, age, address, email, phone_number)" +
                    " values('" + name + "'," + age + ",'" + address + "','" + email + "','" + phoneNumber + "')", conn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

                conn.Close();

            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message);
            }
            showAllCustomers();
            menu();
        }

        private static void showAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            
            MySqlConnection conn;

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("Select * from employee", conn);
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        employees.Add(new Employee(mySqlDataReader.GetInt16(0), mySqlDataReader.GetString(1), mySqlDataReader.GetInt16(2),
                           mySqlDataReader.GetString(3), mySqlDataReader.GetString(4), mySqlDataReader.GetString(5)));
                    }
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        private static void addEmployee()
        {
            MySqlConnection conn;
            string name, address, phoneNumber, email;
            int age;

            Console.Write("Employee Name : ");
            name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Employee Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Employee Address : ");
            address = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Employee Phone Number : ");
            phoneNumber = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Employee Email : ");
            email = Console.ReadLine();
            Console.WriteLine();

            conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                
                MySqlCommand cmd = new MySqlCommand("INSERT INTO employee(name, age, address, email, phone_number)" +
                    " values('" + name +"'," + age + ",'" + address + "','" + email + "','" + phoneNumber + "')" , conn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                   
                conn.Close();
 
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message);
            }
            showAllEmployees();
            menu();
        }

        private static List<EuroAccount> showAllEuroAccount()
        {
            List<EuroAccount> euroAccounts = new List<EuroAccount>();

            MySqlConnection conn;

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("Select * from euro_account", conn);
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        euroAccounts.Add(new EuroAccount(mySqlDataReader.GetString(1), mySqlDataReader.GetInt16(2), mySqlDataReader.GetInt16(3)));
                    }
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (EuroAccount euroAccount in euroAccounts)
            {
                Console.WriteLine(euroAccount);
            }
            return euroAccounts;
        }

        private static void addEuroAccount()
        {
            MySqlConnection conn;
            string iban;
            int customerID, employeeID;
            List<EuroAccount> euroAccounts = showAllEuroAccount();
            List<String> ibanList = new List<String>();
            euroAccounts.ForEach(a => { ibanList.Add(a.GetIban()); });

            showAllCustomers();
            Console.Write("Enter Customer ID from List : ");
            customerID = Convert.ToInt32(Console.ReadLine());

            showAllEmployees();
            Console.Write("Enter Employee ID from List : ");
            employeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Generating Iban");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");

            do
            {
                iban = Generator.getEuroIban();
                if (ibanList.Contains(iban))
                {
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);


            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO euro_account(iban, customerID, employeeID)" +
                    " values('" + iban + "'," + customerID + "," + employeeID + ")", conn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

                conn.Close();

            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message);
            }
            showAllEuroAccount();
            menu();
        }
        private static List<RonAccount> showAllRonAccount()
        {
            List<RonAccount> ronAccounts = new List<RonAccount>();

            MySqlConnection conn;

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("Select * from ron_account", conn);
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        ronAccounts.Add(new RonAccount(mySqlDataReader.GetString(1), mySqlDataReader.GetInt16(2), mySqlDataReader.GetInt16(3)));
                    }
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message);
            }
            foreach (RonAccount ronAccount in ronAccounts)
            {
                Console.WriteLine(ronAccount);
            }
            return ronAccounts;
        }
        private static void addRonAccount()
        {
            MySqlConnection conn;
            string iban;
            int customerID, employeeID;
            List<RonAccount> ronAccounts = showAllRonAccount();
            List<String> ibanList = new List<String>();
            ronAccounts.ForEach(a => { ibanList.Add(a.GetIban()); });

            showAllCustomers();
            Console.Write("Enter Customer ID from List : ");
            customerID = Convert.ToInt32(Console.ReadLine());

            showAllEmployees();
            Console.Write("Enter Employee ID from List : ");
            employeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Generating Iban");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");

            do
            {
                iban = Generator.getRonIban();
                if (ibanList.Contains(iban))
                {
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);


            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO ron_account(iban, customerID, employeeID)" +
                    " values('" + iban +  "'," + customerID + "," + employeeID + ")", conn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

                conn.Close();

            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message);
            }
            showAllRonAccount();
            menu();
        }

    }
}
