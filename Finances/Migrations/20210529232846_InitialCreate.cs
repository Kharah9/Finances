using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finances.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposConta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposConta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposMovimentacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposMovimentacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contas_TiposConta_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TiposConta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ativos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rendimento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Recorrente = table.Column<bool>(type: "bit", nullable: false),
                    ContaId = table.Column<int>(type: "int", nullable: true),
                    MovimentacaoId = table.Column<int>(type: "int", nullable: true),
                    DataMovimentacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ativos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ativos_TiposConta_ContaId",
                        column: x => x.ContaId,
                        principalTable: "TiposConta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ativos_TiposMovimentacao_MovimentacaoId",
                        column: x => x.MovimentacaoId,
                        principalTable: "TiposMovimentacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Recorrente = table.Column<bool>(type: "bit", nullable: false),
                    ContaId = table.Column<int>(type: "int", nullable: true),
                    MovimentacaoId = table.Column<int>(type: "int", nullable: true),
                    DataMovimentacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entradas_TiposConta_ContaId",
                        column: x => x.ContaId,
                        principalTable: "TiposConta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entradas_TiposMovimentacao_MovimentacaoId",
                        column: x => x.MovimentacaoId,
                        principalTable: "TiposMovimentacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Saidas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Recorrente = table.Column<bool>(type: "bit", nullable: false),
                    ContaId = table.Column<int>(type: "int", nullable: true),
                    MovimentacaoId = table.Column<int>(type: "int", nullable: true),
                    DataMovimentacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saidas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Saidas_TiposConta_ContaId",
                        column: x => x.ContaId,
                        principalTable: "TiposConta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Saidas_TiposMovimentacao_MovimentacaoId",
                        column: x => x.MovimentacaoId,
                        principalTable: "TiposMovimentacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ativos_ContaId",
                table: "Ativos",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ativos_MovimentacaoId",
                table: "Ativos",
                column: "MovimentacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contas_TipoId",
                table: "Contas",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_ContaId",
                table: "Entradas",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_MovimentacaoId",
                table: "Entradas",
                column: "MovimentacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Saidas_ContaId",
                table: "Saidas",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_Saidas_MovimentacaoId",
                table: "Saidas",
                column: "MovimentacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ativos");

            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "Entradas");

            migrationBuilder.DropTable(
                name: "Saidas");

            migrationBuilder.DropTable(
                name: "TiposConta");

            migrationBuilder.DropTable(
                name: "TiposMovimentacao");
        }
    }
}
