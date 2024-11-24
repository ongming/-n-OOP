using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Parking_Management_System_sourse
{
    public class Ticket
    {
        private string seriticket;
        private string idcustomer;
        private ParkingSpace parkingdata;
        public Ticket(string seriticket, string idcustomer, ParkingSpace parkingdata)
        {
            this.seriticket = seriticket;
            this.idcustomer = idcustomer;
            this.parkingdata = parkingdata;
        }
        public string Seriticket { get { return seriticket; } set { seriticket = value; } }
        public string Idcustomer { get { return idcustomer; } set { idcustomer = value; } }
        public ParkingSpace Parkingdata { get { return parkingdata; } set { parkingdata = value; } }
    }
}