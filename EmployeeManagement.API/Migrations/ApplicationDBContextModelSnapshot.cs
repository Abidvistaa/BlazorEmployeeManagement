// <auto-generated />
using System;
using EmployeeManagement.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagement.API.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagement.Department", b =>
                {
                    b.Property<int>("departmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("departmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("departmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EmployeeManagement.Employee", b =>
                {
                    b.Property<int>("employeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("departmentID")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("employeeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            employeeID = 1,
                            dateOfBirth = new DateTime(1996, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            departmentID = 10,
                            email = "a@gmail.com",
                            firstname = "Abid",
                            gender = 0,
                            lastName = "Hassan",
                            photoPath = "images/abid.png"
                        },
                        new
                        {
                            employeeID = 2,
                            dateOfBirth = new DateTime(1996, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            departmentID = 20,
                            email = "r@gmail.com",
                            firstname = "Rasel",
                            gender = 0,
                            lastName = "Uddin",
                            photoPath = "images/rasel.jpg"
                        },
                        new
                        {
                            employeeID = 3,
                            dateOfBirth = new DateTime(1996, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            departmentID = 10,
                            email = "j@gmail.com",
                            firstname = "Jahid",
                            gender = 0,
                            lastName = "Hassan",
                            photoPath = "images/jahid.png"
                        },
                        new
                        {
                            employeeID = 4,
                            dateOfBirth = new DateTime(1996, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            departmentID = 30,
                            email = "m@gmail.com",
                            firstname = "Mimu",
                            gender = 1,
                            lastName = "Parvathy",
                            photoPath = "images/mimu.png"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
