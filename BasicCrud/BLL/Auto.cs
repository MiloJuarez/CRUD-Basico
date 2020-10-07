using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCrud.BLL
{
    public class Auto
    {

        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public double Precio { get; set; }
        public string FechaVenta { get; set; }

        public Auto()
        {
            ID = 0;
            Marca = "";
            Modelo = "";
            Anio = 0;
            Precio = 0;
            FechaVenta = "";
        }
    }
}
