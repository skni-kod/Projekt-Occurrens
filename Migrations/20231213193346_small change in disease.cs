using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace occurrensBackend.Migrations
{
    /// <inheritdoc />
    public partial class smallchangeindisease : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_disease",
                table: "Diseases");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByDoctor",
                table: "Diseases",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByDoctor",
                table: "Diseases");

            migrationBuilder.AddColumn<int>(
                name: "Id_disease",
                table: "Diseases",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
