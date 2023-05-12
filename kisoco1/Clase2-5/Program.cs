﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaClase;

namespace Proyecto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Principal principal = new Principal();

            while ()
            {
                Usuario usuarioagregado = new Usuario();
                Console.WriteLine("agregar el tipo de usuario");
                usuarioagregado.tipo = Console.ReadLine();

                Console.WriteLine("arranca por el nombre");
                usuarioagregado.nombre = Console.ReadLine();

                Console.Write("agregame tu apellido");
                usuarioagregado.apellido = Console.ReadLine();

                Console.WriteLine("agregar la contraseña");
                usuarioagregado.contraseña = Console.ReadLine();

                principal.altausuario(usuarioagregado.nombre, usuarioagregado.apellido, usuarioagregado.contraseña, 
                    usuarioagregado.tipo);
            }

            while ()
            {
                Producto Productoagregado = new Producto();
                Console.WriteLine("agregar un producto");

                Console.WriteLine("arranca por el id");
                Productoagregado.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("agregar el nombre");
                Productoagregado.nombrep = Console.ReadLine();

                Console.WriteLine("agregar el precio");
                Productoagregado.precio = int.Parse(Console.ReadLine());

                Console.WriteLine("agregar el codigo de barra");
                Productoagregado.codigo_barra = Console.ReadLine();

                Console.WriteLine("Mostrame el stock del producto");
                Productoagregado.stock = int.Parse(Console.ReadLine());

                principal.altaproducto(Productoagregado.Id, Productoagregado.nombrep, 
                    Productoagregado.precio, Productoagregado.codigo_barra, Productoagregado.stock);
            }

            while ()
            {
                Proveedor Proveedoragregado = new Proveedor();
                Console.WriteLine("agregar un proveedor");

                Console.WriteLine("agrega el apellido");
                Proveedoragregado.apellido = Console.ReadLine();

                Console.WriteLine("agregar el nombre");
                Proveedoragregado.nombreproveedor = Console.ReadLine();

                Console.WriteLine("agregar la lista de producto");
                Proveedoragregado.lproductos = Console.ReadLine();

                principal.altaproveedor(Proveedoragregado.apellido, Proveedoragregado.nombreproveedor, 
                    Proveedoragregado.lproductos);
            }

            while ()
            {
                Carrito Carritoagregado = new Carrito();
                Console.WriteLine("crea tu carrito");

                Console.WriteLine("agregar tu producto al carrito");
                Carritoagregado.tipo_producto = Console.ReadLine();
                
                Console.WriteLine("este es el precio de tu producto");
                Carritoagregado.precio_producto = int.Parse(Console.ReadLine());

                Console.WriteLine("este es el monto final");
                Carritoagregado.final = int.Parse(Console.ReadLine());

                principal.altacarrito(Carritoagregado.final, Carritoagregado.precio_producto,Carritoagregado.tipo_producto);
            }
        }
    }
}
