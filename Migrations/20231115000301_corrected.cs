using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace occurrensBackend.Migrations
{
    /// <inheritdoc />
    public partial class corrected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Is_opened_Is_openedId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Is_opened_Addresses_AddressId",
                table: "Is_opened");

            migrationBuilder.DropIndex(
                name: "IX_Is_opened_AddressId",
                table: "Is_opened");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_Is_openedId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Id_doctor",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "Id_patient",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "Id_doctor",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Is_openedId",
                table: "Addresses");

            migrationBuilder.AlterColumn<Guid>(
                name: "AddressId",
                table: "Is_opened",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId1",
                table: "Is_opened",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Is_opened_AddressId",
                table: "Is_opened",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Is_opened_AddressId1",
                table: "Is_opened",
                column: "AddressId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Is_opened_Addresses_AddressId",
                table: "Is_opened",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Is_opened_Addresses_AddressId1",
                table: "Is_opened",
                column: "AddressId1",
                principalTable: "Addresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Is_opened_Addresses_AddressId",
                table: "Is_opened");

            migrationBuilder.DropForeignKey(
                name: "FK_Is_opened_Addresses_AddressId1",
                table: "Is_opened");

            migrationBuilder.DropIndex(
                name: "IX_Is_opened_AddressId",
                table: "Is_opened");

            migrationBuilder.DropIndex(
                name: "IX_Is_opened_AddressId1",
                table: "Is_opened");

            migrationBuilder.DropColumn(
                name: "AddressId1",
                table: "Is_opened");

            migrationBuilder.AddColumn<int>(
                name: "Id_doctor",
                table: "Visits",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_patient",
                table: "Visits",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "AddressId",
                table: "Is_opened",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<int>(
                name: "Id_doctor",
                table: "Addresses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "Is_openedId",
                table: "Addresses",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Is_opened_AddressId",
                table: "Is_opened",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_Is_openedId",
                table: "Addresses",
                column: "Is_openedId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Is_opened_Is_openedId",
                table: "Addresses",
                column: "Is_openedId",
                principalTable: "Is_opened",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Is_opened_Addresses_AddressId",
                table: "Is_opened",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }
    }
}
