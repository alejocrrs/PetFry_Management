using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry_Management_Console
{
    public abstract class Articulo
    {
        private string _nombre;
        private int _valor;
        private string _notas;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Valor { get => _valor; set => _valor = value; }
        public string Notas { get => _notas; set => _notas = value; }

        public Articulo(string nombre, int valor, string notas)
        {
            Nombre = nombre;
            Valor = valor;
            Notas = notas;
        }

        public Articulo(string nombre, int valor)
        {
            Nombre = nombre;
            Valor = valor;
            Notas = "";
        }
    }
}
