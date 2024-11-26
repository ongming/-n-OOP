using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Car_Parking_Management_System_sourse
{
    public partial class Messenger : Form
    {
        private string filePath;
        private string id_customer;
        private string id_attendant;
        bool flag;
        public Messenger(string id_customer, string id_attendant, bool flag)
        {
            InitializeComponent();
            filePath = $"{id_customer}_{id_attendant}.txt";
            this.flag = flag;
            this.id_attendant = id_attendant;
            this.id_customer= id_customer;
            name_user.Text = flag ? id_attendant : id_customer;
            LoadMessages();
        }

        private void send_message_Click(object sender, EventArgs e)
        {
            string message = text_input.Text.Trim();

            if (!string.IsNullOrEmpty(message))
            {
                string senderId = flag ? id_attendant : id_customer;
                string formattedMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {senderId}: {message}";

                File.AppendAllText(filePath, formattedMessage + Environment.NewLine);

                AddMessageToPanel(formattedMessage, flag);

                text_input.Clear();
            }

        }

        private void LoadMessages()
        {
            flowLayoutPanelMessages.Controls.Clear();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    bool isCustomer = line.Contains($"{id_customer}:");
                    AddMessageToPanel(line, isCustomer);
                }
            }
        }
        //private void AddMessageToPanel(string message, bool isCustomer)
        //{
        //    Label messageLabel = new Label
        //    {
        //        Text = message,
        //        AutoSize = true,
        //        Padding = new Padding(10),
        //        Margin = new Padding(5),
        //        MaximumSize = new Size(flowLayoutPanelMessages.Width - 30, 0), 
        //    };

        //    if (isCustomer)
        //    {
        //        messageLabel.BackColor = Color.LightBlue;
        //        messageLabel.TextAlign = ContentAlignment.MiddleRight;
        //        messageLabel.Anchor = AnchorStyles.Right;
        //    }
        //    else
        //    {
        //        messageLabel.BackColor = Color.LightGreen;
        //        messageLabel.TextAlign = ContentAlignment.MiddleLeft;
        //        messageLabel.Anchor = AnchorStyles.Left;
        //    }

        //    flowLayoutPanelMessages.Controls.Add(messageLabel);

        //    flowLayoutPanelMessages.ScrollControlIntoView(messageLabel);
        //}
        private void AddMessageToPanel(string message, bool isCustomer)
        {
            Panel messagePanel = new Panel
            {
                AutoSize = true,
                Padding = new Padding(10),
                Margin = new Padding(5),
                BackColor = isCustomer ? Color.LightBlue : Color.LightGreen, // Màu nền
                MaximumSize = new Size(flowLayoutPanelMessages.Width - 50, 0), // Giới hạn chiều rộng
            };

            Label messageLabel = new Label
            {
                Text = message,
                AutoSize = true,
                Dock = DockStyle.Fill,
                ForeColor = Color.Black, // Màu chữ
            };

            // Thêm Label vào Panel
            messagePanel.Controls.Add(messageLabel);

            if (isCustomer)
            {
                messagePanel.Anchor = AnchorStyles.Right;
            }
            else
            {
                messagePanel.Anchor = AnchorStyles.Left; 
            }

            flowLayoutPanelMessages.Controls.Add(messagePanel);

            flowLayoutPanelMessages.ScrollControlIntoView(messagePanel);
        }

    }
}

