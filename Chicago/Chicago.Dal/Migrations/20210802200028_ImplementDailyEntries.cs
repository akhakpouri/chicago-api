using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chicago.Dal.Migrations
{
    public partial class ImplementDailyEntries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Networth",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapturedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Networth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NetworthItems",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    NetworthId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetworthItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NetworthItems_Item_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "dbo",
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NetworthItems_Networth_NetworthId",
                        column: x => x.NetworthId,
                        principalSchema: "dbo",
                        principalTable: "Networth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NetworthItems_ItemId",
                schema: "dbo",
                table: "NetworthItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_NetworthItems_NetworthId",
                schema: "dbo",
                table: "NetworthItems",
                column: "NetworthId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NetworthItems",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Networth",
                schema: "dbo");
        }
    }
}
