﻿// <auto-generated />
using System;
using EmployeesRecord.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeesRecord.DAL.Migrations
{
    [DbContext(typeof(EmployeeRecordDbContext))]
    partial class EmployeeRecordDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("EmployeesRecord.Model.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Zagreb",
                            Country = "Hrvatska",
                            PostalCode = 10000,
                            Street = "First Street",
                            StreetNumber = "15"
                        },
                        new
                        {
                            Id = 2,
                            City = "Novi Zagreb",
                            Country = "Hrvatska",
                            PostalCode = 10020,
                            Street = "Second Street",
                            StreetNumber = "55"
                        });
                });

            modelBuilder.Entity("EmployeesRecord.Model.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BusinessEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessMobilePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessTelephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrivateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrivateMobilePhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contact");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PrivateEmail = "ines.alpeza.viman@kbc-zagreb.hr"
                        },
                        new
                        {
                            Id = 2,
                            PrivateEmail = "nikola.habuzin@kbc-zagreb.hr"
                        });
                });

            modelBuilder.Entity("EmployeesRecord.Model.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EmployeesRecord.Model.DepartmentManager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DepartmentManager");
                });

            modelBuilder.Entity("EmployeesRecord.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MBO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OIB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ContactId");

                    b.HasIndex("SectionId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            AddressId = 1,
                            BirthDate = new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ContactId = 1,
                            FirstName = "Ines",
                            LastName = "Alpeza Viman",
                            MBO = "123468940",
                            OIB = "7495830573958",
                            SectionId = 3
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            AddressId = 2,
                            BirthDate = new DateTime(1984, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ContactId = 2,
                            FirstName = "Nikola",
                            LastName = "Habuzin",
                            MBO = "123998940",
                            OIB = "7495875673958",
                            SectionId = 3
                        });
                });

            modelBuilder.Entity("EmployeesRecord.Model.EmployeeStay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Arrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Departure")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartureReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeStay");
                });

            modelBuilder.Entity("EmployeesRecord.Model.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentManagerId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentManagerId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("EmployeesRecord.Model.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("EmployeesRecord.Model.Department", b =>
                {
                    b.HasOne("EmployeesRecord.Model.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("EmployeesRecord.Model.Employee", b =>
                {
                    b.HasOne("EmployeesRecord.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeesRecord.Model.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeesRecord.Model.Section", "Section")
                        .WithMany("Employees")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Contact");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("EmployeesRecord.Model.EmployeeStay", b =>
                {
                    b.HasOne("EmployeesRecord.Model.Employee", "Employee")
                        .WithMany("EmployeeStays")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeesRecord.Model.Organization", b =>
                {
                    b.HasOne("EmployeesRecord.Model.DepartmentManager", "DepartmentManager")
                        .WithMany()
                        .HasForeignKey("DepartmentManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartmentManager");
                });

            modelBuilder.Entity("EmployeesRecord.Model.Section", b =>
                {
                    b.HasOne("EmployeesRecord.Model.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EmployeesRecord.Model.Employee", b =>
                {
                    b.Navigation("EmployeeStays");
                });

            modelBuilder.Entity("EmployeesRecord.Model.Section", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
