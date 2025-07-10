using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_9
{
    public class Electrodomestico
    {
        public Electrodomestico(int id, string articulo_Codigo, string articulo_Tipo, string articulo_Marca, string articulo_Modelo, string articulo_Caracteristicas, int articulo_Cantidad_Stock, int articulo_Precio, string articulo_Ingreso)
        {
            Id = id;
            Articulo_Codigo = articulo_Codigo;
            Articulo_Tipo = articulo_Tipo;
            Articulo_Marca = articulo_Marca;
            Articulo_Modelo = articulo_Modelo;
            Articulo_Caracteristicas = articulo_Caracteristicas;
            Articulo_Cantidad_Stock = articulo_Cantidad_Stock;
            Articulo_Precio = articulo_Precio;
            Articulo_Ingreso = articulo_Ingreso;
        }
        public Electrodomestico()
        {

        }

        public int Id { get; set; }
        public string Articulo_Codigo { get; set; }
        public string Articulo_Tipo { get; set; }
        public string Articulo_Marca { get; set; }
        public string Articulo_Modelo { get; set; }
        public string Articulo_Caracteristicas { get; set; }
        public int Articulo_Cantidad_Stock { get; set; }
        public int Articulo_Precio { get; set; }
        public string Articulo_Ingreso { get; set; }


    }
}
