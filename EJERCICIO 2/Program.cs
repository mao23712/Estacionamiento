using System;
using EJERCICIO_2;

namespace EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Estatica.CargarClientes();
            Estatica.CragarAutos();
            Estacionamiento estacionamiento = new Estacionamiento(3);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("-                  MENU              -");
                Console.WriteLine("1. REGISTRAR CLIENTE");
                Console.WriteLine("2. REGISTRAR AUTO");
                Console.WriteLine("3. REGISTRAR AUTO A CLIENTE");
                Console.WriteLine("4. ESTACIONAR AUTO");
                Console.WriteLine("5. RETIRAR AUTO DEL ESTACIONAMIENTO");
                Console.WriteLine("6. VER ESTACIONAMIENTO");
                Console.WriteLine("7. VER CLIENTES");
                Console.WriteLine("8. VER AUTOS");
                Console.WriteLine("9. SALIR");
                Console.WriteLine("-                                    -");
                Console.WriteLine("--------------------------------------");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        estacionamiento.RegistrarCliente();
                        break;
                    case 2:
                        estacionamiento.RegistrarAuto();
                        break;
                    case 3:
                        estacionamiento.AsociarAutoCliente();
                        break;
                    case 4:
                        estacionamiento.EstacionarAuto();
                        break;
                    case 5:
                        estacionamiento.SacarAutoEstacionamiento();
                        break;
                    case 6:
                        estacionamiento.VerAutosEstacionados();
                        break;
                    case 7:
                        estacionamiento.MostraCliente();
                        break;
                    case 9:
                        return;
                    default:
                        Console.WriteLine("INGRESE UNA OPCION VALIDA");
                        break;
                }
            }
        }
    }
}

