using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorDBCodeFirst23.Migrations
{
    /// <inheritdoc />
    public partial class Mysale2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "Sales",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Sales");
        }
    }
}
