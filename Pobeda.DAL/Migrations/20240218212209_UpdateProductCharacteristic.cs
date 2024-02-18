using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pobeda.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductCharacteristic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProductCharacteristics",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "ProductCharacteristics",
                newName: "Key");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "ProductCharacteristics",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "ProductCharacteristics",
                newName: "Description");
        }
    }
}
