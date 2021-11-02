﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba.Data;

namespace Prueba.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191013223831_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

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

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Prueba.Models.ApplicationUser", b =>
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
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Prueba.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("BillDate");

                    b.Property<DateTimeOffset>("BillDueDate");

                    b.Property<string>("BillName");

                    b.Property<int>("BillTypeId");

                    b.Property<int>("GoodsReceivedNoteId");

                    b.Property<string>("VendorDONumber");

                    b.Property<string>("VendorInvoiceNumber");

                    b.HasKey("BillId");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("Prueba.Models.BillType", b =>
                {
                    b.Property<int>("BillTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillTypeName")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.HasKey("BillTypeId");

                    b.ToTable("BillType");
                });

            modelBuilder.Entity("Prueba.Models.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("BranchName")
                        .IsRequired();

                    b.Property<string>("City");

                    b.Property<string>("ContactPerson");

                    b.Property<int>("CurrencyId");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("ZipCode");

                    b.HasKey("BranchId");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("Prueba.Models.CashBank", b =>
                {
                    b.Property<int>("CashBankId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CashBankName");

                    b.Property<string>("Description");

                    b.HasKey("CashBankId");

                    b.ToTable("CashBank");
                });

            modelBuilder.Entity("Prueba.Models.Currency", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrencyCode")
                        .IsRequired();

                    b.Property<string>("CurrencyName")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.HasKey("CurrencyId");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("Prueba.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("ContactPerson");

                    b.Property<string>("CustomerName")
                        .IsRequired();

                    b.Property<int>("CustomerTypeId");

                    b.Property<string>("Email");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("ZipCode");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Prueba.Models.CustomerType", b =>
                {
                    b.Property<int>("CustomerTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerTypeName")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.HasKey("CustomerTypeId");

                    b.ToTable("CustomerType");
                });

            modelBuilder.Entity("Prueba.Models.GoodsReceivedNote", b =>
                {
                    b.Property<int>("GoodsReceivedNoteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("GRNDate");

                    b.Property<string>("GoodsReceivedNoteName");

                    b.Property<bool>("IsFullReceive");

                    b.Property<int>("PurchaseOrderId");

                    b.Property<string>("VendorDONumber");

                    b.Property<string>("VendorInvoiceNumber");

                    b.Property<int>("WarehouseId");

                    b.HasKey("GoodsReceivedNoteId");

                    b.ToTable("GoodsReceivedNote");
                });

            modelBuilder.Entity("Prueba.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("InvoiceDate");

                    b.Property<DateTimeOffset>("InvoiceDueDate");

                    b.Property<string>("InvoiceName");

                    b.Property<int>("InvoiceTypeId");

                    b.Property<int>("ShipmentId");

                    b.HasKey("InvoiceId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Prueba.Models.InvoiceType", b =>
                {
                    b.Property<int>("InvoiceTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("InvoiceTypeName")
                        .IsRequired();

                    b.HasKey("InvoiceTypeId");

                    b.ToTable("InvoiceType");
                });

            modelBuilder.Entity("Prueba.Models.NumberSequence", b =>
                {
                    b.Property<int>("NumberSequenceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LastNumber");

                    b.Property<string>("Module")
                        .IsRequired();

                    b.Property<string>("NumberSequenceName")
                        .IsRequired();

                    b.Property<string>("Prefix")
                        .IsRequired();

                    b.HasKey("NumberSequenceId");

                    b.ToTable("NumberSequence");
                });

            modelBuilder.Entity("Prueba.Models.PaymentReceive", b =>
                {
                    b.Property<int>("PaymentReceiveId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InvoiceId");

                    b.Property<bool>("IsFullPayment");

                    b.Property<double>("PaymentAmount");

                    b.Property<DateTimeOffset>("PaymentDate");

                    b.Property<string>("PaymentReceiveName");

                    b.Property<int>("PaymentTypeId");

                    b.HasKey("PaymentReceiveId");

                    b.ToTable("PaymentReceive");
                });

            modelBuilder.Entity("Prueba.Models.PaymentType", b =>
                {
                    b.Property<int>("PaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("PaymentTypeName")
                        .IsRequired();

                    b.HasKey("PaymentTypeId");

                    b.ToTable("PaymentType");
                });

            modelBuilder.Entity("Prueba.Models.PaymentVoucher", b =>
                {
                    b.Property<int>("PaymentvoucherId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BillId");

                    b.Property<int>("CashBankId");

                    b.Property<bool>("IsFullPayment");

                    b.Property<double>("PaymentAmount");

                    b.Property<DateTimeOffset>("PaymentDate");

                    b.Property<int>("PaymentTypeId");

                    b.Property<string>("PaymentVoucherName");

                    b.HasKey("PaymentvoucherId");

                    b.ToTable("PaymentVoucher");
                });

            modelBuilder.Entity("Prueba.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode");

                    b.Property<int>("BranchId");

                    b.Property<int>("CurrencyId");

                    b.Property<double>("DefaultBuyingPrice");

                    b.Property<double>("DefaultSellingPrice");

                    b.Property<string>("Description");

                    b.Property<string>("ProductCode");

                    b.Property<string>("ProductImageUrl");

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<int>("UnitOfMeasureId");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Prueba.Models.ProductType", b =>
                {
                    b.Property<int>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ProductTypeName")
                        .IsRequired();

                    b.HasKey("ProductTypeId");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("Prueba.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("PurchaseOrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int>("BranchId");

                    b.Property<int>("CurrencyId");

                    b.Property<DateTimeOffset>("DeliveryDate");

                    b.Property<double>("Discount");

                    b.Property<double>("Freight");

                    b.Property<DateTimeOffset>("OrderDate");

                    b.Property<string>("PurchaseOrderName");

                    b.Property<int>("PurchaseTypeId");

                    b.Property<string>("Remarks");

                    b.Property<double>("SubTotal");

                    b.Property<double>("Tax");

                    b.Property<double>("Total");

                    b.Property<int>("VendorId");

                    b.HasKey("PurchaseOrderId");

                    b.ToTable("PurchaseOrder");
                });

            modelBuilder.Entity("Prueba.Models.PurchaseOrderLine", b =>
                {
                    b.Property<int>("PurchaseOrderLineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<string>("Description");

                    b.Property<double>("DiscountAmount");

                    b.Property<double>("DiscountPercentage");

                    b.Property<double>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("PurchaseOrderId");

                    b.Property<double>("Quantity");

                    b.Property<double>("SubTotal");

                    b.Property<double>("TaxAmount");

                    b.Property<double>("TaxPercentage");

                    b.Property<double>("Total");

                    b.HasKey("PurchaseOrderLineId");

                    b.HasIndex("PurchaseOrderId");

                    b.ToTable("PurchaseOrderLine");
                });

            modelBuilder.Entity("Prueba.Models.PurchaseType", b =>
                {
                    b.Property<int>("PurchaseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("PurchaseTypeName")
                        .IsRequired();

                    b.HasKey("PurchaseTypeId");

                    b.ToTable("PurchaseType");
                });

            modelBuilder.Entity("Prueba.Models.SalesOrder", b =>
                {
                    b.Property<int>("SalesOrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int>("BranchId");

                    b.Property<int>("CurrencyId");

                    b.Property<int>("CustomerId");

                    b.Property<string>("CustomerRefNumber");

                    b.Property<DateTimeOffset>("DeliveryDate");

                    b.Property<double>("Discount");

                    b.Property<double>("Freight");

                    b.Property<DateTimeOffset>("OrderDate");

                    b.Property<string>("Remarks");

                    b.Property<string>("SalesOrderName");

                    b.Property<int>("SalesTypeId");

                    b.Property<double>("SubTotal");

                    b.Property<double>("Tax");

                    b.Property<double>("Total");

                    b.HasKey("SalesOrderId");

                    b.ToTable("SalesOrder");
                });

            modelBuilder.Entity("Prueba.Models.SalesOrderLine", b =>
                {
                    b.Property<int>("SalesOrderLineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<string>("Description");

                    b.Property<double>("DiscountAmount");

                    b.Property<double>("DiscountPercentage");

                    b.Property<double>("Price");

                    b.Property<int>("ProductId");

                    b.Property<double>("Quantity");

                    b.Property<int>("SalesOrderId");

                    b.Property<double>("SubTotal");

                    b.Property<double>("TaxAmount");

                    b.Property<double>("TaxPercentage");

                    b.Property<double>("Total");

                    b.HasKey("SalesOrderLineId");

                    b.HasIndex("SalesOrderId");

                    b.ToTable("SalesOrderLine");
                });

            modelBuilder.Entity("Prueba.Models.SalesType", b =>
                {
                    b.Property<int>("SalesTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("SalesTypeName")
                        .IsRequired();

                    b.HasKey("SalesTypeId");

                    b.ToTable("SalesType");
                });

            modelBuilder.Entity("Prueba.Models.Shipment", b =>
                {
                    b.Property<int>("ShipmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsFullShipment");

                    b.Property<int>("SalesOrderId");

                    b.Property<DateTimeOffset>("ShipmentDate");

                    b.Property<string>("ShipmentName");

                    b.Property<int>("ShipmentTypeId");

                    b.Property<int>("WarehouseId");

                    b.HasKey("ShipmentId");

                    b.ToTable("Shipment");
                });

            modelBuilder.Entity("Prueba.Models.ShipmentType", b =>
                {
                    b.Property<int>("ShipmentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ShipmentTypeName")
                        .IsRequired();

                    b.HasKey("ShipmentTypeId");

                    b.ToTable("ShipmentType");
                });

            modelBuilder.Entity("Prueba.Models.UnitOfMeasure", b =>
                {
                    b.Property<int>("UnitOfMeasureId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("UnitOfMeasureName")
                        .IsRequired();

                    b.HasKey("UnitOfMeasureId");

                    b.ToTable("UnitOfMeasure");
                });

            modelBuilder.Entity("Prueba.Models.UserProfile", b =>
                {
                    b.Property<int>("UserProfileId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("ConfirmPassword");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<short>("IdRol");

                    b.Property<string>("LastName");

                    b.Property<string>("OldPassword");

                    b.Property<string>("Password");

                    b.Property<string>("ProfilePicture");

                    b.HasKey("UserProfileId");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("Prueba.Models.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("ContactPerson");

                    b.Property<string>("Email");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("VendorName")
                        .IsRequired();

                    b.Property<int>("VendorTypeId");

                    b.Property<string>("ZipCode");

                    b.HasKey("VendorId");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("Prueba.Models.VendorType", b =>
                {
                    b.Property<int>("VendorTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("VendorTypeName")
                        .IsRequired();

                    b.HasKey("VendorTypeId");

                    b.ToTable("VendorType");
                });

            modelBuilder.Entity("Prueba.Models.Warehouse", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId");

                    b.Property<string>("Description");

                    b.Property<string>("WarehouseName")
                        .IsRequired();

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouse");
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
                    b.HasOne("Prueba.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Prueba.Models.ApplicationUser")
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

                    b.HasOne("Prueba.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Prueba.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prueba.Models.PurchaseOrderLine", b =>
                {
                    b.HasOne("Prueba.Models.PurchaseOrder", "PurchaseOrder")
                        .WithMany("PurchaseOrderLines")
                        .HasForeignKey("PurchaseOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prueba.Models.SalesOrderLine", b =>
                {
                    b.HasOne("Prueba.Models.SalesOrder", "SalesOrder")
                        .WithMany("SalesOrderLines")
                        .HasForeignKey("SalesOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
