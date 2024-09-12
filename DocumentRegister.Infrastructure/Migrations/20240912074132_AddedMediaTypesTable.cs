using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentRegister.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedMediaTypesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MediaTypes",
                columns: table => new
                {
                    MediaTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaTypes", x => x.MediaTypeId);
                });

            migrationBuilder.InsertData(
                table: "MediaTypes",
                columns: new[] { "MediaTypeId", "CreatedBy", "DateCreated", "DateModified", "Description", "ModifiedBy" },
                values: new object[] { 1, null, new DateTime(2024, 9, 12, 9, 41, 30, 538, DateTimeKind.Local).AddTicks(8448), new DateTime(2024, 9, 12, 9, 41, 30, 538, DateTimeKind.Local).AddTicks(8451), "TestValue", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaTypes");

        }
    }
}
