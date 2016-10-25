using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MaterialNacional : Material
    {
        private int cantidadAniosEnPlaza;

        public int CantidadAniosEnPlaza { set; get; }

        public MaterialNacional()
        {
            this.NombreFabricante = "Sin nombre";
            this.CantidadAniosEnPlaza = 0;
        }

        public MaterialNacional(string unNombreFabricante, int unaCantidadAniosEnPlaza) : base(unNombreFabricante)
        {
            this.NombreFabricante = unNombreFabricante;
            this.CantidadAniosEnPlaza = unaCantidadAniosEnPlaza;
        }

        public override string ToString()
        {
            return base.ToString() + "\nCantidad de años en plaza: " + this.CantidadAniosEnPlaza;
        }
        

    }
}
