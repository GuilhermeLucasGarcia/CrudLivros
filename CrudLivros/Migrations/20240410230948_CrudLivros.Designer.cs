﻿// <auto-generated />
using CrudLivros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudLivros.Migrations
{
    [DbContext(typeof(bancoDeDados))]
    [Migration("20240410230948_CrudLivros")]
    partial class CrudLivros
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrudLivros.Models.Livro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("codBarras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("inativo")
                        .HasColumnType("bit");

                    b.Property<string>("isbn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qtdPag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sinapse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}
