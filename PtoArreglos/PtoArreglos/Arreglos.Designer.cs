namespace PtoArreglos
{
    partial class Arreglos
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
            txnombre = new TextBox();
            lbLista = new Label();
            txAñonacimiento = new TextBox();
            Txmostrar = new Button();
            btsalir = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btcargar
            // 
            btcargar.Cursor = Cursors.Hand;
            btcargar.Location = new Point(86, 83);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(94, 29);
            btcargar.TabIndex = 0;
            btcargar.Text = "Cargar";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // txnombre
            // 
            txnombre.Location = new Point(241, 85);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(125, 27);
            txnombre.TabIndex = 1;
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.Location = new Point(548, 88);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(50, 20);
            lbLista.TabIndex = 3;
            lbLista.Text = "label1";
            lbLista.Visible = false;
            // 
            // txAñonacimiento
            // 
            txAñonacimiento.Location = new Point(372, 85);
            txAñonacimiento.Name = "txAñonacimiento";
            txAñonacimiento.Size = new Size(125, 27);
            txAñonacimiento.TabIndex = 2;
            // 
            // Txmostrar
            // 
            Txmostrar.Cursor = Cursors.Hand;
            Txmostrar.Location = new Point(86, 118);
            Txmostrar.Name = "Txmostrar";
            Txmostrar.Size = new Size(94, 29);
            Txmostrar.TabIndex = 4;
            Txmostrar.Text = "Mostrar";
            Txmostrar.UseVisualStyleBackColor = true;
            Txmostrar.Click += Txmostrar_Click;
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(694, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 5;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 62);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 62);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Año Nac";
            // 
            // Arreglos
            // 
            AcceptButton = btcargar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btsalir);
            Controls.Add(Txmostrar);
            Controls.Add(txAñonacimiento);
            Controls.Add(lbLista);
            Controls.Add(txnombre);
            Controls.Add(btcargar);
            Name = "Arreglos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arreglos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcargar;
        private TextBox txnombre;
        private Label lbLista;
        private TextBox txAñonacimiento;
        private Button Txmostrar;
        private Button btsalir;
        private Label label1;
        private Label label2;
    }
}