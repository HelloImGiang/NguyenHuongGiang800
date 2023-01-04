﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace NguyenHuongGiang800.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("NguyenHuongGiang800.Models.CompanyNHG800", b =>
                {
                    b.Property<string>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CompanyId");

                    b.ToTable("CompanyNHG800");
                });

            modelBuilder.Entity("NguyenHuongGiang800.Models.NHG0800", b =>
                {
                    b.Property<string>("NHGId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("NHGGender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NHGName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NHGId");

                    b.ToTable("NHG0800");
                });
#pragma warning restore 612, 618
        }
    }
}