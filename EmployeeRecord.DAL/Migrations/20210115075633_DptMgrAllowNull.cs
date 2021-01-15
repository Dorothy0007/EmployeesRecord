using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeesRecord.DAL.Migrations
{
    public partial class DptMgrAllowNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Organization_OrganizationId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Section_SectionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Organization_DepartmentManager_DepartmentManagerId",
                table: "Organization");

            migrationBuilder.DropForeignKey(
                name: "FK_Section_Departments_DepartmentId",
                table: "Section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section",
                table: "Section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organization",
                table: "Organization");

            migrationBuilder.RenameTable(
                name: "Section",
                newName: "Sections");

            migrationBuilder.RenameTable(
                name: "Organization",
                newName: "Organizations");

            migrationBuilder.RenameIndex(
                name: "IX_Section_DepartmentId",
                table: "Sections",
                newName: "IX_Sections_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Organization_DepartmentManagerId",
                table: "Organizations",
                newName: "IX_Organizations_DepartmentManagerId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "DepartmentManager",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFrom",
                table: "DepartmentManager",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sections",
                table: "Sections",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organizations",
                table: "Organizations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Sections_SectionId",
                table: "Employees",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_DepartmentManager_DepartmentManagerId",
                table: "Organizations",
                column: "DepartmentManagerId",
                principalTable: "DepartmentManager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Departments_DepartmentId",
                table: "Sections",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Organizations_OrganizationId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Sections_SectionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_DepartmentManager_DepartmentManagerId",
                table: "Organizations");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Departments_DepartmentId",
                table: "Sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sections",
                table: "Sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organizations",
                table: "Organizations");

            migrationBuilder.RenameTable(
                name: "Sections",
                newName: "Section");

            migrationBuilder.RenameTable(
                name: "Organizations",
                newName: "Organization");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_DepartmentId",
                table: "Section",
                newName: "IX_Section_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Organizations_DepartmentManagerId",
                table: "Organization",
                newName: "IX_Organization_DepartmentManagerId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "DepartmentManager",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFrom",
                table: "DepartmentManager",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section",
                table: "Section",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organization",
                table: "Organization",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_DepartmentManager_DepartmentManagerId",
                table: "Organization",
                column: "DepartmentManagerId",
                principalTable: "DepartmentManager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Departments_DepartmentId",
                table: "Section",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
