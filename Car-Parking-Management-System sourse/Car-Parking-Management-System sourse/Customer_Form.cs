using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parking_Management_System_sourse
{
    public partial class Customer_Form : Form
    {
        List<Customer> customers;
        List<ParkingSpace> parkingSpaces;
        string id;
        public Customer_Form(string name,string id,List<ParkingSpace> parking,List<Customer> customers)
        {
            this.parkingSpaces = parking;
            this.customers = customers;
            this.id = id;
            InitializeComponent();
            lbname.Text = name;
            //hellod đg
            // Tắt tự động tạo cột
            dataGridviewParkingSpace.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "Id_carparking"; // Liên kết với thuộc tính Id_carparking
            idColumn.HeaderText = "ID"; // Tiêu đề cột
            dataGridviewParkingSpace.Columns.Add(idColumn);

            // Tạo cột cho Status
            DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn();
            statusColumn.DataPropertyName = "Status"; // Liên kết với thuộc tính Status
            statusColumn.HeaderText = "Status"; // Tiêu đề cột
            dataGridviewParkingSpace.Columns.Add(statusColumn);

            DataGridViewTextBoxColumn costColumn = new DataGridViewTextBoxColumn();
            costColumn.DataPropertyName = "Cost";
            costColumn.HeaderText = "Cost";
            dataGridviewParkingSpace.Columns.Add(costColumn);

            dataGridviewParkingSpace.RowHeadersVisible = false;
            dataGridviewParkingSpace.DataSource = parking;
        }
        public void writeData()
        {
            ParkingSpace.writeparkingdata(this.parkingSpaces);
            string count;
            using (StreamReader sr=new StreamReader("Customer.txt"))
            {
                count=sr.ReadLine();
            }
            using (StreamWriter swriter = new StreamWriter("Customer.txt"))
            {
                swriter.WriteLine(count);
                swriter.Flush();
            }
            for (int i = 0; i < customers.Count; i++)
            {
                customers[i].WriteInfo();
            }

        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out???", "System", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login form = new Login();
                form.ShowDialog();
                this.Close();
            }

        }
        private void btnSignParking_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == id)
                {
                    for(int j = 0; j < parkingSpaces.Count; j++)
                    {
                        if (txtIDSpace.Text == parkingSpaces[j].Id_carparking)
                        {
                            parkingSpaces[j].changeInfo(txtNameCar.Text,txtNumberPlate.Text,"Wait...","Wait...");
                            customers[i].changeInfo($"Request Parking Space ID:{txtIDSpace.Text}");
                            MessageBox.Show("Please! Wait our Attendant reply your Request","System");
                            dataGridviewParkingSpace.DataSource = null;
                            dataGridviewParkingSpace.DataSource = parkingSpaces;
                            writeData();
                            return;
                        }
                    }                   
                    MessageBox.Show("ID of Parking Space is not exist!", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;     
                }
            }
        }
        private void txtSearchSpace_TextChanged(object sender, EventArgs e)
        {
            dataGridviewParkingSpace.DataSource = this.parkingSpaces.Where(p => p.Id_carparking.Contains(txtSearchSpace.Text)).ToList();
        }
    }
}
