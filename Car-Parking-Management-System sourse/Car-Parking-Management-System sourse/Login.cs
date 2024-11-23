using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parking_Management_System_sourse
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool isMatDong = true;
        private void picboxEye_Click(object sender, EventArgs e)
        {
            if (isMatDong)
            {
                picboxEye.Image = Properties.Resources.atmo;
                txtPassLogin.UseSystemPasswordChar = !txtPassLogin.UseSystemPasswordChar;
            }
            else
            {
                picboxEye.Image = Properties.Resources.matdong;
                txtPassLogin.UseSystemPasswordChar = !txtPassLogin.UseSystemPasswordChar;
            }

            isMatDong = !isMatDong;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<ParkingSpace> parkingSpaces = new List<ParkingSpace>();
            List<Customer> customerList = new List<Customer>();
            bool loginSucces = false;
            string username = txtUserLogin.Text;
            string password = txtPassLogin.Text;
            // dòng trong using là khi chạy để đọc từng dòng trong file để lấy dữ liệu tạo nênn đối tượng
            using (StreamReader pl = new StreamReader("ParkingSpace.txt"))
            {
                while (!pl.EndOfStream)
                {
                    parkingSpaces.Add(new ParkingSpace(pl.ReadLine(),
                                                       pl.ReadLine(),
                                                       pl.ReadLine(),
                                                       pl.ReadLine(),
                                                       pl.ReadLine()));

                }
            }

            using (StreamReader cl = new StreamReader("Customer.txt"))
            {
                cl.ReadLine();
                while (!cl.EndOfStream)
                {
                    customerList.Add(new Customer(cl.ReadLine(),
                                                  cl.ReadLine(),
                                                  cl.ReadLine(),
                                                  Convert.ToInt32(cl.ReadLine()),
                                                  cl.ReadLine(),
                                                  cl.ReadLine(),
                                                  cl.ReadLine(),
                                                  cl.ReadLine()));
                }
            }
            if (comboPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Please! Choose position");
            }
            if (comboPosition.SelectedIndex == 0)
            {
                //"ml" là Managerlist!!
                List<Manager> Mangerlist = new List<Manager>();
                using (StreamReader ml = new StreamReader("Manager.txt"))
                {
                    while (!ml.EndOfStream)
                    {
                        Mangerlist.Add(new Manager(ml.ReadLine(),
                                                   ml.ReadLine(),
                                                   ml.ReadLine(),
                                                   Convert.ToInt32(ml.ReadLine()),
                                                   ml.ReadLine(),
                                                   ml.ReadLine(),
                                                   ml.ReadLine()));


                    }
                }
                for (int i = 0; i < Mangerlist.Count; i++)
                {
                    if (username == Mangerlist[i].Username && password == Mangerlist[i].Password)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Manager_Form newForm = new Manager_Form(parkingSpaces);
                        this.Hide();
                        newForm.ShowDialog();
                        this.Close();
                        loginSucces = true;
                        break;
                    }
                }
            }
            if (comboPosition.SelectedIndex == 2)
            {   
                for (int i=0;i< customerList.Count; i++)
                {
                    if (username == customerList[i].Username && password == customerList[i].Password)
                    {
                        string name = $"{customerList[i].Firstname}{" "}{customerList[i].Lastname}";
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Customer_Form newForm = new Customer_Form(name, parkingSpaces);
                        this.Hide();
                        newForm.ShowDialog();
                        this.Close();
                        loginSucces = true;
                        break;
                    }
                }
            }
            if (!loginSucces && comboPosition.SelectedIndex != -1)
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassLogin.Clear();
                txtPassLogin.Focus();
            }
        }

        private void linlbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register form = new Register();
            form.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
