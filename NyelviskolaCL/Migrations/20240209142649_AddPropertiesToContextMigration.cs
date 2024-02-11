using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NyelviskolaCL.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertiesToContextMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<sbyte>(
                name: "Net",
                table: "Tanarok",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Net",
                table: "Tanarok",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(sbyte),
                oldType: "tinyint");
        }
    }
}
