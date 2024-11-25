using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parking_Management_System_sourse
{
    public partial class Attendant__Form : Form
    {
        List<Customer> customers;
        List<ParkingSpace> parkingSpaces;
        public Attendant__Form(string name,List<Customer> customers, List<ParkingSpace> parkingSpaces)
        {
            InitializeComponent();
            lbname.Text = name;
            this.customers = customers;
            this.parkingSpaces = parkingSpaces;
            showData(customers);
            
        }
        public void showData(List<Customer> customers)
        {
            dataGridViewParkingCar.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn idColum = new DataGridViewTextBoxColumn();
            idColum.DataPropertyName = "id";
            idColum.HeaderText = "ID";
            dataGridViewParkingCar.Columns.Add(idColum);
            DataGridViewTextBoxColumn nameCustomerColum = new DataGridViewTextBoxColumn();
            nameCustomerColum.DataPropertyName = "Fullname";
            nameCustomerColum.HeaderText= "Name of Customer";
            dataGridViewParkingCar.Columns.Add(nameCustomerColum);
            DataGridViewTextBoxColumn numberplateColum = new DataGridViewTextBoxColumn();
            numberplateColum.DataPropertyName = "numberplate";
            DataGridViewTextBoxColumn nameofcarColum = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ticketandRequestColum = new DataGridViewTextBoxColumn();
            dataGridViewParkingCar.DataSource = customers;
        }
    }
}
