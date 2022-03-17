using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFry_Management_Console
{
    public class Orden
    {
        private Cliente _cliente;
        private Mascota _mascota;
        private string _tipo;
        private List<Articulo> _listaCompra;
        private int _valorTotal;
        private DateTime _fecha;
        private string _notas;

        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public Mascota Mascota { get => _mascota; set => _mascota = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public List<Articulo> ListaCompra { get => _listaCompra; set => _listaCompra = value; }
        public int ValorTotal { get => _valorTotal; set => _valorTotal = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public string Notas { get => _notas; set => _notas = value; }

        public Orden(Cliente cliente, string tipo, string notas, Mascota mascota)
        {
            Cliente = cliente;
            Mascota = mascota;
            Tipo = tipo;
            ListaCompra = new List<Articulo>();
            Notas = notas;
            ValorTotal = 0;
            Fecha = DateTime.Now;
        }

        public Orden(Cliente cliente, string tipo, Mascota mascota)
        {
            Cliente = cliente;
            Mascota = mascota;
            Tipo = tipo;
            ListaCompra = new List<Articulo>();
            Notas = "";
            ValorTotal = 0;
            Fecha = DateTime.Now;
        }

        public Orden(Cliente cliente, string tipo, string notas)
        {
            Cliente = cliente;
            Mascota = null;
            Tipo = tipo;
            ListaCompra = new List<Articulo>();
            Notas = notas;
            ValorTotal = 0;
            Fecha = DateTime.Now;
        }

        public Orden(Cliente cliente, string tipo)
        {
            Cliente = cliente;
            Mascota = null;
            Tipo = tipo;
            ListaCompra = new List<Articulo>();
            Notas = "";
            ValorTotal = 0;
            Fecha = DateTime.Now;
        }

        public void AgregarArticulo(Articulo articulo)
        {
            if ((Tipo == "Producto" & articulo is Producto) | (Tipo == "Servicio" & articulo is Servicio))
            {
                ListaCompra.Add(articulo);
                ValorTotal = CalcularValor(ListaCompra);
            }
            else
            {
                throw new Exception("[!] Tipo de artículo no compatible con el tipo de orden.");
            }
        }

        public void EliminarArticulo(Articulo articulo)
        {
            ListaCompra.Remove(articulo);
            ValorTotal = CalcularValor(ListaCompra);
        }

        public int CalcularValor(List<Articulo> listaCompra)
        {
            int valorTotal = 0;
            foreach (var articulo in listaCompra)
            {
                valorTotal += articulo.Valor;
            }
            return valorTotal;
        }
    }
}
