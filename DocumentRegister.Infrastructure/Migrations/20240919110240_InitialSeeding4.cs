using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DocumentRegister.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeeding4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 110, DateTimeKind.Local).AddTicks(2838), new DateTime(2024, 9, 19, 13, 2, 40, 110, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 110, DateTimeKind.Local).AddTicks(2855), new DateTime(2024, 9, 19, 13, 2, 40, 110, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 110, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 9, 19, 13, 2, 40, 110, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "DeptDocNumStructs",
                keyColumn: "DeptDocNumStructId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 111, DateTimeKind.Local).AddTicks(5362), new DateTime(2024, 9, 19, 13, 2, 40, 111, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 120, DateTimeKind.Local).AddTicks(1798), new DateTime(2024, 9, 19, 13, 2, 40, 120, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 120, DateTimeKind.Local).AddTicks(1810), new DateTime(2024, 9, 19, 13, 2, 40, 120, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 120, DateTimeKind.Local).AddTicks(1812), new DateTime(2024, 9, 19, 13, 2, 40, 120, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 120, DateTimeKind.Local).AddTicks(1814), new DateTime(2024, 9, 19, 13, 2, 40, 120, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(202), new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(214), new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(2039), new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(2044), new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(2047), new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(2049), new DateTime(2024, 9, 19, 13, 2, 40, 122, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.InsertData(
                table: "SegmentDatum",
                columns: new[] { "SegmentDataId", "CreatedBy", "DateCreated", "DateModified", "Description", "ModifiedBy", "SegmentCategoryId", "Value" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4873), new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4883), "Oxygen sensor retrofitting", null, 1, "A554" },
                    { 2, null, new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4884), new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4885), "Calibration of systems", null, 1, "B336" },
                    { 3, null, new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4886), new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4887), "Testing of new systems", null, 1, "C123" },
                    { 4, null, new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4888), new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4889), "Testing of new systems", null, 1, "D789" },
                    { 5, null, new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4890), new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4891), "Electronic schematic", null, 2, "ELEC" },
                    { 6, null, new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4892), new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4892), "Mechanical schematic", null, 2, "MECH" },
                    { 7, null, new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4894), new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4894), "Financial documents", null, 2, "FIN" },
                    { 8, null, new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4896), new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4896), "Anglo Gold Ashanti", null, 3, "ANG" },
                    { 9, null, new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4898), new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4898), "Sibanye", null, 3, "SIB" },
                    { 10, null, new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4899), new DateTime(2024, 9, 19, 13, 2, 40, 124, DateTimeKind.Local).AddTicks(4900), "Harmony Gold", null, 3, "HAR" }
                });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 126, DateTimeKind.Local).AddTicks(4258), new DateTime(2024, 9, 19, 13, 2, 40, 126, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 126, DateTimeKind.Local).AddTicks(4269), new DateTime(2024, 9, 19, 13, 2, 40, 126, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 126, DateTimeKind.Local).AddTicks(4270), new DateTime(2024, 9, 19, 13, 2, 40, 126, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 2, 40, 126, DateTimeKind.Local).AddTicks(4272), new DateTime(2024, 9, 19, 13, 2, 40, 126, DateTimeKind.Local).AddTicks(4273) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SegmentDatum",
                keyColumn: "SegmentDataId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SegmentDatum",
                keyColumn: "SegmentDataId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SegmentDatum",
                keyColumn: "SegmentDataId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SegmentDatum",
                keyColumn: "SegmentDataId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SegmentDatum",
                keyColumn: "SegmentDataId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SegmentDatum",
                keyColumn: "SegmentDataId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SegmentDatum",
                keyColumn: "SegmentDataId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SegmentDatum",
                keyColumn: "SegmentDataId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SegmentDatum",
                keyColumn: "SegmentDataId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SegmentDatum",
                keyColumn: "SegmentDataId",
                keyValue: 10);

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

            migrationBuilder.UpdateData(
                table: "DeptDocNumStructs",
                keyColumn: "DeptDocNumStructId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 22, 26, 236, DateTimeKind.Local).AddTicks(1149), new DateTime(2024, 9, 19, 12, 22, 26, 236, DateTimeKind.Local).AddTicks(1168) });

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
        }
    }
}
