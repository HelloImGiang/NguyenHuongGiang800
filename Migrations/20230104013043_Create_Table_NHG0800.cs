using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenHuongGiang800.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableNHG0800 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NHG0800",
                columns: table => new
                {
                    NHGId = table.Column<string>(type: "TEXT", nullable: false),
                    NHGName = table.Column<string>(type: "TEXT", nullable: false),
                    NHGGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHG0800", x => x.NHGId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NHG0800");
        }
    }
}
