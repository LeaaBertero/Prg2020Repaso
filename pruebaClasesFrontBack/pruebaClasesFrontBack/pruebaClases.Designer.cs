namespace pruebaClasesFrontBack
{
    partial class pruebaClases
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
            btejecutar = new Button();
            txNombre = new TextBox();
            labelLista = new Label();
            label2 = new Label();
            label1 = new Label();
            txApellido = new TextBox();
            label3 = new Label();
            txDocumento = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txDireccion = new TextBox();
            SuspendLayout();
            // 
            // btejecutar
            // 
            btejecutar.Location = new Point(110, 260);
            btejecutar.Name = "btejecutar";
            btejecutar.Size = new Size(119, 29);
            btejecutar.TabIndex = 0;
            btejecutar.Text = "Ejecutar";
            btejecutar.UseVisualStyleBackColor = true;
            btejecutar.Click += btejecutar_Click;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(110, 98);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(208, 27);
            txNombre.TabIndex = 1;
            txNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // labelLista
            // 
            labelLista.AutoSize = true;
            labelLista.Location = new Point(454, 264);
            labelLista.Name = "labelLista";
            labelLista.Size = new Size(50, 20);
            labelLista.TabIndex = 2;
            labelLista.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 23);
            label2.Name = "label2";
            label2.Size = new Size(196, 20);
            label2.TabIndex = 3;
            label2.Text = "Ingrese los datos personales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 67);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // txApellido
            // 
            txApellido.Location = new Point(110, 179);
            txApellido.Name = "txApellido";
            txApellido.Size = new Size(208, 27);
            txApellido.TabIndex = 5;
            txApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 148);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // txDocumento
            // 
            txDocumento.Location = new Point(454, 98);
            txDocumento.Name = "txDocumento";
            txDocumento.Size = new Size(208, 27);
            txDocumento.TabIndex = 7;
            txDocumento.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 67);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 8;
            label4.Text = "Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 148);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 10;
            label5.Text = "Direccion";
            // 
            // txDireccion
            // 
            txDireccion.Location = new Point(454, 179);
            txDireccion.Name = "txDireccion";
            txDireccion.Size = new Size(208, 27);
            txDireccion.TabIndex = 9;
            txDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // pruebaClases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txDireccion);
            Controls.Add(label4);
            Controls.Add(txDocumento);
            Controls.Add(label3);
            Controls.Add(txApellido);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(labelLista);
            Controls.Add(txNombre);
            Controls.Add(btejecutar);
            Name = "pruebaClases";
            Text = "pruebaClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btejecutar;
        private TextBox txNombre;
        private Label labelLista;
        private Label label2;
        private Label label1;
        private TextBox txApellido;
        private Label label3;
        private TextBox txDocumento;
        private Label label4;
        private Label label5;
        private TextBox txDireccion;
    }
}