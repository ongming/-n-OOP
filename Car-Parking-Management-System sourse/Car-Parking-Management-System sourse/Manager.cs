using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Parking_Management_System_sourse
{
    internal class Manager : Person
    {
        public Manager(string id, string firstname, string lastname, int age, string phonenumber, string username, string password):base(id,firstname, lastname, age,phonenumber,username,password)
        {
            
        }
        public static void CreateParkingSpace()
        {
            
        }
        public override void addID()
        {
            throw new NotImplementedException();
        }
    }
}
