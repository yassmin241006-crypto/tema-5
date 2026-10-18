using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subtema_5._1_y_5._2
{
    internal class Program
    {
        static string nombreArchivo = "Productos.txt";//variable de clase
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("======Menu======");
                Console.WriteLine("[1] Agregar nuevo producto");
                Console.WriteLine("[2] Generar reporte");
                Console.WriteLine("[3] Mostrar ultimo producto registrado");
                Console.WriteLine("[4] Salir");
                Console.Write("-->Elija una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        agregarNuevoProducto();
                        break;
                    case 2:
                        GenerarReporte();
                        break;
                    case 3:
                        ultimoproducto();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo....");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Pruebe de nuevo.");
                        break;
                }
                Console.ReadKey();
            } while (opcion != 4);
        }
        static void agregarNuevoProducto()
        {
            //streamwriter 
            //crear y abrir el documento de texto
            StreamWriter nuevoDocumento = new StreamWriter(nombreArchivo, true);//true para agregar nuevos datos
            //agregar un nuevo dato al documento de texto creado
            Console.Write("Ingrese el nombre del producto a registrar: ");
            string producto = Console.ReadLine();
            nuevoDocumento.WriteLine(producto);
            //IMPORTANTE!!! CERRAR para guardar los cambios en el documento
            nuevoDocumento.Close();
        }
        static void GenerarReporte()
        {
            //StreamReader es para leer o editar un archivo de texto
            StreamReader leerdocumento = new StreamReader(nombreArchivo);// o: StreamReader("Productos.txt");
            //leerdocumento guarda los productos que se ha escrito
            int contador = 0;
            string linea;
            while ((linea = leerdocumento.ReadLine()) != null) //repetir y recorrer la lista aunque no exista un producto que leer; null significa vacio
            {
                contador++;
                Console.WriteLine("Producto: " + linea);
            }
            Console.WriteLine("El total de productos en el almacen es: " + contador);
            leerdocumento.Close();
        }
        static void ultimoproducto()
        {
            StreamReader leerdocumento = new StreamReader(nombreArchivo);
            string productofinal = " ";
            string ultimaposicion;
            while ((ultimaposicion = leerdocumento.ReadLine()) != null) //repetir y recorrer la lista aunque no exista un producto que leer; null significa vacio
            {
                productofinal = ultimaposicion;
            }
            Console.WriteLine("El ultimo producto agregado es: " + productofinal);
            leerdocumento.Close();
        }
    }
}
