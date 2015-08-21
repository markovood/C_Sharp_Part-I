using System;
using System.Threading;
using System.Globalization;

namespace Problem2.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            // A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
            // Write a program that reads the information about a company and its manager and prints it back on the console.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            Console.Write("Enter phone number (without country code): ");
            long telNumber = long.Parse(Console.ReadLine());


            Console.Write("Enter fax number (without country code): ");
            string faxNumber = Console.ReadLine();

            Console.Write("Enter web site: ");
            string webSite = Console.ReadLine();

            Console.Write("Enter manager's first name: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Enter manager's last name: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Enter manager's age: ");
            byte managerAge = byte.Parse(Console.ReadLine());

            Console.Write("Enter manager's phone number (without country code): ");
            long managerPhoneNumber = long.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("{0}\nAddress: {1}\nTel. {2:+359 ### ## ## ###}\nFax: {3}", companyName, address, telNumber,faxNumber);
            Console.WriteLine("Web site: http://" + webSite + "/");
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3:+359 # ### ###})",managerFirstName,managerLastName,managerAge,managerPhoneNumber);
            
        }
    }
}
