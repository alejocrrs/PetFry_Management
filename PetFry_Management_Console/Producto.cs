using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry_Management_Console
{
    public class Producto : Articulo
    {
        public Producto(string nombre, int valor) : base(nombre, valor)
        {
        }

        public Producto(string nombre, int valor, string notas) : base(nombre, valor, notas)
        {
        }
    }
}
