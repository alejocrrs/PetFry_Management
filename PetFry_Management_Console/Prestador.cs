using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry_Management_Console
{
    public class Prestador : Persona
    {
        public Prestador(string documento, string clave, string nombre, string telefono, string direccion, string correo) : 
            base(documento, clave, nombre, telefono, direccion, correo) { }
    }
}
