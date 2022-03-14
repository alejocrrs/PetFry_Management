using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry_Management_Console
{
    public class Articulo
    {
        private string _tipo;
        private string _nombre;
        private int _valor;
        private string _notas;

        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Valor { get => _valor; set => _valor = value; }
        public string Notas { get => _notas; set => _notas = value; }

        public Articulo(string tipo, string nombre, int valor, string notas)
        {
            Tipo = tipo;
            Nombre = nombre;
            Valor = valor;
            Notas = notas;
        }

        public Articulo(string tipo, string nombre, int valor)
        {
            Tipo = tipo;
            Nombre = nombre;
            Valor = valor;
            Notas = "";
        }
    }
}
