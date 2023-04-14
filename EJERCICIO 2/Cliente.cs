using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    class Cliente
    {
        public int CI { get; set; }
        public string Nombre { get; set; }
        public List<Auto> Autos { get; set; }

        public Cliente(int ci, string nombre)
        {
            CI = ci;
            Nombre = nombre;
            Autos = new List<Auto>();
        }

        public override string ToString()
        {
            return $"Cedula: {CI}, Nombre: {Nombre}";
        }

    }
}
