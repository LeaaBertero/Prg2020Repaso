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
            btCargar = new Button();
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
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.BackColor = Color.Orange;
            btsalir.Cursor = Cursors.Hand;
            btsalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btsalir.ForeColor = SystemColors.Control;
            btsalir.Location = new Point(817, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(107, 33);
            btsalir.TabIndex = 0;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = false;
            btsalir.Click += btsalir_Click;
            // 
            // btCargar
            // 
            btCargar.BackColor = Color.Orange;
            btCargar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btCargar.ForeColor = SystemColors.Control;
            btCargar.Location = new Point(272, 215);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(107, 33);
            btCargar.TabIndex = 1;
            btCargar.Text = "Cargar";
            btCargar.UseVisualStyleBackColor = false;
            btCargar.Click += btCargar_Click;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(135, 131);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(125, 27);
            txNombre.TabIndex = 2;
            // 
            // btMostrar
            // 
            btMostrar.BackColor = Color.Orange;
            btMostrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btMostrar.ForeColor = SystemColors.Control;
            btMostrar.Location = new Point(501, 215);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(107, 33);
            btMostrar.TabIndex = 3;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = false;
            btMostrar.Click += btMostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(135, 105);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(301, 105);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // txApellido
            // 
            txApellido.Location = new Point(301, 131);
            txApellido.Name = "txApellido";
            txApellido.Size = new Size(125, 27);
            txApellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(464, 105);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 8;
            label3.Text = "Documento";
            // 
            // txDocumento
            // 
            txDocumento.Location = new Point(464, 131);
            txDocumento.Name = "txDocumento";
            txDocumento.Size = new Size(125, 27);
            txDocumento.TabIndex = 7;
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.Location = new Point(729, 255);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(50, 20);
            lbLista.TabIndex = 9;
            lbLista.Text = "label4";
            lbLista.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(630, 105);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 11;
            label4.Text = "Cuil (sin puntos)";
            // 
            // txCuil
            // 
            txCuil.Location = new Point(630, 131);
            txCuil.Name = "txCuil";
            txCuil.Size = new Size(125, 27);
            txCuil.TabIndex = 10;
            // 
            // CargaListaPers
            // 
            AcceptButton = btCargar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(936, 450);
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
            Controls.Add(btCargar);
            Controls.Add(btsalir);
            Name = "CargaListaPers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carga2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btCargar;
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
    }
}