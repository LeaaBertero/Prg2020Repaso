namespace Prube003
{
    partial class PruebaCarga
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
            txNombre = new TextBox();
            txApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbLista = new Label();
            label3 = new Label();
            txDocumento = new TextBox();
            txMostrar = new Button();
            btsalir = new Button();
            SuspendLayout();
            // 
            // btcargar
            // 
            btcargar.Location = new Point(25, 132);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(94, 29);
            btcargar.TabIndex = 0;
            btcargar.Text = "cargar";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(177, 134);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(125, 27);
            txNombre.TabIndex = 1;
            // 
            // txApellido
            // 
            txApellido.Location = new Point(367, 132);
            txApellido.Name = "txApellido";
            txApellido.Size = new Size(125, 27);
            txApellido.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 89);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 89);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.Location = new Point(177, 302);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(50, 20);
            lbLista.TabIndex = 5;
            lbLista.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(550, 89);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 7;
            label3.Text = "Documento";
            // 
            // txDocumento
            // 
            txDocumento.Location = new Point(550, 134);
            txDocumento.Name = "txDocumento";
            txDocumento.Size = new Size(125, 27);
            txDocumento.TabIndex = 6;
            // 
            // txMostrar
            // 
            txMostrar.Location = new Point(25, 189);
            txMostrar.Name = "txMostrar";
            txMostrar.Size = new Size(94, 29);
            txMostrar.TabIndex = 8;
            txMostrar.Text = "Mostrar";
            txMostrar.UseVisualStyleBackColor = true;
            txMostrar.Click += txMostrar_Click;
            // 
            // btsalir
            // 
            btsalir.Location = new Point(694, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 9;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // PruebaCarga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btsalir);
            Controls.Add(txMostrar);
            Controls.Add(label3);
            Controls.Add(txDocumento);
            Controls.Add(lbLista);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txApellido);
            Controls.Add(txNombre);
            Controls.Add(btcargar);
            MinimizeBox = false;
            Name = "PruebaCarga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PruebaCarga";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcargar;
        private TextBox txNombre;
        private TextBox txApellido;
        private Label label1;
        private Label label2;
        private Label lbLista;
        private Label label3;
        private TextBox txDocumento;
        private Button txMostrar;
        private Button btsalir;
    }
}