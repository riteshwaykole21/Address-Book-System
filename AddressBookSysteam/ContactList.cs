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
            Console.WriteLine("Enter Your First name ");  //enter the name
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
        public void Editperson()
        {
        findingPersonAgain:
            Console.WriteLine("Enter the First name of person to be removed");
            string verifyingFirstnName = Console.ReadLine();
            Console.WriteLine("Enter The Last Name of Person to be removed");
            string verifyingLastname = Console.ReadLine();
            foreach (var person in people)
            {
                if (person.firstName.Equals(verifyingFirstnName) &&
                    person.lastName.Equals(verifyingLastname))
                {
                moreEditing:
                    Console.WriteLine("Please select any one as per below given option on the which you want the modification \n" +
                        "1)First Name \n2)last name \n3)Address\n4)Phone Number\n5)Email_Id");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please enter your First Name :");
                            person.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Please enter your last Name :");
                            person.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Please enter your Address :");
                            person.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Please enter your phone Number :");
                            person.phoneNo = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Please enter your emailid :");
                            person.emailid = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("You are selected Invalid Option");
                            Console.WriteLine("Do You Want To Try Again ");
                            if (Console.ReadKey().Key == ConsoleKey.Y)
                            {
                                goto findingPersonAgain;
                            }
                            break;
                    }
                    Console.WriteLine("Do you want to any More Notification in the same Contact Y/N \n");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        goto moreEditing;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("That Person could not be Found.Do you Want to Try again");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        goto findingPersonAgain;
                    }
                    return;
                }
            }
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
        public void RemovePerson()     //delete n exiting contact
        {
            Console.WriteLine("Enter the first name of person to be removed");
            string verifyingfirstname = Console.ReadLine();
            Console.WriteLine("Enter the Last Name of Person to be removed");
            string verifyinglastName = Console.ReadLine();
            foreach (var person in people)
            {
                if (person.firstName.Equals(verifyingfirstname) && person.lastName.Equals(verifyinglastName))
                {
                    Console.WriteLine("Are you Sure You Want To remove this Person from Your address book ? (Y/N)");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        people.Remove(person);
                        Console.WriteLine("person Removed Press any key To Continue.\n");
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                       Console.WriteLine("That Person could not be found.Pres any key to continue to try again");
                       Console.ReadKey();
                       return;
                }
            }
        }
    }
}


