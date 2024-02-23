using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaClasesFrontBack
{
    internal class Persona
    {
        //propiedades de la clase persona
        public string? NombreApellido { get; set; }
        //public string? Apellido { get; set; }
        public int? Documento { get; set; }
        public string? Direccion { get; set; }

        //método (por que tiene paréntesis)
        public string NombreCompleto()
        {
            return "Nombre completo: " + " " + NombreApellido + "\r\n" + "Documento:" + " " + Documento + "\r\n" + "Dirección:" + " " + Direccion + " " + "\r\n";
        }

    }
}
