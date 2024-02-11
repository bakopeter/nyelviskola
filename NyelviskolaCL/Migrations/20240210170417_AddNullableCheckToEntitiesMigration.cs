using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NyelviskolaCL.Migrations
{
    /// <inheritdoc />
    public partial class AddNullableCheckToEntitiesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TanitasiAlkalmak_Tanarok_TanarId",
                table: "TanitasiAlkalmak");

            migrationBuilder.DropForeignKey(
                name: "FK_TanitasiAlkalmak_Tanitvanyok_TanitvanyId",
                table: "TanitasiAlkalmak");

            migrationBuilder.AlterColumn<long>(
                name: "TanitvanyId",
                table: "TanitasiAlkalmak",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "TanarId",
                table: "TanitasiAlkalmak",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "OrakSzama",
                table: "TanitasiAlkalmak",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Kezdesido",
                table: "TanitasiAlkalmak",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Datum",
                table: "TanitasiAlkalmak",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetime");

            migrationBuilder.AddForeignKey(
                name: "FK_TanitasiAlkalmak_Tanarok_TanarId",
                table: "TanitasiAlkalmak",
                column: "TanarId",
                principalTable: "Tanarok",
                principalColumn: "TanarId");

            migrationBuilder.AddForeignKey(
                name: "FK_TanitasiAlkalmak_Tanitvanyok_TanitvanyId",
                table: "TanitasiAlkalmak",
                column: "TanitvanyId",
                principalTable: "Tanitvanyok",
                principalColumn: "TanitvanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TanitasiAlkalmak_Tanarok_TanarId",
                table: "TanitasiAlkalmak");

            migrationBuilder.DropForeignKey(
                name: "FK_TanitasiAlkalmak_Tanitvanyok_TanitvanyId",
                table: "TanitasiAlkalmak");

            migrationBuilder.AlterColumn<long>(
                name: "TanitvanyId",
                table: "TanitasiAlkalmak",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "TanarId",
                table: "TanitasiAlkalmak",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "OrakSzama",
                table: "TanitasiAlkalmak",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Kezdesido",
                table: "TanitasiAlkalmak",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Datum",
                table: "TanitasiAlkalmak",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TanitasiAlkalmak_Tanarok_TanarId",
                table: "TanitasiAlkalmak",
                column: "TanarId",
                principalTable: "Tanarok",
                principalColumn: "TanarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TanitasiAlkalmak_Tanitvanyok_TanitvanyId",
                table: "TanitasiAlkalmak",
                column: "TanitvanyId",
                principalTable: "Tanitvanyok",
                principalColumn: "TanitvanyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
