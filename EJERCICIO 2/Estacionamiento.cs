using System;
using System.Collections.Generic;
using System.Linq;

namespace EJERCICIO_2
{
    public class Estacionamiento
    {

        private Stack<Auto> autosEstacionados;
        private int tamMaximo;

        public Estacionamiento(int tamMaximo)
        {
            autosEstacionados = new Stack<Auto>(tamMaximo);
            this.tamMaximo = tamMaximo;
        }
        public void RegistrarCliente()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la Cedula:");
            int ci = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Nombre:");
            string nombre = Console.ReadLine();
            Cliente nuevoCliente = new Cliente(ci, nombre);
            Estatica.clientes.Add(nuevoCliente);
            Console.WriteLine($"Cliente con cedula :[ {ci} ] registrado exitosamente");
            Console.ReadLine();
        }
        public void MostraCliente()
        {
            Console.Clear();
            Console.WriteLine("**LISTA DE CLIENTES REGISTRADOS***");
           for(int i =0; i < Estatica.clientes.Count ; i++)
            {
                Console.WriteLine($"ID: {Estatica.clientes[i].CI} Nombre: {Estatica.clientes[i].Nombre}");
            }
            Console.ReadLine();
        }
        public void RegistrarAuto()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la Placa:");
            int placa = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Marca:");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese el Modelo:");
            string modelo = Console.ReadLine();
            Auto nuevoAuto = new Auto(placa, marca, modelo);
            Estatica.autos.Add(nuevoAuto);
            Console.WriteLine($"Auto con placa [ {placa} ] registrado exitosamente");
            Console.ReadLine();
        }

        public void AsociarAutoCliente()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cedula del Cliente:");
            int ci = int.Parse(Console.ReadLine());
            Cliente cliente = Estatica.clientes.Find(c => c.CI == ci);
            if (cliente == null)
            {
                Console.WriteLine("Por favor ingrese un cliente que exista");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Ingrese la placa del Auto:");
            int placa = int.Parse(Console.ReadLine());
            Auto auto = Estatica.autos.Find(a => a.Placa == placa);
            if (auto == null)
            {
                Console.WriteLine("Por favor ingrese un auto existente");
                Console.ReadLine();
                return;
            }

            cliente.Autos.Add(auto);
            Console.WriteLine($"El auto con placa [ {placa} ] fue asociado al cliente con cedula [ {ci} ] con éxito.");
            Console.ReadLine();
        }

        public void EstacionarAuto()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la placa del auto:");
            int placa = int.Parse(Console.ReadLine());
            Auto auto = Estatica.autos.Find(a => a.Placa == placa);
            if (auto == null)
            {
                Console.WriteLine("Por favor ingrese un auto existente");
                Console.ReadLine();
                return;
            }
            bool estaAsociado = false;
            foreach (Cliente cliente in Estatica.clientes)
            {
                if (cliente.Autos.Contains(auto))
                {
                    estaAsociado = true;
                    break;
                }
            }

            if (estaAsociado == false)
            {
                Console.WriteLine("Este auto no está asociado a ningún cliente y no puede ser estacionado.");
                Console.ReadLine();
                return;
            }

            if (autosEstacionados.Count >= tamMaximo)
            {
                Console.WriteLine("Lo siento, el estacionamiento está lleno.");
                Console.ReadLine();
            }
            else
            {
                autosEstacionados.Push(auto);
                Console.WriteLine($"El auto con placa [ {placa} ] ha sido estacionado exitosamente.");
                Console.ReadLine();
            }
        }


        public void SacarAutoEstacionamiento()
        {
            Console.Clear();
            if (autosEstacionados.Count == 0)
            {
                Console.WriteLine("No hay autos estacionados.");
                return;
            }

            Console.WriteLine("Ingrese la placa del Auto: ");
            int placa = int.Parse(Console.ReadLine());
            Auto auto = autosEstacionados.FirstOrDefault(a => a.Placa == placa);
            if (auto == null)
            {
                Console.WriteLine($"No se encontró el auto con placa {placa} en el estacionamiento.");
                Console.ReadLine();
                return;
            }

            autosEstacionados = new Stack<Auto>(autosEstacionados.Where(a => a.Placa != placa));
            Console.WriteLine($"El auto con Placa [ {auto.Placa} ] fue sacado del estacionamiento con éxito.");
            Console.ReadLine();

        }

        public void VerAutosEstacionados()
        {
            Console.Clear();
            if (autosEstacionados.Count == 0)
            {
                Console.WriteLine("No hay autos estacionados.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Autos estacionados:");
            foreach (Auto auto in autosEstacionados)
            {
                Console.WriteLine(auto.ToString());
            }
            Console.ReadLine();
        }
    }
 }
