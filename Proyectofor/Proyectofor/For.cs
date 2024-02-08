namespace Proyectofor
{
    public partial class For : Form
    {
        public For()
        {
            InitializeComponent();
        }

        private void BtIniciar_Click(object sender, EventArgs e)
        {
            int contador;

            try
            {
                for (contador = Convert.ToInt32(TxDesde.Text); //Desde
               contador <= Convert.ToInt32(TxHasta.Text); //Hasta
               contador = contador + Convert.ToInt32(TxPaso.Text)) //Paso
                {
                    //convertir el label del resultado en string
                    LblRes.Text = "Contando.." + " " + contador.ToString();
                    this.Refresh();
                    LblRes.Visible = true;
                }

                MessageBox.Show("Contador ha llegado al final");
            }
            catch (Exception)
            {

                MessageBox.Show("Debe ingresar los datos solicitados");
            }
        }


        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            TxDesde.Text = null;
            TxHasta.Text = null;
            TxPaso.Text = null;
            LblRes.Text = null;
        }
    }
}
           
           
          






