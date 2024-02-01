namespace operadores
{
    public partial class Form1 : Form
    {
        //definición de variables, en este caso enteras, por cuestión de práctica..
        int numero1;
        int numero2;
        int resultado;

        //constructor
        public Form1() //nombre del formulario(olvidé cambiarlo)
        {
            InitializeComponent();
        }

        private void btsumar_Click(object sender, EventArgs e)
        {
            //control de errores
            try
            {
                //variables definidas anteriormente, convertidas a entero, para poder realizar la sumatoria 
                //con los respectivos texbox incluidos, donde el usuario va a ingresar los datos correspondientes
                numero1 = Convert.ToInt32(txnum1.Text);
                numero2 = Convert.ToInt32(txnum2.Text);

                //suma de variables definidas al principio
                resultado = numero1 + numero2;

                //se convierte la variable resultado a string, donde se va a visulizar el resultado
                lbresultado.Text = resultado.ToString();

                //se muestra visible el resultado a realizar click en el boton sumar
                lbresultado.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("No puede sumar datos vacios");
            }
        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            lbresultado.Text = null;
            txnum1.Text = null;
            txnum2.Text = null;

        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
