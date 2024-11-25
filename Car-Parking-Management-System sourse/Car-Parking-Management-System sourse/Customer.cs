using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Car_Parking_Management_System_sourse
{
    public class Customer : Person, CarParkingSpaceSystem
    {
        private string ticketseri;
        public Customer(string id, string firstname, string lastname, int age, string phonenumber, string username, string password, string ticketseri) : base(id, firstname, lastname, age, phonenumber, username, password)
        {
            this.ticketseri = ticketseri;
        }
        public string Ticketseri { get { return ticketseri; } set { ticketseri = value; } }
        public string Fullname { get { return $"{Lastname} {Firstname} "; } }
        public override void addID(string id)
        {
            this.Id = id;
        }
        public void changeInfo(string ticketseri)
        {
            this.ticketseri = ticketseri;
        }
        public void WriteInfo(string temp)
        {
            using (StreamWriter swriter = new StreamWriter("Customer.txt", true))
            {
                if (temp == null)
                {
                    swriter.WriteLine("");
                }
                swriter.WriteLine(Id);
                swriter.WriteLine(Firstname);
                swriter.WriteLine(Lastname);
                swriter.WriteLine(Age);
                swriter.WriteLine(Phonenumber);
                swriter.WriteLine(Username);
                swriter.WriteLine(Password);
                swriter.WriteLine(ticketseri);
                swriter.Flush();
            }
        }
        public void WriteInfo()
        {
            using (StreamWriter swriter = new StreamWriter("Customer.txt"))
            {
                swriter.WriteLine(Id);
                swriter.WriteLine(Firstname);
                swriter.WriteLine(Lastname);
                swriter.WriteLine(Age);
                swriter.WriteLine(Phonenumber);
                swriter.WriteLine(Username);
                swriter.WriteLine(Password);
                swriter.WriteLine(ticketseri);
                swriter.Flush();
            }
        }
        public void changeInfo()
        {
            throw new NotImplementedException();
        }
    }
}