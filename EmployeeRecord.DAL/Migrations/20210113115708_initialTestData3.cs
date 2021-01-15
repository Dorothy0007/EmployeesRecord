using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeesRecord.DAL.Migrations
{
    public partial class initialTestData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_DepartmentManager_DepartmentManagerId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameIndex(
                name: "IX_Department_DepartmentManagerId",
                table: "Departments",
                newName: "IX_Departments_DepartmentManagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "PostalCode", "Street", "StreetNumber" },
                values: new object[] { 1, "Zagreb", "Croatia", 10020, "First Street", "15" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "PostalCode", "Street", "StreetNumber" },
                values: new object[] { 2, "Zagreb", "Croatia", 10000, "Second Street", "45" });

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_DepartmentManager_DepartmentManagerId",
                table: "Departments",
                column: "DepartmentManagerId",
                principalTable: "DepartmentManager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_DepartmentManager_DepartmentManagerId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_DepartmentManagerId",
                table: "Department",
                newName: "IX_Department_DepartmentManagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_DepartmentManager_DepartmentManagerId",
                table: "Department",
                column: "DepartmentManagerId",
                principalTable: "DepartmentManager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
