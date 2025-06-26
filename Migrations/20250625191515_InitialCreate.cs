using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LockAi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_REQUERIMENTOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Momento = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    TipoRequerimento = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    IdLocacao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Observacao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Situacao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    DataAtualizacao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    IdUsuarioAtualizacao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_REQUERIMENTOS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_REQUERIMENTOS",
                columns: new[] { "Id", "DataAtualizacao", "IdLocacao", "IdUsuarioAtualizacao", "Momento", "Observacao", "Situacao", "TipoRequerimento" },
                values: new object[,]
                {
                    { 1, "01/06/2025", "001", "007", "Na locação de um objeto", "Preciso da chave para meu armario.", "Em analise", "Requerimento sem custo" },
                    { 2, "02/06/2025", "002", "006", " Utilizando um objeto", "Perdi as chaves do meu armario", "Concluido", "Requerimento com custo" },
                    { 3, "03/06/2025", "003", "005", " Utilizando um objeto", "o armario tem um objeto do antigo usuario", "Concluido", "Requerimento sem custo" },
                    { 4, "04/06/2025", "004", "004", " Utilizando um objeto", "quero canselar o plano e receber o restante do meu dinheiro", "Negado", "Requerimento com custo" },
                    { 5, "05/06/2025", "005", "003", " Utilizando um objeto", "Perdi as chaves do meu armario ", "Respondido", "Requerimento com custo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_REQUERIMENTOS");
        }
    }
}
