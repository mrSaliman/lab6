using lab6.Models;
using Microsoft.EntityFrameworkCore;

namespace lab6.Data;

public class AcmeDataContext : DbContext
{
    public AcmeDataContext(DbContextOptions<AcmeDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Order> Orders { get; set; }
}