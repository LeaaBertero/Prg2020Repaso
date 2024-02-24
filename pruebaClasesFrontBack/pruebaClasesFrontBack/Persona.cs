using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaClasesFrontBack
{
    //objeto persona
    public class Persona
    {
        //propiedades de la clase persona
        public string? NombreApellido { get; set; }
        //public string? Apellido { get; set; }
        public int? Documento { get; set; }
        public string? Direccion { get; set; }
        public int? Telefono { get; set; }
       


        //método (son acciones que determinan la cualidad del objeto)
        public string NombreCompleto()
        {
            return "DATOS PERSONALES" + "\r\n" + "\r\n" + "Nombre completo: " + " " + NombreApellido 
                + "\r\n" + "Documento:" + " " 
                + Documento + "\r\n" + "Dirección:" 
                + " " + Direccion + " " + "\r\n" + "Teléfono: " 
                + " " + Telefono + "\r\n";
        }

       

    }
}
