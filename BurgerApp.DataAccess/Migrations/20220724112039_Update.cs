using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerApp.DataAccess.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Burgers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://www.pngall.com/wp-content/uploads/2016/05/Burger-Free-Download-PNG.png");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://www.pngmart.com/files/16/Bacon-Cheese-Burger-Transparent-PNG.png");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://www.kindpng.com/picc/m/537-5374610_veg-patties-png-burger-images-hd-png-transparent.png");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://www.seekpng.com/png/full/316-3165034_falafel-burger-hamburger.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Burgers");
        }
    }
}
