﻿// <auto-generated />
using System;
using DocumentRegister.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DocumentRegister.Infrastructure.Migrations
{
    [DbContext(typeof(DocumentRegisterDbContext))]
    [Migration("20240919095843_InitialSeeding")]
    partial class InitialSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DeptDocNumStructSegmentCategory", b =>
                {
                    b.Property<int>("DeptDocNumStructsDeptDocNumStructId")
                        .HasColumnType("int");

                    b.Property<int>("SegmentCategoriesSegmentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("DeptDocNumStructsDeptDocNumStructId", "SegmentCategoriesSegmentCategoryId");

                    b.HasIndex("SegmentCategoriesSegmentCategoryId");

                    b.ToTable("DeptDocNumStructSegmentCategory");
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.DataType", b =>
                {
                    b.Property<int>("DataTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DataTypeId"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DataTypeId");

                    b.ToTable("DataTypes");

                    b.HasData(
                        new
                        {
                            DataTypeId = 1,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2785),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2797),
                            Name = "String"
                        },
                        new
                        {
                            DataTypeId = 2,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2798),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2799),
                            Name = "Number"
                        },
                        new
                        {
                            DataTypeId = 3,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2800),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 46, DateTimeKind.Local).AddTicks(2800),
                            Name = "Currency"
                        });
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.DeptDocNumStruct", b =>
                {
                    b.Property<int>("DeptDocNumStructId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptDocNumStructId"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seperator")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("DeptDocNumStructId");

                    b.ToTable("DeptDocNumStructs");
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("DdnsDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("DDNSDescription");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MediaTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Revision")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Seperator")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("DocumentId");

                    b.HasIndex("MediaTypeId");

                    b.HasIndex("StatusId");

                    b.ToTable("Documents");

                    b.HasData(
                        new
                        {
                            DocumentId = 1,
                            DdnsDescription = "Electronic Department",
                            Description = "TestValue",
                            DocumentNumber = "A554-ELEC-ANG-566",
                            Location = "Documents office, cabinet 3",
                            MediaTypeId = 1,
                            RequestedBy = "Ron",
                            Revision = "45",
                            Seperator = "-----",
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.DocumentSegment", b =>
                {
                    b.Property<int>("DocumentSegmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentSegmentId"));

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ValueDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("DocumentSegmentId");

                    b.HasIndex("DocumentId");

                    b.ToTable("DocumentSegments");

                    b.HasData(
                        new
                        {
                            DocumentSegmentId = 1,
                            CategoryDescription = "Codes that define what project the document is part of",
                            CategoryName = "Project Code",
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1659),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1670),
                            DocumentId = 1,
                            Value = "A554",
                            ValueDescription = "Oxygen sensor retrofitting"
                        },
                        new
                        {
                            DocumentSegmentId = 2,
                            CategoryDescription = "Specifies the type of document",
                            CategoryName = "Document Type",
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1671),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1672),
                            DocumentId = 1,
                            Value = "ELEC",
                            ValueDescription = "Electronic schematic"
                        },
                        new
                        {
                            DocumentSegmentId = 3,
                            CategoryDescription = "Codes that define the customer they are related to",
                            CategoryName = "Customer code",
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1673),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1674),
                            DocumentId = 1,
                            Value = "ANG",
                            ValueDescription = "Anglo Gold Ashanti"
                        },
                        new
                        {
                            DocumentSegmentId = 4,
                            CategoryDescription = "Unique serial number for identifying individual documents",
                            CategoryName = "Sequence Number",
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1676),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 52, DateTimeKind.Local).AddTicks(1676),
                            DocumentId = 1,
                            Value = "566",
                            ValueDescription = "Some info about seq number"
                        });
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.MediaType", b =>
                {
                    b.Property<int>("MediaTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MediaTypeId"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MediaTypeId");

                    b.ToTable("MediaTypes");

                    b.HasData(
                        new
                        {
                            MediaTypeId = 1,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1340),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1350),
                            Description = "Hard copy"
                        },
                        new
                        {
                            MediaTypeId = 2,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1351),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1352),
                            Description = "Digital - local"
                        },
                        new
                        {
                            MediaTypeId = 3,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1353),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 54, DateTimeKind.Local).AddTicks(1354),
                            Description = "Digital - cloud"
                        });
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.SegmentCategory", b =>
                {
                    b.Property<int>("SegmentCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SegmentCategoryId"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DataTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsPredefined")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SegmentCategoryId");

                    b.HasIndex("DataTypeId");

                    b.ToTable("SegmentCategories");

                    b.HasData(
                        new
                        {
                            SegmentCategoryId = 1,
                            DataTypeId = 1,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9119),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9134),
                            Description = "Codes that define what project the document is part of",
                            IsPredefined = true,
                            Name = "Project Code"
                        },
                        new
                        {
                            SegmentCategoryId = 2,
                            DataTypeId = 1,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9135),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9136),
                            Description = "Specifies the type of document",
                            IsPredefined = true,
                            Name = "Document Type"
                        },
                        new
                        {
                            SegmentCategoryId = 3,
                            DataTypeId = 1,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9137),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9138),
                            Description = "Codes that define the customer they are related to",
                            IsPredefined = true,
                            Name = "Customer code"
                        },
                        new
                        {
                            SegmentCategoryId = 4,
                            DataTypeId = 2,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9140),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 57, DateTimeKind.Local).AddTicks(9140),
                            Description = "Unique serial number for identifying individual documents",
                            IsPredefined = false,
                            Name = "Sequence Number"
                        });
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.SegmentData", b =>
                {
                    b.Property<int>("SegmentDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SegmentDataId"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SegmentCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("SegmentDataId");

                    b.HasIndex("SegmentCategoryId");

                    b.ToTable("SegmentDatum");
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = 1,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(634),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(642),
                            Description = "Pending Approval"
                        },
                        new
                        {
                            StatusId = 2,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(643),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(644),
                            Description = "Approved"
                        },
                        new
                        {
                            StatusId = 3,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(645),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(645),
                            Description = "Deprecated"
                        },
                        new
                        {
                            StatusId = 4,
                            DateCreated = new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(646),
                            DateModified = new DateTime(2024, 9, 19, 11, 58, 43, 62, DateTimeKind.Local).AddTicks(647),
                            Description = "N/A"
                        });
                });

            modelBuilder.Entity("DeptDocNumStructSegmentCategory", b =>
                {
                    b.HasOne("DocumentRegister.Core.Entities.DeptDocNumStruct", null)
                        .WithMany()
                        .HasForeignKey("DeptDocNumStructsDeptDocNumStructId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DocumentRegister.Core.Entities.SegmentCategory", null)
                        .WithMany()
                        .HasForeignKey("SegmentCategoriesSegmentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.Document", b =>
                {
                    b.HasOne("DocumentRegister.Core.Entities.MediaType", "MediaType")
                        .WithMany()
                        .HasForeignKey("MediaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DocumentRegister.Core.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MediaType");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.DocumentSegment", b =>
                {
                    b.HasOne("DocumentRegister.Core.Entities.Document", "Document")
                        .WithMany("DocumentSegments")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.SegmentCategory", b =>
                {
                    b.HasOne("DocumentRegister.Core.Entities.DataType", "DataType")
                        .WithMany()
                        .HasForeignKey("DataTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataType");
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.SegmentData", b =>
                {
                    b.HasOne("DocumentRegister.Core.Entities.SegmentCategory", "SegmentCategory")
                        .WithMany("SegmentDatum")
                        .HasForeignKey("SegmentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SegmentCategory");
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.Document", b =>
                {
                    b.Navigation("DocumentSegments");
                });

            modelBuilder.Entity("DocumentRegister.Core.Entities.SegmentCategory", b =>
                {
                    b.Navigation("SegmentDatum");
                });
#pragma warning restore 612, 618
        }
    }
}
