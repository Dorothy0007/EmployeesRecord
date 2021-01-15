using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeesRecord.DAL.Migrations
{
    public partial class addSectionDepartmentOrganization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_DepartmentManager_DepartmentManagerId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Departments_DepartmentManagerId",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "DepartmentManagerId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Employees",
                newName: "SectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                newName: "IX_Employees_SectionId");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Departments",
                newName: "OrganizationId");

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organization_DepartmentManager_DepartmentManagerId",
                        column: x => x.DepartmentManagerId,
                        principalTable: "DepartmentManager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Section_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_OrganizationId",
                table: "Departments",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_DepartmentManagerId",
                table: "Organization",
                column: "DepartmentManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Section_DepartmentId",
                table: "Section",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Organization_OrganizationId",
                table: "Departments",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Section_SectionId",
                table: "Employees",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Organization_OrganizationId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Section_SectionId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropIndex(
                name: "IX_Departments_OrganizationId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "Employees",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_SectionId",
                table: "Employees",
                newName: "IX_Employees_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "OrganizationId",
                table: "Departments",
                newName: "Level");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentManagerId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "PostalCode", "Street", "StreetNumber" },
                values: new object[] { 1, "Zagreb", "Croatia", 10020, "First Street", "15" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "PostalCode", "Street", "StreetNumber" },
                values: new object[] { 2, "Zagreb", "Croatia", 10000, "Second Street", "45" });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DepartmentManagerId",
                table: "Departments",
                column: "DepartmentManagerId");

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
    }
}
