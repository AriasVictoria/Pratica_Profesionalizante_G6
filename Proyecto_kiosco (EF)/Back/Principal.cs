namespace Back
{
    public class Principal
    {
        public void AltaAdministrador(Administrador administrador)
        {
            using (var context = new BaseDatos())
            {
                var NuevoAdministrador = new Administrador
                {
                    NombreAdministrador = administrador.NombreAdministrador,
                    ApellidoAdministrador = administrador.ApellidoAdministrador,
                    contraseña = administrador.contraseña

                };
                context.Administradores.Add(NuevoAdministrador);
                context.SaveChanges();
            }
        }
        public void AltaPedido(Pedido pedido)
        {
            using (var context = new BaseDatos())
            {
                var NuevoPedido = new Pedido
                {
                    MontoFinal = pedido.MontoFinal,
                    Precio_Producto = pedido.Precio_Producto,
                };
                context.Pedidos.Add(NuevoPedido);
                context.SaveChanges();
            }
        }
        public void AltaProducto(Producto producto)
        {
            using (var context = new BaseDatos())
            {
                var NuevoProducto = new Producto
                {
                    Id = producto.Id,
                    NombreProducto = producto.NombreProducto,
                    Precio = producto.Precio,
                    stock = producto.stock,
                };
                context.Productos.Add(NuevoProducto);
                context.SaveChanges();
            }
        }
        public void AltaProveedor(Proveedor proveedor)
        {
            using (var context = new BaseDatos())
            {
                var NuevoProveedor = new Proveedor
                {
                    cuit = proveedor.cuit,
                    NombreProvedor = proveedor.NombreProvedor,
                    ApellidoProvedor = proveedor.ApellidoProvedor,
                };
                context.Proveedores.Add(NuevoProveedor);
                context.SaveChanges();
            }
        }
        public void AltaVendedor(Vendedor vendedor)
        {
            using (var context = new BaseDatos())
            {
                var NuevoVendedor = new Vendedor
                {
                    numerolegajo = vendedor.numerolegajo,
                    NombreVendedor = vendedor.NombreVendedor,
                    ApellidoVendedor = vendedor.ApellidoVendedor,
                    contraseñaV = vendedor.contraseñaV,
                };
                context.Vendedores.Add(NuevoVendedor);
                context.SaveChanges();
            }
        }
        public void EliminarAdministrador(Administrador administrador)
        {
            using (var context = new BaseDatos())
            {
                var BorrarAdministrador = context.Administradores.Find(administrador.NombreAdministrador,
                    administrador.ApellidoAdministrador, administrador.contraseña);
                if(BorrarAdministrador != null)
                {
                    context.Administradores.Remove(BorrarAdministrador);
                    context.SaveChanges();
                }
            }
        }
        public void EliminarPedido(Pedido pedido)
        {
            using (var context = new BaseDatos())
            {
                var BorrarPedido = context.Administradores.Find(pedido.MontoFinal,pedido.Precio_Producto);
                if (BorrarPedido != null)
                {
                    context.Administradores.Remove(BorrarPedido);
                    context.SaveChanges();
                }
            }
        }
        public void EliminarProducto(Producto producto)
        {
            using (var context = new BaseDatos())
            {
                var BorrarProcuto = context.Productos.Find(producto.Id, producto.NombreProducto,
                    producto.Precio, producto.stock);
                if (BorrarProcuto != null)
                {
                    context.Productos.Remove(BorrarProcuto);
                    context.SaveChanges();
                }
            }
        }
        public void EliminarProveedor(Proveedor proveedor)
        {
            using (var context = new BaseDatos())
            {
                var Borrarproveedor = context.Proveedores.Find(proveedor.cuit, proveedor.NombreProvedor,
                    proveedor.ApellidoProvedor);
                if (Borrarproveedor != null)
                {
                    context.Proveedores.Remove(Borrarproveedor);
                    context.SaveChanges();
                }
            }
        }
        public void EliminarVendedor(Vendedor vendedor)
        {
            using (var context = new BaseDatos())
            {
                var BorrarVendedor = context.Vendedores.Find(vendedor.NombreVendedor,vendedor.ApellidoVendedor,
                    vendedor.contraseñaV);
                if (BorrarVendedor != null)
                {
                    context.Vendedores.Remove(BorrarVendedor);
                    context.SaveChanges();
                }
            }
        }
        public void ActucalizarAdministrador(Administrador administrador)
        {
            using (var context = new BaseDatos())
            {
                var ModificarAdmnistrador = context.Administradores.Find(administrador.NombreAdministrador,
                    administrador.ApellidoAdministrador, administrador.contraseña);
                if (ModificarAdmnistrador != null)
                {
                    context.Administradores.Remove(ModificarAdmnistrador);
                    context.SaveChanges();
                }
            }
        }
        public void ActucalizarPedido(Pedido pedido)
        {
            using (var context = new BaseDatos())
            {
                var ModificarPedido = context.Pedidos.Find(pedido.MontoFinal, pedido.Precio_Producto);
                if (ModificarPedido != null)
                {
                    context.Pedidos.Remove(ModificarPedido);
                    context.SaveChanges();
                }
            }
        }
        public void ActucalizarProducto(Producto producto)
        {
            using (var context = new BaseDatos())
            {
                var ModificarProducto = context.Productos.Find(producto.Id, producto.NombreProducto,
                    producto.Precio, producto.stock);
                if (ModificarProducto != null)
                {
                    context.Productos.Remove(ModificarProducto);
                    context.SaveChanges();
                }
            }
        }
        public void ActucalizarProveedor(Proveedor proveedor)
        {
            using (var context = new BaseDatos())
            {
                var ModificarProveedor = context.Proveedores.Find(proveedor.cuit, proveedor.NombreProvedor,
                    proveedor.ApellidoProvedor);
                if (ModificarProveedor != null)
                {
                    context.Proveedores.Remove(ModificarProveedor);
                    context.SaveChanges();
                }
            }
        }
        public void ActucalizarVendedor(Vendedor vendedor)
        {
            using (var context = new BaseDatos())
            {
                var ModificarVendedor = context.Vendedores.Find(vendedor.NombreVendedor, vendedor.ApellidoVendedor,
                    vendedor.contraseñaV);
                if (ModificarVendedor != null)
                {
                    context.Vendedores.Remove(ModificarVendedor);
                    context.SaveChanges();
                }
            }
        }
        public void ObtenerAdmnistrador()
        {
            using (var context = new BaseDatos())
            {
                var administradores = context.Administradores.ToList();
                foreach(var administrador in administradores)
                {
                    Console.WriteLine($"Nombre: {administrador.NombreAdministrador}," +
                        $"Apellido: {administrador.ApellidoAdministrador}, " +
                        $"Contraseña: {administrador.contraseña}");
                }
            }
        }
        public void ObtenerPedido()
        {
            using (var context = new BaseDatos())
            {
                var Pedidos = context.Pedidos.ToList();
                foreach (var pedido in Pedidos)
                {
                    Console.WriteLine($"Id: {pedido.MontoFinal}," +
                        $"Apellido: {pedido.Precio_Producto}");
                }
            }
        }
        public void ObtenerProducto()
        {
            using (var context = new BaseDatos())
            {
                var Productos = context.Productos.ToList();
                foreach (var producto in Productos)
                {
                    Console.WriteLine($"Id: {producto.Id}," +
                        $"Nombre: {producto.NombreProducto}, Precio: {producto.Precio}," +
                        $"Stock: {producto.stock}");
                }
            }
        }
        public void ObtenerProveedor()
        {
            using (var context = new BaseDatos())
            {
                var Proveedores = context.Proveedores.ToList();
                foreach (var proveedor in Proveedores)
                {
                    Console.WriteLine($"Id: {proveedor.cuit}," +
                        $"Nombre: {proveedor.NombreProvedor}, Apellido: {proveedor.ApellidoProvedor}");
                }
            }
        }
        public void ObtenerVendedor()
        {
            using (var context = new BaseDatos())
            {
                var Vendedores = context.Vendedores.ToList();
                foreach (var vendedor in Vendedores)
                {
                    Console.WriteLine($"Id: {vendedor.NombreVendedor}," +
                        $"Apellido: {vendedor.ApellidoVendedor}, Contraseña: {vendedor.contraseñaV}");
                }
            }
        }
    }
}