using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP.EMPLOYEE.CRUD.Migrations
{
    /// <inheritdoc />
    public partial class INITIALMIGRATION : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    CID = table.Column<int>(type: "int", nullable: false),
                    CNAME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.CID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    POSID = table.Column<int>(type: "int", nullable: false),
                    POSNAME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.POSID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Empno = table.Column<int>(type: "int", nullable: false),
                    EmpName = table.Column<int>(type: "int", nullable: false),
                    EmpSal = table.Column<int>(type: "int", nullable: false),
                    EmpEmal = table.Column<int>(type: "int", nullable: false),
                    CID = table.Column<int>(type: "int", nullable: false),
                    POSID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Empno);
                    table.ForeignKey(
                        name: "FK_Employees_Positions_Empno",
                        column: x => x.Empno,
                        principalTable: "Positions",
                        principalColumn: "POSID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_company_CID",
                        column: x => x.CID,
                        principalTable: "company",
                        principalColumn: "CID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CID",
                table: "Employees",
                column: "CID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "company");
        }
    }
}
