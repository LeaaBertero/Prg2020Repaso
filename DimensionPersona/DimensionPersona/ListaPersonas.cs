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
        public Persona[] Personas { get; set; }

        public void Redimensionar()
        {
            if (Personas == null)
            {
                Personas = new Persona[0];
            }
            else
            {
                Persona[] arregloAuxiliar = new Persona[Personas.Length + 1];

                for (int incremneto = 0; incremneto < Personas.Length; incremneto++)
                {
                    arregloAuxiliar[incremneto] = Personas[incremneto];
                }

                Personas = arregloAuxiliar;
            }
        }

        public bool AddPersona(string nombre, string año)
        {
            Persona persona = new Persona();
            persona.Nombre = nombre;
            persona.AñoNacimiento = Convert.ToInt32(año);
            bool respuesta = persona.Validar();

            if (respuesta)
            {
                Redimensionar();
                Personas[Personas.Length - 1] = persona;
            }

            return respuesta;

          
        }

        public string ToStringFiltrado(int añoMinimo) 
        {
            string Resp = "";

            foreach (Persona item in Personas)
            {
                if (item.AñoNacimiento >= añoMinimo)
                {

                    Resp = "Lista de personas cargadas:"
                         + "\r\n"
                         + "\r\n"
                         + "Nombre:" + " "
                         + item.Nombre + "\r\n"
                         + "Año:" + " " + item.AñoNacimiento.ToString();
                }


            }

            return Resp;
           
        }
    }
}
