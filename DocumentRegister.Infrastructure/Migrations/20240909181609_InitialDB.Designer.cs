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
    [Migration("20240909181609_InitialDB")]
    partial class InitialDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                            DateCreated = new DateTime(2024, 9, 9, 20, 16, 8, 617, DateTimeKind.Local).AddTicks(1500),
                            DateModified = new DateTime(2024, 9, 9, 20, 16, 8, 617, DateTimeKind.Local).AddTicks(1532),
                            Name = "TestValue"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
