using System.Globalization;
using System.Runtime.InteropServices.ObjectiveC;

namespace Back
{
    public class Principal
    {
        public void AltaDueño (Dueño dueño)
        {
            using (var context = new BaseDatos())
            {
                var NuevoDueño = new Dueño
                {
                    NombreDuenio = dueño.NombreDuenio,
                    ApellidoDuenio = dueño.ApellidoDuenio,
                    Contrasenia = dueño.Contrasenia,
                };
                context.Dueños.Add(NuevoDueño);
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
            }
        }
        public void EliminarDueño(Dueño dueño)
        {
            using (var context = new BaseDatos())
            {
                context.Dueños.Remove(dueño);
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
        public void ActualizarDueño(Dueño NuevoDueño, Dueño seleccionado)
        {
            using (var context = new BaseDatos())
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


        // devuelve toda la lista de pro
        //
        /*
        public List<Productos> ObtenerProducto()
        {
            using (var context = new BaseDatos())
            {
                return context.Productos.ToList();
            }
        }
        */
        public List<Dueño> MostrarDueñio()
        {
            using (var context = new BaseDatos())
            {
                var ListaDueño = context.Dueños.ToList();
                return ListaDueño;
            }
        }
    }
}