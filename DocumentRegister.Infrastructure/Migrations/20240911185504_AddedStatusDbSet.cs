using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentRegister.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedStatusDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "CreatedBy", "DateCreated", "DateModified", "Description", "ModifiedBy" },
                values: new object[] { 1, null, new DateTime(2024, 9, 11, 20, 55, 3, 889, DateTimeKind.Local).AddTicks(7699), new DateTime(2024, 9, 11, 20, 55, 3, 889, DateTimeKind.Local).AddTicks(7701), "TestValue", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
