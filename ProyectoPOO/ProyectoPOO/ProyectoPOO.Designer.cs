namespace ProyectoPOO
{
    partial class ProyectoPOO
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
            TxApellido = new TextBox();
            TxNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btcargar = new Button();
            lbMostrar = new Label();
            btsalir = new Button();
            SuspendLayout();
            // 
            // TxApellido
            // 
            TxApellido.Location = new Point(361, 128);
            TxApellido.Name = "TxApellido";
            TxApellido.Size = new Size(125, 27);
            TxApellido.TabIndex = 2;
            // 
            // TxNombre
            // 
            TxNombre.Location = new Point(212, 128);
            TxNombre.Name = "TxNombre";
            TxNombre.Size = new Size(125, 27);
            TxNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 89);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 89);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // btcargar
            // 
            btcargar.Location = new Point(511, 128);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(94, 29);
            btcargar.TabIndex = 3;
            btcargar.Text = "Cargar";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // lbMostrar
            // 
            lbMostrar.AutoSize = true;
            lbMostrar.Location = new Point(212, 240);
            lbMostrar.Name = "lbMostrar";
            lbMostrar.Size = new Size(50, 20);
            lbMostrar.TabIndex = 5;
            lbMostrar.Text = "label3";
            // 
            // btsalir
            // 
            btsalir.Location = new Point(694, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 6;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // ProyectoPOO
            // 
            AcceptButton = btcargar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btsalir);
            Controls.Add(lbMostrar);
            Controls.Add(btcargar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxNombre);
            Controls.Add(TxApellido);
            Name = "ProyectoPOO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProyectoPOO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxApellido;
        private TextBox TxNombre;
        private Label label1;
        private Label label2;
        private Button btcargar;
        private Label lbMostrar;
        private Button btsalir;
    }
}