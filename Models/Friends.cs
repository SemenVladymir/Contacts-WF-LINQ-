using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts_WF_LINQ_.Models
{
    public class Friends
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birthday{ get; set; }

        public Friends()
        {
            Id = 0;
            Name = string.Empty;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            this.Birthday = DateTime.Now;
        }
        public Friends(int id, string name, string address, string phone, string email, DateTime birthday)
        {
            Id=id;
            Name = name;
            Address = $"| {address}";
            Phone = $"| {phone}";
            Email = $"| {email}";
            Birthday = birthday;
        }

        public Friends(string name, string address, string phone, string email, DateTime birthday)
        {
            Name = name;
            Address = $"| {address}";
            Phone = $"| {phone}";
            Email = $"| {email}";
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"|{Name}|{Address}|{Phone}|{Email}|{Birthday.Date}";
        }
    }
}
