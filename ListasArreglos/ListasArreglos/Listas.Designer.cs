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
            SuspendLayout();
            // 
            // btcargar
            // 
            btcargar.Cursor = Cursors.Hand;
            btcargar.Location = new Point(63, 138);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(130, 40);
            btcargar.TabIndex = 0;
            btcargar.Text = "Cargar";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(216, 145);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(125, 27);
            txNombre.TabIndex = 1;
            txNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.Location = new Point(555, 152);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(50, 20);
            lbLista.TabIndex = 2;
            lbLista.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(443, 91);
            label2.Name = "label2";
            label2.Size = new Size(259, 41);
            label2.TabIndex = 3;
            label2.Text = "Lista de personas";
            // 
            // btDimension
            // 
            btDimension.Cursor = Cursors.Hand;
            btDimension.Location = new Point(63, 92);
            btDimension.Name = "btDimension";
            btDimension.Size = new Size(130, 40);
            btDimension.TabIndex = 4;
            btDimension.Text = "Dimensionar";
            btDimension.UseVisualStyleBackColor = true;
            btDimension.Click += btDimension_Click;
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Font = new Font("Segoe UI", 10F);
            btsalir.Location = new Point(726, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(114, 34);
            btsalir.TabIndex = 5;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btMostrar
            // 
            btMostrar.Cursor = Cursors.Hand;
            btMostrar.Location = new Point(63, 184);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(130, 40);
            btMostrar.TabIndex = 6;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // txDomensionar
            // 
            txDomensionar.Location = new Point(216, 95);
            txDomensionar.Name = "txDomensionar";
            txDomensionar.Size = new Size(125, 27);
            txDomensionar.TabIndex = 7;
            txDomensionar.TextAlign = HorizontalAlignment.Center;
            // 
            // Listas
            // 
            AcceptButton = btcargar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(852, 450);
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
    }
}