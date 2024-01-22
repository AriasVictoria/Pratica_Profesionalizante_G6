﻿// <auto-generated />
using System;
using Back;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Back.Migrations
{
    [DbContext(typeof(BaseDatos))]
    [Migration("20240111002917_kioscoC10")]
    partial class kioscoC10
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Back.DetallePedido", b =>
                {
                    b.Property<int>("numeropedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("numeropedido"));

                    b.Property<int>("Cantidad_Producto")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha_Pedido")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id1")
                        .HasColumnType("int");

                    b.Property<int>("NombreDuenioDNI")
                        .HasColumnType("int");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio_Producto")
                        .HasColumnType("int");

                    b.Property<string>("tipo_producto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("numeropedido");

                    b.HasIndex("Id1");

                    b.HasIndex("NombreDuenioDNI");

                    b.ToTable("DetallePedidos");
                });

            modelBuilder.Entity("Back.Dueño", b =>
                {
                    b.Property<int>("DNI")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DNI"));

                    b.Property<string>("ApellidoDuenio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NombreDuenio")
                        .HasColumnType("int");

                    b.HasKey("DNI");

                    b.ToTable("Dueños");
                });

            modelBuilder.Entity("Back.Productos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NombreProvedorId")
                        .HasColumnType("int");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.Property<string>("tipo_producto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NombreProvedorId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Back.Proveedores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApellidoProvedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProvedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cuit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("proveedores");
                });

            modelBuilder.Entity("Back.DetallePedido", b =>
                {
                    b.HasOne("Back.Productos", "Id")
                        .WithMany()
                        .HasForeignKey("Id1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Back.Dueño", "NombreDuenio")
                        .WithMany()
                        .HasForeignKey("NombreDuenioDNI")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Id");

                    b.Navigation("NombreDuenio");
                });

            modelBuilder.Entity("Back.Productos", b =>
                {
                    b.HasOne("Back.Proveedores", "NombreProvedor")
                        .WithMany()
                        .HasForeignKey("NombreProvedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NombreProvedor");
                });
#pragma warning restore 612, 618
        }
    }
}
