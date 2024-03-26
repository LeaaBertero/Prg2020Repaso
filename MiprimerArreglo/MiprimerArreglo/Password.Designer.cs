namespace MiprimerArreglo
{
    partial class Password
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
            btAceptar = new Button();
            txClave = new TextBox();
            label1 = new Label();
            btSalir = new Button();
            SuspendLayout();
            // 
            // btAceptar
            // 
            btAceptar.BackColor = Color.Gold;
            btAceptar.Cursor = Cursors.Hand;
            btAceptar.Location = new Point(326, 94);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(94, 29);
            btAceptar.TabIndex = 0;
            btAceptar.Text = "Aceptar";
            btAceptar.UseVisualStyleBackColor = false;
            btAceptar.Click += btAceptar_Click;
            // 
            // txClave
            // 
            txClave.Location = new Point(168, 95);
            txClave.Name = "txClave";
            txClave.PasswordChar = '*';
            txClave.Size = new Size(125, 27);
            txClave.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 72);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingresá la clave";
            // 
            // btSalir
            // 
            btSalir.BackColor = Color.Gold;
            btSalir.Cursor = Cursors.Hand;
            btSalir.Location = new Point(493, 12);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(94, 29);
            btSalir.TabIndex = 3;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = false;
            btSalir.Click += btSalir_Click;
            // 
            // Password
            // 
            AcceptButton = btAceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(599, 190);
            Controls.Add(btSalir);
            Controls.Add(label1);
            Controls.Add(txClave);
            Controls.Add(btAceptar);
            Name = "Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAceptar;
        private TextBox txClave;
        private Label label1;
        private Button btSalir;
    }
}