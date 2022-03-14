using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry_Management_Console
{
    public class Mascota
    {
        private string _nombre;
        private Persona _propietario;
        private string _animal;
        private string _raza;
        private double _peso;
        private string _color;
        private string _notas;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public Persona Propietario { get => _propietario; set => _propietario = value; }
        public string Animal { get => _animal; set => _animal = value; }
        public string Raza { get => _raza; set => _raza = value; }
        public double Peso { get => _peso; set => _peso = value; }
        public string Color { get => _color; set => _color = value; }
        public string Notas { get => _notas; set => _notas = value; }

        public Mascota(string nombre, Persona propietario, string animal, string raza, double peso, string color, 
            string notas)
        {
            Nombre = nombre;
            Propietario = propietario;
            Animal = animal;
            Raza = raza;
            Peso = peso;
            Color = color;
            Notas = notas;
        }

        public Mascota(string nombre, Persona propietario, string animal, string raza, double peso, string color)
        {
            Nombre = nombre;
            Propietario = propietario;
            Animal = animal;
            Raza = raza;
            Peso = peso;
            Color = color;
            Notas = "";
        }

        public Mascota(string nombre, Persona propietario, string animal, string raza, double peso)
        {
            Nombre = nombre;
            Propietario = propietario;
            Animal = animal;
            Raza = raza;
            Peso = peso;
            Color = "";
            Notas = "";
        }

        public Mascota(string nombre, Persona propietario, string animal, string raza)
        {
            Nombre = nombre;
            Propietario = propietario;
            Animal = animal;
            Raza = raza;
            Peso = 0;
            Color = "";
            Notas = "";
        }

        public Mascota(string nombre, Persona propietario, string animal)
        {
            Nombre = nombre;
            Propietario = propietario;
            Animal = animal;
            Raza = "";
            Peso = 0;
            Color = "";
            Notas = "";
        }
    }
}
