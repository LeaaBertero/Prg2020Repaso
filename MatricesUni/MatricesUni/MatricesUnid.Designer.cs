namespace MatricesUni
{
    partial class MatricesUnid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btcerrar = new Button();
            btiniciar = new Button();
            TxNombre = new TextBox();
            lblista = new Label();
            btlistar = new Button();
            btDimensionar = new Button();
            TxCantidad = new TextBox();
            btprueba = new Button();
            SuspendLayout();
            // 
            // btcerrar
            // 
            btcerrar.BackColor = Color.DodgerBlue;
            btcerrar.Cursor = Cursors.Hand;
            btcerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btcerrar.ForeColor = SystemColors.Control;
            btcerrar.Location = new Point(690, 256);
            btcerrar.Name = "btcerrar";
            btcerrar.Size = new Size(78, 40);
            btcerrar.TabIndex = 0;
            btcerrar.Text = "salir";
            btcerrar.UseVisualStyleBackColor = false;
            btcerrar.Click += btcerrar_Click;
            // 
            // btiniciar
            // 
            btiniciar.BackColor = Color.DodgerBlue;
            btiniciar.Cursor = Cursors.Hand;
            btiniciar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btiniciar.ForeColor = SystemColors.Control;
            btiniciar.Location = new Point(79, 96);
            btiniciar.Name = "btiniciar";
            btiniciar.Size = new Size(73, 37);
            btiniciar.TabIndex = 3;
            btiniciar.Text = "Cargar";
            btiniciar.UseVisualStyleBackColor = false;
            btiniciar.Click += btiniciar_Click;
            // 
            // TxNombre
            // 
            TxNombre.Font = new Font("Segoe UI", 9F);
            TxNombre.Location = new Point(206, 101);
            TxNombre.Name = "TxNombre";
            TxNombre.Size = new Size(127, 27);
            TxNombre.TabIndex = 4;
            // 
            // lblista
            // 
            lblista.AutoSize = true;
            lblista.Font = new Font("Segoe UI", 12F);
            lblista.Location = new Point(514, 53);
            lblista.Name = "lblista";
            lblista.Size = new Size(51, 28);
            lblista.TabIndex = 2;
            lblista.Text = "Lista";
            lblista.TextAlign = ContentAlignment.MiddleCenter;
            lblista.Visible = false;
            // 
            // btlistar
            // 
            btlistar.BackColor = Color.DodgerBlue;
            btlistar.Cursor = Cursors.Hand;
            btlistar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btlistar.ForeColor = SystemColors.Control;
            btlistar.Location = new Point(79, 139);
            btlistar.Name = "btlistar";
            btlistar.Size = new Size(73, 39);
            btlistar.TabIndex = 5;
            btlistar.Text = "Mostrar";
            btlistar.UseVisualStyleBackColor = false;
            btlistar.Click += btlistar_Click;
            // 
            // btDimensionar
            // 
            btDimensionar.BackColor = Color.DodgerBlue;
            btDimensionar.Cursor = Cursors.Hand;
            btDimensionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btDimensionar.ForeColor = SystemColors.Control;
            btDimensionar.Location = new Point(79, 53);
            btDimensionar.Name = "btDimensionar";
            btDimensionar.Size = new Size(110, 37);
            btDimensionar.TabIndex = 1;
            btDimensionar.Text = "Dimensionar";
            btDimensionar.UseVisualStyleBackColor = false;
            btDimensionar.Click += btDimensionar_Click;
            // 
            // TxCantidad
            // 
            TxCantidad.Font = new Font("Segoe UI", 9F);
            TxCantidad.Location = new Point(206, 58);
            TxCantidad.Name = "TxCantidad";
            TxCantidad.Size = new Size(127, 27);
            TxCantidad.TabIndex = 2;
            // 
            // btprueba
            // 
            btprueba.BackColor = Color.DodgerBlue;
            btprueba.Cursor = Cursors.Hand;
            btprueba.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btprueba.ForeColor = SystemColors.Control;
            btprueba.Location = new Point(79, 242);
            btprueba.Name = "btprueba";
            btprueba.Size = new Size(174, 38);
            btprueba.TabIndex = 6;
            btprueba.Text = "Formulario de prueba";
            btprueba.UseVisualStyleBackColor = false;
            btprueba.Click += btprueba_Click;
            // 
            // MatricesUnid
            // 
            AcceptButton = btiniciar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(780, 308);
            Controls.Add(btprueba);
            Controls.Add(TxCantidad);
            Controls.Add(btDimensionar);
            Controls.Add(btlistar);
            Controls.Add(lblista);
            Controls.Add(TxNombre);
            Controls.Add(btiniciar);
            Controls.Add(btcerrar);
            ForeColor = SystemColors.ControlText;
            Name = "MatricesUnid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MatricesUnid";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcerrar;
        private Button btiniciar;
        private TextBox TxNombre;
        private Label lblista;
        private Button btlistar;
        private Button btDimensionar;
        private TextBox TxCantidad;
        private Button btprueba;
    }
}