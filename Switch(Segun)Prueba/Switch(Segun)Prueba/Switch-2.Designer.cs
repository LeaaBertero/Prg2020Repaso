namespace Switch_Segun_Prueba
{
    partial class Switch_2
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
            btsalir = new Button();
            BtAceptar = new Button();
            TXIngresar = new TextBox();
            label1 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(667, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(121, 40);
            btsalir.TabIndex = 0;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // BtAceptar
            // 
            BtAceptar.Location = new Point(160, 156);
            BtAceptar.Name = "BtAceptar";
            BtAceptar.Size = new Size(124, 33);
            BtAceptar.TabIndex = 1;
            BtAceptar.Text = "Aceptar";
            BtAceptar.UseVisualStyleBackColor = true;
            BtAceptar.Click += BtAceptar_Click;
            // 
            // TXIngresar
            // 
            TXIngresar.Location = new Point(330, 159);
            TXIngresar.Name = "TXIngresar";
            TXIngresar.Size = new Size(125, 27);
            TXIngresar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 119);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese su edad con letras";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(330, 252);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "label2";
            lblResultado.Visible = false;
            // 
            // Switch_2
            // 
            AcceptButton = BtAceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(TXIngresar);
            Controls.Add(BtAceptar);
            Controls.Add(btsalir);
            Name = "Switch_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Switch_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button BtAceptar;
        private TextBox TXIngresar;
        private Label label1;
        private Label lblResultado;
    }
}