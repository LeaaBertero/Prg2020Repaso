using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasArreglos.PersonaCls
{
    public class Persona
    { 
        public string? Nombre { get; set; }
        public int añoNacimiento { get; set; }

        public int Documento { get; set; }

        public bool Validar()
        {
            bool respuesta = false;

            if (añoNacimiento > 1900 && añoNacimiento <= DateTime.Now.Year)
            {
                respuesta = true;
            }

            return respuesta;
        }

    }
}
