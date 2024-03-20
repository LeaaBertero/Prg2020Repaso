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
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btCargar
            // 
            btCargar.Cursor = Cursors.Hand;
            btCargar.Location = new Point(85, 255);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(94, 29);
            btCargar.TabIndex = 5;
            btCargar.Text = "Cargar";
            btCargar.UseVisualStyleBackColor = true;
            btCargar.Click += btCargar_Click;
            // 
            // txnombre
            // 
            txnombre.Location = new Point(85, 147);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(125, 27);
            txnombre.TabIndex = 1;
            // 
            // txbarrio
            // 
            txbarrio.Location = new Point(85, 210);
            txbarrio.Name = "txbarrio";
            txbarrio.Size = new Size(125, 27);
            txbarrio.TabIndex = 3;
            // 
            // txlocalidad
            // 
            txlocalidad.Location = new Point(229, 149);
            txlocalidad.Name = "txlocalidad";
            txlocalidad.Size = new Size(125, 27);
            txlocalidad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Purple;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(229, 124);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Localidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Purple;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(85, 185);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 5;
            label2.Text = "Barrio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Purple;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(85, 124);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.BackColor = Color.Violet;
            lbLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbLista.Location = new Point(456, 167);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(51, 20);
            lbLista.TabIndex = 7;
            lbLista.Text = "label4";
            lbLista.Visible = false;
            // 
            // btMostrar
            // 
            btMostrar.Cursor = Cursors.Hand;
            btMostrar.Location = new Point(229, 255);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(94, 29);
            btMostrar.TabIndex = 6;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // txedad
            // 
            txedad.AutoSize = true;
            txedad.BackColor = Color.Purple;
            txedad.Enabled = false;
            txedad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txedad.ForeColor = SystemColors.Control;
            txedad.Location = new Point(229, 188);
            txedad.Name = "txedad";
            txedad.Size = new Size(43, 20);
            txedad.TabIndex = 10;
            txedad.Text = "Edad";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(229, 213);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(708, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 7;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 75);
            label4.Name = "label4";
            label4.Size = new Size(650, 28);
            label4.TabIndex = 11;
            label4.Text = "Programa que utiliza una carga de solamente tres personas";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(456, 116);
            label5.Name = "label5";
            label5.Size = new Size(222, 28);
            label5.TabIndex = 12;
            label5.Text = "LISTA DE PERSONAS";
            // 
            // ArregloPrueba
            // 
            AcceptButton = btCargar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(814, 463);
            Controls.Add(label5);
            Controls.Add(label4);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label4;
        private Label label5;
    }
}