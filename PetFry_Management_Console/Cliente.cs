using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry_Management_Console
{
    public class Cliente : Persona
    {
        public Cliente(string documento, string clave, string nombre, string telefono, string direccion, string correo) :
            base(documento, clave, nombre, telefono, direccion, correo) { }

        public Cliente(string documento, string clave, string nombre) : base(documento, clave, nombre) { }

        public Cliente(string documento) : base(documento) { }
    }
}
