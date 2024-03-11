using System.Security.Cryptography;

namespace DimensionPersona
{
    public partial class ArregloPersonas : Form
    {
        public Persona[] personas { get; set; } = new Persona[2];
        int posicion = 0;


        public ArregloPersonas()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = txnombre.Text;
            personas[personas.Length - 1] = persona;
            posicion = posicion + 1;
        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
            lblista.Text = "";
            foreach (Persona item in personas)
            {
                lblista.Text = "Lista de peronas" + "\r\n" + "\r\n" + "Nombre:" + " " + item.Nombre;
            }
        }

        private void Redimensionar()
        {
            if (personas == null)
            {
                personas = new Persona[0];
            }
            else
            {

            }
        }

      
    }
}
