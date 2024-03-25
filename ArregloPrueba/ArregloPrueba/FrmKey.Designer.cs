namespace ArregloPrueba
{
    partial class FrmKey
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
            btClave = new Button();
            label1 = new Label();
            txClave = new TextBox();
            lbMensajeError = new Label();
            btsalir = new Button();
            SuspendLayout();
            // 
            // btClave
            // 
            btClave.Location = new Point(317, 105);
            btClave.Name = "btClave";
            btClave.Size = new Size(94, 29);
            btClave.TabIndex = 0;
            btClave.Text = "Ingresar";
            btClave.UseVisualStyleBackColor = true;
            btClave.Click += btClave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Purple;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(126, 50);
            label1.Name = "label1";
            label1.Size = new Size(326, 23);
            label1.TabIndex = 5;
            label1.Text = "Bienvenido, para iniciar ingrese la clave";
            // 
            // txClave
            // 
            txClave.Location = new Point(157, 105);
            txClave.Name = "txClave";
            txClave.PasswordChar = '*';
            txClave.PlaceholderText = "Contraseña";
            txClave.Size = new Size(121, 27);
            txClave.TabIndex = 6;
            // 
            // lbMensajeError
            // 
            lbMensajeError.AutoSize = true;
            lbMensajeError.ForeColor = SystemColors.Control;
            lbMensajeError.Location = new Point(157, 203);
            lbMensajeError.Name = "lbMensajeError";
            lbMensajeError.Size = new Size(50, 20);
            lbMensajeError.TabIndex = 7;
            lbMensajeError.Text = "label2";
            lbMensajeError.Visible = false;
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(12, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 8;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // FrmKey
            // 
            AcceptButton = btClave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(568, 254);
            Controls.Add(btsalir);
            Controls.Add(lbMensajeError);
            Controls.Add(txClave);
            Controls.Add(label1);
            Controls.Add(btClave);
            Name = "FrmKey";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmKey";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btClave;
        private Label label1;
        private TextBox txClave;
        private Label lbMensajeError;
        private Button btsalir;
    }
}