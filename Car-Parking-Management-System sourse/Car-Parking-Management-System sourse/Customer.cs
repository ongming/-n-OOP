﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Parking_Management_System_sourse
{
    public class Customer : Person
    {
        private string ticketseri;
        public Customer(string id,string firstname, string lastname, int age, string phonenumber, string username, string password, string ticketseri) : base(id, firstname, lastname, age, phonenumber, username, password)
        {
            this.ticketseri = ticketseri;
        }   
        public string Ticketseri { get { return ticketseri; } set { ticketseri = value; } }

        public override void addID()
        {
            throw new NotImplementedException();
        }
    }
}