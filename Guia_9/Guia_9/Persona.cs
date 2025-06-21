using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_9
{
    public class Persona
    {
        public Persona(int id, int legajo, int dni, string apellido, string nombre, string telefono, string telefono2, string direccion, string mensualQuincenal, string baja)
        {
            Id = id;
            Legajo = legajo;
            Dni = dni;
            Apellido = apellido;
            Nombre = nombre;
            Telefono = telefono;
            Telefono2 = telefono2;
            Direccion = direccion;
            MensualQuincenal = mensualQuincenal;
            Baja = baja;
        }

        public Persona(int id)
        {
            Id = id;
        }
        public Persona()
        {

        }
        public int Id { get; set; }
        public int Legajo { get; set; }
        public int Dni { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string Direccion { get; set; }
        public string MensualQuincenal { get; set; }
        public string Baja { get; set; }


    }
}
