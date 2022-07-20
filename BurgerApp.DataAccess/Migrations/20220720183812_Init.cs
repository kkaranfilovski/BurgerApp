using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerApp.DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Burgers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsVegeterian = table.Column<bool>(type: "bit", nullable: false),
                    IsVegan = table.Column<bool>(type: "bit", nullable: false),
                    HasFries = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burgers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BurgerOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    BurgerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BurgerOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BurgerOrder_Burgers_BurgerId",
                        column: x => x.BurgerId,
                        principalTable: "Burgers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BurgerOrder_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "HasFries", "IsVegan", "IsVegeterian", "Name", "Price" },
                values: new object[,]
                {
                    { 1, true, false, false, "Hamburger", 150.0 },
                    { 2, true, false, false, "Cheeseburger", 180.0 },
                    { 3, true, false, true, "Vegeburger", 140.0 },
                    { 4, false, true, true, "Veganburger", 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Location" },
                values: new object[,]
                {
                    { 1, "ul.France Preshern br.46", "Kristijan", "Karanfilovski", "Vlae" },
                    { 2, "ul. Radishani Hills br. 10", "Ilija", "Mitev", "Radishani" },
                    { 3, "ul.Sparkling Water br. 99", "Aneta", "Stankovska", "Kisela voda" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsDelivered", "PaymentMethod", "UserId" },
                values: new object[] { 1, false, 2, 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsDelivered", "PaymentMethod", "UserId" },
                values: new object[] { 2, false, 2, 2 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsDelivered", "PaymentMethod", "UserId" },
                values: new object[] { 3, false, 2, 3 });

            migrationBuilder.InsertData(
                table: "BurgerOrder",
                columns: new[] { "Id", "BurgerId", "OrderId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 2 },
                    { 4, 3, 3 },
                    { 5, 4, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BurgerOrder_BurgerId",
                table: "BurgerOrder",
                column: "BurgerId");

            migrationBuilder.CreateIndex(
                name: "IX_BurgerOrder_OrderId",
                table: "BurgerOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BurgerOrder");

            migrationBuilder.DropTable(
                name: "Burgers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
