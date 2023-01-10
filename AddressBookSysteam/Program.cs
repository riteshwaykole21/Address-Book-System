using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSysteam
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContactList contact = new ContactList();
            contact.welcomeMeassage();
            ReEnteringApp:
            Console.WriteLine("Select Amy one From,below Option \n" +
                "Press 1 :to create/Add a new contact \n"+
                "Press 2 :to Edit/Modify any existing contct\n" +
                "Press 3 : to view all the contact in address book");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    contact.AddPerson();
                    break;  
                case 2:
                    contact.Editperson();
                    break;
                case 3:
                    contact.ListPeople();
                    break;
                default :
                    Console.WriteLine("Invalid option Selected , Please try again");
                    break;
            }
            goto ReEnteringApp;

        }
    }
}
