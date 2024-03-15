using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionPersona
{
    public class Persona
    {
        public int Codigo { get; set; }

       public string? Nombre { get; set; }

        public int AñoNacimiento { get; set; }

        public bool Validar()
        {
            bool respuesta = false;

            if (AñoNacimiento > 1900 && AñoNacimiento <= DateTime.Now.Year)
            {
                respuesta = true;
            }
            

            return respuesta;
        }
    }
}
