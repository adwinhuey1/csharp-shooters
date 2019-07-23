﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using valkyrieID.Models;

namespace valkyrieID.Migrations
{
    [DbContext(typeof(ValkyrieDBContext))]
    partial class ValkyrieDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("valkyrieID.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerEmail");

                    b.Property<string>("CustomerPhone");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int?>("SaleReceiptId");

                    b.HasKey("CustomerId");

                    b.HasIndex("SaleReceiptId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("valkyrieID.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("InvoiceDate");

                    b.Property<int?>("ProductNameProductId");

                    b.Property<decimal>("PurchasePrice");

                    b.Property<int>("Quantity");

                    b.Property<string>("VendorName");

                    b.HasKey("InvoiceId");

                    b.HasIndex("ProductNameProductId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("valkyrieID.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<int?>("InvoiceId");

                    b.Property<string>("ProductName");

                    b.Property<decimal>("PurchasePrice");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("SalePrice");

                    b.Property<int?>("SaleReceiptId");

                    b.Property<string>("Unit");

                    b.Property<string>("VendorName");

                    b.HasKey("ProductId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("SaleReceiptId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("valkyrieID.Models.SaleReceipt", b =>
                {
                    b.Property<int>("SaleReceiptId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomerFirstNameCustomerId");

                    b.Property<int?>("CustomerLastNameCustomerId");

                    b.Property<int?>("ProductNameProductId");

                    b.Property<int>("Quantity");

                    b.Property<DateTime>("ReceiptDate");

                    b.Property<decimal>("SalePrice");

                    b.HasKey("SaleReceiptId");

                    b.HasIndex("CustomerFirstNameCustomerId");

                    b.HasIndex("CustomerLastNameCustomerId");

                    b.HasIndex("ProductNameProductId");

                    b.ToTable("SaleReceipts");
                });

            modelBuilder.Entity("valkyrieID.Models.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("InvoiceId");

                    b.Property<string>("VendorAddress");

                    b.Property<string>("VendorEmail");

                    b.Property<string>("VendorName");

                    b.Property<string>("VendorPhone");

                    b.HasKey("VendorId");

                    b.HasIndex("InvoiceId");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("valkyrieID.Models.Customer", b =>
                {
                    b.HasOne("valkyrieID.Models.SaleReceipt")
                        .WithMany("Customers")
                        .HasForeignKey("SaleReceiptId");
                });

            modelBuilder.Entity("valkyrieID.Models.Invoice", b =>
                {
                    b.HasOne("valkyrieID.Models.Product", "ProductName")
                        .WithMany()
                        .HasForeignKey("ProductNameProductId");
                });

            modelBuilder.Entity("valkyrieID.Models.Product", b =>
                {
                    b.HasOne("valkyrieID.Models.Invoice")
                        .WithMany("Products")
                        .HasForeignKey("InvoiceId");

                    b.HasOne("valkyrieID.Models.SaleReceipt")
                        .WithMany("Products")
                        .HasForeignKey("SaleReceiptId");
                });

            modelBuilder.Entity("valkyrieID.Models.SaleReceipt", b =>
                {
                    b.HasOne("valkyrieID.Models.Customer", "CustomerFirstName")
                        .WithMany()
                        .HasForeignKey("CustomerFirstNameCustomerId");

                    b.HasOne("valkyrieID.Models.Customer", "CustomerLastName")
                        .WithMany()
                        .HasForeignKey("CustomerLastNameCustomerId");

                    b.HasOne("valkyrieID.Models.Product", "ProductName")
                        .WithMany()
                        .HasForeignKey("ProductNameProductId");
                });

            modelBuilder.Entity("valkyrieID.Models.Vendor", b =>
                {
                    b.HasOne("valkyrieID.Models.Invoice")
                        .WithMany("Vendors")
                        .HasForeignKey("InvoiceId");
                });
#pragma warning restore 612, 618
        }
    }
}
