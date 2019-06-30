using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ValkyrieIMS.Migrations
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
                    CustomerFirstNameCustomerId = table.Column<int>(nullable: true),
                    CustomerLastNameCustomerId = table.Column<int>(nullable: true),
                    ProductNameProductId = table.Column<int>(nullable: true),
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
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
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
                    InvoiceId = table.Column<int>(nullable: true),
                    SaleReceiptId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_SaleReceipts_SaleReceiptId",
                        column: x => x.SaleReceiptId,
                        principalTable: "SaleReceipts",
                        principalColumn: "SaleReceiptId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VendorName = table.Column<string>(nullable: true),
                    ProductNameProductId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    PurchasePrice = table.Column<decimal>(nullable: false),
                    InvoiceDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoices_Products_ProductNameProductId",
                        column: x => x.ProductNameProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
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
                    InvoiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                    table.ForeignKey(
                        name: "FK_Vendors_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_SaleReceiptId",
                table: "Customers",
                column: "SaleReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ProductNameProductId",
                table: "Invoices",
                column: "ProductNameProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_InvoiceId",
                table: "Products",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SaleReceiptId",
                table: "Products",
                column: "SaleReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleReceipts_CustomerFirstNameCustomerId",
                table: "SaleReceipts",
                column: "CustomerFirstNameCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleReceipts_CustomerLastNameCustomerId",
                table: "SaleReceipts",
                column: "CustomerLastNameCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleReceipts_ProductNameProductId",
                table: "SaleReceipts",
                column: "ProductNameProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_InvoiceId",
                table: "Vendors",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleReceipts_Products_ProductNameProductId",
                table: "SaleReceipts",
                column: "ProductNameProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleReceipts_Customers_CustomerFirstNameCustomerId",
                table: "SaleReceipts",
                column: "CustomerFirstNameCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleReceipts_Customers_CustomerLastNameCustomerId",
                table: "SaleReceipts",
                column: "CustomerLastNameCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Invoices_InvoiceId",
                table: "Products",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SaleReceipts_SaleReceiptId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SaleReceipts_SaleReceiptId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Products_ProductNameProductId",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "SaleReceipts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
