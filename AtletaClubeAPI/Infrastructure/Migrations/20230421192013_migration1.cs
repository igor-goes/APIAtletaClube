using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clube",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    Sigla = table.Column<string>(type: "varchar(5)", nullable: false),
                    Estadio = table.Column<string>(type: "varchar(50)", nullable: false),
                    Treinador = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clube", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Atleta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Nacionalidade = table.Column<string>(type: "varchar(30)", nullable: false),
                    Idade = table.Column<string>(type: "varchar(2)", nullable: false),
                    Posicao = table.Column<string>(type: "varchar(30)", nullable: false),
                    ClubeId = table.Column<int>(type: "int", nullable: true),
                    ClubeId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atleta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atleta_Clube_ClubeId",
                        column: x => x.ClubeId,
                        principalTable: "Clube",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Atleta_Clube_ClubeId1",
                        column: x => x.ClubeId1,
                        principalTable: "Clube",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atleta_ClubeId",
                table: "Atleta",
                column: "ClubeId");

            migrationBuilder.CreateIndex(
                name: "IX_Atleta_ClubeId1",
                table: "Atleta",
                column: "ClubeId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atleta");

            migrationBuilder.DropTable(
                name: "Clube");
        }
    }
}
