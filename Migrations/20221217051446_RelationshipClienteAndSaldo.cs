using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zanfranceschichallenge.Migrations
{
    /// <inheritdoc />
    public partial class RelationshipClienteAndSaldo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Saldos",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Saldos_ClienteId",
                table: "Saldos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Saldos_Clientes_ClienteId",
                table: "Saldos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Saldos_Clientes_ClienteId",
                table: "Saldos");

            migrationBuilder.DropIndex(
                name: "IX_Saldos_ClienteId",
                table: "Saldos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Saldos");
        }
    }
}
