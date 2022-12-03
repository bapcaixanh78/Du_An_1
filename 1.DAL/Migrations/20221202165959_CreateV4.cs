using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class CreateV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bills_HistoryUsingPoints_HPointsidHPoints",
                table: "bills");

            migrationBuilder.DropForeignKey(
                name: "FK_PointsFund_HistoryUsingPoints_HPointsidHPoints",
                table: "PointsFund");

            migrationBuilder.DropForeignKey(
                name: "FK_PointWallet_HistoryUsingPoints_HPointsidHPoints",
                table: "PointWallet");

            migrationBuilder.DropIndex(
                name: "IX_PointWallet_HPointsidHPoints",
                table: "PointWallet");

            migrationBuilder.DropIndex(
                name: "IX_PointsFund_HPointsidHPoints",
                table: "PointsFund");

            migrationBuilder.DropIndex(
                name: "IX_bills_HPointsidHPoints",
                table: "bills");

            migrationBuilder.DropColumn(
                name: "HPointsidHPoints",
                table: "PointWallet");

            migrationBuilder.DropColumn(
                name: "idHPoints",
                table: "PointWallet");

            migrationBuilder.DropColumn(
                name: "HPointsidHPoints",
                table: "PointsFund");

            migrationBuilder.DropColumn(
                name: "idHPoints",
                table: "PointsFund");

            migrationBuilder.DropColumn(
                name: "HPointsidHPoints",
                table: "bills");

            migrationBuilder.DropColumn(
                name: "idHPoints",
                table: "bills");

            migrationBuilder.AddColumn<Guid>(
                name: "BillsIdBill",
                table: "HistoryUsingPoints",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdBill",
                table: "HistoryUsingPoints",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdPFund",
                table: "HistoryUsingPoints",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdPWallet",
                table: "HistoryUsingPoints",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PFundIdPFund",
                table: "HistoryUsingPoints",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PWalletIdPWallet",
                table: "HistoryUsingPoints",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistoryUsingPoints_BillsIdBill",
                table: "HistoryUsingPoints",
                column: "BillsIdBill");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryUsingPoints_PFundIdPFund",
                table: "HistoryUsingPoints",
                column: "PFundIdPFund");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryUsingPoints_PWalletIdPWallet",
                table: "HistoryUsingPoints",
                column: "PWalletIdPWallet");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryUsingPoints_bills_BillsIdBill",
                table: "HistoryUsingPoints",
                column: "BillsIdBill",
                principalTable: "bills",
                principalColumn: "IdBill",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryUsingPoints_PointsFund_PFundIdPFund",
                table: "HistoryUsingPoints",
                column: "PFundIdPFund",
                principalTable: "PointsFund",
                principalColumn: "IdPFund",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryUsingPoints_PointWallet_PWalletIdPWallet",
                table: "HistoryUsingPoints",
                column: "PWalletIdPWallet",
                principalTable: "PointWallet",
                principalColumn: "IdPWallet",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoryUsingPoints_bills_BillsIdBill",
                table: "HistoryUsingPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoryUsingPoints_PointsFund_PFundIdPFund",
                table: "HistoryUsingPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoryUsingPoints_PointWallet_PWalletIdPWallet",
                table: "HistoryUsingPoints");

            migrationBuilder.DropIndex(
                name: "IX_HistoryUsingPoints_BillsIdBill",
                table: "HistoryUsingPoints");

            migrationBuilder.DropIndex(
                name: "IX_HistoryUsingPoints_PFundIdPFund",
                table: "HistoryUsingPoints");

            migrationBuilder.DropIndex(
                name: "IX_HistoryUsingPoints_PWalletIdPWallet",
                table: "HistoryUsingPoints");

            migrationBuilder.DropColumn(
                name: "BillsIdBill",
                table: "HistoryUsingPoints");

            migrationBuilder.DropColumn(
                name: "IdBill",
                table: "HistoryUsingPoints");

            migrationBuilder.DropColumn(
                name: "IdPFund",
                table: "HistoryUsingPoints");

            migrationBuilder.DropColumn(
                name: "IdPWallet",
                table: "HistoryUsingPoints");

            migrationBuilder.DropColumn(
                name: "PFundIdPFund",
                table: "HistoryUsingPoints");

            migrationBuilder.DropColumn(
                name: "PWalletIdPWallet",
                table: "HistoryUsingPoints");

            migrationBuilder.AddColumn<Guid>(
                name: "HPointsidHPoints",
                table: "PointWallet",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "idHPoints",
                table: "PointWallet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "HPointsidHPoints",
                table: "PointsFund",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "idHPoints",
                table: "PointsFund",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "HPointsidHPoints",
                table: "bills",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "idHPoints",
                table: "bills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PointWallet_HPointsidHPoints",
                table: "PointWallet",
                column: "HPointsidHPoints");

            migrationBuilder.CreateIndex(
                name: "IX_PointsFund_HPointsidHPoints",
                table: "PointsFund",
                column: "HPointsidHPoints");

            migrationBuilder.CreateIndex(
                name: "IX_bills_HPointsidHPoints",
                table: "bills",
                column: "HPointsidHPoints");

            migrationBuilder.AddForeignKey(
                name: "FK_bills_HistoryUsingPoints_HPointsidHPoints",
                table: "bills",
                column: "HPointsidHPoints",
                principalTable: "HistoryUsingPoints",
                principalColumn: "idHPoints",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PointsFund_HistoryUsingPoints_HPointsidHPoints",
                table: "PointsFund",
                column: "HPointsidHPoints",
                principalTable: "HistoryUsingPoints",
                principalColumn: "idHPoints",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PointWallet_HistoryUsingPoints_HPointsidHPoints",
                table: "PointWallet",
                column: "HPointsidHPoints",
                principalTable: "HistoryUsingPoints",
                principalColumn: "idHPoints",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
