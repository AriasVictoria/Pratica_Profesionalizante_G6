using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion
{
    public class Principal
    {
        List<Vendedor> ListaVendedor = new List<Vendedor>();
        List<Administrador> ListaAdministrador = new List<Administrador>();
        List<Producto> ListaProducto = new List<Producto>();
        List<Proveedor> ListaProveedor = new List<Proveedor>();
        List<Pedido> ListaPedido = new List<Pedido>();

        public void AltaVendedor(Vendedor vendedor)
        {
            Vendedor vendedor1 = new Vendedor();
            vendedor1.NombreVendedor = vendedor1.NombreVendedor;
            vendedor1.ApellidoVendedor = vendedor1.ApellidoVendedor;
            vendedor1.contraseñaV = vendedor1.contraseñaV;

            ListaVendedor.Add(vendedor);
        }
        public void AltaAdministrador(Administrador administrador)
        {
            Administrador administrador1 = new Administrador();
            administrador1.NombreAdministrador = administrador1.NombreAdministrador;
            administrador1.ApellidoAdministrador = administrador1.ApellidoAdministrador;
            administrador1.contraseña = administrador1.contraseña;

            ListaAdministrador.Add(administrador);
        }
        public void AltaProveedor(Proveedor proveedor)
        {
            Proveedor proveedor1 = new Proveedor();
            proveedor1.NombreProvedor = proveedor1.NombreProvedor;
            proveedor1.ApellidoProvedor = proveedor1.ApellidoProvedor;
            proveedor1.lproducto = proveedor1.lproducto;

            ListaProveedor.Add(proveedor);
        }
        public void AltaPedido(Pedido pedido)
        {
            Pedido pedido1 = new Pedido();
            pedido1.MontoFinal = pedido1.MontoFinal;
            pedido1.Tipo_Producto = pedido1.Tipo_Producto;
            pedido1.Precio_Producto = pedido1.Precio_Producto;

            ListaPedido.Add(pedido);
        }
        public void BajaVendedor(Vendedor vendedor)
        {
            Vendedor vendedor1 = new Vendedor();
            vendedor1.NombreVendedor = vendedor1.NombreVendedor;
            vendedor1.ApellidoVendedor = vendedor1.ApellidoVendedor;
            vendedor1.contraseñaV = vendedor1.contraseñaV;

            ListaVendedor.Remove(vendedor);
        }
        public void BajaAdministrador(Administrador administrador)
        {
            Administrador administrador1 = new Administrador();
            administrador1.NombreAdministrador = administrador1.NombreAdministrador;
            administrador1.ApellidoAdministrador = administrador1.ApellidoAdministrador;
            administrador1.contraseña = administrador1.contraseña;

            ListaAdministrador.Remove(administrador);
        }
        public void BajaProveedor(Proveedor proveedor)
        {
            Proveedor proveedor1 = new Proveedor();
            proveedor1.NombreProvedor = proveedor1.NombreProvedor;
            proveedor1.ApellidoProvedor = proveedor1.ApellidoProvedor;
            proveedor1.lproducto = proveedor1.lproducto;

            ListaProveedor.Remove(proveedor);
        }
        public void BajaPedido(Pedido pedido)
        {
            Pedido pedido1 = new Pedido();
            pedido1.MontoFinal = pedido1.MontoFinal;
            pedido1.Tipo_Producto = pedido1.Tipo_Producto;
            pedido1.Precio_Producto = pedido1.Precio_Producto;

            ListaPedido.Remove(pedido);
        }
        public void ModificarVendedor(Vendedor NuevoVendedor)
        {
            Vendedor ModificarVendedor = new Vendedor();

            Vendedor vendedor1 = new Vendedor();
            vendedor1.NombreVendedor = vendedor1.NombreVendedor;
            vendedor1.ApellidoVendedor = vendedor1.ApellidoVendedor;
            vendedor1.contraseñaV = vendedor1.contraseñaV;

            ListaVendedor.Remove(vendedor1);
            ListaVendedor.Add(ModificarVendedor);
        }
        public void ModificarAdministrador(Administrador NuevoAdmnistrador)
        {
            Administrador ModificarAdministrador = new Administrador();

            Administrador administrador1 = new Administrador();
            administrador1.NombreAdministrador = administrador1.NombreAdministrador;
            administrador1.ApellidoAdministrador = administrador1.ApellidoAdministrador;
            administrador1.contraseña = administrador1.contraseña;

            ListaAdministrador.Remove(administrador1);
            ListaAdministrador.Add(ModificarAdministrador);
        }
        public void ModificarProveedor(Proveedor NuevoProveedor)
        {
            Proveedor ModificarProveedor = new Proveedor();

            Proveedor proveedor1 = new Proveedor();
            proveedor1.NombreProvedor = proveedor1.NombreProvedor;
            proveedor1.ApellidoProvedor = proveedor1.ApellidoProvedor;
            proveedor1.lproducto = proveedor1.lproducto;

            ListaProveedor.Remove(proveedor1);
            ListaProveedor.Add(ModificarProveedor);
        }
        public void ModificarPedido(Pedido NuevoPedido)
        {
            Pedido ModificarPedido = new Pedido();

            Pedido pedido1 = new Pedido();
            pedido1.MontoFinal = pedido1.MontoFinal;
            pedido1.Tipo_Producto = pedido1.Tipo_Producto;
            pedido1.Precio_Producto = pedido1.Precio_Producto;

            ListaPedido.Remove(pedido1);
            ListaPedido.Add(ModificarPedido);
        }

    }
}
