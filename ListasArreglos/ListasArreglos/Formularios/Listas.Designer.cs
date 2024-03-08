namespace ListasArreglos
{
    partial class Listas
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
            lbLista = new Label();
            label2 = new Label();
            btDimension = new Button();
            btsalir = new Button();
            btMostrar = new Button();
            txDomensionar = new TextBox();
            txAñoNacimiento = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txDocumento = new TextBox();
            SuspendLayout();
            // 
            // btcargar
            // 
            btcargar.Cursor = Cursors.Hand;
            btcargar.Location = new Point(12, 159);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(105, 30);
            btcargar.TabIndex = 3;
            btcargar.Text = "Cargar";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(144, 159);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(94, 27);
            txNombre.TabIndex = 2;
            txNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.Location = new Point(726, 222);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(50, 20);
            lbLista.TabIndex = 2;
            lbLista.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(726, 112);
            label2.Name = "label2";
            label2.Size = new Size(259, 41);
            label2.TabIndex = 3;
            label2.Text = "Lista de personas";
            // 
            // btDimension
            // 
            btDimension.Cursor = Cursors.Hand;
            btDimension.Location = new Point(12, 77);
            btDimension.Name = "btDimension";
            btDimension.Size = new Size(105, 30);
            btDimension.TabIndex = 0;
            btDimension.Text = "Dimensionar";
            btDimension.UseVisualStyleBackColor = true;
            
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Font = new Font("Segoe UI", 10F);
            btsalir.Location = new Point(1057, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(105, 30);
            btsalir.TabIndex = 5;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btMostrar
            // 
            btMostrar.Cursor = Cursors.Hand;
            btMostrar.Location = new Point(12, 244);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(105, 30);
            btMostrar.TabIndex = 4;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // txDomensionar
            // 
            txDomensionar.Location = new Point(144, 80);
            txDomensionar.Name = "txDomensionar";
            txDomensionar.Size = new Size(94, 27);
            txDomensionar.TabIndex = 1;
            txDomensionar.TextAlign = HorizontalAlignment.Center;
            // 
            // txAñoNacimiento
            // 
            txAñoNacimiento.Location = new Point(273, 159);
            txAñoNacimiento.Name = "txAñoNacimiento";
            txAñoNacimiento.Size = new Size(94, 27);
            txAñoNacimiento.TabIndex = 3;
            txAñoNacimiento.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 52);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 9;
            label1.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 129);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 10;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 129);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 11;
            label4.Text = "Año de nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 129);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 13;
            label5.Text = "Documento";
            // 
            // txDocumento
            // 
            txDocumento.Location = new Point(423, 159);
            txDocumento.Name = "txDocumento";
            txDocumento.Size = new Size(94, 27);
            txDocumento.TabIndex = 4;
            txDocumento.TextAlign = HorizontalAlignment.Center;
            // 
            // Listas
            // 
            AcceptButton = btcargar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(1174, 450);
            Controls.Add(label5);
            Controls.Add(txDocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txAñoNacimiento);
            Controls.Add(txDomensionar);
            Controls.Add(btMostrar);
            Controls.Add(btsalir);
            Controls.Add(btDimension);
            Controls.Add(label2);
            Controls.Add(lbLista);
            Controls.Add(txNombre);
            Controls.Add(btcargar);
            MaximizeBox = false;
            Name = "Listas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcargar;
        private TextBox txNombre;
        private Label lbLista;
        private Label label2;
        private Button btDimension;
        private Button btsalir;
        private Button btMostrar;
        private TextBox txDomensionar;
        private TextBox txAñoNacimiento;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txDocumento;
    }
}