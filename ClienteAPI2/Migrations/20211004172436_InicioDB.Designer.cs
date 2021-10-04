﻿// <auto-generated />
using ClienteAPI2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClienteAPI2.Migrations
{
    [DbContext(typeof(ClienteDB))]
    [Migration("20211004172436_InicioDB")]
    partial class InicioDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClienteAPI2.Models.Cliente", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Datanasc")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Emaail")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdUsuario");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
