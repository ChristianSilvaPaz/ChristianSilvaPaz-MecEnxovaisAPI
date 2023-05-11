using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MecEnxovais.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductImageDeletion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Image",
                table: "Products",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
