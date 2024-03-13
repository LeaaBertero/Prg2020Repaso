using System.Security.Cryptography;

namespace DimensionPersona
{
    public partial class ArregloPersonas : Form
    {
        //public DimensionPersona.Persona[] Personas { get; set; }

        private ListaPersonas Lista { get; set; } = new ListaPersonas();


        public ArregloPersonas()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            //Persona persona = new Persona();
            //persona.Nombre = txnombre.Text;
            //persona.AñoNacimiento = Convert.ToInt32(txaño.Text);
            //Lista.Redimensionar();
            //Lista.Personas[Lista.Personas.Length - 1] = persona;
            Lista.AddPersona(txnombre.Text, txaño.Text);
        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
            //lblista.Text = "Lista:\\r\\n\\";
            //foreach (Persona item in Lista.Personas)
            //{
            //    lblista.Text = "Lista de personas cargadas" 
            //        + "\r\n" 
            //        + "\r\n" 
            //        + "Nombre:" + " " 
            //        + item.Nombre + "\r\n" 
            //        + "Año:" + " " + item.AñoNacimiento.ToString();
            //}
           lblista.Text = Lista.ToString();
        }

        //private void Redimensionar()
        //{
        //    if (Personas == null)
        //    {
        //        Personas = new Persona[0];
        //    }
        //    else
        //    {
        //        Persona[] arregloAuxiliar = new Persona[Personas.Length + 1];

        //        for (int incremneto = 0; incremneto < Personas.Length; incremneto++)
        //        {
        //            arregloAuxiliar[incremneto] = Personas[incremneto];
        //        }

        //        Personas = arregloAuxiliar;
        //    }
        //}

        private void btOperaciones_Click(object sender, EventArgs e)
        {
            Form calcu = new Calcu();
            calcu.Show();
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
