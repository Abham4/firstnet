using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace firstnet.Migrations
{
    /// <inheritdoc />
    public partial class one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Studs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Studs_MemberId",
                table: "Studs",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Studs_Members_MemberId",
                table: "Studs",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studs_Members_MemberId",
                table: "Studs");

            migrationBuilder.DropIndex(
                name: "IX_Studs_MemberId",
                table: "Studs");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Studs");
        }
    }
}
