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
        public Attendant__Form(string name,List<Customer> customers)
        {
            InitializeComponent();
            lbname.Text = name;
        }
        public void showData()
        {

        }
    }
}
