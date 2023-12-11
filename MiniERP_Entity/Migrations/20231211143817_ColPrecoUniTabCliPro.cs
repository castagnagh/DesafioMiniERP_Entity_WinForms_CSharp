using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniERP_Entity.Migrations
{
    public partial class ColPrecoUniTabCliPro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecoUnitario",
                table: "ClientesProdutos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoUnitario",
                table: "ClientesProdutos");
        }
    }
}
