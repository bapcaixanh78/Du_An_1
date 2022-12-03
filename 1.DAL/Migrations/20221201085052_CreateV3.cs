using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class CreateV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bills_HPoints_HPointsidHPoints",
                table: "bills");

            migrationBuilder.DropForeignKey(
                name: "FK_pointsFunds_HPoints_HPointsidHPoints",
                table: "pointsFunds");

            migrationBuilder.DropForeignKey(
                name: "FK_pointWallets_Customers_CustomerIdCustomer",
                table: "pointWallets");

            migrationBuilder.DropForeignKey(
                name: "FK_pointWallets_HPoints_HPointsidHPoints",
                table: "pointWallets");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pointWallets",
                table: "pointWallets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pointsFunds",
                table: "pointsFunds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HPoints",
                table: "HPoints");

            migrationBuilder.RenameTable(
                name: "pointWallets",
                newName: "PointWallet");

            migrationBuilder.RenameTable(
                name: "pointsFunds",
                newName: "PointsFund");

            migrationBuilder.RenameTable(
                name: "HPoints",
                newName: "HistoryUsingPoints");

            migrationBuilder.RenameIndex(
                name: "IX_pointWallets_HPointsidHPoints",
                table: "PointWallet",
                newName: "IX_PointWallet_HPointsidHPoints");

            migrationBuilder.RenameIndex(
                name: "IX_pointWallets_CustomerIdCustomer",
                table: "PointWallet",
                newName: "IX_PointWallet_CustomerIdCustomer");

            migrationBuilder.RenameIndex(
                name: "IX_pointsFunds_HPointsidHPoints",
                table: "PointsFund",
                newName: "IX_PointsFund_HPointsidHPoints");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointWallet",
                table: "PointWallet",
                column: "IdPWallet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointsFund",
                table: "PointsFund",
                column: "IdPFund");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoryUsingPoints",
                table: "HistoryUsingPoints",
                column: "idHPoints");

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
                name: "FK_PointWallet_Customers_CustomerIdCustomer",
                table: "PointWallet",
                column: "CustomerIdCustomer",
                principalTable: "Customers",
                principalColumn: "IdCustomer",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PointWallet_HistoryUsingPoints_HPointsidHPoints",
                table: "PointWallet",
                column: "HPointsidHPoints",
                principalTable: "HistoryUsingPoints",
                principalColumn: "idHPoints",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bills_HistoryUsingPoints_HPointsidHPoints",
                table: "bills");

            migrationBuilder.DropForeignKey(
                name: "FK_PointsFund_HistoryUsingPoints_HPointsidHPoints",
                table: "PointsFund");

            migrationBuilder.DropForeignKey(
                name: "FK_PointWallet_Customers_CustomerIdCustomer",
                table: "PointWallet");

            migrationBuilder.DropForeignKey(
                name: "FK_PointWallet_HistoryUsingPoints_HPointsidHPoints",
                table: "PointWallet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointWallet",
                table: "PointWallet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointsFund",
                table: "PointsFund");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoryUsingPoints",
                table: "HistoryUsingPoints");

            migrationBuilder.RenameTable(
                name: "PointWallet",
                newName: "pointWallets");

            migrationBuilder.RenameTable(
                name: "PointsFund",
                newName: "pointsFunds");

            migrationBuilder.RenameTable(
                name: "HistoryUsingPoints",
                newName: "HPoints");

            migrationBuilder.RenameIndex(
                name: "IX_PointWallet_HPointsidHPoints",
                table: "pointWallets",
                newName: "IX_pointWallets_HPointsidHPoints");

            migrationBuilder.RenameIndex(
                name: "IX_PointWallet_CustomerIdCustomer",
                table: "pointWallets",
                newName: "IX_pointWallets_CustomerIdCustomer");

            migrationBuilder.RenameIndex(
                name: "IX_PointsFund_HPointsidHPoints",
                table: "pointsFunds",
                newName: "IX_pointsFunds_HPointsidHPoints");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pointWallets",
                table: "pointWallets",
                column: "IdPWallet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pointsFunds",
                table: "pointsFunds",
                column: "IdPFund");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HPoints",
                table: "HPoints",
                column: "idHPoints");

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_bills_HPoints_HPointsidHPoints",
                table: "bills",
                column: "HPointsidHPoints",
                principalTable: "HPoints",
                principalColumn: "idHPoints",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_pointsFunds_HPoints_HPointsidHPoints",
                table: "pointsFunds",
                column: "HPointsidHPoints",
                principalTable: "HPoints",
                principalColumn: "idHPoints",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_pointWallets_Customers_CustomerIdCustomer",
                table: "pointWallets",
                column: "CustomerIdCustomer",
                principalTable: "Customers",
                principalColumn: "IdCustomer",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_pointWallets_HPoints_HPointsidHPoints",
                table: "pointWallets",
                column: "HPointsidHPoints",
                principalTable: "HPoints",
                principalColumn: "idHPoints",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
