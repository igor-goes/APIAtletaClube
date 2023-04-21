using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Idade",
                table: "Atleta",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Idade",
                table: "Atleta",
                type: "varchar(2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
