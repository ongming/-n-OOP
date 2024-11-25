using System;
using System.Collections.Generic;
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
        public void changeInfo()
        {
            throw new NotImplementedException();
        }
    }
}