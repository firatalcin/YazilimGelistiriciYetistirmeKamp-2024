using Intro.Business;
using Intro.Entities;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Krediler";
            int term = 12;
            double amount = 100000.5;

            //variables -> camelCase
            bool IsAuthenticated = true;

            Console.WriteLine(message);

            //Condition
            if (IsAuthenticated)
            {
                Console.WriteLine("Hoşgeldin Fırat");
            }

            string[] loans = { "kredi 1", "kredi 2", "kredi 3", "kredi 4", "kredi 5" };

            for (int i = 0; i < loans.Length; i++)
            {
                Console.WriteLine(loans[i]);
            }

            CourseManager courseManager = new CourseManager();
            Course[] courses = courseManager.GetAll();

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i].Name + " - " + courses[i].Price);
            }


            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.NationalIdentity = "12345678911";
            customer1.FirstName = "Aslı";
            customer1.LastName = "Karayiğit";
            customer1.CustomerNumber = "123456";
            IndividualCustomer customer2 = new IndividualCustomer();
            customer2.Id = 2;
            customer2.NationalIdentity = "12345678912";
            customer2.FirstName = "Özgür";
            customer2.LastName = "Atılgan";
            customer2.CustomerNumber = "123457";

            CorporateCustomer customer3 = new CorporateCustomer();
            customer3.Id = 3;
            customer3.Name = "KodlamaIO";
            customer3.CustomerNumber = "654778";
            customer3.TaxNumber = "1234567891";

            CorporateCustomer customer4 = new CorporateCustomer();
            customer3.Id = 4;
            customer3.Name = "Abc";
            customer3.CustomerNumber = "654779";
            customer3.TaxNumber = "1234567892";

            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 50;
            Console.WriteLine(number1);

            string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
            string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

            cities2 = cities1;
            cities1[0] = "Adana";

            Console.WriteLine(cities2[0]);

            BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerNumber);
            }



        }
    }
}
