using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeesRecord.DAL.Migrations
{
    public partial class addContactDeptMgr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentManagerId",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrivateEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessTelephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessMobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivateMobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentManager",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentManager", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ContactId",
                table: "Employees",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_DepartmentManagerId",
                table: "Department",
                column: "DepartmentManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_DepartmentManager_DepartmentManagerId",
                table: "Department",
                column: "DepartmentManagerId",
                principalTable: "DepartmentManager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Contact_ContactId",
                table: "Employees",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_DepartmentManager_DepartmentManagerId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Contact_ContactId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "DepartmentManager");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ContactId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Department_DepartmentManagerId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentManagerId",
                table: "Department");
        }
    }
}
