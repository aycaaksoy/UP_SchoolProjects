using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.DataAccess.Layer.Migrations
{
    public partial class create_emp_taskfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Categories_CategoryID",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_CategoryID",
                table: "Employees",
                newName: "IX_Employees_CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.CreateTable(
                name: "EmployeesTasks",
                columns: table => new
                {
                    EmployeeTaskID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesTasks", x => x.EmployeeTaskID);
                    table.ForeignKey(
                        name: "FK_EmployeesTasks_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTaskDetail",
                columns: table => new
                {
                    EmployeeTaskDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeTaskID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTaskDetail", x => x.EmployeeTaskDetailID);
                    table.ForeignKey(
                        name: "FK_EmployeeTaskDetail_EmployeesTasks_EmployeeTaskID",
                        column: x => x.EmployeeTaskID,
                        principalTable: "EmployeesTasks",
                        principalColumn: "EmployeeTaskID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesTasks_AppUserID",
                table: "EmployeesTasks",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTaskDetail_EmployeeTaskID",
                table: "EmployeeTaskDetail",
                column: "EmployeeTaskID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Categories_CategoryID",
                table: "Employees",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Categories_CategoryID",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "EmployeeTaskDetail");

            migrationBuilder.DropTable(
                name: "EmployeesTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_CategoryID",
                table: "Employee",
                newName: "IX_Employee_CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Categories_CategoryID",
                table: "Employee",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
