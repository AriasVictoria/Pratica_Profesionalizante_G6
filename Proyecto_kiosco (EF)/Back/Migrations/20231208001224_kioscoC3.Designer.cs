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
    [Migration("20231208001224_kioscoC3")]
    partial class kioscoC3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Back.Administradores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApellidoAdministrador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreAdministrador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("Back.DetallePedido", b =>
                {
                    b.Property<string>("numeropedido")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Cantidad_Producto")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha_Pedido")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id1")
                        .HasColumnType("int");

                    b.Property<int>("Id_Producto1")
                        .HasColumnType("int");

                    b.Property<int>("MontoFinal")
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

                    b.HasIndex("Id_Producto1");

                    b.ToTable("DetallePedidos");
                });

            modelBuilder.Entity("Back.Pedidos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NombreVendedornumerolegajo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NombreVendedornumerolegajo");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Back.Productos", b =>
                {
                    b.Property<int>("Id_Producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Producto"));

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

                    b.HasKey("Id_Producto");

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

            modelBuilder.Entity("Back.Usuarios", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("Back.Vendedores", b =>
                {
                    b.Property<int>("numerolegajo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("numerolegajo"));

                    b.Property<string>("ApellidoVendedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreVendedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("numerolegajo");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("Back.DetallePedido", b =>
                {
                    b.HasOne("Back.Pedidos", "Id")
                        .WithMany()
                        .HasForeignKey("Id1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Back.Productos", "Id_Producto")
                        .WithMany()
                        .HasForeignKey("Id_Producto1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Id");

                    b.Navigation("Id_Producto");
                });

            modelBuilder.Entity("Back.Pedidos", b =>
                {
                    b.HasOne("Back.Vendedores", "NombreVendedor")
                        .WithMany()
                        .HasForeignKey("NombreVendedornumerolegajo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NombreVendedor");
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
