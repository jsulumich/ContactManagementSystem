// DbContext class - aides in interacting with and performing database operations

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContactManagementSystem.Data
{
    public class ContactDbContext : DbContext
    {
         // inject options
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options){}

        // define DBSet of contacts
        public DbSet<Contact> Contacts { get; set; }

        // model definition
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        // release allocated resource
        public override void Dispose()
        {
            base.Dispose();
        }

        // release allocated resource (async)
        public override ValueTask DisposeAsync()
        {
            return base.DisposeAsync();
        }
    }
}
