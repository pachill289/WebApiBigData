﻿// <auto-generated />
using CapaDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CapaDatos.Migrations
{
    [DbContext(typeof(dbContext))]
    partial class dbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CapaDatos.Hechos", b =>
                {
                    b.Property<int>("idHecho")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("Hora")
                        .HasColumnType("integer");

                    b.Property<bool>("Like")
                        .HasColumnType("boolean");

                    b.Property<string>("Mensaje")
                        .HasColumnType("text");

                    b.Property<string>("Resultado")
                        .HasColumnType("text");

                    b.Property<string>("colorFondo")
                        .HasColumnType("text");

                    b.Property<string>("colorTexto")
                        .HasColumnType("text");

                    b.HasKey("idHecho");

                    b.ToTable("Hechos");
                });

            modelBuilder.Entity("CapaDatos.Publicacion", b =>
                {
                    b.Property<int>("idPublicacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("Hora")
                        .HasColumnType("integer");

                    b.Property<string>("Ip")
                        .HasColumnType("text");

                    b.Property<bool>("Like")
                        .HasColumnType("boolean");

                    b.Property<string>("Mensaje")
                        .HasColumnType("text");

                    b.Property<long>("colorFondo")
                        .HasColumnType("bigint");

                    b.Property<long>("colorTexto")
                        .HasColumnType("bigint");

                    b.HasKey("idPublicacion");

                    b.ToTable("Publicaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
