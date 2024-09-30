using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentRegister.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2785), new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2798), new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2800), new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1659), new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1671), new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1673), new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1676), new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1340), new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1351), new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1353), new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9135), new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9140), new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(634), new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(645), new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(646), new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(647) });
        }
    }
}
