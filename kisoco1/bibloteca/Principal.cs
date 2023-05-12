using bibloteca;
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
        List<Usuario> ListaUsuario = new List<Usuario>();
        List<Carrito> ListaCarrito = new List<Carrito>();
        List<Vendedor> ListaVendedor = new List<Vendedor>();
        List<Dueño> Listadueño = new List<Dueño>();
        public void altausuario(string nombre, string apellido, string contraseña, string tipo) //parametros
        {
            Usuario usuarionuevo = new Usuario();
            usuarionuevo.nombre = nombre;
            usuarionuevo.apellido = apellido;
            usuarionuevo.contraseña = contraseña;
            usuarionuevo.tipo = tipo;
            ListaUsuario.Add(usuarionuevo);

        }

        public void altaproducto(int id, string codigo_barra, int precio, string nombrep, int stock) //parametros
        {
            Producto productconuevo = new Producto();
            productconuevo.Id = id + 1;
            productconuevo.codigo_barra = codigo_barra;
            productconuevo.precio = precio;
            productconuevo.nombrep = nombrep;
            productconuevo.stock = stock;
            ListaProducto.Add(productconuevo);
        }

        public void altaproveedor(string aoellido, string nombreproveedor, string lproductos) //parametros
        {
            Proveedor proveedorconuevo = new Proveedor();
            proveedorconuevo.apellido = aoellido;
            proveedorconuevo.nombreproveedor = nombreproveedor;
            proveedorconuevo.lproductos = lproductos;
            ListaProveedor.Add(proveedorconuevo);
        }

        public void altacarrito(double final, double precio_producto, string tipo_producto) //parametros
        {
            Carrito carritonuevo = new Carrito();
            carritonuevo.final = final; ;
            carritonuevo.precio_producto = precio_producto;
            carritonuevo.tipo_producto = tipo_producto;
            ListaCarrito.Add(carritonuevo);
        }
    }
}
