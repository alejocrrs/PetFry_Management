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
        private List<Persona> _personas;
        private List<Mascota> _mascotas;
        private List<Articulo> _articulos;
        private List<Orden> _ordenes;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public List<Persona> Personas { get => _personas; set => _personas = value; }
        public List<Mascota> Mascotas { get => _mascotas; set => _mascotas = value; }
        public List<Articulo> Articulos { get => _articulos; set => _articulos = value; }
        public List<Orden> Ordenes { get => _ordenes; set => _ordenes = value; }

        public Veterinaria(string nombre, string direccion, string telefono, string correo)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;

            Personas = new List<Persona>();
            Mascotas = new List<Mascota>();
            Articulos = new List<Articulo>();
            Ordenes = new List<Orden>();
        }

        public void AgregarPersona(Persona persona)
        {
            Personas.Add(persona);
        }

        public void EliminarPersona(Persona persona)
        {
            Personas.Remove(persona);
        }

        public void AgregarMascota(Mascota mascota)
        {
            Mascotas.Add(mascota);
        }

        public void EliminarMascota(Mascota mascota)
        {
            Mascotas.Remove(mascota);
        }

        public void AgregarArticulo(Articulo objetoCompra)
        {
            Articulos.Add(objetoCompra);
        }

        public void EliminarArticulo(Articulo objetoCompra)
        {
            Articulos.Remove(objetoCompra);
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
