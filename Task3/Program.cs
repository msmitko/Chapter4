using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyPhoneNumber = Console.ReadLine();
            string companyFaxNumber = Console.ReadLine();
            string companyWebSite = Console.ReadLine();
            string companyManagerFirstName = Console.ReadLine();
            string companyManagerLastName = Console.ReadLine();
            string companyManagerPhoneNumber = Console.ReadLine();

            Console.WriteLine("Company: {0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Phone: {0}", companyPhoneNumber);
            Console.WriteLine("Fax: {0}", companyFaxNumber);
            Console.WriteLine("Web site: {0}", companyWebSite);
            Console.WriteLine("Manager: {0} {1}", companyManagerFirstName, companyManagerLastName);
            Console.WriteLine("Manager phone: {0}", companyManagerPhoneNumber);
        }
    }
}
