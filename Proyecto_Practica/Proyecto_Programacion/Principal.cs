using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion
{
    public class Principal
    {
        public List<Vendedor> ListaVendedor = new List<Vendedor>();
        public List<Administrador> ListaAdministrador = new List<Administrador>();
        public List<Producto> ListaProducto = new List<Producto>();
        public List<Proveedor> ListaProveedor = new List<Proveedor>();
        public List<Pedido> ListaPedido = new List<Pedido>();

        public void AltaVendedor(Vendedor vendedor)
        {
            Vendedor vendedor1 = new Vendedor();
            vendedor1.NombreVendedor = vendedor.NombreVendedor;
            vendedor1.ApellidoVendedor = vendedor.ApellidoVendedor;
            vendedor1.contraseñaV = vendedor.contraseñaV;

            ListaVendedor.Add(vendedor);
        }
        public void AltaAdministrador(Administrador administrador)
        {
            Administrador administrador1 = new Administrador();
            administrador1.NombreAdministrador = administrador.NombreAdministrador;
            administrador1.ApellidoAdministrador = administrador.ApellidoAdministrador;
            administrador1.contraseña = administrador.contraseña;

            ListaAdministrador.Add(administrador);
        }
        public void AltaProdcuto(Producto producto)
        {
            Producto producto1 = new Producto();
            producto1.Id = producto.Id; 
            producto1.NombreProducto = producto.NombreProducto;
            producto1.Precio = producto.Precio;
            producto1.stock = producto.stock;

            ListaProducto.Add(producto1);
        }
        public void AltaProveedor(Proveedor proveedor)
        {
            Proveedor proveedor1 = new Proveedor();
            proveedor1.NombreProvedor = proveedor.NombreProvedor;
            proveedor1.ApellidoProvedor = proveedor.ApellidoProvedor;
            proveedor1.lproducto = proveedor.lproducto;

            ListaProveedor.Add(proveedor1);
        }
        public void AltaPedido(Pedido pedido)
        {
            Pedido pedido1 = new Pedido();
            pedido1.MontoFinal = pedido.MontoFinal;
            pedido1.Tipo_Producto = pedido.Tipo_Producto;
            pedido1.Precio_Producto = pedido.Precio_Producto;

            ListaPedido.Add(pedido1);
        }
        public void BajaVendedor(Vendedor vendedor)
        {
            

            ListaVendedor.Remove(vendedor);
        }
        public void BajaAdministrador(Administrador administrador)
        {
            ListaAdministrador.Remove(administrador);
        }
        public void BajaProdcuto(Producto producto)
        {

            ListaProducto.Remove(producto);
        }
        public void BajaProveedor(Proveedor proveedor)
        {
          

            ListaProveedor.Remove(proveedor);
        }
        public void BajaPedido(Pedido pedido)
        {
            

            ListaPedido.Remove(pedido);
        }
        public void ModificarVendedor(Vendedor NuevoVendedor, Vendedor VendedorEliminado)
        {
            Vendedor ModificarVendedor = new Vendedor();

            Vendedor vendedor1 = new Vendedor();
            ModificarVendedor.NombreVendedor = NuevoVendedor.NombreVendedor;
            ModificarVendedor.ApellidoVendedor = NuevoVendedor.ApellidoVendedor;
            ModificarVendedor.contraseñaV = NuevoVendedor.contraseñaV;

            ListaVendedor.Remove(VendedorEliminado);
            ListaVendedor.Add(ModificarVendedor);
        }
        public void ModificarAdministrador(Administrador NuevoAdmnistrador, Administrador administradorEliminado)
        {
            Administrador ModificarAdministrador = new Administrador();

            Administrador administrador1 = new Administrador();
            ModificarAdministrador.NombreAdministrador = NuevoAdmnistrador.NombreAdministrador;
            ModificarAdministrador.ApellidoAdministrador = NuevoAdmnistrador.ApellidoAdministrador;
            ModificarAdministrador.contraseña = NuevoAdmnistrador.contraseña;

            ListaAdministrador.Remove(administradorEliminado);
            ListaAdministrador.Add(ModificarAdministrador);
        }
        public void ModificarProdcuto(Producto NuevoProducto, Producto ProductoEliminar)
        {
            Producto ModififcarProducto = new Producto();

            Producto producto1 = new Producto();
            ModififcarProducto.Id = NuevoProducto.Id;
            ModififcarProducto.NombreProducto = NuevoProducto.NombreProducto;
            ModififcarProducto.Precio = NuevoProducto.Precio;
            ModififcarProducto.stock = NuevoProducto.stock;

            ListaProducto.Remove(ProductoEliminar);
            ListaProducto.Add(ModififcarProducto);
        }
        public void ModificarProveedor(Proveedor NuevoProveedor, Proveedor ProveedorEliminado)
        {
            Proveedor ModificarProveedor = new Proveedor();

            Proveedor proveedor1 = new Proveedor();
            ModificarProveedor.NombreProvedor = NuevoProveedor.NombreProvedor;
            ModificarProveedor.ApellidoProvedor = NuevoProveedor.ApellidoProvedor;
            ModificarProveedor.lproducto = NuevoProveedor.lproducto;

            ListaProveedor.Remove(ProveedorEliminado);
            ListaProveedor.Add(ModificarProveedor);
        }
        public void ModificarPedido(Pedido NuevoPedido, Pedido pedidoEliminado)
        {
            Pedido ModificarPedido = new Pedido();

            Pedido pedido1 = new Pedido();
            ModificarPedido.MontoFinal = NuevoPedido.MontoFinal;
            ModificarPedido.Tipo_Producto = NuevoPedido.Tipo_Producto;
            ModificarPedido.Precio_Producto = NuevoPedido.Precio_Producto;

            ListaPedido.Remove(pedidoEliminado);
            ListaPedido.Add(ModificarPedido);
        }

    }
}
