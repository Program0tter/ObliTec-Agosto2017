using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Direccion
    {
        private string calle;
        private string numeroPuerta;
        private string ciudad;

        public string Calle { set; get; }
        public string NumeroPuerta { set; get; }
        public string Ciudad { set; get; }

        public Direccion()
        {
            this.Calle = "Sin calle";
            this.NumeroPuerta = "Sin numero de puerta";
            this.Ciudad = "Sin ciudad";
        }

        public Direccion(string unaCalle, string unNumeroPuerta, string unaCiudad)
        {
            this.Calle = unaCalle;
            this.NumeroPuerta = unNumeroPuerta;
            this.Ciudad = unaCiudad;
        }

        public override string ToString()
        {
            string infoDireccion = "Calle: " + this.Calle + "\nNumero de puerta: " + this.NumeroPuerta + "\nCiudad: " + this.Ciudad;
            return infoDireccion;
        }

    }
}
