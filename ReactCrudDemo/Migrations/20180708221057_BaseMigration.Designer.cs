﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ReactCrudDemo.Models;
using System;

namespace ReactCrudDemo.Migrations
{
    [DbContext(typeof(myTestDBContext))]
    [Migration("20180708221057_BaseMigration")]
    partial class BaseMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReactCrudDemo.Models.TblCities", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CityID");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("CityId");

                    b.ToTable("tblCities");
                });

            modelBuilder.Entity("ReactCrudDemo.Models.TblEmployee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EmployeeID");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("EmployeeId");

                    b.ToTable("tblEmployee");
                });
#pragma warning restore 612, 618
        }
    }
}
