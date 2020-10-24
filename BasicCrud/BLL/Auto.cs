using System;
using System.Collections.Generic;
using System.Drawing;
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
        public string Imagen { get; set; }
        public string Detalles { get; set; }

        public Auto()
        {
            ID = 0;
            Marca = "";
            Modelo = "";
            Anio = 0;
            Precio = 0;
            FechaVenta = "";
            Imagen = "";
            Detalles = "";
        }
    }
}
