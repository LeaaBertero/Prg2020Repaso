namespace pruebaClasesFrontBack
{
    partial class pruebaClases
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
            btejecutar = new Button();
            txNombre = new TextBox();
            labelLista = new Label();
            label2 = new Label();
            label1 = new Label();
            txDocumento = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txDireccion = new TextBox();
            btsalir = new Button();
            label3 = new Label();
            txTelefono = new TextBox();
            SuspendLayout();
            // 
            // btejecutar
            // 
            btejecutar.Cursor = Cursors.Hand;
            btejecutar.Location = new Point(66, 220);
            btejecutar.Name = "btejecutar";
            btejecutar.Size = new Size(119, 29);
            btejecutar.TabIndex = 5;
            btejecutar.Text = "Aceptar";
            btejecutar.UseVisualStyleBackColor = true;
            btejecutar.Click += btejecutar_Click;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(66, 131);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(148, 27);
            txNombre.TabIndex = 1;
            txNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // labelLista
            // 
            labelLista.AutoSize = true;
            labelLista.Location = new Point(397, 220);
            labelLista.Name = "labelLista";
            labelLista.Size = new Size(50, 20);
            labelLista.TabIndex = 2;
            labelLista.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(203, 17);
            label2.Name = "label2";
            label2.Size = new Size(378, 32);
            label2.TabIndex = 3;
            label2.Text = "INGRESE LOS DATOS PERSONALES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 100);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre completo";
            // 
            // txDocumento
            // 
            txDocumento.Location = new Point(232, 131);
            txDocumento.Name = "txDocumento";
            txDocumento.Size = new Size(148, 27);
            txDocumento.TabIndex = 2;
            txDocumento.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 100);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 8;
            label4.Text = "Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(397, 100);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 10;
            label5.Text = "Direccion";
            // 
            // txDireccion
            // 
            txDireccion.Location = new Point(397, 131);
            txDireccion.Name = "txDireccion";
            txDireccion.Size = new Size(148, 27);
            txDireccion.TabIndex = 3;
            txDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(694, 409);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 6;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(561, 100);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 12;
            label3.Text = "Teléfono";
            // 
            // txTelefono
            // 
            txTelefono.Location = new Point(561, 131);
            txTelefono.Name = "txTelefono";
            txTelefono.Size = new Size(148, 27);
            txTelefono.TabIndex = 4;
            txTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // pruebaClases
            // 
            AcceptButton = btejecutar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txTelefono);
            Controls.Add(btsalir);
            Controls.Add(label5);
            Controls.Add(txDireccion);
            Controls.Add(label4);
            Controls.Add(txDocumento);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(labelLista);
            Controls.Add(txNombre);
            Controls.Add(btejecutar);
            Name = "pruebaClases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pruebaClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btejecutar;
        private TextBox txNombre;
        private Label labelLista;
        private Label label2;
        private Label label1;
        private TextBox txDocumento;
        private Label label4;
        private Label label5;
        private TextBox txDireccion;
        private Button btsalir;
        private Label label3;
        private TextBox txTelefono;
    }
}