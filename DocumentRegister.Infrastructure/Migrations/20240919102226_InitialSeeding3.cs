using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DocumentRegister.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeeding3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 234, DateTimeKind.Local).AddTicks(8293), new DateTime(2024, 9, 19, 12, 22, 26, 234, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 234, DateTimeKind.Local).AddTicks(8306), new DateTime(2024, 9, 19, 12, 22, 26, 234, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 234, DateTimeKind.Local).AddTicks(8308), new DateTime(2024, 9, 19, 12, 22, 26, 234, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.InsertData(
                table: "DeptDocNumStructs",
                columns: new[] { "DeptDocNumStructId", "CreatedBy", "DateCreated", "DateModified", "Description", "ModifiedBy", "Seperator" },
                values: new object[] { 1, null, new DateTime(2024, 9, 19, 12, 22, 26, 236, DateTimeKind.Local).AddTicks(1149), new DateTime(2024, 9, 19, 12, 22, 26, 236, DateTimeKind.Local).AddTicks(1168), "Electronic Department", null, "-----" });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 244, DateTimeKind.Local).AddTicks(4625), new DateTime(2024, 9, 19, 12, 22, 26, 244, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 244, DateTimeKind.Local).AddTicks(4639), new DateTime(2024, 9, 19, 12, 22, 26, 244, DateTimeKind.Local).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 244, DateTimeKind.Local).AddTicks(4641), new DateTime(2024, 9, 19, 12, 22, 26, 244, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 244, DateTimeKind.Local).AddTicks(4643), new DateTime(2024, 9, 19, 12, 22, 26, 244, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(2707), new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(2720), new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(2722), new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(5084), new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(5090), new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(5092), new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(5094), new DateTime(2024, 9, 19, 12, 22, 26, 246, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 250, DateTimeKind.Local).AddTicks(6150), new DateTime(2024, 9, 19, 12, 22, 26, 250, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 250, DateTimeKind.Local).AddTicks(6160), new DateTime(2024, 9, 19, 12, 22, 26, 250, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 250, DateTimeKind.Local).AddTicks(6162), new DateTime(2024, 9, 19, 12, 22, 26, 250, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 250, DateTimeKind.Local).AddTicks(6164), new DateTime(2024, 9, 19, 12, 22, 26, 250, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.InsertData(
                table: "DeptDocNumStructSegmentCategory",
                columns: new[] { "DeptDocNumStructsDeptDocNumStructId", "SegmentCategoriesSegmentCategoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeptDocNumStructSegmentCategory",
                keyColumns: new[] { "DeptDocNumStructsDeptDocNumStructId", "SegmentCategoriesSegmentCategoryId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DeptDocNumStructSegmentCategory",
                keyColumns: new[] { "DeptDocNumStructsDeptDocNumStructId", "SegmentCategoriesSegmentCategoryId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "DeptDocNumStructSegmentCategory",
                keyColumns: new[] { "DeptDocNumStructsDeptDocNumStructId", "SegmentCategoriesSegmentCategoryId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "DeptDocNumStructSegmentCategory",
                keyColumns: new[] { "DeptDocNumStructsDeptDocNumStructId", "SegmentCategoriesSegmentCategoryId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "DeptDocNumStructs",
                keyColumn: "DeptDocNumStructId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 928, DateTimeKind.Local).AddTicks(2193), new DateTime(2024, 9, 19, 12, 15, 27, 928, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 928, DateTimeKind.Local).AddTicks(2205), new DateTime(2024, 9, 19, 12, 15, 27, 928, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 928, DateTimeKind.Local).AddTicks(2206), new DateTime(2024, 9, 19, 12, 15, 27, 928, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 933, DateTimeKind.Local).AddTicks(2336), new DateTime(2024, 9, 19, 12, 15, 27, 933, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 933, DateTimeKind.Local).AddTicks(2346), new DateTime(2024, 9, 19, 12, 15, 27, 933, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 933, DateTimeKind.Local).AddTicks(2348), new DateTime(2024, 9, 19, 12, 15, 27, 933, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 933, DateTimeKind.Local).AddTicks(2351), new DateTime(2024, 9, 19, 12, 15, 27, 933, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 934, DateTimeKind.Local).AddTicks(8432), new DateTime(2024, 9, 19, 12, 15, 27, 934, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 934, DateTimeKind.Local).AddTicks(8442), new DateTime(2024, 9, 19, 12, 15, 27, 934, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 934, DateTimeKind.Local).AddTicks(8443), new DateTime(2024, 9, 19, 12, 15, 27, 934, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 938, DateTimeKind.Local).AddTicks(1445), new DateTime(2024, 9, 19, 12, 15, 27, 938, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 938, DateTimeKind.Local).AddTicks(1456), new DateTime(2024, 9, 19, 12, 15, 27, 938, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 938, DateTimeKind.Local).AddTicks(1458), new DateTime(2024, 9, 19, 12, 15, 27, 938, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 938, DateTimeKind.Local).AddTicks(1460), new DateTime(2024, 9, 19, 12, 15, 27, 938, DateTimeKind.Local).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 941, DateTimeKind.Local).AddTicks(8228), new DateTime(2024, 9, 19, 12, 15, 27, 941, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 941, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 9, 19, 12, 15, 27, 941, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 941, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 9, 19, 12, 15, 27, 941, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 15, 27, 941, DateTimeKind.Local).AddTicks(8242), new DateTime(2024, 9, 19, 12, 15, 27, 941, DateTimeKind.Local).AddTicks(8243) });
        }
    }
}
