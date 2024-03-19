namespace ArregloPrueba
{
    partial class ArregloPrueba
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
            txnombre = new TextBox();
            txbarrio = new TextBox();
            txlocalidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbLista = new Label();
            btMostrar = new Button();
            txedad = new Label();
            textBox1 = new TextBox();
            btsalir = new Button();
            SuspendLayout();
            // 
            // btCargar
            // 
            btCargar.Location = new Point(81, 158);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(94, 29);
            btCargar.TabIndex = 0;
            btCargar.Text = "Cargar";
            btCargar.UseVisualStyleBackColor = true;
            btCargar.Click += btCargar_Click;
            // 
            // txnombre
            // 
            txnombre.Location = new Point(254, 158);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(125, 27);
            txnombre.TabIndex = 1;
            // 
            // txbarrio
            // 
            txbarrio.Location = new Point(394, 160);
            txbarrio.Name = "txbarrio";
            txbarrio.Size = new Size(125, 27);
            txbarrio.TabIndex = 2;
            // 
            // txlocalidad
            // 
            txlocalidad.Location = new Point(536, 160);
            txlocalidad.Name = "txlocalidad";
            txlocalidad.Size = new Size(125, 27);
            txlocalidad.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(536, 135);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 4;
            label1.Text = "Localidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 135);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Barrio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 135);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.Location = new Point(254, 269);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(50, 20);
            lbLista.TabIndex = 7;
            lbLista.Text = "label4";
            lbLista.Visible = false;
            // 
            // btMostrar
            // 
            btMostrar.Location = new Point(81, 202);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(94, 29);
            btMostrar.TabIndex = 8;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // txedad
            // 
            txedad.AutoSize = true;
            txedad.Enabled = false;
            txedad.Location = new Point(678, 135);
            txedad.Name = "txedad";
            txedad.Size = new Size(43, 20);
            txedad.TabIndex = 10;
            txedad.Text = "Edad";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(678, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(851, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 11;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // ArregloPrueba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 450);
            Controls.Add(btsalir);
            Controls.Add(txedad);
            Controls.Add(textBox1);
            Controls.Add(btMostrar);
            Controls.Add(lbLista);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txlocalidad);
            Controls.Add(txbarrio);
            Controls.Add(txnombre);
            Controls.Add(btCargar);
            Name = "ArregloPrueba";
            Text = "ArregloPrueba";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCargar;
        private TextBox txnombre;
        private TextBox txbarrio;
        private TextBox txlocalidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbLista;
        private Button btMostrar;
        private Label txedad;
        private TextBox textBox1;
        private Button btsalir;
    }
}