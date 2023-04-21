using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atleta_Clube_ClubeId",
                table: "Atleta");

            migrationBuilder.DropIndex(
                name: "IX_Atleta_ClubeId",
                table: "Atleta");

            migrationBuilder.AlterColumn<int>(
                name: "ClubeId",
                table: "Atleta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ClubeId",
                table: "Atleta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Atleta_ClubeId",
                table: "Atleta",
                column: "ClubeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atleta_Clube_ClubeId",
                table: "Atleta",
                column: "ClubeId",
                principalTable: "Clube",
                principalColumn: "Id");
        }
    }
}
