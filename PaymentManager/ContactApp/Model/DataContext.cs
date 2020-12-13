using PaymentManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace PaymentManagement.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<BankAccount> BankAccount { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<User> User { get; set; }


    }
}
