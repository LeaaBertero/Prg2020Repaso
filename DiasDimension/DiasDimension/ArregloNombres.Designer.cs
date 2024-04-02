namespace DiasDimension
{
    partial class ArregloNombres
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
            btSalir = new Button();
            btCargar = new Button();
            txNombre = new TextBox();
            LbLista = new Label();
            label1 = new Label();
            btMostrar = new Button();
            SuspendLayout();
            // 
            // btSalir
            // 
            btSalir.Cursor = Cursors.Hand;
            btSalir.Location = new Point(556, 12);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(94, 29);
            btSalir.TabIndex = 0;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // btCargar
            // 
            btCargar.Location = new Point(272, 146);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(94, 29);
            btCargar.TabIndex = 1;
            btCargar.Text = "Cargar";
            btCargar.UseVisualStyleBackColor = true;
            btCargar.Click += btCargar_Click;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(121, 146);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(125, 27);
            txNombre.TabIndex = 2;
            // 
            // LbLista
            // 
            LbLista.AutoSize = true;
            LbLista.Location = new Point(461, 155);
            LbLista.Name = "LbLista";
            LbLista.Size = new Size(50, 20);
            LbLista.TabIndex = 3;
            LbLista.Text = "label1";
            LbLista.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 109);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 4;
            label1.Text = "Cargue acá los nombres";
            // 
            // btMostrar
            // 
            btMostrar.Location = new Point(272, 181);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(94, 29);
            btMostrar.TabIndex = 5;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // ArregloNombres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 450);
            Controls.Add(btMostrar);
            Controls.Add(label1);
            Controls.Add(LbLista);
            Controls.Add(txNombre);
            Controls.Add(btCargar);
            Controls.Add(btSalir);
            Name = "ArregloNombres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ArregloNombres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSalir;
        private Button btCargar;
        private TextBox txNombre;
        private Label LbLista;
        private Label label1;
        private Button btMostrar;
    }
}