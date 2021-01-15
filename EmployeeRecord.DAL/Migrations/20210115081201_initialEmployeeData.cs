using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeesRecord.DAL.Migrations
{
    public partial class initialEmployeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "PostalCode", "Street", "StreetNumber" },
                values: new object[,]
                {
                    { 1, "Zagreb", "Hrvatska", 10000, "First Street", "15" },
                    { 2, "Novi Zagreb", "Hrvatska", 10020, "Second Street", "55" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "BusinessEmail", "BusinessMobilePhone", "BusinessTelephone", "PrivateEmail", "PrivateMobilePhone" },
                values: new object[,]
                {
                    { 1, null, null, null, "ines.alpeza.viman@kbc-zagreb.hr", null },
                    { 2, null, null, null, "nikola.habuzin@kbc-zagreb.hr", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Active", "AddressId", "BirthDate", "ContactId", "FirstName", "LastName", "MBO", "OIB", "SectionId" },
                values: new object[] { 1, true, 1, new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ines", "Alpeza Viman", "123468940", "7495830573958", 3 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Active", "AddressId", "BirthDate", "ContactId", "FirstName", "LastName", "MBO", "OIB", "SectionId" },
                values: new object[] { 2, true, 2, new DateTime(1984, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Nikola", "Habuzin", "123998940", "7495875673958", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
