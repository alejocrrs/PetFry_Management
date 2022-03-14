using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry_Management_Console
{
    public abstract class Persona
    {
        private string _documento;
        private string _clave;
        private string _nombre;
        private string _telefono;
        private string _direccion;
        private string _correo;

        public string Documento { get => _documento; set => _documento = value; }
        public string Clave { get => _clave; set => _clave = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Correo { get => _correo; set => _correo = value; }

        public Persona(string documento, string clave, string nombre,string telefono, string direccion, string correo)
        {
            Documento = documento;
            Clave = clave;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Correo = correo;
        }

        public Persona(string documento, string clave, string nombre)
        {
            Documento = documento;
            Clave = clave;
            Nombre = nombre;
            Telefono = "";
            Direccion = "";
            Correo = "";
        }

        public Persona(string documento)
        {
            Documento = documento;
            Clave = "";
            Nombre = "";
            Telefono = "";
            Direccion = "";
            Correo = "";
        }
    }
}
