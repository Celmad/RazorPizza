using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesPizza.Migrations
{
    /// <inheritdoc />
    public partial class PizzaSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Pizza",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Pizza");
        }
    }
}
