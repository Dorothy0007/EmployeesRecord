using EmployeesRecord.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeesRecord.DAL
{
    public class EmployeeRecordDbContext : DbContext
    {
        public EmployeeRecordDbContext(DbContextOptions<EmployeeRecordDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Section> Sections { get; set; }
        public EmployeeRecordDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=KBC-C04901; Database=EmployeeDb; User ID=sa;Password=DoricaForica12;Trusted_Connection=False; MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasData(new Address
                {
                    Id = 1,
                    Street = "First Street",
                    StreetNumber = "15",
                    PostalCode = 10000,
                    City = "Zagreb",
                    Country = "Hrvatska"
                },
                new Address
                {
                    Id = 2,
                    Street = "Second Street",
                    StreetNumber = "55",
                    PostalCode = 10020,
                    City = "Novi Zagreb",
                    Country = "Hrvatska"
                });

            modelBuilder.Entity<Contact>()
                .HasData(new Contact
                {
                    Id = 1,
                    PrivateEmail = "ines.alpeza.viman@kbc-zagreb.hr"
                });

            modelBuilder.Entity<Contact>()
                .HasData(new Contact
                {
                    Id = 2,
                    PrivateEmail = "nikola.habuzin@kbc-zagreb.hr"
                });

            modelBuilder.Entity<Employee>()
                .HasData(new Employee
                {
                    Id = 1,
                    FirstName = "Ines",
                    LastName = "Alpeza Viman",
                    OIB = "7495830573958",
                    MBO = "123468940",
                    Active = true,
                    BirthDate = new DateTime(1979, 04, 25),
                    SectionId = 3,
                    AddressId = 1,
                    ContactId = 1
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Nikola",
                    LastName = "Habuzin",
                    OIB = "7495875673958",
                    MBO = "123998940",
                    Active = true,
                    BirthDate = new DateTime(1984, 04, 25),
                    SectionId = 3,
                    AddressId = 2,
                    ContactId = 2
                });
        }

    }
}
