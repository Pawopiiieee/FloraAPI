using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FloraAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Habitat",
                table: "Floras",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NativeRange",
                table: "Floras",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Habitat",
                table: "Floras");

            migrationBuilder.DropColumn(
                name: "NativeRange",
                table: "Floras");
        }
    }
}
