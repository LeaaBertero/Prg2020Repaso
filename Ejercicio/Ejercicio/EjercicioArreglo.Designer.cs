namespace Ejercicio
{
    partial class EjercicioArreglo
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
            btCargar = new Button();
            txNombre = new TextBox();
            txMateria = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbLista = new Label();
            btMostrar = new Button();
            label3 = new Label();
            txAño = new TextBox();
            btSalir = new Button();
            SuspendLayout();
            // 
            // btCargar
            // 
            btCargar.BackColor = Color.Orange;
            btCargar.Cursor = Cursors.Hand;
            btCargar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCargar.Location = new Point(429, 102);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(94, 29);
            btCargar.TabIndex = 3;
            btCargar.Text = "Cargar";
            btCargar.UseVisualStyleBackColor = false;
            btCargar.Click += btCargar_Click;
            // 
            // txNombre
            // 
            txNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txNombre.Location = new Point(16, 104);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(125, 27);
            txNombre.TabIndex = 0;
            // 
            // txMateria
            // 
            txMateria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txMateria.Location = new Point(147, 104);
            txMateria.Name = "txMateria";
            txMateria.Size = new Size(125, 27);
            txMateria.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(16, 81);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(147, 81);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 4;
            label2.Text = "Materia";
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.BackColor = Color.Orange;
            lbLista.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLista.Location = new Point(657, 112);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(62, 19);
            lbLista.TabIndex = 5;
            lbLista.Text = "label3";
            lbLista.Visible = false;
            // 
            // btMostrar
            // 
            btMostrar.BackColor = Color.Orange;
            btMostrar.Cursor = Cursors.Hand;
            btMostrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btMostrar.Location = new Point(529, 102);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(94, 29);
            btMostrar.TabIndex = 4;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = false;
            btMostrar.Click += btMostrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(278, 81);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 8;
            label3.Text = "Año";
            // 
            // txAño
            // 
            txAño.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txAño.Location = new Point(278, 104);
            txAño.Name = "txAño";
            txAño.Size = new Size(125, 27);
            txAño.TabIndex = 2;
            // 
            // btSalir
            // 
            btSalir.BackColor = Color.Orange;
            btSalir.Cursor = Cursors.Hand;
            btSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSalir.Location = new Point(890, 12);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(94, 29);
            btSalir.TabIndex = 5;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = false;
            btSalir.Click += btSalir_Click;
            // 
            // EjercicioArreglo
            // 
            AcceptButton = btCargar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(996, 450);
            Controls.Add(btSalir);
            Controls.Add(label3);
            Controls.Add(txAño);
            Controls.Add(btMostrar);
            Controls.Add(lbLista);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txMateria);
            Controls.Add(txNombre);
            Controls.Add(btCargar);
            Name = "EjercicioArreglo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EjercicioArreglo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCargar;
        private TextBox txNombre;
        private TextBox txMateria;
        private Label label1;
        private Label label2;
        private Label lbLista;
        private Button btMostrar;
        private Label label3;
        private TextBox txAño;
        private Button btSalir;
    }
}