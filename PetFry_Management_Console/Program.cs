using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry_Management_Console
{
    internal class Program
    {
        static void Menu(Veterinaria veterinaria)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("=== MENÚ PRINCIPAL ===");
                Console.WriteLine();
                Console.WriteLine("[1] Clientes");
                Console.WriteLine("[2] Mascotas");
                Console.WriteLine("[3] Productos");
                Console.WriteLine("[4] Servicios");
                Console.WriteLine("[5] Órdenes");
                Console.WriteLine("[0] Salir");
                Console.WriteLine();

                Console.Write("Ingresa el número que corresponda con la opción seleccionada: ");
                string opcionRead = Console.ReadLine();
                int opcion = -1;
                if (Int32.TryParse(opcionRead, out _))
                {
                    opcion = Int32.Parse(opcionRead);
                }

                if (opcion == 1)
                {
                    MenuClientes(veterinaria);
                }
                else if (opcion == 2)
                {
                    MenuMascotas(veterinaria);
                }
                else if (opcion == 3)
                {
                    MenuProductos(veterinaria);
                }
                else if (opcion == 4)
                {
                    MenuServicios(veterinaria);
                }
                else if (opcion == 5)
                {
                    MenuOrdenes(veterinaria);
                }
                else if (opcion == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("[!] Por favor, elija una opción correcta.");
                }
            }
        }

        static void MenuClientes(Veterinaria veterinaria)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("=== MENÚ CLIENTES ===");
                Console.WriteLine("[1] Lista de clientes");
                Console.WriteLine("[2] Agregar cliente");
                Console.WriteLine("[0] Menú principal");
                Console.WriteLine();

                Console.Write("Ingresa el número que corresponda con la opción seleccionada: ");
                string opcionRead = Console.ReadLine();
                int opcion = -1;
                if (Int32.TryParse(opcionRead, out _))
                {
                    opcion = Int32.Parse(opcionRead);
                }

                if (opcion == 1)
                {
                    while (true)
                    {
                        ListaClientes(veterinaria.Clientes);
                        Console.Write("Ingresa el número del Id del cliente (0: Menú clientes): ");
                        string clienteRead = Console.ReadLine();
                        int idCliente = -1;
                        if (Int32.TryParse(clienteRead, out _))
                        {
                            idCliente = Int32.Parse(clienteRead);
                        }
                        idCliente--;

                        if (idCliente <= -2)
                        {
                            Console.WriteLine("[!] Por favor, elija una opción correcta.");
                        }
                        else if (idCliente == -1)
                        {
                            break;
                        }
                        else if (veterinaria.Clientes.Count > idCliente)
                        {
                            while (true)
                            {
                                Cliente cliente = veterinaria.Clientes[idCliente];
                                Console.WriteLine();
                                Console.WriteLine($"=== CLIENTE #{idCliente + 1} ===");
                                Console.Write($"[(1) Documento: {cliente.Documento}] ");
                                Console.Write($"[(2) Nombre: {cliente.Nombre}] ");
                                Console.Write($"[(3) Teléfono: {cliente.Telefono}] ");
                                Console.Write($"[(4) Dirección: {cliente.Direccion}] ");
                                Console.Write($"[(5) Correo: {cliente.Correo}]\n");

                                Console.WriteLine();
                                Console.Write("Ingresa el número que corresponda con el atributo a editar (0: Lista de clientes) (*: Eliminar cliente): ");
                                string atributoRead = Console.ReadLine();
                                int atributo = -1;
                                if (Int32.TryParse(atributoRead, out _))
                                {
                                    atributo = Int32.Parse(atributoRead);
                                }

                                if (atributoRead == "*")
                                {
                                    veterinaria.EliminarCliente(cliente);
                                    Console.WriteLine("[!] Cliente eliminado correctamente.");
                                    break;
                                }
                                else if (atributo == 0)
                                {
                                    break;
                                }
                                else if (atributo == 1)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa el nuevo número de documento: ");
                                    string nuevoDocumento = Console.ReadLine();

                                    veterinaria.Clientes[idCliente].Documento = nuevoDocumento;
                                    Console.WriteLine("[!] Documento actualizado correctamente.");
                                }
                                else if (atributo == 2)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa el nuevo nombre: ");
                                    string nuevoNombre = Console.ReadLine();

                                    veterinaria.Clientes[idCliente].Nombre = nuevoNombre;
                                    Console.WriteLine("[!] Nombre actualizado correctamente.");
                                }
                                else if (atributo == 3)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa el nuevo número de teléfono: ");
                                    string nuevoTelefono = Console.ReadLine();

                                    veterinaria.Clientes[idCliente].Telefono = nuevoTelefono;
                                    Console.WriteLine("[!] Teléfono actualizado correctamente.");
                                }
                                else if (atributo == 4)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa la nueva dirección: ");
                                    string nuevaDireccion = Console.ReadLine();

                                    veterinaria.Clientes[idCliente].Direccion = nuevaDireccion;
                                    Console.WriteLine("[!] Dirección actualizada correctamente.");
                                }
                                else if (atributo == 5)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa el nuevo correo electrónico: ");
                                    string nuevoCorreo = Console.ReadLine();

                                    veterinaria.Clientes[idCliente].Correo = nuevoCorreo;
                                    Console.WriteLine("[!] Correo electrónico actualizado correctamente."); ;
                                }
                                else
                                {
                                    Console.WriteLine("[!] Por favor, elija una opción correcta.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("[!] Cliente no encontrado.");
                        }
                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("=== AGREGAR CLIENTE ===");
                    Console.Write("Ingresa el número de documento: ");
                    string documento = Console.ReadLine();
                    Console.Write("Ingresa el nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingresa el teléfono: ");
                    string telefono = Console.ReadLine();
                    Console.Write("Ingresa la dirección: ");
                    string direccion = Console.ReadLine();
                    Console.Write("Ingresa el correo electrónico: ");
                    string correo = Console.ReadLine();

                    Console.WriteLine();
                    veterinaria.AgregarCliente(new Cliente(documento, nombre, telefono, direccion, correo));
                    Console.WriteLine("[!] Cliente agregado correctamente.");
                }
                else if (opcion == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("[!] Por favor, elija una opción correcta.");
                }
            }
        }

        static void MenuMascotas(Veterinaria veterinaria)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("=== MENÚ MASCOTAS ===");
                Console.WriteLine("[1] Lista de mascotas");
                Console.WriteLine("[2] Agregar mascota");
                Console.WriteLine("[0] Menú principal");
                Console.WriteLine();

                Console.Write("Ingresa el número que corresponda con la opción seleccionada: ");
                string opcionRead = Console.ReadLine();
                int opcion = -1;
                if (Int32.TryParse(opcionRead, out _))
                {
                    opcion = Int32.Parse(opcionRead);
                }

                if (opcion == 1)
                {
                    while (true)
                    {
                        ListaMascotas(veterinaria.Mascotas);
                        Console.Write("Ingresa el número del Id de la mascota (0: Menú mascotas): ");
                        string clienteRead = Console.ReadLine();
                        int idMascota = -1;
                        if (Int32.TryParse(clienteRead, out _))
                        {
                            idMascota = Int32.Parse(clienteRead);
                        }
                        idMascota--;

                        if (idMascota <= -2)
                        {
                            Console.WriteLine("[!] Por favor, elija una opción correcta.");
                        }
                        else if (idMascota == -1)
                        {
                            break;
                        }
                        else if (veterinaria.Mascotas.Count > idMascota)
                        {
                            while (true)
                            {
                                Mascota mascota = veterinaria.Mascotas[idMascota];
                                Console.WriteLine();
                                Console.WriteLine($"=== MASCOTA #{idMascota + 1} ===");
                                Console.Write($"[(1) Nombre: {mascota.Nombre}] ");
                                Console.Write($"[(2) Propietario: {mascota.Propietario.Nombre}] ");
                                Console.Write($"[(3) Animal: {mascota.Animal}] ");
                                Console.Write($"[(4) Raza: {mascota.Raza}] ");
                                Console.Write($"[(5) Peso: {mascota.Peso}] ");
                                Console.Write($"[(6) Color: {mascota.Color}] ");
                                Console.Write($"[(7) Notas: {mascota.Notas}]\n");

                                Console.WriteLine();
                                Console.Write("Ingresa el número que corresponda con el atributo a editar (0: Lista de mascotas) (*: Eliminar mascota): ");
                                string atributoRead = Console.ReadLine();
                                int atributo = -1;
                                if (Int32.TryParse(atributoRead, out _))
                                {
                                    atributo = Int32.Parse(atributoRead);
                                }

                                if (atributoRead == "*")
                                {
                                    veterinaria.EliminarMascota(mascota);
                                    Console.WriteLine("[!] Mascota eliminada correctamente.");
                                    break;
                                }
                                else if (atributo == 0)
                                {
                                    break;
                                }
                                else if (atributo == 1)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa el nuevo nombre: ");
                                    string nuevoNombre = Console.ReadLine();

                                    veterinaria.Mascotas[idMascota].Nombre = nuevoNombre;
                                    Console.WriteLine("[!] Nombre actualizado correctamente.");
                                }
                                else if (atributo == 2)
                                {
                                    while (true)
                                    {
                                        ListaClientes(veterinaria.Clientes);
                                        Console.Write("Ingresa el Id del nuevo propietario: ");
                                        string nuevoPropietarioRead = Console.ReadLine();
                                        int nuevoPropietarioId = 0;
                                        if (Int32.TryParse(nuevoPropietarioRead, out _))
                                        {
                                            nuevoPropietarioId = Int32.Parse(nuevoPropietarioRead);
                                        }
                                        nuevoPropietarioId--;

                                        if (nuevoPropietarioId == -1)
                                        {
                                            Console.WriteLine("[!] Por favor, elija una opción correcta.");
                                        }
                                        else if (veterinaria.Clientes.Count > nuevoPropietarioId)
                                        {
                                            veterinaria.Mascotas[idMascota].Propietario = veterinaria.Clientes[nuevoPropietarioId];
                                            Console.WriteLine("[!] Propietario actualizado correctamente.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("[!] Cliente no encontrado.");
                                        }
                                    }
                                }
                                else if (atributo == 3)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa el nuevo tipo de animal: ");
                                    string nuevoAnimal = Console.ReadLine();

                                    veterinaria.Mascotas[idMascota].Animal = nuevoAnimal;
                                    Console.WriteLine("[!] Tipo de animal actualizado correctamente.");
                                }
                                else if (atributo == 4)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa la nueva raza: ");
                                    string nuevaRaza = Console.ReadLine();

                                    veterinaria.Mascotas[idMascota].Raza = nuevaRaza;
                                    Console.WriteLine("[!] Raza actualizada correctamente.");
                                }
                                else if (atributo == 5)
                                {
                                    while (true)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Ingresa el nuevo peso (en kilogramos): ");
                                        string nuevoPesoRead = Console.ReadLine();
                                        double nuevoPeso = 0;
                                        if (Double.TryParse(nuevoPesoRead, out _))
                                        {
                                            nuevoPeso = Double.Parse(nuevoPesoRead.Replace(".", ","));
                                        }

                                        if (nuevoPeso <= 0)
                                        {
                                            Console.WriteLine("[!] Por favor, ingresa un valor correcto.");
                                        }
                                        else
                                        {
                                            veterinaria.Mascotas[idMascota].Peso = nuevoPeso;
                                            Console.WriteLine("[!] Peso actualizado correctamente.");
                                            break;
                                        }
                                    }
                                }
                                else if (atributo == 6)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa el nuevo color: ");
                                    string nuevoColor = Console.ReadLine();

                                    veterinaria.Mascotas[idMascota].Color = nuevoColor;
                                    Console.WriteLine("[!] Color actualizado correctamente.");
                                }
                                else if (atributo == 7)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa las nuevas notas: ");
                                    string nuevasNotas = Console.ReadLine();

                                    veterinaria.Mascotas[idMascota].Notas = nuevasNotas;
                                    Console.WriteLine("[!] Notas actualizadas correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("[!] Por favor, elija una opción correcta.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("[!] Mascota no encontrada.");
                        }
                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("=== AGREGAR MASCOTA ===");
                    Console.Write("Ingresa el nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingresa el propietario: ");
                    Cliente propietario = null;
                    while (true)
                    {
                        ListaClientes(veterinaria.Clientes);
                        Console.Write("Ingresa el Id del propietario (si no existe, debe agregarlo): ");
                        string propietarioRead = Console.ReadLine();
                        int propietarioId = 0;
                        if (Int32.TryParse(propietarioRead, out _))
                        {
                            propietarioId = Int32.Parse(propietarioRead);
                        }
                        propietarioId--;

                        if (propietarioId == -1)
                        {
                            Console.WriteLine("[!] Por favor, elija una opción correcta.");
                        }
                        else if (veterinaria.Clientes.Count > propietarioId)
                        {
                            propietario = veterinaria.Clientes[propietarioId];
                            break;
                        }
                        else
                        {
                            Console.WriteLine("[!] Cliente no encontrado.");
                        }
                    }
                    Console.Write("Ingresa el tipo de animal: ");
                    string animal = Console.ReadLine();
                    Console.Write("Ingresa la raza: ");
                    string raza = Console.ReadLine();
                    double peso = 0;
                    while (true)
                    {
                        Console.Write("Ingresa el peso (en kilogramos): ");
                        string pesoRead = Console.ReadLine();
                        if (Double.TryParse(pesoRead, out _))
                        {
                            peso = Double.Parse(pesoRead.Replace(".", ","));
                        }

                        if (peso <= 0)
                        {
                            Console.WriteLine("[!] Por favor, ingresa un valor correcto.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.Write("Ingresa el color: ");
                    string color = Console.ReadLine();
                    Console.Write("Ingresa las notas: ");
                    string notas = Console.ReadLine();

                    Console.WriteLine();
                    veterinaria.AgregarMascota(new Mascota(nombre, propietario, animal, raza, peso, color, notas));
                    Console.WriteLine("[!] Mascota agregada correctamente.");
                }
                else if (opcion == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("[!] Por favor, elija una opción correcta.");
                }
            }
        }

        static void MenuProductos(Veterinaria veterinaria)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("=== MENÚ PRODUCTOS ===");
                Console.WriteLine("[1] Lista de productos");
                Console.WriteLine("[2] Agregar producto");
                Console.WriteLine("[0] Menú principal");
                Console.WriteLine();

                Console.Write("Ingresa el número que corresponda con la opción seleccionada: ");
                string opcionRead = Console.ReadLine();
                int opcion = -1;
                if (Int32.TryParse(opcionRead, out _))
                {
                    opcion = Int32.Parse(opcionRead);
                }

                if (opcion == 1)
                {
                    while (true)
                    {
                        ListaProductos(veterinaria.Productos);
                        Console.Write("Ingresa el número del Id del producto (0: Menú productos): ");
                        string productoRead = Console.ReadLine();
                        int idProducto = -1;
                        if (Int32.TryParse(productoRead, out _))
                        {
                            idProducto = Int32.Parse(productoRead);
                        }
                        idProducto--;

                        if (idProducto <= -2)
                        {
                            Console.WriteLine("[!] Por favor, elija una opción correcta.");
                        }
                        else if (idProducto == -1)
                        {
                            break;
                        }
                        else if (veterinaria.Productos.Count > idProducto)
                        {
                            while (true)
                            {
                                Producto producto = veterinaria.Productos[idProducto];
                                Console.WriteLine();
                                Console.WriteLine($"=== PRODUCTO #{idProducto + 1} ===");
                                Console.Write($"[(1) Nombre: {producto.Nombre}] ");
                                Console.Write($"[(2) Valor: {producto.Valor}] ");
                                Console.Write($"[(3) Notas: {producto.Notas}]\n");

                                Console.WriteLine();
                                Console.Write("Ingresa el número que corresponda con el atributo a editar (0: Lista de productos) (*: Eliminar producto): ");
                                string atributoRead = Console.ReadLine();
                                int atributo = -1;
                                if (Int32.TryParse(atributoRead, out _))
                                {
                                    atributo = Int32.Parse(atributoRead);
                                }

                                if (atributoRead == "*")
                                {
                                    veterinaria.EliminarProducto(producto);
                                    Console.WriteLine("[!] Producto eliminado correctamente.");
                                    break;
                                }
                                else if (atributo == 0)
                                {
                                    break;
                                }
                                else if (atributo == 1)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa el nuevo nombre: ");
                                    string nuevoNombre = Console.ReadLine();

                                    veterinaria.Productos[idProducto].Nombre = nuevoNombre;
                                    Console.WriteLine("[!] Nombre actualizado correctamente.");
                                }
                                else if (atributo == 2)
                                {
                                    while (true)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Ingresa el nuevo valor: ");
                                        string nuevoValorRead = Console.ReadLine();
                                        int nuevoValor = -1;
                                        if (Int32.TryParse(nuevoValorRead, out _))
                                        {
                                            nuevoValor = Int32.Parse(nuevoValorRead);
                                        }

                                        if (nuevoValor < 0)
                                        {
                                            Console.WriteLine("[!] Por favor, ingresa un valor correcto.");
                                        }
                                        else
                                        {
                                            veterinaria.Productos[idProducto].Valor = nuevoValor;
                                            Console.WriteLine("[!] Valor actualizado correctamente.");
                                            break;
                                        }
                                    }
                                }
                                else if (atributo == 3)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa las nuevas notas: ");
                                    string nuevasNotas = Console.ReadLine();

                                    veterinaria.Productos[idProducto].Notas = nuevasNotas;
                                    Console.WriteLine("[!] Notas actualizadas correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("[!] Por favor, elija una opción correcta.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("[!] Producto no encontrado.");
                        }
                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("=== AGREGAR PRODUCTO ===");
                    Console.Write("Ingresa el nombre: ");
                    string nombre = Console.ReadLine();
                    int valor = -1;
                    while (true)
                    {
                        Console.Write("Ingresa el valor: ");
                        string valorRead = Console.ReadLine();
                        if (Int32.TryParse(valorRead, out _))
                        {
                            valor = Int32.Parse(valorRead);
                        }

                        if (valor < 0)
                        {
                            Console.WriteLine("[!] Por favor, ingresa un valor correcto.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.Write("Ingresa las notas: ");
                    string notas = Console.ReadLine();

                    Console.WriteLine();
                    veterinaria.AgregarProducto(new Producto(nombre, valor, notas));
                    Console.WriteLine("[!] Producto agregado correctamente.");
                }
                else if (opcion == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("[!] Por favor, elija una opción correcta.");
                }
            }
        }

        static void MenuServicios(Veterinaria veterinaria)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("=== MENÚ SERVICIOS ===");
                Console.WriteLine("[1] Lista de servicios");
                Console.WriteLine("[2] Agregar servicio");
                Console.WriteLine("[0] Menú principal");
                Console.WriteLine();

                Console.Write("Ingresa el número que corresponda con la opción seleccionada: ");
                string opcionRead = Console.ReadLine();
                int opcion = -1;
                if (Int32.TryParse(opcionRead, out _))
                {
                    opcion = Int32.Parse(opcionRead);
                }

                if (opcion == 1)
                {
                    while (true)
                    {
                        ListaServicios(veterinaria.Servicios);
                        Console.Write("Ingresa el número del Id del servicio (0: Menú servicios): ");
                        string servicioRead = Console.ReadLine();
                        int idServicio = -1;
                        if (Int32.TryParse(servicioRead, out _))
                        {
                            idServicio = Int32.Parse(servicioRead);
                        }
                        idServicio--;

                        if (idServicio <= -2)
                        {
                            Console.WriteLine("[!] Por favor, elija una opción correcta.");
                        }
                        else if (idServicio == -1)
                        {
                            break;
                        }
                        else if (veterinaria.Servicios.Count > idServicio)
                        {
                            while (true)
                            {
                                Servicio servicio = veterinaria.Servicios[idServicio];
                                Console.WriteLine();
                                Console.WriteLine($"=== PRODUCTO #{idServicio + 1} ===");
                                Console.Write($"[(1) Nombre: {servicio.Nombre}] ");
                                Console.Write($"[(2) Valor: {servicio.Valor}] ");
                                Console.Write($"[(3) Notas: {servicio.Notas}]\n");

                                Console.WriteLine();
                                Console.Write("Ingresa el número que corresponda con el atributo a editar (0: Lista de productos) (*: Eliminar producto): ");
                                string atributoRead = Console.ReadLine();
                                int atributo = -1;
                                if (Int32.TryParse(atributoRead, out _))
                                {
                                    atributo = Int32.Parse(atributoRead);
                                }

                                if (atributoRead == "*")
                                {
                                    veterinaria.EliminarServicio(servicio);
                                    Console.WriteLine("[!] Servicio eliminado correctamente.");
                                    break;
                                }
                                else if (atributo == 0)
                                {
                                    break;
                                }
                                else if (atributo == 1)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa el nuevo nombre: ");
                                    string nuevoNombre = Console.ReadLine();

                                    veterinaria.Servicios[idServicio].Nombre = nuevoNombre;
                                    Console.WriteLine("[!] Nombre actualizado correctamente.");
                                }
                                else if (atributo == 2)
                                {
                                    while (true)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Ingresa el nuevo valor: ");
                                        string nuevoValorRead = Console.ReadLine();
                                        int nuevoValor = -1;
                                        if (Int32.TryParse(nuevoValorRead, out _))
                                        {
                                            nuevoValor = Int32.Parse(nuevoValorRead);
                                        }

                                        if (nuevoValor < 0)
                                        {
                                            Console.WriteLine("[!] Por favor, ingresa un valor correcto.");
                                        }
                                        else
                                        {
                                            veterinaria.Servicios[idServicio].Valor = nuevoValor;
                                            Console.WriteLine("[!] Valor actualizado correctamente.");
                                            break;
                                        }
                                    }
                                }
                                else if (atributo == 3)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingresa las nuevas notas: ");
                                    string nuevasNotas = Console.ReadLine();

                                    veterinaria.Servicios[idServicio].Notas = nuevasNotas;
                                    Console.WriteLine("[!] Notas actualizadas correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("[!] Por favor, elija una opción correcta.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("[!] Servicio no encontrado.");
                        }
                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("=== AGREGAR SERVICIO ===");
                    Console.Write("Ingresa el nombre: ");
                    string nombre = Console.ReadLine();
                    int valor = -1;
                    while (true)
                    {
                        Console.Write("Ingresa el valor: ");
                        string valorRead = Console.ReadLine();
                        if (Int32.TryParse(valorRead, out _))
                        {
                            valor = Int32.Parse(valorRead);
                        }

                        if (valor < 0)
                        {
                            Console.WriteLine("[!] Por favor, ingresa un valor correcto.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.Write("Ingresa las notas: ");
                    string notas = Console.ReadLine();

                    Console.WriteLine();
                    veterinaria.AgregarServicio(new Servicio(nombre, valor, notas));
                    Console.WriteLine("[!] Servicio agregado correctamente.");
                }
                else if (opcion == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("[!] Por favor, elija una opción correcta.");
                }
            }
        }

        static void MenuOrdenes(Veterinaria veterinaria)
        {
            Console.WriteLine();

            Console.WriteLine();
        }

        static void ListaClientes(List<Cliente> clientes)
        {
            Console.WriteLine();
            Console.WriteLine("=== LISTA DE CLIENTES ===");
            foreach (var cliente in clientes)
            {
                Console.Write($"[Id: {clientes.IndexOf(cliente) + 1}] ");
                Console.Write($"[Documento: {cliente.Documento}] ");
                Console.Write($"[Nombre: {cliente.Nombre}] ");
                Console.Write($"[Teléfono: {cliente.Telefono}] ");
                Console.Write($"[Dirección: {cliente.Direccion}] ");
                Console.Write($"[Correo: {cliente.Correo}]\n");
            }
            Console.WriteLine();
        }

        static void ListaMascotas(List<Mascota> mascotas)
        {
            Console.WriteLine();
            Console.WriteLine("=== LISTA DE MASCOTAS ===");
            foreach (var mascota in mascotas)
            {
                Console.Write($"[Id: {mascotas.IndexOf(mascota) + 1}] ");
                Console.Write($"[Nombre: {mascota.Nombre}] ");
                Console.Write($"[Propietario: {mascota.Propietario.Nombre}] ");
                Console.Write($"[Animal: {mascota.Animal}] ");
                Console.Write($"[Raza: {mascota.Raza}] ");
                Console.Write($"[Peso: {mascota.Peso}] ");
                Console.Write($"[Color: {mascota.Color}] ");
                Console.Write($"[Notas: {mascota.Notas}]\n");
            }
            Console.WriteLine();
        }

        static void ListaProductos(List<Producto> productos)
        {
            Console.WriteLine();
            Console.WriteLine("=== LISTA DE PRODUCTOS ===");
            foreach (var producto in productos)
            {
                Console.Write($"[Id: {productos.IndexOf(producto) + 1}] ");
                Console.Write($"[Nombre: {producto.Nombre}] ");
                Console.Write($"[Valor: {producto.Valor}] ");
                Console.Write($"[Notas: {producto.Notas}]\n");
            }
            Console.WriteLine();
        }

        static void ListaServicios(List<Servicio> servicios)
        {
            Console.WriteLine();
            Console.WriteLine("=== LISTA DE SERVICIOS ===");
            foreach (var servicio in servicios)
            {
                Console.Write($"[Id: {servicios.IndexOf(servicio) + 1}] ");
                Console.Write($"[Nombre: {servicio.Nombre}] ");
                Console.Write($"[Valor: {servicio.Valor}] ");
                Console.Write($"[Notas: {servicio.Notas}]\n");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Veterinaria PetFry = new Veterinaria("PetFry", "Cl 20 #43-95", "406 3710", "contacto@petfry.com");
            Cliente alejandro = new Cliente("1001025610", "Alejandro Córdoba Ríos");
            Cliente andres = new Cliente("100", "Andrés Marín Escobar");
            PetFry.AgregarCliente(alejandro);
            PetFry.AgregarCliente(andres);

            Menu(PetFry);
        }
    }
}