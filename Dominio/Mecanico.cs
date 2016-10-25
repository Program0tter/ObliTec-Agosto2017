using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mecanico
    {
        private string nombre;
        private string telefono;
        private Direccion direccionResidencia;
        private int numeroRegistro;
        private int valorJornal;
        private bool realizoCapacitacion;

        public string Nombre { set; get; }
        public string Telefono { set; get; }
        public Direccion DireccionResidencia { set; get;}
       
        public int NumeroRegistro { set; get; }

        public int ValorJornal { set; get; }

        public bool RealizoCapacitacion { set; get; }

        public Mecanico()
        {
            Direccion dirVacia = new Direccion();
            this.Nombre = "Sin nombre";
            this.Telefono = "Sin telefono";
            this.DireccionResidencia = dirVacia;
            this.NumeroRegistro = 0;
            this.ValorJornal = 0;
            this.RealizoCapacitacion = false;
        }

        public Mecanico(string unNombre, string unTelefono, Direccion unaDireccionResidencia, int unValorJornal, int unNumeroRegistro, bool seCapacitoExtra)
        {
            this.Nombre = unNombre;
            this.Telefono = unTelefono;
            this.DireccionResidencia = unaDireccionResidencia;
            this.ValorJornal = unValorJornal;
            this.RealizoCapacitacion = seCapacitoExtra;
            this.NumeroRegistro = unNumeroRegistro;
        }


        //Método que crea un objeto tipo Direccion y lo devuelve. Es necesario para la creación de un objeto tipo Mecanico y no es
        //pertinente a otras clases, por eso lo incluyo dentro de la clase Mecanico.
        public Direccion crearNuevaDireccion(string unaCalle, string unNumeroPuerta, string unaCiudad)
        {
            Direccion unaDireccion = new Direccion(unaCalle, unNumeroPuerta, unaCiudad);

            return unaDireccion;
        }


        public override string ToString()
        {
            string seCapacito;
            if(this.RealizoCapacitacion)
            {
                seCapacito = "\nEste mecanico ha realizado capacitación extra";
            }
            else
            {
                seCapacito = "\nEste mecanico ha no realizado capacitación extra";
            }
            string infoMecanico = "Nombre: " + this.Nombre + "\nTelefono: " + this.Telefono + "\nNumero de registro: " + this.NumeroRegistro + "\nDireccion: " + this.DireccionResidencia + "\nValor del jornal: " + this.ValorJornal + seCapacito;
            return infoMecanico;
        }

        
        public override bool Equals(object obj)
        {
            Mecanico unMecanico = obj as Mecanico;
            return unMecanico.NumeroRegistro == this.NumeroRegistro;
        }
    }
}
    