using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace NyelviskolaCL.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Nyelvek",
                columns: table => new
                {
                    NyelvId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nyelvnev = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nyelvek", x => x.NyelvId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tanitvanyok",
                columns: table => new
                {
                    TanitvanyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nev = table.Column<string>(type: "longtext", nullable: false),
                    Telefon = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanitvanyok", x => x.TanitvanyId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tanarok",
                columns: table => new
                {
                    TanarId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nev = table.Column<string>(type: "longtext", nullable: false),
                    NyelvId = table.Column<long>(type: "bigint", nullable: false),
                    Oradij = table.Column<long>(type: "bigint", nullable: false),
                    Telefon = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Net = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanarok", x => x.TanarId);
                    table.ForeignKey(
                        name: "FK_Tanarok_Nyelvek_NyelvId",
                        column: x => x.NyelvId,
                        principalTable: "Nyelvek",
                        principalColumn: "NyelvId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TanitasiAlkalmak",
                columns: table => new
                {
                    AlkalomId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TanarId = table.Column<long>(type: "bigint", nullable: false),
                    TanitvanyId = table.Column<long>(type: "bigint", nullable: false),
                    Datum = table.Column<DateTimeOffset>(type: "datetime", nullable: false),
                    Kezdesido = table.Column<DateTimeOffset>(type: "datetime", nullable: false),
                    OrakSzama = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TanitasiAlkalmak", x => x.AlkalomId);
                    table.ForeignKey(
                        name: "FK_TanitasiAlkalmak_Tanarok_TanarId",
                        column: x => x.TanarId,
                        principalTable: "Tanarok",
                        principalColumn: "TanarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TanitasiAlkalmak_Tanitvanyok_TanitvanyId",
                        column: x => x.TanitvanyId,
                        principalTable: "Tanitvanyok",
                        principalColumn: "TanitvanyId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Tanarok_NyelvId",
                table: "Tanarok",
                column: "NyelvId");

            migrationBuilder.CreateIndex(
                name: "IX_TanitasiAlkalmak_TanarId",
                table: "TanitasiAlkalmak",
                column: "TanarId");

            migrationBuilder.CreateIndex(
                name: "IX_TanitasiAlkalmak_TanitvanyId",
                table: "TanitasiAlkalmak",
                column: "TanitvanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TanitasiAlkalmak");

            migrationBuilder.DropTable(
                name: "Tanarok");

            migrationBuilder.DropTable(
                name: "Tanitvanyok");

            migrationBuilder.DropTable(
                name: "Nyelvek");
        }
    }
}
