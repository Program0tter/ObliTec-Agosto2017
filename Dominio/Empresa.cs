using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empresa
    {
        private List<Reparacion> listaReparaciones;
        private List<Mecanico> listaMecanicos;        
        private List<Embarcacion> listaEmbarcacionesFabricadas;
        private List<Material> listaMateriales;
        public Empresa()
        {
            listaReparaciones = new List<Reparacion>();
            listaMecanicos = new List<Mecanico>();
            listaMateriales= new List<Material>();
            listaEmbarcacionesFabricadas = new List<Embarcacion>();
        }

        //Metodo que recibe todos los datos necesarios para crear un objeto clase Mecanico, lo crea y lo agrega a la lista correspondiente.
        public void registrarMecanicoEnEmpresa(string unNombre, string unTelefono, Direccion unaDireccionResidencia, int unValorJornal, int unNumeroRegistro, bool seCapacitoExtra)
        {
            Mecanico unMecanico = new Mecanico(unNombre, unTelefono, unaDireccionResidencia, unValorJornal, unNumeroRegistro, seCapacitoExtra);
            listaMecanicos.Add(unMecanico);
        }

        //Metodo que recibe todos los datos necesarios para crear un objeto clase Embarcacion, lo crea y lo agrega a la lista correspondiente.
        public void registrarNuevaEmbarcacionConstruida(string unNombre, DateTime unaFechaConstruccion, int unTipoMotor)
        {
            Embarcacion unaEmbarcacion = new Embarcacion(unNombre, unaFechaConstruccion, unTipoMotor);
            listaEmbarcacionesFabricadas.Add(unaEmbarcacion);
        }

        //Metodo que recibe todos los datos necesarios para crear un objeto clase Reparacion, lo crea y lo agrega a la lista correspondiente.
        public void ingresarReparacionDeEmbarcacion(DateTime unaFechaIngreso, DateTime unaFechaPromesa, Embarcacion unaEmbarcacion)
        {
            Reparacion unaReparacion = new Reparacion(unaFechaIngreso, unaFechaPromesa, unaEmbarcacion);
            listaReparaciones.Add(unaReparacion);
        }

        //Metodo en el cual se recorre la lista de mecanicos de la empresa con un while y se buscan los mecanicos que tengan su valor 'RealizoCapacitacion' en falso. Si hay una coincidencia
        //en la busqueda, se agrega ese objeto Mecanico a una lista que se devuelve al terminar el recorrido.
        public List<Mecanico> devolverListaDeMecanicosSinCapacitacionExtra()
        {
            List<Mecanico> listaMecanicosSinCapacitacionExtra = new List<Mecanico>();
            int index = 0;
            while(index < listaMecanicos.Count())
            {
                if(!listaMecanicos[index].RealizoCapacitacion)
                {
                    listaMecanicosSinCapacitacionExtra.Add(listaMecanicos[index]);
                }
                index++;
            }
            return listaMecanicosSinCapacitacionExtra;
        }

        
        //Metodo que usa el override del metodo 'Equals' hecho en la clase Mecanico para buscar coincidencias a traves del código
        //identificador ingresado (variable int). Devuelve un booleano positivo si se encontró el código ingresado.
        public bool mecanicoExiste(int numeroRegistroMecanico)
        {
            Mecanico unMecanico = new Mecanico();
            unMecanico.NumeroRegistro = numeroRegistroMecanico;
            return listaMecanicos.Contains(unMecanico);
        }

        public bool codigoEmbarcacionExiste(int codigoEmbarcacion)
        {
            Embarcacion unaEmbarcacion = new Embarcacion();
            unaEmbarcacion.CodigoIdentificador = codigoEmbarcacion;
            return listaEmbarcacionesFabricadas.Contains(unaEmbarcacion);
        }

        //Método que recorre la lista de embarcaciones utilizando el método IndexOf, al cual se le da un objeto Embarcacion creado
        //con un código identificador ingresado cuando se invoca a la funcíón. Se devuelve el objeto tipo Embarcacion que esté en
        //la posición especificada por el IndexOf (la comprobación previa de los datos ingresados impide que IndexOf devuelva -1)
        public Embarcacion devolverEmbarcacionPorCodigoIdentificador(int codigo)
        {
            Embarcacion unaEmbarcacion = new Embarcacion();
            unaEmbarcacion.CodigoIdentificador = codigo;
            int posicionEnLista = listaEmbarcacionesFabricadas.IndexOf(unaEmbarcacion);
            return listaEmbarcacionesFabricadas[posicionEnLista];
        }
        
    }
}
