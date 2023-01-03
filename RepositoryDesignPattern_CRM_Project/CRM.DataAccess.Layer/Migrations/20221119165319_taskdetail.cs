using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.DataAccess.Layer.Migrations
{
    public partial class taskdetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTaskDetail_EmployeesTasks_EmployeeTaskID",
                table: "EmployeeTaskDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeTaskDetail",
                table: "EmployeeTaskDetail");

            migrationBuilder.RenameTable(
                name: "EmployeeTaskDetail",
                newName: "EmployeeTaskDetails");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeTaskDetail_EmployeeTaskID",
                table: "EmployeeTaskDetails",
                newName: "IX_EmployeeTaskDetails_EmployeeTaskID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeTaskDetails",
                table: "EmployeeTaskDetails",
                column: "EmployeeTaskDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTaskDetails_EmployeesTasks_EmployeeTaskID",
                table: "EmployeeTaskDetails",
                column: "EmployeeTaskID",
                principalTable: "EmployeesTasks",
                principalColumn: "EmployeeTaskID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTaskDetails_EmployeesTasks_EmployeeTaskID",
                table: "EmployeeTaskDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeTaskDetails",
                table: "EmployeeTaskDetails");

            migrationBuilder.RenameTable(
                name: "EmployeeTaskDetails",
                newName: "EmployeeTaskDetail");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeTaskDetails_EmployeeTaskID",
                table: "EmployeeTaskDetail",
                newName: "IX_EmployeeTaskDetail_EmployeeTaskID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeTaskDetail",
                table: "EmployeeTaskDetail",
                column: "EmployeeTaskDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTaskDetail_EmployeesTasks_EmployeeTaskID",
                table: "EmployeeTaskDetail",
                column: "EmployeeTaskID",
                principalTable: "EmployeesTasks",
                principalColumn: "EmployeeTaskID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
