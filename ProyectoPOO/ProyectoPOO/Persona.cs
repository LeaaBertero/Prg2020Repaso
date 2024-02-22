using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        //llamando a la clase materia por ser una propiedad de la persona
        public Materia MateriaCursando { get; set; }

        public string NombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        public void Inscribir (Materia materia)
        {
            MateriaCursando = materia;
        }
    }
}
