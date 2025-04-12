using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgramacaoIV.Venda.Api.Migrations
{
    /// <inheritdoc />
    public partial class migration_1_1_0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "VendedorId",
                table: "TRANSACAO",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "VENDEDOR",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false),
                    NM_VENDEDOR = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    IN_ATIVO = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DT_CRIACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DT_ATUALIZACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENDEDOR", x => x.ID);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TRANSACAO_VendedorId",
                table: "TRANSACAO",
                column: "VendedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TRANSACAO_VENDEDOR_VendedorId",
                table: "TRANSACAO",
                column: "VendedorId",
                principalTable: "VENDEDOR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRANSACAO_VENDEDOR_VendedorId",
                table: "TRANSACAO");

            migrationBuilder.DropTable(
                name: "VENDEDOR");

            migrationBuilder.DropIndex(
                name: "IX_TRANSACAO_VendedorId",
                table: "TRANSACAO");

            migrationBuilder.DropColumn(
                name: "VendedorId",
                table: "TRANSACAO");
        }
    }
}
