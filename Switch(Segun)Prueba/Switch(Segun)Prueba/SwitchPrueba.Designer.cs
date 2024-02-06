namespace Switch_Segun_Prueba
{
    partial class SwitchPrueba
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
            btaceptar = new Button();
            txingresar = new TextBox();
            lblrespuesta = new Label();
            label1 = new Label();
            btNuevo = new Button();
            SuspendLayout();
            // 
            // btSalir
            // 
            btSalir.Cursor = Cursors.Hand;
            btSalir.Location = new Point(12, 226);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(112, 39);
            btSalir.TabIndex = 0;
            btSalir.Text = "salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // btaceptar
            // 
            btaceptar.Location = new Point(194, 89);
            btaceptar.Name = "btaceptar";
            btaceptar.Size = new Size(110, 27);
            btaceptar.TabIndex = 1;
            btaceptar.Text = "Aceptar";
            btaceptar.UseVisualStyleBackColor = true;
            btaceptar.Click += btaceptar_Click;
            // 
            // txingresar
            // 
            txingresar.Location = new Point(47, 89);
            txingresar.Name = "txingresar";
            txingresar.Size = new Size(125, 27);
            txingresar.TabIndex = 2;
            // 
            // lblrespuesta
            // 
            lblrespuesta.AutoSize = true;
            lblrespuesta.Location = new Point(47, 153);
            lblrespuesta.Name = "lblrespuesta";
            lblrespuesta.Size = new Size(50, 20);
            lblrespuesta.TabIndex = 3;
            lblrespuesta.Text = "label1";
            lblrespuesta.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 48);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 4;
            label1.Text = "Ingrese su edad";
            // 
            // btNuevo
            // 
            btNuevo.Cursor = Cursors.Hand;
            btNuevo.Location = new Point(491, 231);
            btNuevo.Name = "btNuevo";
            btNuevo.Size = new Size(94, 29);
            btNuevo.TabIndex = 5;
            btNuevo.Text = "Switch-2";
            btNuevo.UseVisualStyleBackColor = true;
            btNuevo.Click += btNuevo_Click;
            // 
            // SwitchPrueba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 286);
            Controls.Add(btNuevo);
            Controls.Add(label1);
            Controls.Add(lblrespuesta);
            Controls.Add(txingresar);
            Controls.Add(btaceptar);
            Controls.Add(btSalir);
            Name = "SwitchPrueba";
            Text = "SwitchPrueba";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSalir;
        private Button btaceptar;
        private TextBox txingresar;
        private Label lblrespuesta;
        private Label label1;
        private Button btNuevo;
    }
}