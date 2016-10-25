using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MaterialImportado : Material
    {
        private string paisOrigen;

        public string PaisOrigen { set; get; }

        public MaterialImportado()
        {
            this.NombreFabricante = "Sin nombre";
            this.PaisOrigen = "Sin pais";
        }

        public MaterialImportado(string unNombreFabricante, string unPaisOrigen) : base (unNombreFabricante)
        {
            this.PaisOrigen = unPaisOrigen;
        }

        public override string ToString()
        {
            return base.ToString() + "\nPais de origen: " + this.PaisOrigen;
        }
    }
}
