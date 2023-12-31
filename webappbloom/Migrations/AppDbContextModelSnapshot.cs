﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppBloom.Contexts;

#nullable disable

namespace webappbloom.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAppBloom.Models.Competencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ColunaBloom")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasColumnName("ColunaBloom");

                    b.Property<string>("LinhaBloom")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasColumnName("LinhaBloom");

                    b.HasKey("Id");

                    b.ToTable("Competencia", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}