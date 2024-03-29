namespace carga
{
    partial class CargaListaPers
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
            btBorrarDgv = new Button();
            txNombre = new TextBox();
            btMostrar = new Button();
            label1 = new Label();
            label2 = new Label();
            txApellido = new TextBox();
            label3 = new Label();
            txDocumento = new TextBox();
            lbLista = new Label();
            label4 = new Label();
            txCuil = new TextBox();
            label5 = new Label();
            btBorrar = new Button();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.BackColor = Color.LawnGreen;
            btsalir.Cursor = Cursors.Hand;
            btsalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btsalir.ForeColor = SystemColors.Control;
            btsalir.Location = new Point(995, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(107, 33);
            btsalir.TabIndex = 6;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = false;
            btsalir.Click += btsalir_Click;
            // 
            // btBorrarDgv
            // 
            btBorrarDgv.BackColor = Color.Black;
            btBorrarDgv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btBorrarDgv.ForeColor = SystemColors.Control;
            btBorrarDgv.Location = new Point(414, 275);
            btBorrarDgv.Name = "btBorrarDgv";
            btBorrarDgv.Size = new Size(107, 33);
            btBorrarDgv.TabIndex = 4;
            btBorrarDgv.Text = "Cargar";
            btBorrarDgv.UseVisualStyleBackColor = false;
            btBorrarDgv.Click += btCargar_Click;
            // 
            // txNombre
            // 
            txNombre.BackColor = Color.LawnGreen;
            txNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txNombre.Location = new Point(560, 95);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(125, 27);
            txNombre.TabIndex = 0;
            // 
            // btMostrar
            // 
            btMostrar.BackColor = Color.Black;
            btMostrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btMostrar.ForeColor = SystemColors.Control;
            btMostrar.Location = new Point(578, 275);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(107, 33);
            btMostrar.TabIndex = 5;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = false;
            btMostrar.Click += btMostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(441, 95);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(439, 136);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // txApellido
            // 
            txApellido.BackColor = Color.LawnGreen;
            txApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txApellido.Location = new Point(560, 136);
            txApellido.Name = "txApellido";
            txApellido.Size = new Size(125, 27);
            txApellido.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(424, 182);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 8;
            label3.Text = "Documento";
            // 
            // txDocumento
            // 
            txDocumento.BackColor = Color.LawnGreen;
            txDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txDocumento.Location = new Point(560, 182);
            txDocumento.Name = "txDocumento";
            txDocumento.Size = new Size(125, 27);
            txDocumento.TabIndex = 2;
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.BackColor = Color.LawnGreen;
            lbLista.Font = new Font("Kristen ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLista.ForeColor = Color.Black;
            lbLista.Location = new Point(852, 102);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(57, 24);
            lbLista.TabIndex = 9;
            lbLista.Text = "label4";
            lbLista.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(414, 224);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 11;
            label4.Text = "Cuil (sin puntos)";
            // 
            // txCuil
            // 
            txCuil.BackColor = Color.LawnGreen;
            txCuil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txCuil.Location = new Point(560, 223);
            txCuil.Name = "txCuil";
            txCuil.Size = new Size(125, 27);
            txCuil.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.Location = new Point(289, 12);
            label5.Name = "label5";
            label5.Size = new Size(555, 37);
            label5.TabIndex = 12;
            label5.Text = "Cargue todos los datos en este formulario";
            // 
            // btBorrar
            // 
            btBorrar.BackColor = Color.Black;
            btBorrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btBorrar.ForeColor = SystemColors.Control;
            btBorrar.Location = new Point(414, 314);
            btBorrar.Name = "btBorrar";
            btBorrar.Size = new Size(271, 33);
            btBorrar.TabIndex = 13;
            btBorrar.Text = "Borrar lista";
            btBorrar.UseVisualStyleBackColor = false;
            btBorrar.Click += btBorrar_Click;
            // 
            // CargaListaPers
            // 
            AcceptButton = btBorrarDgv;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(1114, 374);
            Controls.Add(btBorrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txCuil);
            Controls.Add(lbLista);
            Controls.Add(label3);
            Controls.Add(txDocumento);
            Controls.Add(label2);
            Controls.Add(txApellido);
            Controls.Add(label1);
            Controls.Add(btMostrar);
            Controls.Add(txNombre);
            Controls.Add(btBorrarDgv);
            Controls.Add(btsalir);
            Name = "CargaListaPers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carga de personas con arreglos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btBorrarDgv;
        private TextBox txNombre;
        private Button btMostrar;
        private Label label1;
        private Label label2;
        private TextBox txApellido;
        private Label label3;
        private TextBox txDocumento;
        private Label lbLista;
        private Label label4;
        private TextBox txCuil;
        private Label label5;
        private Button btBorrar;
    }
}