using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSysteam
{
    public class CreatingContactcs
    {
        public static void Intialcontacts()
        {
            Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("enter your Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number");
            double phoneNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Email Id");
            String emailid = Console.ReadLine();
            Console.WriteLine($"\n First Name  : {firstName} \n Last name : {lastName} \n Address : {address}\n Phone Number : {phoneNo} \n Email Id : {emailid}");
        }  
            
    }
}
