namespace ListaRepaso2
{
    partial class ListaRepaso2
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
            btcargar = new Button();
            lbLista = new Label();
            txcargar = new TextBox();
            label2 = new Label();
            btsalir = new Button();
            btMostrar = new Button();
            SuspendLayout();
            // 
            // btcargar
            // 
            btcargar.Location = new Point(101, 161);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(94, 29);
            btcargar.TabIndex = 0;
            btcargar.Text = "Cargar";
            btcargar.UseVisualStyleBackColor = true;
            
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.Location = new Point(473, 170);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(50, 20);
            lbLista.TabIndex = 1;
            lbLista.Text = "label1";
            // 
            // txcargar
            // 
            txcargar.Location = new Point(227, 163);
            txcargar.Name = "txcargar";
            txcargar.Size = new Size(125, 27);
            txcargar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 140);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // btsalir
            // 
            btsalir.Location = new Point(694, 409);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 4;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btMostrar
            // 
            btMostrar.Location = new Point(101, 196);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(94, 29);
            btMostrar.TabIndex = 5;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = true;
            
            // 
            // ListaRepaso2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btMostrar);
            Controls.Add(btsalir);
            Controls.Add(label2);
            Controls.Add(txcargar);
            Controls.Add(lbLista);
            Controls.Add(btcargar);
            Name = "ListaRepaso2";
            Text = "ListaRepaso2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcargar;
        private Label lbLista;
        private TextBox txcargar;
        private Label label2;
        private Button btsalir;
        private Button btMostrar;
    }
}