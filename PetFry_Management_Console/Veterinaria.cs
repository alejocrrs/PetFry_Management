using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry_Management_Console
{
    public class Veterinaria
    {
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _correo;
        private List<Cliente> _clientes;
        private List<Mascota> _mascotas;
        private List<Producto> _productos;
        private List<Servicio> _servicios;
        private List<Orden> _ordenes;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public List<Cliente> Clientes { get => _clientes; set => _clientes = value; }
        public List<Mascota> Mascotas { get => _mascotas; set => _mascotas = value; }
        public List<Producto> Productos { get => _productos; set => _productos = value; }
        public List<Servicio> Servicios { get => _servicios; set => _servicios = value; }
        public List<Orden> Ordenes { get => _ordenes; set => _ordenes = value; }

        public Veterinaria(string nombre, string direccion, string telefono, string correo)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;

            Clientes = new List<Cliente>();
            Mascotas = new List<Mascota>();
            Productos = new List<Producto>();
            Servicios = new List<Servicio>();
            Ordenes = new List<Orden>();
        }

        public void AgregarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void EliminarCliente(Cliente cliente)
        {
            Clientes.Remove(cliente);
        }

        public void AgregarMascota(Mascota mascota)
        {
            Mascotas.Add(mascota);
        }

        public void EliminarMascota(Mascota mascota)
        {
            Mascotas.Remove(mascota);
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void EliminarProducto(Producto producto)
        {
            Productos.Remove(producto);
        }
        public void AgregarServicio(Servicio servicio)
        {
            Servicios.Add(servicio);
        }

        public void EliminarServicio(Servicio servicio)
        {
            Servicios.Remove(servicio);
        }

        public void AgregarOrden(Orden orden)
        {
            Ordenes.Add(orden);
        }

        public void EliminarOrden(Orden orden)
        {
            Ordenes.Remove(orden);
        }
    }
}
