using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KingPandaMedia.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Portfolios_PortfolioImageID",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_PortfolioImageID",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioImageID",
                table: "Portfolios");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "KPMUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "KPMUsers",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "KPMUsers",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SignUpDate",
                table: "KPMUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "KPMUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "KPMUsers");

            migrationBuilder.DropColumn(
                name: "SignUpDate",
                table: "KPMUsers");

            migrationBuilder.AddColumn<int>(
                name: "PortfolioImageID",
                table: "Portfolios",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "KPMUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_PortfolioImageID",
                table: "Portfolios",
                column: "PortfolioImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Portfolios_PortfolioImageID",
                table: "Portfolios",
                column: "PortfolioImageID",
                principalTable: "Portfolios",
                principalColumn: "ImageID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
