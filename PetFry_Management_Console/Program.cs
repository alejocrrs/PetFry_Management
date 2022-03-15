using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry_Management_Console
{
    internal class Program
    {
        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("=== MENÚ DE OPCIONES ===");
                Console.WriteLine();
                Console.WriteLine("[1] Opciones de visualización");
                Console.WriteLine("[2] Opciones de creación");
                Console.WriteLine("[3] Opciones de edición");
                Console.WriteLine("[4] Opciones de eliminación");
                Console.WriteLine();

                Console.WriteLine("Ingresa el número que corresponda con la opción seleccionada: ");
                int opcion = Int32.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("=== OPCIONES DE VISUALIZACIÓN ===");
                    Console.WriteLine("[1] Ver lista de usuarios");
                    Console.WriteLine("    [1.1] Ver lista de clientes");
                    Console.WriteLine("    [1.2] Ver lista de prestadores");
                    Console.WriteLine("[2] Ver lista de mascotas");
                    Console.WriteLine("[3] Ver lista de artículos");
                    Console.WriteLine("    [3.1] Ver lista de productos");
                    Console.WriteLine("    [3.1] Ver lista de servicios");
                    Console.WriteLine("[4] Ver lista de órdenes");
                    Console.WriteLine("    [4.1] Ver lista de órdenes de productos");
                    Console.WriteLine("    [4.1] Ver lista de órdenes de servicios");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("=== OPCIONES DE CREACIÓN ===");
                    Console.WriteLine("[1] Agregar usuario");
                    Console.WriteLine("    [1.1] Agregar cliente");
                    Console.WriteLine("    [1.2] Agregar prestador");
                    Console.WriteLine("[2] Agregar mascota");
                    Console.WriteLine("[3] Agregar artículo");
                    Console.WriteLine("    [3.1] Agregar producto");
                    Console.WriteLine("    [3.1] Agregar servicio");
                    Console.WriteLine("[4] Agregar orden");
                    Console.WriteLine("    [4.1] Agregar orden de productos");
                    Console.WriteLine("    [4.1] Agregar orden de servicios");
                }
                else if (opcion == 3)
                {

                }
                else if (opcion == 4)
                {

                }
            }
        }

        static void Main(string[] args)
        {
            Menu();

            Prestador alejo = new Prestador("1001025610", "1234567a", "Alejandro Córdoba Ríos", "3118372792", "Cr 89 #27-42", "alejocrrs@gmail.com");

            Cliente andres = new Cliente("102");
            andres.Nombre = "Andrés Marín";

            Mascota andy = new Mascota("Andy", alejo, "Perro", "Caniche argentino", 30, "Blanco");

            Articulo producto1 = new Articulo("Producto", "Cepillo de pelo", 7500);
            Articulo producto2 = new Articulo("Producto", "Comida de perro 2kg", 9200);
            Articulo servicio1 = new Articulo("Servicio", "Cita médica general", 11000);
            Articulo servicio2 = new Articulo("Servicio", "Estelirización para gato", 55000);

            Orden orden1 = new Orden(andres, "Producto");
            orden1.AgregarArticulo(producto1);
            orden1.AgregarArticulo(producto2);

            Orden orden2 = new Orden(andres, "Servicio", andy);
            orden2.AgregarArticulo(servicio2);

            // INSTANCIAR VETERINARIA
            Veterinaria PetFry = new Veterinaria("PetFry", "Cl 20 #43-95", "406 3710", "contacto@petfry.com");
            PetFry.AgregarPersona(alejo);
            PetFry.AgregarPersona(andres);

            PetFry.AgregarMascota(andy);

            PetFry.AgregarArticulo(producto1);
            PetFry.AgregarArticulo(producto2);
            PetFry.AgregarArticulo(servicio1);
            PetFry.AgregarArticulo(servicio2);

            PetFry.AgregarOrden(orden1);
            PetFry.AgregarOrden(orden2);

            Console.WriteLine(PetFry.Ordenes[0].ValorTotal);
            
            Console.ReadKey();
        }
    }
}
