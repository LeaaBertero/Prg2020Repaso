namespace operadores
{
    public partial class Form1 : Form
    {
        int numero1;
        int numero2;
        int resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btsumar_Click(object sender, EventArgs e)
        {

            numero1 = Convert.ToInt32(txnum1.Text);
            numero2 = Convert.ToInt32(txnum2.Text);


            resultado = numero1 + numero2;

            lbresultado.Text = resultado.ToString();

            //lbresultado.ToString(); 

            lbresultado.Visible = true;
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
