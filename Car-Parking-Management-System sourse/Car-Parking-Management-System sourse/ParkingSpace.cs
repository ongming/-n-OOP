using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Car_Parking_Management_System_sourse
{
    public class ParkingSpace : CarParkingSpaceSystem
    {
        private string id_carparking;
        private string numberplate;
        private string name_car;
        private string status;
        private string cost;
        private string ticketseri;
        public ParkingSpace(string id_carparking, string numberplate, string name_car, string status, string cost, string ticketseri)
        {
            this.id_carparking = id_carparking;
            this.numberplate = numberplate;
            this.name_car = name_car;
            this.status = status;
            this.cost = cost;
            this.ticketseri = ticketseri;
        }
        public string Id_carparking { get { return id_carparking; } set { id_carparking = value; } }
        public string Numberplate { get { return numberplate; } set { numberplate = value; } }
        public string Name_car { get { return name_car; } set { name_car = value; } }
        public string Status { get { return status; } set { status = value; } }
        public string Cost { get { return cost; } set { cost = value; } }
        
        public string Ticketseri { get { return ticketseri; } set { ticketseri = value; } }

        public void changeInfo(string id, string numberplate, string name, string status, string cost)
        {
            this.id_carparking = id;
            this.name_car = name;
            this.numberplate = numberplate;
            this.status = status;
            this.cost = cost;
        }
        public void changeInfo(string nameofcar,string numberplate,string status,string ticketseri)
        {
            this.name_car = nameofcar;
            this.numberplate = numberplate;
            this.status = status;
            this.ticketseri = ticketseri;
        }
        public static void writeparkingdata(List<ParkingSpace> parkingSpaces)
        {
            using (StreamWriter sw = new StreamWriter("ParkingSpace.txt"))
            {
                for (int i = 0; i < parkingSpaces.Count; i++)
                {
                    sw.WriteLine(parkingSpaces[i].Id_carparking);
                    sw.WriteLine(parkingSpaces[i].Numberplate);
                    sw.WriteLine(parkingSpaces[i].Name_car);
                    sw.WriteLine(parkingSpaces[i].Status);
                    sw.WriteLine(parkingSpaces[i].Cost);
                    sw.WriteLine(parkingSpaces[i].Ticketseri);
                }
            }
        }
        public void changeInfo()
        {
            throw new NotImplementedException();
        }
    }
}