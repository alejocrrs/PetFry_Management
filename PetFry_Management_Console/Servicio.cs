using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry_Management_Console
{
    public class Servicio : Articulo
    {
        public Servicio(string nombre, int valor) : base(nombre, valor)
        {
        }

        public Servicio(string nombre, int valor, string notas) : base(nombre, valor, notas)
        {
        }
    }
}
