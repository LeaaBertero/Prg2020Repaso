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

        //variable publica inicilmente en cero
        public int ContadorUltimoCodigo { get; set; } = 0;

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

            //variable persona creada e inicializada
            


            if (resp)
            {
                persona.Id = ContadorUltimoCodigo;
                ContadorUltimoCodigo = ContadorUltimoCodigo + 1;
                Redimensionar();
                Personas[Personas.Length - 1] = persona;
            }

            return resp;

        }

        public bool AddPersona(Persona persona)
        {
            //Persona persona = new Persona();
            //persona.Nombre = nombre;
            //persona.AñoNacimiento = Convert.ToInt32(año);
            bool resp = persona.Validar(); 

            //variable persona creada e inicializada

            if (resp)
            {
                if (persona.Id == 0)
                {
                    ContadorUltimoCodigo = ContadorUltimoCodigo + 1;
                    persona.Id = ContadorUltimoCodigo;
                    Redimensionar();
                    Personas[Personas.Length - 1] = persona;
                }
                else
                {
                    for (int incremento = 0; incremento < Personas.Length; incremento++)
                    {
                        
                        if (Personas[incremento].Id == persona.Id)
                        {
                            Personas[incremento] = persona;

                            break;
                        }
                    }
                }
            }

            return resp;
        }


        //Método ToString
        public override string ToString()
        {
            string Resp = "";

            //Resp = "Lista: \r\n";
            foreach (Persona item in Personas)
            {
                Resp =  Resp 
                    + "\r\n"
                    + "\r\n" + "Código" + " " + item.Id.ToString() + " "
                    + "Nombre:" + " "
                    + item.Nombre + "\r\n"
                    + "Año:" + " " + item.AñoNacimiento.ToString();
            }

            return Resp;
        }

        public string ToStringFiltrado(int añoMinimo)
        {
            string Resp = "";

            //Resp = "Lista: \r\n";
            foreach (Persona item in Personas)
            {
                if (item.AñoNacimiento >= añoMinimo)
                {
                    Resp = Resp
                    + "\r\n"
                    + "\r\n" + "Código" + " " + item.Id.ToString()
                    + "Nombre:" + " "
                    + item.Nombre + "\r\n"
                    + "Año:" + " " + item.AñoNacimiento.ToString();
                }
            }

            return Resp;
        }



        public Persona BuscarPersonas(int Id)
        {
            //inicializa el objeto persona 
            Persona res = new Persona();

            //for (int incremento = 0; incremento < Personas.Length; incremento++)
            //{
            //    if (Personas[incremento].Codigo == codigo)
            //    {
            //        return Personas[incremento];
            //        break;
            //    }
            //}

            //res.Codigo = codigo;
            //return res;

            
            foreach (Persona item in Personas)
            {
                if (Personas[item.Id].Id == Id)
                {
                    res = item;
                    break;
                }
            }
 
            return res;
        }

        public bool updatePersona (Persona persona) 
        {
            return false;
        }
        public bool deletePersona(Persona persona)
        {
            return false;
        }
    }
}







            



