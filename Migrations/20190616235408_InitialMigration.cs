using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace valkyrieIMS.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SaleReceipts",
                columns: table => new
                {
                    SaleReceiptId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReceiptDate = table.Column<DateTime>(nullable: false),
                    CustomerFirstName = table.Column<string>(nullable: true),
                    CustomerLastName = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    SalePrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleReceipts", x => x.SaleReceiptId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerFirstName = table.Column<string>(nullable: true),
                    CustomerLastName = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true),
                    CustomerEmail = table.Column<string>(nullable: true),
                    SaleReceiptId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_SaleReceipts_SaleReceiptId",
                        column: x => x.SaleReceiptId,
                        principalTable: "SaleReceipts",
                        principalColumn: "SaleReceiptId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoices",
                columns: table => new
                {
                    PurchaseInvoiceId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VendorName = table.Column<string>(nullable: true),
                    ProductNameProductId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    PurchasePrice = table.Column<decimal>(nullable: false),
                    InvoiceDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoices", x => x.PurchaseInvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    VendorName = table.Column<string>(nullable: true),
                    PurchasePrice = table.Column<decimal>(nullable: false),
                    SalePrice = table.Column<decimal>(nullable: false),
                    Unit = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    PurchaseInvoiceId = table.Column<int>(nullable: true),
                    SaleReceiptId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_PurchaseInvoices_PurchaseInvoiceId",
                        column: x => x.PurchaseInvoiceId,
                        principalTable: "PurchaseInvoices",
                        principalColumn: "PurchaseInvoiceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_SaleReceipts_SaleReceiptId",
                        column: x => x.SaleReceiptId,
                        principalTable: "SaleReceipts",
                        principalColumn: "SaleReceiptId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VendorName = table.Column<string>(nullable: true),
                    VendorAddress = table.Column<string>(nullable: true),
                    VendorEmail = table.Column<string>(nullable: true),
                    VendorPhone = table.Column<string>(nullable: true),
                    PurchaseInvoiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                    table.ForeignKey(
                        name: "FK_Vendors_PurchaseInvoices_PurchaseInvoiceId",
                        column: x => x.PurchaseInvoiceId,
                        principalTable: "PurchaseInvoices",
                        principalColumn: "PurchaseInvoiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_SaleReceiptId",
                table: "Customers",
                column: "SaleReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PurchaseInvoiceId",
                table: "Products",
                column: "PurchaseInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SaleReceiptId",
                table: "Products",
                column: "SaleReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoices_ProductNameProductId",
                table: "PurchaseInvoices",
                column: "ProductNameProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_PurchaseInvoiceId",
                table: "Vendors",
                column: "PurchaseInvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoices_Products_ProductNameProductId",
                table: "PurchaseInvoices",
                column: "ProductNameProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SaleReceipts_SaleReceiptId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_PurchaseInvoices_PurchaseInvoiceId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "SaleReceipts");

            migrationBuilder.DropTable(
                name: "PurchaseInvoices");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
