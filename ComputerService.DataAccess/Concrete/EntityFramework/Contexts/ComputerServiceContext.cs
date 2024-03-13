using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerService.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ComputerService.DataAccess.Concrete.EntityFramework.Contexts;
public class ComputerServiceContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=ACENGIZ\AKINCENGIZ; initial catalog=ComputerServiceDb;Integrated Security=True;Trust Server Certificate=True;");
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<SparePart> SpareParts { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<ServiceStatu> ServiceStatus { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<ServiceRecord> ServiceRecords { get; set; }
}
