using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    class Estatica
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Auto> autos = new List<Auto>();

        public static void CargarClientes()
        {
            clientes.Add(new Cliente(13745869, "Mario"));
            clientes.Add(new Cliente(24680135, "Ana"));
            clientes.Add(new Cliente(35468902, "Pedro"));
            clientes.Add(new Cliente(11223344, "Carla"));
            clientes.Add(new Cliente(98765432, "Juan"));
            clientes.Add(new Cliente(55555555, "Sofía"));
            clientes.Add(new Cliente(77777777, "María"));
            clientes.Add(new Cliente(88888888, "Luis"));
            clientes.Add(new Cliente(99999999, "Lucía"));
            clientes.Add(new Cliente(12345678, "Miguel"));
            clientes.Add(new Cliente(45678901, "Julia"));
        }

        public static  void CragarAutos()
        {
            autos.Add(new Auto(78346, "4x4", "Toyota"));
            autos.Add(new Auto(12345, "Sedán", "Honda"));
            autos.Add(new Auto(23456, "Hatchback", "Volkswagen"));
            autos.Add(new Auto(34567, "Camioneta", "Ford"));
            autos.Add(new Auto(45678, "Deportivo", "Ferrari"));
            autos.Add(new Auto(56789, "SUV", "Mercedes-Benz"));
            autos.Add(new Auto(67890, "Pickup", "Chevrolet"));
            autos.Add(new Auto(78901, "Convertible", "BMW"));
            autos.Add(new Auto(89012, "Furgoneta", "Nissan"));
            autos.Add(new Auto(90123, "Coupe", "Audi"));
            autos.Add(new Auto(01234, "Descapotable", "Mazda"));
        }
    }
}
