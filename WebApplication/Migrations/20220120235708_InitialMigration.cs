using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    EmployeePhoneNumber_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.EmployeePhoneNumber_ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    EmpRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.EmpRoleID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    empId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpRoleID = table.Column<int>(type: "int", nullable: false),
                    RoleEmpRoleID = table.Column<int>(type: "int", nullable: true),
                    Location_ID = table.Column<int>(type: "int", nullable: false),
                    EmployeeLocationLocationID = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeePhoneNumber_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.empId);
                    table.ForeignKey(
                        name: "FK_Employees_Location_EmployeeLocationLocationID",
                        column: x => x.EmployeeLocationLocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_PhoneNumber_EmployeePhoneNumber_ID",
                        column: x => x.EmployeePhoneNumber_ID,
                        principalTable: "PhoneNumber",
                        principalColumn: "EmployeePhoneNumber_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Role_RoleEmpRoleID",
                        column: x => x.RoleEmpRoleID,
                        principalTable: "Role",
                        principalColumn: "EmpRoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeLocationLocationID",
                table: "Employees",
                column: "EmployeeLocationLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeePhoneNumber_ID",
                table: "Employees",
                column: "EmployeePhoneNumber_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleEmpRoleID",
                table: "Employees",
                column: "RoleEmpRoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "PhoneNumber");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
