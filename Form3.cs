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
    public partial class Form3 : Form
    {
        public List<Friends> data = new List<Friends>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btnOk.Click += Search_Click;
            btnCancel.Click += (s, ee) => { this.Close(); };
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                string txtSearch = txtInput.Text;
                using (MyContext db = new MyContext())
                {
                    List<Friends> friends = db.Friends.ToList();
                    if (friends != null)
                    {
                        foreach (Friends u in friends)
                        {
                            if (u.Name?.IndexOf(txtSearch, StringComparison.OrdinalIgnoreCase) != -1 || u.Address?.IndexOf(txtSearch, StringComparison.OrdinalIgnoreCase) != -1
                                || u.Phone?.IndexOf(txtSearch, StringComparison.OrdinalIgnoreCase) != -1 || u.Email?.IndexOf(txtSearch, StringComparison.OrdinalIgnoreCase) != -1)
                                data.Add(u);
                        }
                    }
                }
                if (data.Count == 0)
                    MessageBox.Show("Data isn`t found!");
            }
            else
                MessageBox.Show("You need to input data!");
            this.Close();
        }
    }
}
