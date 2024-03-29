namespace carga
{
    partial class FrmIngreso
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
            txUsuario = new TextBox();
            label1 = new Label();
            txContraseña = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btCancelar = new Button();
            txLimpiar = new Button();
            btSalir = new Button();
            SuspendLayout();
            // 
            // btIngresar
            // 
            btIngresar.BackColor = Color.Black;
            btIngresar.Cursor = Cursors.Hand;
            btIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btIngresar.ForeColor = Color.White;
            btIngresar.Location = new Point(182, 193);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(94, 36);
            btIngresar.TabIndex = 0;
            btIngresar.Text = "Ingresar";
            btIngresar.UseVisualStyleBackColor = false;
            btIngresar.Click += btIngresar_Click;
            // 
            // txUsuario
            // 
            txUsuario.BackColor = Color.LawnGreen;
            txUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txUsuario.ForeColor = Color.Black;
            txUsuario.Location = new Point(182, 127);
            txUsuario.Name = "txUsuario";
            txUsuario.Size = new Size(125, 27);
            txUsuario.TabIndex = 1;
            txUsuario.TextChanged += txUsuario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(211, 36);
            label1.Name = "label1";
            label1.Size = new Size(254, 20);
            label1.TabIndex = 2;
            label1.Text = "Complete con usuario y contraseña";
            // 
            // txContraseña
            // 
            txContraseña.BackColor = Color.LawnGreen;
            txContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txContraseña.ForeColor = Color.Black;
            txContraseña.Location = new Point(346, 127);
            txContraseña.Name = "txContraseña";
            txContraseña.PasswordChar = '*';
            txContraseña.Size = new Size(125, 27);
            txContraseña.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(211, 92);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(369, 92);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.Black;
            btCancelar.Cursor = Cursors.Hand;
            btCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btCancelar.ForeColor = Color.White;
            btCancelar.Location = new Point(377, 193);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(94, 36);
            btCancelar.TabIndex = 6;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // txLimpiar
            // 
            txLimpiar.BackColor = Color.Black;
            txLimpiar.Cursor = Cursors.Hand;
            txLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txLimpiar.ForeColor = Color.White;
            txLimpiar.Location = new Point(182, 235);
            txLimpiar.Name = "txLimpiar";
            txLimpiar.Size = new Size(283, 36);
            txLimpiar.TabIndex = 7;
            txLimpiar.Text = "Limpiar campos";
            txLimpiar.UseVisualStyleBackColor = false;
            txLimpiar.Click += txLimpiar_Click;
            // 
            // btSalir
            // 
            btSalir.BackColor = Color.Black;
            btSalir.Cursor = Cursors.Hand;
            btSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btSalir.ForeColor = Color.White;
            btSalir.Location = new Point(555, 243);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(94, 36);
            btSalir.TabIndex = 8;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = false;
            btSalir.Click += btSalir_Click;
            // 
            // FrmIngreso
            // 
            AcceptButton = btIngresar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(661, 291);
            Controls.Add(btSalir);
            Controls.Add(txLimpiar);
            Controls.Add(btCancelar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txContraseña);
            Controls.Add(label1);
            Controls.Add(txUsuario);
            Controls.Add(btIngresar);
            Name = "FrmIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmIngreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btIngresar;
        private TextBox txUsuario;
        private Label label1;
        private TextBox txContraseña;
        private Label label2;
        private Label label3;
        private Button btCancelar;
        private Button txLimpiar;
        private Button btSalir;
    }
}