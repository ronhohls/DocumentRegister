using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DocumentRegister.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DataTypes",
                columns: new[] { "DataTypeId", "CreatedBy", "DateCreated", "DateModified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2785), new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2797), null, "String" },
                    { 2, null, new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2798), new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2799), null, "Number" },
                    { 3, null, new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2800), new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2800), null, "Currency" }
                });

            migrationBuilder.InsertData(
                table: "MediaTypes",
                columns: new[] { "MediaTypeId", "CreatedBy", "DateCreated", "DateModified", "Description", "ModifiedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1340), new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1350), "Hard copy", null },
                    { 2, null, new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1351), new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1352), "Digital - local", null },
                    { 3, null, new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1353), new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1354), "Digital - cloud", null }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "CreatedBy", "DateCreated", "DateModified", "Description", "ModifiedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(634), new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(642), "Pending Approval", null },
                    { 2, null, new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(644), "Approved", null },
                    { 3, null, new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(645), new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(645), "Deprecated", null },
                    { 4, null, new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(646), new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(647), "N/A", null }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "DocumentId", "CreatedBy", "DateCreated", "DateModified", "DDNSDescription", "Description", "DocumentNumber", "Location", "MediaTypeId", "ModifiedBy", "RequestedBy", "Revision", "Seperator", "StatusId" },
                values: new object[] { 1, null, null, null, "Electronic Department", "TestValue", "A554-ELEC-ANG-566", "Documents office, cabinet 3", 1, null, "Ron", "45", "-----", 1 });

            migrationBuilder.InsertData(
                table: "SegmentCategories",
                columns: new[] { "SegmentCategoryId", "CreatedBy", "DataTypeId", "DateCreated", "DateModified", "Description", "IsPredefined", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9134), "Codes that define what project the document is part of", true, null, "Project Code" },
                    { 2, null, 1, new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9135), new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9136), "Specifies the type of document", true, null, "Document Type" },
                    { 3, null, 1, new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9138), "Codes that define the customer they are related to", true, null, "Customer code" },
                    { 4, null, 2, new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9140), new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9140), "Unique serial number for identifying individual documents", false, null, "Sequence Number" }
                });

            migrationBuilder.InsertData(
                table: "DocumentSegments",
                columns: new[] { "DocumentSegmentId", "CategoryDescription", "CategoryName", "CreatedBy", "DateCreated", "DateModified", "DocumentId", "ModifiedBy", "Value", "ValueDescription" },
                values: new object[,]
                {
                    { 1, "Codes that define what project the document is part of", "Project Code", null, new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1659), new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1670), 1, null, "A554", "Oxygen sensor retrofitting" },
                    { 2, "Specifies the type of document", "Document Type", null, new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1671), new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1672), 1, null, "ELEC", "Electronic schematic" },
                    { 3, "Codes that define the customer they are related to", "Customer code", null, new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1673), new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1674), 1, null, "ANG", "Anglo Gold Ashanti" },
                    { 4, "Unique serial number for identifying individual documents", "Sequence Number", null, new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1676), new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1676), 1, null, "566", "Some info about seq number" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DocumentSegments",
                keyColumn: "DocumentSegmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SegmentCategories",
                keyColumn: "SegmentCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DataTypes",
                keyColumn: "DataTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "MediaTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 1);
        }
    }
}
