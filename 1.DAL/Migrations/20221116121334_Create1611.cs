using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class Create1611 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BirthOfDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.IdCustomer);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    IdMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.IdMaterial);
                });

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    IdPosition = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions", x => x.IdPosition);
                });

            migrationBuilder.CreateTable(
                name: "producers",
                columns: table => new
                {
                    IdProducer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Nation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producers", x => x.IdProducer);
                });

            migrationBuilder.CreateTable(
                name: "wareHouses",
                columns: table => new
                {
                    IdWarehouse = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Nation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wareHouses", x => x.IdWarehouse);
                });

            migrationBuilder.CreateTable(
                name: "MaterialDetails",
                columns: table => new
                {
                    IdMDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImportPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProducerIdProducer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaterialIdMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDetails", x => x.IdMDetail);
                    table.ForeignKey(
                        name: "FK_MaterialDetails_Materials_MaterialIdMaterial",
                        column: x => x.MaterialIdMaterial,
                        principalTable: "Materials",
                        principalColumn: "IdMaterial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialDetails_producers_ProducerIdProducer",
                        column: x => x.ProducerIdProducer,
                        principalTable: "producers",
                        principalColumn: "IdProducer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "staffs",
                columns: table => new
                {
                    IdStaff = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Wage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PositionIdPosition = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WareHouseIdWarehouse = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.IdStaff);
                    table.ForeignKey(
                        name: "FK_staffs_positions_PositionIdPosition",
                        column: x => x.PositionIdPosition,
                        principalTable: "positions",
                        principalColumn: "IdPosition",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_staffs_wareHouses_WareHouseIdWarehouse",
                        column: x => x.WareHouseIdWarehouse,
                        principalTable: "wareHouses",
                        principalColumn: "IdWarehouse",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "bills",
                columns: table => new
                {
                    IdBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CustomerIdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StaffIdStaff = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bills", x => x.IdBill);
                    table.ForeignKey(
                        name: "FK_bills_Customers_CustomerIdCustomer",
                        column: x => x.CustomerIdCustomer,
                        principalTable: "Customers",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bills_staffs_StaffIdStaff",
                        column: x => x.StaffIdStaff,
                        principalTable: "staffs",
                        principalColumn: "IdStaff",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "billDetails",
                columns: table => new
                {
                    IdBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaterialIdMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billDetails", x => new { x.IdMDetail, x.IdBill });
                    table.ForeignKey(
                        name: "FK_billDetails_bills_IdBill",
                        column: x => x.IdBill,
                        principalTable: "bills",
                        principalColumn: "IdBill",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_billDetails_Materials_MaterialIdMaterial",
                        column: x => x.MaterialIdMaterial,
                        principalTable: "Materials",
                        principalColumn: "IdMaterial",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_billDetails_IdBill",
                table: "billDetails",
                column: "IdBill");

            migrationBuilder.CreateIndex(
                name: "IX_billDetails_MaterialIdMaterial",
                table: "billDetails",
                column: "MaterialIdMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_bills_CustomerIdCustomer",
                table: "bills",
                column: "CustomerIdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_bills_StaffIdStaff",
                table: "bills",
                column: "StaffIdStaff");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDetails_MaterialIdMaterial",
                table: "MaterialDetails",
                column: "MaterialIdMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDetails_ProducerIdProducer",
                table: "MaterialDetails",
                column: "ProducerIdProducer");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_PositionIdPosition",
                table: "staffs",
                column: "PositionIdPosition");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_WareHouseIdWarehouse",
                table: "staffs",
                column: "WareHouseIdWarehouse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "billDetails");

            migrationBuilder.DropTable(
                name: "MaterialDetails");

            migrationBuilder.DropTable(
                name: "bills");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "producers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "staffs");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropTable(
                name: "wareHouses");
        }
    }
}
