using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Reparacion
    {
        private DateTime fechaIngreso;
        private DateTime fechaPromesaEntrega;
        private DateTime fechaRealEntrega;
        private Embarcacion embarcacionAReparar;
        private List<Mecanico> listaMecanicos;

        public DateTime FechaIngreso { set; get; }
        public DateTime FechaPromesaEntrega { set; get; }
        public DateTime FechaRealEntrega { set; get; }
        public Embarcacion EmbarcacionAReparar { set; get; }

        public Reparacion()
        {
            DateTime unaFechaIngreso = new DateTime(0, 0, 0);
            DateTime unaFechaPromesa = new DateTime(0, 0, 0);
            DateTime unaFechaEntrega = new DateTime(0, 0, 0);
            this.FechaIngreso = unaFechaIngreso;
            this.FechaPromesaEntrega = unaFechaPromesa;
            this.FechaRealEntrega = unaFechaEntrega;
        }

        public Reparacion(DateTime unaFechaIngreso, DateTime unaFechaPromesa, Embarcacion unaEmbarcacion)
        {
            this.FechaIngreso = unaFechaIngreso;
            this.FechaPromesaEntrega = unaFechaPromesa;
            this.EmbarcacionAReparar = unaEmbarcacion;
        }

        public override string ToString()
        {
            string infoReparacion = "Codigo de la embarcacion: " + this.EmbarcacionAReparar.CodigoIdentificador + "\nFecha de ingreso al taller: " + this.FechaIngreso + "\nFecha prometida de entrega: " + this.FechaPromesaEntrega + "\nFecha de entrega al cliente: " + this.FechaRealEntrega + "\nMecanicos que trabajaron en la reparación: " + obtenerListaDeMecanicosQueTrabajaronEnReparacion(this.EmbarcacionAReparar.CodigoIdentificador);
            return infoReparacion;
        }

        public string obtenerListaDeMecanicosQueTrabajaronEnReparacion(int codigoEmbarcacion)
        {
            string mecanicos = "";
            foreach (Mecanico mec in listaMecanicos)
            {
                mecanicos += mec.NumeroRegistro + " ";
            }
            return mecanicos;
        }
    }
}
