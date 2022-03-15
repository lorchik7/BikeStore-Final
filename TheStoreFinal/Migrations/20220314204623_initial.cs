using Microsoft.EntityFrameworkCore.Migrations;

namespace TheStoreFinal.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sales");

            migrationBuilder.CreateTable(
                name: "stores",
                schema: "sales",
                columns: table => new
                {
                    store_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    store_name = table.Column<string>(type: "varchar", nullable: false),
                    city = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.store_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stores",
                schema: "sales");
        }
    }
}
