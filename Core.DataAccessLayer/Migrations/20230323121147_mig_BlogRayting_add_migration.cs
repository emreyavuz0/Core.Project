using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_BlogRayting_add_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogRaytings",
                columns: table => new
                {
                    BlogRaytingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    BlogTotalScore = table.Column<int>(type: "int", nullable: false),
                    BlogRaytingCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogRaytings", x => x.BlogRaytingId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogRaytings");
        }
    }
}
