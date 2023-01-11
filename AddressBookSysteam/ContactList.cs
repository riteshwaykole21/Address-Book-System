using AddressBookSysteam;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookApp
{
    public class ContactList
    {
        public void WelcomeMessage()    //Welcome Message
        {
            Console.WriteLine("Welcome to Address Book Program!\n");
        }
        Person personObj = new Person();
        List<Person> listPersonObj = new List<Person>();
        Dictionary<string, List<Person>> personMapping = new Dictionary<string, List<Person>>();
        public void AddPerson()     //Adding Person .
        {
            personObj = new Person();
            Console.WriteLine("Enter your First Name");
        tryingWithDifferentName:
            personObj.firstName = Console.ReadLine();
            foreach (KeyValuePair<string, List<Person>> kvp in personMapping)        //UC6-Won't allow duplicate first name to be stored in AddressBook .
            {
                if (kvp.Key.Equals(personObj.firstName))
                {
                    Console.WriteLine("The Name which your are trying to save is already in use,So in order to avoid confusion you've to try with some different name.");
                    Console.WriteLine("Please try again :");
                    goto tryingWithDifferentName;
                }
            }
            Console.WriteLine("Enter your Last Name");
            personObj.lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            personObj.address = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number");
            personObj.phoneNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your email id");
            personObj.emailid = Console.ReadLine();

            listPersonObj.Add(personObj);
            personMapping.Add(personObj.firstName, listPersonObj);
        }
        public void EditPerson()    //Editing Contact .
        {
        updateDetails:
            Console.WriteLine("Enter the first name of personObj to be removed");
            string verifyingFirstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of personObj to be removed");
            string verifyingLastName = Console.ReadLine();
            foreach (var person in listPersonObj)
            {
                if (person.firstName.Equals(verifyingFirstName) && person.lastName.Equals(verifyingLastName))   //Editing Contact if exists.
                {
                moreEditing:
                    Console.WriteLine("Please select any one as per the below given options on which you want the modification \n" +
                        "1)First Name\n2)Last Name\n3)Address\n4)Phone Number\n5)Email_Id");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please enter your first name : ");
                            person.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Please enter your last name : ");
                            person.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Please enter your Address : ");
                            person.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Please enter your Phone Number : ");
                            person.phoneNo = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Please enter your email Id: ");
                            person.emailid = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("You've selected an Invalid Option!");
                            Console.WriteLine("Do you want to try again ");
                            if (Console.ReadKey().Key == ConsoleKey.Y)
                            {
                                goto updateDetails;
                            }
                            break;
                    }
                    Console.WriteLine("Do you want to do any more modification in the same contact Y/N \n");
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
                    Console.WriteLine("That person name could not be found.Do you want to try again ");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        goto updateDetails;
                    }
                    return;
                }
            }
        }
        public void ListPeople()        //List of all Contacts/People's.
        {
            if (listPersonObj.Count == 0)
            {
                Console.WriteLine("Your Address book is empty. Press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current listPersonObj found in your address book :");
            foreach (var person in listPersonObj)
            {
                Console.WriteLine($"\n First Name : {person.firstName}\n Last Name : {person.lastName}\n Address : {person.address}\n Phone Number : {person.phoneNo}\n Email ID : {person.emailid}");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        public void RemovePerson()      //Delete an existing Contact 
        {
            Console.WriteLine("Enter the first name of personObj to be removed");
            string verifyingFirstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of personObj to be removed");
            string verifyingLastName = Console.ReadLine();
            foreach (var person in listPersonObj)
            {
                if (person.firstName.Equals(verifyingFirstName) && person.lastName.Equals(verifyingLastName))
                {
                    Console.WriteLine("Are you sure you want to remove this personObj from your address book ? (Y/N)");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        listPersonObj.Remove(person);
                        Console.WriteLine("Person removed .Press any key to continue.\n");
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("That personObj could not be found.Press any key to continue to try again ");
                    Console.ReadKey();
                    return;
                }
            }
        }
    }
}
