using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class CreateTri2611 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdPosition",
                table: "staffs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdWarehouse",
                table: "staffs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdMaterial",
                table: "MaterialDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdProducer",
                table: "MaterialDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdBill",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "HPointsidHPoints",
                table: "bills",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdCustomer",
                table: "bills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdStaff",
                table: "bills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "PointsUsed",
                table: "bills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "idHPoints",
                table: "bills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HPoints",
                columns: table => new
                {
                    idHPoints = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PointsUsed = table.Column<int>(type: "int", nullable: false),
                    DateUse = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlusPoints = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HPoints", x => x.idHPoints);
                });

            migrationBuilder.CreateTable(
                name: "pointsFunds",
                columns: table => new
                {
                    IdPFund = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PointsMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PointsUsed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    HPointsidHPoints = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pointsFunds", x => x.IdPFund);
                    table.ForeignKey(
                        name: "FK_pointsFunds_HPoints_HPointsidHPoints",
                        column: x => x.HPointsidHPoints,
                        principalTable: "HPoints",
                        principalColumn: "idHPoints",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pointWallets",
                columns: table => new
                {
                    IdPWallet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalScore = table.Column<int>(type: "int", nullable: false),
                    PointsUsed = table.Column<int>(type: "int", nullable: false),
                    PointsAdded = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CustomerIdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HPointsidHPoints = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pointWallets", x => x.IdPWallet);
                    table.ForeignKey(
                        name: "FK_pointWallets_Customers_CustomerIdCustomer",
                        column: x => x.CustomerIdCustomer,
                        principalTable: "Customers",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pointWallets_HPoints_HPointsidHPoints",
                        column: x => x.HPointsidHPoints,
                        principalTable: "HPoints",
                        principalColumn: "idHPoints",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bills_HPointsidHPoints",
                table: "bills",
                column: "HPointsidHPoints");

            migrationBuilder.CreateIndex(
                name: "IX_pointsFunds_HPointsidHPoints",
                table: "pointsFunds",
                column: "HPointsidHPoints");

            migrationBuilder.CreateIndex(
                name: "IX_pointWallets_CustomerIdCustomer",
                table: "pointWallets",
                column: "CustomerIdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_pointWallets_HPointsidHPoints",
                table: "pointWallets",
                column: "HPointsidHPoints");

            migrationBuilder.AddForeignKey(
                name: "FK_bills_HPoints_HPointsidHPoints",
                table: "bills",
                column: "HPointsidHPoints",
                principalTable: "HPoints",
                principalColumn: "idHPoints",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bills_HPoints_HPointsidHPoints",
                table: "bills");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "pointsFunds");

            migrationBuilder.DropTable(
                name: "pointWallets");

            migrationBuilder.DropTable(
                name: "HPoints");

            migrationBuilder.DropIndex(
                name: "IX_bills_HPointsidHPoints",
                table: "bills");

            migrationBuilder.DropColumn(
                name: "IdPosition",
                table: "staffs");

            migrationBuilder.DropColumn(
                name: "IdWarehouse",
                table: "staffs");

            migrationBuilder.DropColumn(
                name: "IdMaterial",
                table: "MaterialDetails");

            migrationBuilder.DropColumn(
                name: "IdProducer",
                table: "MaterialDetails");

            migrationBuilder.DropColumn(
                name: "IdBill",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "HPointsidHPoints",
                table: "bills");

            migrationBuilder.DropColumn(
                name: "IdCustomer",
                table: "bills");

            migrationBuilder.DropColumn(
                name: "IdStaff",
                table: "bills");

            migrationBuilder.DropColumn(
                name: "PointsUsed",
                table: "bills");

            migrationBuilder.DropColumn(
                name: "idHPoints",
                table: "bills");
        }
    }
}
