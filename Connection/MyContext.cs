using Contacts_WF_LINQ_.Models;
using System.Data.Entity;


namespace Contacts_WF_LINQ_.Connection 
{
    public class MyContext : DbContext
    {
        public DbSet<Friends> Friends { get; set; }

        public MyContext(): base("DbConnection") { }
    }
}
