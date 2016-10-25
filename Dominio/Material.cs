using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Material
    {
        private string nombreFabricante;

        public string NombreFabricante;

        public Material()
        {
            this.NombreFabricante = "Sin nombre";
        }

        public Material(string unNombre)
        {
            this.NombreFabricante = unNombre;
        }

        public override string ToString()
        {
            string infoMaterial = "Nombre del fabricante: " + this.NombreFabricante;
            return infoMaterial;
        }
        
    }
}
