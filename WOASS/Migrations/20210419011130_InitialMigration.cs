using Microsoft.EntityFrameworkCore.Migrations;

namespace WOASS.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkOrders",
                columns: table => new
                {
                    WorkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<bool>(type: "bit", nullable: false),
                    WorkType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayStatus = table.Column<bool>(type: "bit", nullable: false),
                    PriceId = table.Column<int>(type: "int", nullable: false),
                    GearId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrders", x => x.WorkId);
                });

            migrationBuilder.InsertData(
                table: "WorkOrders",
                columns: new[] { "WorkId", "GearId", "Notes", "OrderDate", "PayStatus", "PriceId", "Priority", "UserId", "WorkType" },
                values: new object[,]
                {
                    { 1, 1, null, "10/27/2020", true, 1, false, 1, "wax" },
                    { 2, 2, null, "10/28/2020", true, 2, false, 2, "base grind" },
                    { 3, 3, null, "10/29/2020", true, 2, false, 2, "base grind" },
                    { 4, 4, null, "10/30/2020", true, 3, false, 3, "basic tune" },
                    { 5, 4, null, "11/1/2020", true, 3, false, 3, "basic tune" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkOrders");
        }
    }
}
