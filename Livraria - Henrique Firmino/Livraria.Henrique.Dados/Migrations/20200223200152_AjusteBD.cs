using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Henrique.Dados.Migrations
{
    public partial class AjusteBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    Genero = table.Column<string>(nullable: true),
                    DataPublicacao = table.Column<DateTime>(nullable: false),
                    Pagina = table.Column<int>(nullable: false),
                    Autor = table.Column<string>(nullable: true),
                    Editora = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Sinopse = table.Column<string>(nullable: true),
                    Capa = table.Column<string>(nullable: true),
                    Links = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
