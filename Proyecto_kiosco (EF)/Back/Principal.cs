using System.Globalization;
using System.Runtime.InteropServices.ObjectiveC;

namespace Back
{
    public class Principal
    {
        public void AltaAdmnistradores(Administradores administrador)
        {
            using (var context = new BaseDatos())
            {
                var NuevoAdmnistrador = new Administradores
                {
                    NombreAdministrador = administrador.NombreAdministrador,
                    ApellidoAdministrador = administrador.ApellidoAdministrador,
                    contrasenia = administrador.contrasenia,
                };
                context.Administradores.Add(NuevoAdmnistrador);
                context.SaveChanges();
            }
        }
        public void AltaVendedor(Vendedores vendedor)
        {
            using (var context = new BaseDatos())
            {
                var NuevoVendedor = new Vendedores
                {
                    NombreVendedor = vendedor.NombreVendedor,
                    ApellidoVendedor = vendedor.ApellidoVendedor,
                    contrasenia = vendedor.contrasenia,
                };
                context.Vendedores.Add(NuevoVendedor);
                context.SaveChanges();
            }
        }
        
        public void AltaPedido(Pedidos pedido)
        {
            using (var context = new BaseDatos())
            {
                var NuevoPedido = new Pedidos
                {
                    NombreVendedor = pedido.NombreVendedor,
                };
                context.Pedidos.Add(NuevoPedido);
                context.SaveChanges();
            }
        }
        public void AltaProducto(Productos producto)
        {
            using (var context = new BaseDatos())
            {
                var NuevoProducto = new Productos
                {
                    NombreProducto = producto.NombreProducto,
                    stock = producto.stock,
                    tipo_producto = producto.tipo_producto,
                    NombreProvedor = producto.NombreProvedor,
                };
                context.Productos.Add(NuevoProducto);
                context.SaveChanges();

            }
        }
        public void AltaProveedor(Proveedores proveedor)
        {
            using (BaseDatos context = new BaseDatos())
            {
                Proveedores NuevoProveedor = new Proveedores
                {  
                    cuit = proveedor.cuit,
                    NombreProvedor = proveedor.NombreProvedor,
                    ApellidoProvedor = proveedor.ApellidoProvedor,
                };

                context.proveedores.Add(NuevoProveedor);
                context.SaveChanges();

            }
        }
        public void AltaDetallePedido(DetallePedido detalle)
        {
            using (var context = new BaseDatos())
            {
                var NuevoDetallePedido = new DetallePedido
                {
                    Cantidad_Producto = detalle.Cantidad_Producto,
                    Precio_Producto = detalle.Precio_Producto,
                    Fecha_Pedido = detalle.Fecha_Pedido,
                    NombreProducto = detalle.NombreProducto,
                    tipo_producto = detalle.tipo_producto,
                };
                context.DetallePedidos.Add(NuevoDetallePedido);
                context.SaveChanges();
            }
        }
        public void EliminarDetallePedido(DetallePedido detalle1)
        {
            using (var context = new BaseDatos())
            {
                context.DetallePedidos.Remove(detalle1);
                context.SaveChanges();
            }
        }
        public void EliminarAdministrador(Administradores administrador2)
        {
            using (var context = new BaseDatos())
            {
                context.Administradores.Remove(administrador2);
                context.SaveChanges();
            }
        }
        public void EliminarPedido(Pedidos pedido)
        {
            using (var context = new BaseDatos())
            {
                context.Pedidos.Remove(pedido);
                context.SaveChanges();
            }
        }
        public void EliminarProducto(Productos producto)
        {
            using (var context = new BaseDatos())
            {
                context.Productos.Remove(producto);
                context.SaveChanges();
            }
        }
        public void EliminarProveedor(Proveedores proveedor)
        {
            using (var context = new BaseDatos())
            {
                context.proveedores.Remove(proveedor);
                context.SaveChanges();
            }
        }
        public void EliminarVendedor(Vendedores vendedor)
        {
            using (var context = new BaseDatos())
            {
                context.Vendedores.Remove(vendedor);
                context.SaveChanges();


            }
        }
        public void ActucalizarAdministrador(Administradores Nuevoadministrador, Administradores seleccionado)
        {
            using (var context = new BaseDatos())
            {
                Administradores ModificarAdministrador = new Administradores();

                Administradores administrador1 = new Administradores();
                //ModificarAdministrador.Id_Administrador = Nuevoadministrador.Id_Administrador;
                ModificarAdministrador.NombreAdministrador = Nuevoadministrador.NombreAdministrador;
                ModificarAdministrador.ApellidoAdministrador = Nuevoadministrador.ApellidoAdministrador;
                ModificarAdministrador.contrasenia = Nuevoadministrador.contrasenia;

                context.Administradores.Update(Nuevoadministrador);
                context.SaveChanges();

            }
        }
        public void ActucalizarPedido(Pedidos NuevoPedido, Pedidos seleccionado)
        {
            using (var context = new BaseDatos())
            {
                Pedidos ModificarPedido = new Pedidos();

                Pedidos pedido1 = new Pedidos();

                ModificarPedido.NombreVendedor = NuevoPedido.NombreVendedor;

                context.Pedidos.Update(NuevoPedido);
                context.SaveChanges(); 
            }

        }
        public void ActualizarDetallePedido(DetallePedido NuevoDetalle, DetallePedido seleccionado)
        {
            using (var context = new BaseDatos())
            {
                DetallePedido ModificarDetallePedido = new DetallePedido();

                DetallePedido detalle1 = new DetallePedido();

                ModificarDetallePedido.Cantidad_Producto = NuevoDetalle.Cantidad_Producto;
                ModificarDetallePedido.Precio_Producto = NuevoDetalle.Precio_Producto;
                ModificarDetallePedido.Fecha_Pedido = NuevoDetalle.Fecha_Pedido;
                ModificarDetallePedido.NombreProducto = NuevoDetalle.NombreProducto;
                ModificarDetallePedido.tipo_producto = NuevoDetalle.tipo_producto;

                context.DetallePedidos.Update(NuevoDetalle);
                context.SaveChanges();
            }

        }
        public void ActucalizarProducto(Productos NuevoProducto, Productos seleccionado)
        {
            using (var context = new BaseDatos())
            {
                Productos ModififcarProducto = new Productos();

                Productos producto1 = new Productos();
                //ModififcarProducto.Id = NuevoProducto.Id;
                ModififcarProducto.NombreProducto = NuevoProducto.NombreProducto;
                ModififcarProducto.stock = NuevoProducto.stock;
                ModififcarProducto.NombreProvedor = NuevoProducto.NombreProvedor;

                context.Productos.Update(NuevoProducto);
                context.SaveChanges();

            }
        }
        public void ActucalizarProveedor(Proveedores NuevoProveedor, Proveedores seleccionado)
        {
            using (var context = new BaseDatos())
            {
                Proveedores ModificarProveedor = new Proveedores();

                Proveedores proveedor1 = new Proveedores();
                ModificarProveedor.NombreProvedor = NuevoProveedor.NombreProvedor;
                ModificarProveedor.ApellidoProvedor = NuevoProveedor.ApellidoProvedor;
                ModificarProveedor.cuit = ModificarProveedor.cuit;

                context.proveedores.Update(NuevoProveedor);
                context.SaveChanges();

            }
        }
        public void ActucalizarVendedor(Vendedores NuevoVendedor, Vendedores seleccionado)
        {
            using (var context = new BaseDatos())
            {
                Vendedores ModificarVendedor = new Vendedores();

                Vendedores vendedor1 = new Vendedores();

                ModificarVendedor.NombreVendedor = NuevoVendedor.NombreVendedor;
                ModificarVendedor.ApellidoVendedor = NuevoVendedor.ApellidoVendedor;
                ModificarVendedor.contrasenia = NuevoVendedor.contrasenia;
                //numerolegajo = NuevoVendedor.numerolegajo;

                context.Vendedores.Update(NuevoVendedor);
                context.SaveChanges();
            }
        }
       // devuelve toda la lista de prod
        public List<Productos> ObtenerProducto()
        {
            using (var context = new BaseDatos())
            {
                return context.Productos.ToList();
            }
        }

    }
}