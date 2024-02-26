using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasArreglos.PersonaCls
{
   public class ListaPersonas
   {
        //propiedad traida de front(comunicación con el formulario), hacia el backend(regela de negicios
        //(como comunmente se llama..)), por que justamente tiene relacion con las propiedades de la persona en la clase
        //Persona , creada inicialmente.
        public PersonaCls.Persona[] Personas { get; set; } = new Persona[1];

        public void Redimensionar()
        {
            if (Personas == null)
            {
                Personas = new PersonaCls.Persona[1];
            }
            else
            {
                PersonaCls.Persona[] Arraux = new PersonaCls.Persona[Personas.Length + 1];

                for (int incremento = 0; incremento < Personas.Length; incremento++)
                {
                    Arraux[incremento] = Personas[incremento];
                }

                Personas = Arraux;

        }   }
}  }



