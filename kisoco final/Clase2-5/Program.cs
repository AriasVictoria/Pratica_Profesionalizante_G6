using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bibloteca;
using LogicaClase;

namespace Proyecto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Principal principal = new Principal();

            {
                Vendedor vendedoragregado = new Vendedor();
                Console.WriteLine("agrega tu id ");
                vendedoragregado.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("arranca por el nombre");
                vendedoragregado.Nombre_vendedor = Console.ReadLine();

                principal.altavendedor(vendedoragregado.Id, vendedoragregado.Nombre_vendedor);
            }

            {
                Producto Productoagregado = new Producto();
                Console.WriteLine("agregar un producto");

                Console.WriteLine("arranca por el id");
                Productoagregado.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("agregar el nombre");
                Productoagregado.nombrep = Console.ReadLine();

                Console.WriteLine("agregar el precio");
                Productoagregado.precio_producto = int.Parse(Console.ReadLine());

                Console.WriteLine("agregar el codigo de barra");
                Productoagregado.codigo_barra = Console.ReadLine();

                Console.WriteLine("Mostrame el stock del producto");
                Productoagregado.stock = int.Parse(Console.ReadLine());

                principal.altaproducto(Productoagregado.Id, Productoagregado.nombrep, 
                    Productoagregado.precio_producto, Productoagregado.codigo_barra, Productoagregado.stock, Productoagregado.tipo_producto);
            }

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

            {
                Pedido Pedidoagregado = new Pedido();
                Console.WriteLine("crea tu carrito");

                Console.WriteLine("este es tu pedido");
                Pedidoagregado.lpedido = Console.ReadLine();

                Console.WriteLine("este es el monto final");
                Pedidoagregado.final = int.Parse(Console.ReadLine());

                principal.altapedido(Pedidoagregado.final, Pedidoagregado.lpedido);
            }
            
            Pedido  mipedido = new Pedido();
            mipedido.cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine(mipedido.cantidad);
            mipedido.final = int.Parse(Console.ReadLine()); 
            Console.WriteLine(mipedido.final);

            Console.ReadLine();
            Console.WriteLine("el monto final a pagar es: " + mipedido.calcularMonto());

            Vendedor mivendedor = new Vendedor();
            mivendedor.Id = mipedido.Id;
            Console.WriteLine(mivendedor.Id);
            mivendedor.Nombre_vendedor = mivendedor.Nombre_vendedor;

            Console.ReadLine();
            Console.WriteLine("tu usuario es correcto " + mivendedor.validar());

        }
    }
}
