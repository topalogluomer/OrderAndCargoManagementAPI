using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderAndCargoManagement.DataAccess.Migrations
{
    public partial class initialCreateOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "arasCargos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderCanceledDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arasCargos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "yurticiCargos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderCanceledDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yurticiCargos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "arasCargos");

            migrationBuilder.DropTable(
                name: "yurticiCargos");
        }
    }
}
