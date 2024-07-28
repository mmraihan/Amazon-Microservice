using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Amazon.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class ProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Electronics", "High performance laptop with 16GB RAM and 512GB SSD.<br/> Ideal for gaming, programming, and design.", "https://placehold.co/603x403", "Laptop", 1000.0 },
                    { 2, "Electronics", "Latest smartphone with 5G connectivity and 128GB storage.<br/> Features a stunning display and excellent camera.", "https://placehold.co/602x402", "Smartphone", 699.99000000000001 },
                    { 3, "Wearables", "Smartwatch with heart rate monitor and GPS tracking.<br/> Perfect for fitness enthusiasts and tech lovers.", "https://placehold.co/601x401", "Smartwatch", 199.99000000000001 },
                    { 4, "Electronics", "Versatile tablet with 10.5-inch display and 64GB storage.<br/> Great for entertainment and productivity on the go.", "https://placehold.co/600x400", "Tablet", 329.99000000000001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
