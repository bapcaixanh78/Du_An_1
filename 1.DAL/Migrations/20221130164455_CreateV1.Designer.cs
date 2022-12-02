﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

namespace _1.DAL.Migrations
{
    [DbContext(typeof(MaterialWarehouseDbContext))]
    [Migration("20221130164455_CreateV1")]
    partial class CreateV1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1.DAL.Models.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("_1.DAL.Models.Bill", b =>
                {
                    b.Property<Guid>("IdBill")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CustomerIdCustomer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HPointsidHPoints")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCustomer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdStaff")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PaymentedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PointsUsed")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceivedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ShipDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("StaffIdStaff")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("idHPoints")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdBill");

                    b.HasIndex("CustomerIdCustomer");

                    b.HasIndex("HPointsidHPoints");

                    b.HasIndex("StaffIdStaff");

                    b.ToTable("bills");
                });

            modelBuilder.Entity("_1.DAL.Models.BillDetail", b =>
                {
                    b.Property<Guid>("IdMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdBill")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdMaterial", "IdBill");

                    b.HasIndex("IdBill");

                    b.ToTable("billDetails");
                });

            modelBuilder.Entity("_1.DAL.Models.Customer", b =>
                {
                    b.Property<Guid>("IdCustomer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("BirthOfDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdCustomer");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("_1.DAL.Models.HistoryUsingPoints", b =>
                {
                    b.Property<Guid>("idHPoints")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateUse")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlusPoints")
                        .HasColumnType("int");

                    b.Property<int>("PointsUsed")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("idHPoints");

                    b.ToTable("HPoints");
                });

            modelBuilder.Entity("_1.DAL.Models.Material", b =>
                {
                    b.Property<Guid>("IdMaterial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdMaterial");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("_1.DAL.Models.MaterialDetail", b =>
                {
                    b.Property<Guid>("IdMDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid>("IdMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdProducer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ImportPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("MaterialIdMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("ProducerIdProducer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Unit")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdMDetail");

                    b.HasIndex("MaterialIdMaterial");

                    b.HasIndex("ProducerIdProducer");

                    b.ToTable("MaterialDetails");
                });

            modelBuilder.Entity("_1.DAL.Models.PointWallet", b =>
                {
                    b.Property<Guid>("IdPWallet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerIdCustomer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HPointsidHPoints")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCustomer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PointsAdded")
                        .HasColumnType("int");

                    b.Property<int>("PointsUsed")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TotalScore")
                        .HasColumnType("int");

                    b.Property<Guid>("idHPoints")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdPWallet");

                    b.HasIndex("CustomerIdCustomer");

                    b.HasIndex("HPointsidHPoints");

                    b.ToTable("pointWallets");
                });

            modelBuilder.Entity("_1.DAL.Models.PointsFund", b =>
                {
                    b.Property<Guid>("IdPFund")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HPointsidHPoints")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PointsMoney")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PointsUsed")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("idHPoints")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdPFund");

                    b.HasIndex("HPointsidHPoints");

                    b.ToTable("pointsFunds");
                });

            modelBuilder.Entity("_1.DAL.Models.Position", b =>
                {
                    b.Property<Guid>("IdPosition")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdPosition");

                    b.ToTable("positions");
                });

            modelBuilder.Entity("_1.DAL.Models.Producer", b =>
                {
                    b.Property<Guid>("IdProducer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nation")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdProducer");

                    b.ToTable("producers");
                });

            modelBuilder.Entity("_1.DAL.Models.Staff", b =>
                {
                    b.Property<Guid>("IdStaff")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdPosition")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdWareHouse")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid?>("PositionIdPosition")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Wage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("WareHouseIdWarehouse")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdStaff");

                    b.HasIndex("PositionIdPosition");

                    b.HasIndex("WareHouseIdWarehouse");

                    b.ToTable("staffs");
                });

            modelBuilder.Entity("_1.DAL.Models.WareHouse", b =>
                {
                    b.Property<Guid>("IdWarehouse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nation")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdWarehouse");

                    b.ToTable("wareHouses");
                });

            modelBuilder.Entity("_1.DAL.Models.Bill", b =>
                {
                    b.HasOne("_1.DAL.Models.Customer", "Customer")
                        .WithMany("Bills")
                        .HasForeignKey("CustomerIdCustomer");

                    b.HasOne("_1.DAL.Models.HistoryUsingPoints", "HPoints")
                        .WithMany("Bills")
                        .HasForeignKey("HPointsidHPoints");

                    b.HasOne("_1.DAL.Models.Staff", "Staff")
                        .WithMany("Bills")
                        .HasForeignKey("StaffIdStaff");

                    b.Navigation("Customer");

                    b.Navigation("HPoints");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("_1.DAL.Models.BillDetail", b =>
                {
                    b.HasOne("_1.DAL.Models.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("IdBill")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.Material", "Material")
                        .WithMany("BillDetails")
                        .HasForeignKey("IdMaterial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("_1.DAL.Models.MaterialDetail", b =>
                {
                    b.HasOne("_1.DAL.Models.Material", "Material")
                        .WithMany("MaterialDetails")
                        .HasForeignKey("MaterialIdMaterial");

                    b.HasOne("_1.DAL.Models.Producer", "Producer")
                        .WithMany("MaterialDetails")
                        .HasForeignKey("ProducerIdProducer");

                    b.Navigation("Material");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("_1.DAL.Models.PointWallet", b =>
                {
                    b.HasOne("_1.DAL.Models.Customer", "Customer")
                        .WithMany("PointWallets")
                        .HasForeignKey("CustomerIdCustomer");

                    b.HasOne("_1.DAL.Models.HistoryUsingPoints", "HPoints")
                        .WithMany("PWallet")
                        .HasForeignKey("HPointsidHPoints");

                    b.Navigation("Customer");

                    b.Navigation("HPoints");
                });

            modelBuilder.Entity("_1.DAL.Models.PointsFund", b =>
                {
                    b.HasOne("_1.DAL.Models.HistoryUsingPoints", "HPoints")
                        .WithMany("PFund")
                        .HasForeignKey("HPointsidHPoints");

                    b.Navigation("HPoints");
                });

            modelBuilder.Entity("_1.DAL.Models.Staff", b =>
                {
                    b.HasOne("_1.DAL.Models.Position", "Position")
                        .WithMany("Staffs")
                        .HasForeignKey("PositionIdPosition");

                    b.HasOne("_1.DAL.Models.WareHouse", "WareHouse")
                        .WithMany("Staffs")
                        .HasForeignKey("WareHouseIdWarehouse");

                    b.Navigation("Position");

                    b.Navigation("WareHouse");
                });

            modelBuilder.Entity("_1.DAL.Models.Bill", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("_1.DAL.Models.Customer", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("PointWallets");
                });

            modelBuilder.Entity("_1.DAL.Models.HistoryUsingPoints", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("PFund");

                    b.Navigation("PWallet");
                });

            modelBuilder.Entity("_1.DAL.Models.Material", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("MaterialDetails");
                });

            modelBuilder.Entity("_1.DAL.Models.Position", b =>
                {
                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("_1.DAL.Models.Producer", b =>
                {
                    b.Navigation("MaterialDetails");
                });

            modelBuilder.Entity("_1.DAL.Models.Staff", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("_1.DAL.Models.WareHouse", b =>
                {
                    b.Navigation("Staffs");
                });
#pragma warning restore 612, 618
        }
    }
}
