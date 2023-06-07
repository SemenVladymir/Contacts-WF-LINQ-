using Contacts_WF_LINQ_.Models;
using System.Windows.Forms;

namespace Contacts_WF_LINQ_
{
    public partial class FriendsControl1 : UserControl
    {
        public FriendsControl1()
        {
            InitializeComponent();
        }

        public FriendsControl1(Friends friend) : this()
        {
            lName.Text = friend.Name;
            lAddress.Text = friend.Address;
            lPhone.Text = friend.Phone;
            lEmail.Text = friend.Email;
            lBirthdate.Text = friend.Birthday.Date.ToString();
        }
    }
}
