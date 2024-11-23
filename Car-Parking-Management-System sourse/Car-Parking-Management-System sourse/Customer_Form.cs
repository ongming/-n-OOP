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
    public partial class Customer_Form : Form
    {
        List<Customer> _customerList;
        List<ParkingSpace> parkingSpaces;
        public Customer_Form(string name,List<ParkingSpace> parking)
        {
            this.parkingSpaces = parking;
            InitializeComponent();
            lbname.Text = name;
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

        }

        private void txtSearchSpace_TextChanged(object sender, EventArgs e)
        {
            dataGridviewParkingSpace.DataSource = this.parkingSpaces.Where(p => p.Id_carparking.Contains(txtSearchSpace.Text)).ToList();
        }
    }
}
