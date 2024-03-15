using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionPersona
{
    public class ListaPersonas
    {
        //arreglo de personas
        public  Persona[] Personas { get; set; }

        //Método Redimensionar
        public void Redimensionar()
        {
            if (Personas == null)
            {
               Personas = new Persona[0];
            }
            else
            {
                Persona[] arregloAuxiliar = new Persona[Personas.Length + 1];

                for (int i = 0; i < Personas.Length; i++)
                {
                    arregloAuxiliar[i] = Personas[i];
                }

                Personas = arregloAuxiliar;
            }
        }

        //Método AddPersona
        public bool AddPersona(string nombre, string año)
        {
            Persona persona = new Persona();
            persona.Nombre = nombre;
            persona.AñoNacimiento = Convert.ToInt32(año);
            bool resp = persona.Validar();

            if (resp)
            {
                Redimensionar();
                Personas[Personas.Length - 1] = persona;
            }

            return resp;


        }

        //Método ToString
        public override string ToString()
        {
            string Resp = "";

            Resp = "Lista: \r\n";
            foreach (Persona item in Personas)
            {
                Resp =  Resp + "Lista de personas cargadas"
                    + "\r\n"
                    + "\r\n"
                    + "Nombre:" + " "
                    + item.Nombre + "\r\n"
                    + "Año:" + " " + item.AñoNacimiento.ToString();
            }

            return Resp;


        }

        
      
    }
}
