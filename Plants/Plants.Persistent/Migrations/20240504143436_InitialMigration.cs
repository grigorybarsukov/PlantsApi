using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Plants.Persistent.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LatinName = table.Column<string>(type: "text", nullable: false),
                    Illumination = table.Column<int>(type: "integer", nullable: true),
                    SoilAttributes = table.Column<string[]>(type: "text[]", nullable: true),
                    Watering = table.Column<string>(type: "text", nullable: false),
                    Temperature = table.Column<string>(type: "text", nullable: false),
                    Humidity = table.Column<string>(type: "text", nullable: false),
                    Complexity = table.Column<string>(type: "text", nullable: false),
                    ToxicToPets = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plants");
        }
    }
}
