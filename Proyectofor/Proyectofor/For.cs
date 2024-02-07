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

            for (int contador = Convert.ToInt32(TxDesde.Text); //Desde
                contador <= Convert.ToInt32(TxHasta.Text); //Hasta
                contador = contador + Convert.ToInt32(TxPaso.Text)) //Paso
            {
                //convertir el label del resultado en string
                LblRes.Text = contador.ToString();
                this.Refresh();
                LblRes.Visible = true;
            }
        }


        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
           
           
          






