using System.Security.Cryptography;

namespace DimensionPersona
{
    public partial class ArregloPersonas : Form
    {
        public DimensionPersona.Persona[] personas { get; set; } = new DimensionPersona.Persona[3];
        public int posicion = -1;


        public ArregloPersonas()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = txnombre.Text;
            posicion = posicion + 1;
            personas[posicion] = persona;
        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
           //lblista.Text = "Lista:\\r\\n\\";
            foreach (Persona item in personas)
            {
                lblista.Text = "Lista de personas cargadas" + "\r\n" + "\r\n" + "Nombre:" + " " + item.Nombre;
            }
        }
    }
}
