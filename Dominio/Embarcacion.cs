using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Embarcacion
    {
        private static int ultimoNumeroCodigo;
        private string nombre;
        private DateTime fechaConstruccion;
        private int tipoMotor;
        private int codigoIdentificador;

        public static int UltimoNumeroCodigo { set; get; }
        public string Nombre { get; }
        public DateTime FechaConstruccion { set; get; }
        public int TipoMotor { set; get; }
        public int CodigoIdentificador { set; get; }

        public Embarcacion()
        {
            DateTime unaFechaConstruccion = new DateTime(1, 1, 1);
            this.Nombre = "Sin nombre";
            this.FechaConstruccion = unaFechaConstruccion;
            this.TipoMotor = 0;
            this.CodigoIdentificador = 0;
        }

        public Embarcacion(string unNombre, DateTime unaFechaConstruccion, int unTipoMotor)
        {
            this.Nombre = unNombre;
            this.FechaConstruccion = unaFechaConstruccion;
            this.TipoMotor = unTipoMotor;
            this.CodigoIdentificador = crearCodigoIdentificador();
        }

        public override string ToString()
        {
            string tipoDeMotor;
            if(this.TipoMotor == 0)
            {
                tipoDeMotor = "Integrado";
            }else if(this.TipoMotor == 1)
            {
                tipoDeMotor = "Fuera de borda";
            }else if(this.TipoMotor == 2)
            {
                tipoDeMotor = "Otros";
            }

            string infoEmbarcacion = "Nombre: " + this.Nombre + "\nCodigo identificador: " + this.CodigoIdentificador + "\nFecha de construccion: " + this.FechaConstruccion + "\nTipo de motor: " + TipoMotor;
           
            return infoEmbarcacion;
        }

        public int crearCodigoIdentificador()
        {
            return UltimoNumeroCodigo++;
        }

        public override bool Equals(object obj)
        {
            Embarcacion unaEmbarcacion = obj as Embarcacion;
            return unaEmbarcacion.CodigoIdentificador == this.CodigoIdentificador;
        }
    }
}
    