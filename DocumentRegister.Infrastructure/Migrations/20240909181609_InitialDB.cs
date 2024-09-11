using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentRegister.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataTypes",
                columns: table => new
                {
                    DataTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataTypes", x => x.DataTypeId);
                });

            migrationBuilder.InsertData(
                table: "DataTypes",
                columns: new[] { "DataTypeId", "CreatedBy", "DateCreated", "DateModified", "ModifiedBy", "Name" },
                values: new object[] { 1, null, new DateTime(2024, 9, 9, 20, 16, 8, 617, DateTimeKind.Local).AddTicks(1500), new DateTime(2024, 9, 9, 20, 16, 8, 617, DateTimeKind.Local).AddTicks(1532), null, "TestValue" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataTypes");
        }
    }
}
