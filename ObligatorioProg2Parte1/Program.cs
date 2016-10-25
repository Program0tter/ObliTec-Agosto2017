using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace ObligatorioProg2Parte1
{
    class Program
    {
        static Empresa unaEmpresa = new Empresa();
        static Mecanico miMecanico = new Mecanico();
        static void Main(string[] args)
        {
            Embarcacion.UltimoNumeroCodigo = 100;
            crearMenu();

         }

        //Metodo que crea el menu que muestra las opciones al usuario. Contiene un switch con tantos cases como opciones aparecen en el menu, y las comprobaciones necesarias
        //para que el usuario solo pueda elegir una opcion valida o salir del programa.
        static void crearMenu()
        {
            bool salir = false;
            do
            {
                Console.WriteLine("Ingrese la opción deseada:\n1 - Registrar mecánico en el sistema.\n2 - Registrar una nueva embarcación.\n3 - Ingresar nueva reparación.\n4 - Listar mecánicos que no hán realizado capacitación extra.\n5 - Salir.");
                int opcionMenu = Convert.ToInt32(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        registrarMecanicoEnSistema();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        registrarEmbarcacionEnSistema();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        registrarReparacionEnSistema();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        listarMecanicosSinCapacitacion();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("ERROR: Debe ingresar una opcion valida.");
                        Console.ReadLine();
                        Console.Clear();
                        break;                        
                }
            } while (salir == false);

        }

        //Metodo que pide al usuario que ingrese la información necesaria para ingresar un objeto tipo Embarcacion al sistema, tras lo cual llama a la clase Empresa y crea
        //el objeto. Tiene validaciones en cada paso del proceso para asegurarse de que la información que se entrega a Empresa es válida.
        static void registrarEmbarcacionEnSistema()
        {
            Console.WriteLine("Ingrese nombre de la embarcación:");
            string nombre = Console.ReadLine().Trim();
            if (nombre == "")
            {
                Console.WriteLine("ERROR: Debe ingresar un nombre.");
            }  else
            {
                Console.WriteLine("Ingrese la fecha de construcción usando el siguiente formato: Dia/Mes/Año/\n\nEg: 02/11/2016");
                string fechaIngresada = Console.ReadLine();
                if (fechaIngresada.IndexOf('/') == -1 || fechaIngresada == "")
                {
                    Console.WriteLine("Debe ingresar la fecha con el formato especificado en las instrucciones.");
                }
                else
                {
                    DateTime unafecha = DateTime.Parse(fechaIngresada);
                    Console.WriteLine("Ingrese el tipo de motor de la embarcación:\n1 - Integrado\n2 - Fuera de borda\n3 - Otros");
                    int opcionMotor = Convert.ToInt32(Console.ReadLine());
                    if (opcionMotor < 1 || opcionMotor > 3)
                    {
                        Console.WriteLine("ERROR: Debe ingresar una opcion válida.");
                    }
                    else
                    {
                        unaEmpresa.registrarNuevaEmbarcacionConstruida(nombre, unafecha, opcionMotor);
                        Console.WriteLine("Embarcación ingresada al sistema exitosamente.");
                    }
                }
            }
        }

        //Metodo que obtiene una lista de mecánicos cuyo atributo booleano 'realizoCapacitacion' es falso mediante un metodo de Empresa, y los imprime en la consola.
        static void listarMecanicosSinCapacitacion()
        {
            List<Mecanico> listaMecanicosSinCapacitacionExtra = unaEmpresa.devolverListaDeMecanicosSinCapacitacionExtra();
            if (listaMecanicosSinCapacitacionExtra.Count != 0)
            {
                foreach (Mecanico mec in listaMecanicosSinCapacitacionExtra)
                {
                    Console.WriteLine(mec + "\n");
                }

            }
            else
            {
                Console.WriteLine("No hay mecánicos sin capacitación ingresados en el sistema.");
            }
        }

        //Metodo que pide al usuario que ingrese la información necesaria para ingresar un objeto tipo Mecanico al sistema, tras lo cual llama a la clase Empresa y crea
        //el objeto. Tiene validaciones en cada paso del proceso para asegurarse de que la información que se entrega a Empresa es válida.
        static void registrarMecanicoEnSistema()
        {
            Console.WriteLine("Ingrese el numero de registro del mecánico:");
            int numeroRegistroMecanico = Convert.ToInt32(Console.ReadLine());
            if (unaEmpresa.mecanicoExiste(numeroRegistroMecanico))
            {
                Console.WriteLine("ERROR: Ya existe este código dentro de la base de datos. Debe ingresar un nuevo código.");
            }
            else
            {
                Console.WriteLine("Ingrese un nombre:");
                string nombreMecanico = Console.ReadLine().Trim();
                if (nombreMecanico == "")
                {
                    Console.WriteLine("ERROR: Debe ingresar el nombre del mecánico.");
                }
                else
                {
                    Console.WriteLine("Ingrese la calle de residencia:");
                    string calle = Console.ReadLine().Trim();
                    if (calle == "")
                    {
                        Console.WriteLine("ERROR: Debe ingresar una calle.");
                    }
                    else
                    {
                        Console.WriteLine("Ingrese el numero de puerta de la residencia:");
                        string numeroPuerta = Console.ReadLine().Trim();
                        if (numeroPuerta == "")
                        {
                            Console.WriteLine("ERROR: Debe ingresar un numero de puerta.");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese la ciudad de residencia:");
                            string ciudad = Console.ReadLine().Trim();
                            if (ciudad == "")
                            {
                                Console.WriteLine("ERROR: Debe ingresar una ciudad.");
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un numero de contacto para el mecánico:");
                                string telefono = Console.ReadLine().Trim();
                                if (telefono == "")
                                {
                                    Console.WriteLine("ERROR: Debe ingresar un numero de telefono.");
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese el valor del jornal del mecánico:");
                                    int valorJornal = Convert.ToInt32(Console.ReadLine());
                                    if (valorJornal <= 0)
                                    {
                                        Console.WriteLine("ERROR: Debe ingresar un valor mayor a 0 para el jornal del mecánico.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("¿El mecánico ha realizado capacitación extra?\n1 - Si.\n2 - No.");
                                        int opcionElegida = Convert.ToInt32(Console.ReadLine());
                                        bool seCapacito = false;
                                        if (opcionElegida < 0 || opcionElegida > 2)
                                        {
                                            Console.WriteLine("ERROR: Debe elegír una opción válida.");
                                        }
                                        else
                                        {
                                            if (opcionElegida == 1)
                                            {
                                                seCapacito = true;
                                            }
                                            Direccion unaDireccion = miMecanico.crearNuevaDireccion(calle, numeroPuerta, ciudad);
                                            unaEmpresa.registrarMecanicoEnEmpresa(nombreMecanico, telefono, unaDireccion, valorJornal, numeroRegistroMecanico, seCapacito);
                                            Console.WriteLine("Mecanico agregado al sistema exitosamente.");
                                        }
                                    }
                                }
                            }
                        }


                    }
                }
            }

        }

        //Metodo que pide al usuario que ingrese la información necesaria para ingresar un objeto tipo Reparacion al sistema, tras lo cual llama a la clase Empresa y crea
        //el objeto. Tiene validaciones en cada paso del proceso para asegurarse de que la información que se entrega a Empresa es válida.
        static void registrarReparacionEnSistema()
        {
            Console.WriteLine("Ingrese el código identificador de la embarcación a reparar:");
            //Busco embarcación por nombre o por codigo? Los dos deberían ser únicos.
            int codigo = Convert.ToInt32(Console.ReadLine());
            if (!unaEmpresa.codigoEmbarcacionExiste(codigo))
            {
                Console.WriteLine("ERROR: El codigo ingresado no corresponde a ninguna embarcación en el sistema.");
            }
            else
            {
                Embarcacion unaEmbarcacion = unaEmpresa.devolverEmbarcacionPorCodigoIdentificador(codigo);
                Console.WriteLine("Ingrese la fecha de ingreso de la embarcación al taller usando el siguiente formato: Dia/Mes/Año./\nEg: 02/11/2016");
                string fechaIngreso = Console.ReadLine();
                if (fechaIngreso.IndexOf('/') == -1 || fechaIngreso == "")
                {
                    Console.WriteLine("Debe ingresar la fecha con el formato especificado en las instrucciones.");
                }
                else
                {
                    DateTime unaFechaIngreso = DateTime.Parse(fechaIngreso);
                    Console.WriteLine("Ingrese la fecha prometida de finalización de reparación en este formato: Dia/Mes/Año./\nEg: 02/11/2016");
                    string fechaPrometida = Console.ReadLine();
                    if (fechaPrometida.IndexOf('/') == -1 || fechaPrometida == "")
                    {
                        Console.WriteLine("Debe ingresar la fecha con el formato especificado en las instrucciones.");
                    }
                    else
                    {
                        DateTime unaFechaPrometida = DateTime.Parse(fechaPrometida);
                        unaEmpresa.ingresarReparacionDeEmbarcacion(unaFechaIngreso, unaFechaPrometida, unaEmbarcacion);
                        Console.WriteLine("Reparación ingresada al sistema existosamente.");
                    }

                }

            }
        }
    }
}
