using ListasArreglos.PersonaCls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            }
        }
    
        public void AddPersona(string nombre, string año, string documento)
        {
            //clase - variable --Instancia(Hace nacer un objeto)
            //la sintaxis es lo mismo que llamar a un formulario
            //desde otro formulario.
            Persona persona = new PersonaCls.Persona();
            Redimensionar();
            persona.Nombre = nombre;
            Personas[Personas.Length - 1] = persona;
            persona.añoNacimiento = Convert.ToInt32(año);
            persona.Documento = Convert.ToInt32(documento);
        }

        public override string ToString()
        {

            string Resp = "";

            Resp = "Personas cargadas: \r\n" + "\r\n";
            foreach (Persona incremento in Personas)
            {
                Resp = Resp + "Nombre:" + " "
                    + incremento.Nombre + " " + "\r\n"
                    + "Año de nacimiento:" + " "
                    + incremento.añoNacimiento + " " + "\r\n"
                    + "Documento:" + " "
                    + incremento.Documento + " " + "\r\n";
            }

            return Resp;
        }
    
    }
}  



