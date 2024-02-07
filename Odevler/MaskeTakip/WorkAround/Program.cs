using Business.Concrete;
using Entities.Concrete;

namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.NationalIdentity = 123;
            person.FirstName = "FIRAT";
            person.LastName = "ALÇIN";
            person.DateOfBirthYear = 1998;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);
        }     
    }
}
