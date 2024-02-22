namespace Kiosco_Candy
{
    public class Principal
    {
        public void AltaDueño(Dueño dueño)
        {
            using (var context = new BaseDeDatos())
            {
                var NuevoDueño = new Dueño
                {
                    DNI = dueño.DNI,
                    NombreDuenio = dueño.NombreDuenio,
                    ApellidoDuenio = dueño.ApellidoDuenio,
                    Contrasenia = dueño.Contrasenia,
                };
                context.Dueños.Add(NuevoDueño);
                context.SaveChanges();
            }
        }
        public void AltaProductos(Productos producto)
        {
            using (var context = new BaseDeDatos())
            {
                var NuevoProducto = new Productos
                {
                    NombreProducto = producto.NombreProducto,
                    stock = producto.stock,
                    tipo_producto = producto.tipo_producto,
                    NombreProvedor = producto.NombreProvedor,
                };
                context.SaveChanges();
                context.Productos.Add(NuevoProducto);
            }
        }
        public void AltaProveedor(Proveedor proveedor)
        {
            using (BaseDeDatos context = new BaseDeDatos())
            {
                Proveedor NuevoProveedor = new Proveedor
                {
                    cuit = proveedor.cuit,
                    NombreProvedor = proveedor.NombreProvedor,
                    ApellidoProvedor = proveedor.ApellidoProvedor,
                };
                context.SaveChanges();

                context.Proveedor.Add(NuevoProveedor);
            }
        }
        public void AltaDetallePedido(DetallePedido detalle)
        {
            using (var context = new BaseDeDatos())
            {
                var NuevoDetallePedido = new DetallePedido
                {
                    Cantidad_Producto = detalle.Cantidad_Producto,
                    MontoFinal = detalle.MontoFinal,
                    Fecha_Pedido = detalle.Fecha_Pedido,
                    NombreProducto = detalle.NombreProducto,
                    tipo_producto = detalle.tipo_producto,
                    Precio_Producto = detalle.Precio_Producto,
                };
                context.SaveChanges();
                context.DetallePedidos.Add(NuevoDetallePedido);
            }
        }
        public void EliminarDueño(Dueño dueño)
        {
            using (var context = new BaseDeDatos())
            {
                context.Dueños.Remove(dueño);
                context.SaveChanges();
            }
        }
        public void EliminarDetallePedido(DetallePedido detalle1)
        {
            using (var context = new BaseDeDatos())
            {
                context.DetallePedidos.Remove(detalle1);
                context.SaveChanges();
            }
        }

        public void EliminarProducto(Productos producto)
        {
            using (var context = new BaseDeDatos())
            {
                context.Productos.Remove(producto);
                context.SaveChanges();
            }
        }
        public void EliminarProveedor(Proveedor proveedor)
        {
            using (var context = new BaseDeDatos())
            {
                context.Proveedor.Remove(proveedor);
                context.SaveChanges();
            }
        }
        public void ActualizarDetallePedido(DetallePedido NuevoDetalle, DetallePedido seleccionado)
        {
            using (var context = new BaseDeDatos())
            {
                DetallePedido ModificarDetallePedido = new DetallePedido();

                DetallePedido detalle1 = new DetallePedido();

                ModificarDetallePedido.Cantidad_Producto = NuevoDetalle.Cantidad_Producto;
                ModificarDetallePedido.MontoFinal = NuevoDetalle.MontoFinal;
                ModificarDetallePedido.Precio_Producto = NuevoDetalle.Precio_Producto; 
                ModificarDetallePedido.Fecha_Pedido = NuevoDetalle.Fecha_Pedido;
                ModificarDetallePedido.NombreProducto = NuevoDetalle.NombreProducto;
                ModificarDetallePedido.tipo_producto = NuevoDetalle.tipo_producto;

                context.DetallePedidos.Update(NuevoDetalle);
            }
        }
        public void ActucalizarProducto(Productos NuevoProducto, Productos seleccionado)
        {
            using (var context = new BaseDeDatos())
            {
                Productos ModififcarProducto = new Productos();

                Productos producto1 = new Productos();
                ModififcarProducto.NombreProducto = NuevoProducto.NombreProducto;
                ModififcarProducto.stock = NuevoProducto.stock;
                ModififcarProducto.NombreProvedor = NuevoProducto.NombreProvedor;

                context.Productos.Update(NuevoProducto);
                context.SaveChanges();
            }
        }
        public void ActucalizarProveedor(Proveedor NuevoProveedor, Proveedor seleccionado)
        {
            using (var context = new BaseDeDatos())
            {
                Proveedor ModificarProveedor = new Proveedor();

                Proveedor proveedor1 = new  Proveedor();
                ModificarProveedor.NombreProvedor = NuevoProveedor.NombreProvedor;
                ModificarProveedor.ApellidoProvedor = NuevoProveedor.ApellidoProvedor;
                ModificarProveedor.cuit = ModificarProveedor.cuit;

                context.Proveedor.Update(NuevoProveedor);
                context.SaveChanges();
            }
        }
        public void ActualizarDueño(Dueño NuevoDueño, Dueño seleccionado)
        {
            using (var context = new BaseDeDatos())
            {
                Dueño ModificarDueño = new Dueño();

                Dueño dueño = new Dueño();

                ModificarDueño.DNI = NuevoDueño.DNI;
                ModificarDueño.NombreDuenio = NuevoDueño.NombreDuenio;
                ModificarDueño.ApellidoDuenio = NuevoDueño.ApellidoDuenio;
                ModificarDueño.Contrasenia = NuevoDueño.Contrasenia;

                context.Dueños.Update(NuevoDueño);
            }
        }
        public List<Dueño> MostrarUsuarios()
        {
            using (var context = new BaseDeDatos())
            {
                return context.Dueños.ToList();
            }
        }
        
    }
    
}