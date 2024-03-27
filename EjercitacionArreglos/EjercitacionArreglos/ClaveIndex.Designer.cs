namespace EjercitacionArreglos
{
    partial class ClaveIndex
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
            btIngresar = new Button();
            label1 = new Label();
            txUsuario = new TextBox();
            btCancelar = new Button();
            label2 = new Label();
            label3 = new Label();
            txContraseña = new TextBox();
            btSalir = new Button();
            btLimpiar = new Button();
            SuspendLayout();
            // 
            // btIngresar
            // 
            btIngresar.BackColor = Color.Orange;
            btIngresar.Cursor = Cursors.Hand;
            btIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btIngresar.Location = new Point(128, 180);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(107, 34);
            btIngresar.TabIndex = 2;
            btIngresar.Text = "Ingresar";
            btIngresar.UseVisualStyleBackColor = false;
            btIngresar.Click += btIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(93, 41);
            label1.Name = "label1";
            label1.Size = new Size(339, 23);
            label1.TabIndex = 1;
            label1.Text = "Para iniciar,  ingrese usuario y contraseña";
            // 
            // txUsuario
            // 
            txUsuario.Location = new Point(128, 125);
            txUsuario.Name = "txUsuario";
            txUsuario.Size = new Size(125, 27);
            txUsuario.TabIndex = 0;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.Orange;
            btCancelar.Cursor = Cursors.Hand;
            btCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btCancelar.Location = new Point(287, 180);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(107, 34);
            btCancelar.TabIndex = 3;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(128, 102);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Orange;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(269, 102);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // txContraseña
            // 
            txContraseña.Location = new Point(269, 125);
            txContraseña.Name = "txContraseña";
            txContraseña.PasswordChar = '*';
            txContraseña.Size = new Size(125, 27);
            txContraseña.TabIndex = 1;
            // 
            // btSalir
            // 
            btSalir.BackColor = Color.Orange;
            btSalir.Cursor = Cursors.Hand;
            btSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btSalir.Location = new Point(424, 288);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(107, 34);
            btSalir.TabIndex = 6;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = false;
            btSalir.Click += btSalir_Click;
            // 
            // btLimpiar
            // 
            btLimpiar.BackColor = Color.Orange;
            btLimpiar.Cursor = Cursors.Hand;
            btLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btLimpiar.Location = new Point(128, 220);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(266, 34);
            btLimpiar.TabIndex = 7;
            btLimpiar.Text = "Limpiar todos los campos";
            btLimpiar.UseVisualStyleBackColor = false;
            btLimpiar.Click += btLimpiar_Click;
            // 
            // ClaveIndex
            // 
            AcceptButton = btIngresar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(543, 334);
            Controls.Add(btLimpiar);
            Controls.Add(btSalir);
            Controls.Add(txContraseña);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btCancelar);
            Controls.Add(txUsuario);
            Controls.Add(label1);
            Controls.Add(btIngresar);
            Name = "ClaveIndex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClaveIndex";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btIngresar;
        private Label label1;
        private TextBox txUsuario;
        private Button btCancelar;
        private Label label2;
        private Label label3;
        private TextBox txContraseña;
        private Button btSalir;
        private Button btLimpiar;
    }
}