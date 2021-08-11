using Microsoft.EntityFrameworkCore.Migrations;

namespace Chicago.Dal.Migrations
{
    public partial class UniqueCaptureDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Networth_CapturedDate",
                schema: "dbo",
                table: "Networth",
                column: "CapturedDate",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Networth_CapturedDate",
                schema: "dbo",
                table: "Networth");
        }
    }
}
