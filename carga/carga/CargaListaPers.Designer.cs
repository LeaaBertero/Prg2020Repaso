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
            label5 = new Label();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.BackColor = Color.Black;
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
            // btCargar
            // 
            btCargar.BackColor = Color.Black;
            btCargar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btCargar.ForeColor = SystemColors.Control;
            btCargar.Location = new Point(384, 206);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(107, 33);
            btCargar.TabIndex = 4;
            btCargar.Text = "Cargar";
            btCargar.UseVisualStyleBackColor = false;
            btCargar.Click += btCargar_Click;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(218, 140);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(125, 27);
            txNombre.TabIndex = 0;
            // 
            // btMostrar
            // 
            btMostrar.BackColor = Color.Black;
            btMostrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btMostrar.ForeColor = SystemColors.Control;
            btMostrar.Location = new Point(565, 206);
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
            label1.Location = new Point(218, 114);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(384, 114);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // txApellido
            // 
            txApellido.Location = new Point(384, 140);
            txApellido.Name = "txApellido";
            txApellido.Size = new Size(125, 27);
            txApellido.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(547, 114);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 8;
            label3.Text = "Documento";
            // 
            // txDocumento
            // 
            txDocumento.Location = new Point(547, 140);
            txDocumento.Name = "txDocumento";
            txDocumento.Size = new Size(125, 27);
            txDocumento.TabIndex = 2;
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.BackColor = Color.LightSeaGreen;
            lbLista.Font = new Font("Kristen ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLista.ForeColor = Color.White;
            lbLista.Location = new Point(790, 206);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(63, 24);
            lbLista.TabIndex = 9;
            lbLista.Text = "label4";
            lbLista.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(713, 114);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 11;
            label4.Text = "Cuil (sin puntos)";
            // 
            // txCuil
            // 
            txCuil.Location = new Point(713, 140);
            txCuil.Name = "txCuil";
            txCuil.Size = new Size(125, 27);
            txCuil.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.Location = new Point(238, 46);
            label5.Name = "label5";
            label5.Size = new Size(555, 37);
            label5.TabIndex = 12;
            label5.Text = "Cargue todos los datos en este formulario";
            // 
            // CargaListaPers
            // 
            AcceptButton = btCargar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(1114, 450);
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
            Controls.Add(btCargar);
            Controls.Add(btsalir);
            Cursor = Cursors.Hand;
            Name = "CargaListaPers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carga de personas con arreglos";
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
        private Label label5;
    }
}