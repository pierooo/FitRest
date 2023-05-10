using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitRestAPI.Migrations
{
    public partial class idday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sleep_Day_IdDay",
                table: "Sleep");

            migrationBuilder.AlterColumn<int>(
                name: "IdDay",
                table: "Sleep",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sleep_Day_IdDay",
                table: "Sleep",
                column: "IdDay",
                principalTable: "Day",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sleep_Day_IdDay",
                table: "Sleep");

            migrationBuilder.AlterColumn<int>(
                name: "IdDay",
                table: "Sleep",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Sleep_Day_IdDay",
                table: "Sleep",
                column: "IdDay",
                principalTable: "Day",
                principalColumn: "Id");
        }
    }
}
