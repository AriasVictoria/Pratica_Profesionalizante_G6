﻿using bibloteca;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicaClase
{
    public class Principal
    {
        List<Producto> ListaProducto = new List<Producto>();
        List<Proveedor> ListaProveedor = new List<Proveedor>();
        List<Pedido> ListaPedido = new List<Pedido>();
        List<Vendedor> ListaVendedor = new List<Vendedor>();

        public void altavendedor(int Id, string Nombre_vendedor) //parametros
        {
            Vendedor vendedornuevo = new Vendedor();
            vendedornuevo.Id = Id;
            vendedornuevo.Nombre_vendedor = Nombre_vendedor;
            ListaVendedor.Add(vendedornuevo);
        }

        public void altaproducto(int id, string codigo_barra, int precio, string nombrep, int stock) //parametros
        {
            Producto productonuevo = new Producto();
            productonuevo.Id = id + 1;
            productonuevo.codigo_barra = codigo_barra;
            productonuevo.precio = precio;
            productonuevo.nombrep = nombrep;
            productonuevo.stock = stock;
            ListaProducto.Add(productonuevo);
        }
        public void modificarrpducto(int Id, Producto Productonuevo)
        {
            Producto productomodificado = new Producto();

            var productoencontrado = ListaProducto.Find(x => x.Id == Id);

            if (productoencontrado == null)
            {
                productomodificado.Id = Productonuevo.Id + 1;
                productomodificado.codigo_barra = Productonuevo.codigo_barra;
                productomodificado.precio = Productonuevo.precio;
                productomodificado.nombrep = Productonuevo.nombrep;
                productomodificado.stock = Productonuevo.stock;

                ListaProducto.Add(productomodificado);
                ListaProducto.Remove(productoencontrado);
            }
        }
        public void altaproveedor(string aoellido, string nombreproveedor, string lproductos) //parametros
        {
            Proveedor proveedorconuevo = new Proveedor();
            proveedorconuevo.apellido = aoellido;
            proveedorconuevo.nombreproveedor = nombreproveedor;
            proveedorconuevo.lproductos = lproductos;
            ListaProveedor.Add(proveedorconuevo);
        }

        public void altapedido(double final, double precio_producto, string tipo_producto) //parametros
        {
            Pedido pedidotonuevo = new Pedido();
            pedidotonuevo.final = final; ;
            pedidotonuevo.precio_producto = precio_producto;
            pedidotonuevo.tipo_producto = tipo_producto;
            ListaPedido.Add(pedidotonuevo);
        }
        
    }
}
