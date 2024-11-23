using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Parking_Management_System_sourse
{
    public class Attendant : Person
    {
        public Attendant(string id, string firstname, string lastname, int age, string phonenumber, string username, string password):base(id, firstname, lastname, age, phonenumber, username, password)
        {
            
        }
        public override void addID()
        {
            throw new NotImplementedException();
        }
    }
}