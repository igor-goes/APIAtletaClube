using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atleta_Clube_ClubeId1",
                table: "Atleta");

            migrationBuilder.DropIndex(
                name: "IX_Atleta_ClubeId1",
                table: "Atleta");

            migrationBuilder.DropColumn(
                name: "ClubeId1",
                table: "Atleta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClubeId1",
                table: "Atleta",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Atleta_ClubeId1",
                table: "Atleta",
                column: "ClubeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Atleta_Clube_ClubeId1",
                table: "Atleta",
                column: "ClubeId1",
                principalTable: "Clube",
                principalColumn: "Id");
        }
    }
}
