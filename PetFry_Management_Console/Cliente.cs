using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry_Management_Console
{
    public class Cliente
    {
        private string _documento;
        private string _nombre;
        private string _telefono;
        private string _direccion;
        private string _correo;

        public string Documento { get => _documento; set => _documento = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Correo { get => _correo; set => _correo = value; }

        public Cliente(string documento, string nombre, string telefono, string direccion, string correo)
        {
            Documento = documento;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Correo = correo;
        }

        public Cliente(string documento, string nombre)
        {
            Documento = documento;
            Nombre = nombre;
            Telefono = "";
            Direccion = "";
            Correo = "";
        }

        public Cliente(string documento)
        {
            Documento = documento;
            Nombre = "";
            Telefono = "";
            Direccion = "";
            Correo = "";
        }
    }
}
