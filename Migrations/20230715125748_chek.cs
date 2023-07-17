using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace firstnet.Migrations
{
    /// <inheritdoc />
    public partial class chek : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckOrganizaion_Checks_CheckId",
                table: "CheckOrganizaion");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckOrganizaion_Organizations_OrganizationId",
                table: "CheckOrganizaion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckOrganizaion",
                table: "CheckOrganizaion");

            migrationBuilder.RenameTable(
                name: "CheckOrganizaion",
                newName: "CheckOrganizaions");

            migrationBuilder.RenameIndex(
                name: "IX_CheckOrganizaion_OrganizationId",
                table: "CheckOrganizaions",
                newName: "IX_CheckOrganizaions_OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckOrganizaion_CheckId",
                table: "CheckOrganizaions",
                newName: "IX_CheckOrganizaions_CheckId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckOrganizaions",
                table: "CheckOrganizaions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckOrganizaions_Checks_CheckId",
                table: "CheckOrganizaions",
                column: "CheckId",
                principalTable: "Checks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckOrganizaions_Organizations_OrganizationId",
                table: "CheckOrganizaions",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckOrganizaions_Checks_CheckId",
                table: "CheckOrganizaions");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckOrganizaions_Organizations_OrganizationId",
                table: "CheckOrganizaions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckOrganizaions",
                table: "CheckOrganizaions");

            migrationBuilder.RenameTable(
                name: "CheckOrganizaions",
                newName: "CheckOrganizaion");

            migrationBuilder.RenameIndex(
                name: "IX_CheckOrganizaions_OrganizationId",
                table: "CheckOrganizaion",
                newName: "IX_CheckOrganizaion_OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckOrganizaions_CheckId",
                table: "CheckOrganizaion",
                newName: "IX_CheckOrganizaion_CheckId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckOrganizaion",
                table: "CheckOrganizaion",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckOrganizaion_Checks_CheckId",
                table: "CheckOrganizaion",
                column: "CheckId",
                principalTable: "Checks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckOrganizaion_Organizations_OrganizationId",
                table: "CheckOrganizaion",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
