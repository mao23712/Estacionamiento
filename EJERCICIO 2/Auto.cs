using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
   public class Auto
    {
        public int Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Auto(int placa, string marca, string modelo)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            
        }

        public override string ToString()
        {
            return $"Placa: {Placa}, Marca: {Marca}, Modelo: {Modelo}";
        }
    }  
}
