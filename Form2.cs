using Contacts_WF_LINQ_.Connection;
using Contacts_WF_LINQ_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts_WF_LINQ_
{
    public partial class Form2 : Form
    {
        string name;
        string address;
        string phone;
        string email;
        DateTime birthday;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Date.Format = DateTimePickerFormat.Custom;
            Date.CustomFormat = "ddd   dd.MM.yyyy";
            btnOk.Click += AddContact_Click;
            btnCancel.Click += (s, ee) => { this.Close(); };
        }

        private void AddContact_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            address = txtAddress.Text;
            phone = txtPhone.Text;
            email = txtEmail.Text;
            birthday = Date.Value;
            if (name != "")
            {
                using (MyContext db = new MyContext())
                {
                    Friends friend = new Friends { Name = name, Address = address, Phone = phone, Email = email, Birthday = birthday };
                    db.Friends.Add(friend);
                    db.SaveChanges();
                }
            }
            else
                MessageBox.Show("You need to fill out a form!");
            this.Close();
        }
    }
}
