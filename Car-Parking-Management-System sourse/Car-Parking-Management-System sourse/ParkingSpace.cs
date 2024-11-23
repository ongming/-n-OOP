using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Parking_Management_System_sourse
{
    public class ParkingSpace
    {
        private string id_carparking;
        private string numberplate;
        private string name_car;
        private string status;
        private string cost;
        public ParkingSpace(string id_carparking,string numberplate,string name_car,string status,string cost)
        {
            this.id_carparking = id_carparking;
            this.numberplate = numberplate;
            this.name_car = name_car;
            this.status = status;
            this.cost = cost;
        }
        public string Id_carparking { get { return id_carparking; } set { id_carparking = value; } }
        public string Numberplate { get { return numberplate; } set { numberplate = value; } }
        public string Name_car { get { return name_car; } set { name_car = value; } }
        public string Status { get { return status; } set { status = value; } }
        public string Cost { get { return cost; } set { cost = value; } }

        public void changeInfo(string id,string numberplate,string name,string status,string cost)
        {
            this.id_carparking = id;
            this.name_car= name;
            this.numberplate= numberplate;
            this.status = status;
            this.cost = cost;
        }
    }
}