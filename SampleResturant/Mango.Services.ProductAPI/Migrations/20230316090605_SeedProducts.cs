using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mango.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "ImageUrl", "Price", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { 1, "Appetizer", "https://drive.google.com/file/d/1YbDtCsClmwwYeDfzVLIyhH5jih9qnB5x/view?usp=share_link", 15.0, "A fried South Asian pastry with a savoury filling, including ingredients such as spiced potatoes, onions, and peas.", "Samosa" },
                    { 2, "Appetizer", "https://drive.google.com/file/d/1euCZOZbWStvcQyueSOtx8oafD2c5mlVJ/view?usp=share_link", 13.99, "An Indian dish made from chunks of paneer marinated in spices and grilled in a tandoor.", "Paneer Tikka" },
                    { 3, "Dessert", "https://drive.google.com/file/d/1jylnF37jQKvXoe1rdm--dt-UjQJdEST7/view?usp=share_link", 10.99, "A pie is a baked dish which is usually made of a pastry dough casing that contains a filling of various sweet or savoury ingredients.", "Sweet Pie" },
                    { 4, "Entree", "https://drive.google.com/file/d/1aV-V_5KcMB7ankZjTezNX8ncbgYq4iie/view?usp=sharing", 15.0, "Pav Bhaji is a fast food dish from Mumbai (Bombay), India, consisting of a vegetable curry (bhaji) cooked in tomato gravy and served with a soft bread roll (pav).", "Pav Bhaji" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
