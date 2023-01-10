using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSysteam
{
    public class ContactList
    {
        Person person = new Person();
        List<Person> people = new List<Person>();
        public void welcomeMeassage()    //Welcome Meassage 
        {
            Console.WriteLine("Welcome to Address Book Program \n");
        }
        public void AddPerson()   //Adding person 
        {
            person = new Person();
            Console.WriteLine("Enter Your First name ");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last name");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter  your Address ");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter your phone Number ");
            person.phoneNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Youe Email Id ");
            person.emailid = Console.ReadLine();
            people.Add(person);

        }
        public void ListPeople()
        {
            if (people.Count == 0)
            {
                Console.WriteLine("Your Address book is empty. Press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people found in your address book :");
            foreach (var person in people)
            {
                Console.WriteLine($"\n first name :{person.firstName}\n Email ID :{person.emailid}");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
