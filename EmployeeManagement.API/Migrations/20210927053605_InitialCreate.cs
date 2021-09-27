using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    employeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    departmentID = table.Column<int>(type: "int", nullable: false),
                    photoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.employeeID);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "employeeID", "dateOfBirth", "departmentID", "email", "firstname", "gender", "lastName", "photoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1996, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "a@gmail.com", "Abid", 0, "Hassan", "images/abid.png" },
                    { 2, new DateTime(1996, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "r@gmail.com", "Rasel", 0, "Uddin", "images/rasel.jpg" },
                    { 3, new DateTime(1996, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "j@gmail.com", "Jahid", 0, "Hassan", "images/jahid.png" },
                    { 4, new DateTime(1996, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "m@gmail.com", "Mimu", 1, "Parvathy", "images/mimu.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
