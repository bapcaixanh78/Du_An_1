using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class CreateV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "wareHouses",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "staffs",
                newName: "BirthOfDate");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "staffs",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "producers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Customers",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "wareHouses",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "BirthOfDate",
                table: "staffs",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "staffs",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "producers",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Customers",
                newName: "Adress");
        }
    }
}
