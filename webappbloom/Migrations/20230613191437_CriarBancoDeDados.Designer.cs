﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppBloom.Contexts;

#nullable disable

namespace webappbloom.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230613191437_CriarBancoDeDados")]
    partial class CriarBancoDeDados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAppBloom.Models.Competencia", b =>
                {
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
