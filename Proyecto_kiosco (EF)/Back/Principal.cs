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
                    contraseña = administrador.contraseña,
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
                    contraseñaV = vendedor.contraseñaV,
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
                    Precio_Producto = pedido.Precio_Producto,
                    MontoFinal = pedido.MontoFinal,
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
                    Precio = producto.Precio,
                    stock = producto.stock,
                };
                context.Productos.Add(NuevoProducto);
                context.SaveChanges();

            }
        }
        public void AltaProveedor(Proveedores proveedor)
        {
            using (var context = new BaseDatos())
            {
                var NuevoProveedor = new Proveedores
                {
                    cuit = proveedor.cuit,
                    NombreProvedor = proveedor.NombreProvedor,
                    ApellidoProvedor = proveedor.ApellidoProvedor,
                };
                context.proveedores.Add(NuevoProveedor);
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
        public void ActucalizarAdministrador(Administradores Nuevoadministrador)
        {
            using (var context = new BaseDatos())
            {
                Administradores ModificarAdministrador = new Administradores();

                Administradores administrador1 = new Administradores();
                ModificarAdministrador.Id_Administrador = Nuevoadministrador.Id_Administrador;
                ModificarAdministrador.NombreAdministrador = Nuevoadministrador.NombreAdministrador;
                ModificarAdministrador.ApellidoAdministrador = Nuevoadministrador.ApellidoAdministrador;
                ModificarAdministrador.contraseña = Nuevoadministrador.contraseña;

                context.Administradores.Update(Nuevoadministrador);
            }
        }
        public void ActucalizarPedido(Pedidos NuevoPedido)
        {
            using (var context = new BaseDatos())
            {
                Pedidos ModificarPedido = new Pedidos();

                Pedidos pedido1 = new Pedidos();

                ModificarPedido.Id = NuevoPedido.Id;
                ModificarPedido.MontoFinal = NuevoPedido.MontoFinal;
                ModificarPedido.Precio_Producto = NuevoPedido.Precio_Producto;

                context.Pedidos.Update(NuevoPedido);
            }

        }
        
        public void ActucalizarProducto(Productos NuevoProducto)
        {
            using (var context = new BaseDatos())
            {
                Productos ModififcarProducto = new Productos();

                Productos producto1 = new Productos();
                ModififcarProducto.Id = NuevoProducto.Id;
                ModififcarProducto.NombreProducto = NuevoProducto.NombreProducto;
                ModififcarProducto.Precio = NuevoProducto.Precio;
                ModififcarProducto.stock = NuevoProducto.stock;

                context.Productos.Update(NuevoProducto);
            }
        }
        public void ActucalizarProveedor(Proveedores NuevoProveedor)
        {
            using (var context = new BaseDatos())
            {
                Proveedores ModificarProveedor = new Proveedores();

                Proveedores proveedor1 = new Proveedores();
                ModificarProveedor.NombreProvedor = NuevoProveedor.NombreProvedor;
                ModificarProveedor.ApellidoProvedor = NuevoProveedor.ApellidoProvedor;
                ModificarProveedor.cuit = ModificarProveedor.cuit;

                context.proveedores.Update(NuevoProveedor);
            }
        }
        public void ActucalizarVendedor(Vendedores NuevoVendedor)
        {
            using (var context = new BaseDatos())
            {
                Vendedores ModificarVendedor = new Vendedores();

                Vendedores vendedor1 = new Vendedores();
                ModificarVendedor.NombreVendedor = NuevoVendedor.NombreVendedor;
                ModificarVendedor.ApellidoVendedor = NuevoVendedor.ApellidoVendedor;
                ModificarVendedor.contraseñaV = NuevoVendedor.contraseñaV;
                ModificarVendedor.numerolegajo = NuevoVendedor.numerolegajo;

                context.Vendedores.Update(NuevoVendedor);
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
                var Proveedores = context.proveedores.ToList();
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