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
            lbInscipcionMateria = new Label();
            btInscribir = new Button();
            label4 = new Label();
            txañoMateria = new TextBox();
            label3 = new Label();
            txnombreMateria = new TextBox();
            SuspendLayout();
            // 
            // TxApellido
            // 
            TxApellido.Location = new Point(319, 73);
            TxApellido.Name = "TxApellido";
            TxApellido.Size = new Size(125, 27);
            TxApellido.TabIndex = 2;
            // 
            // TxNombre
            // 
            TxNombre.Location = new Point(170, 71);
            TxNombre.Name = "TxNombre";
            TxNombre.Size = new Size(125, 27);
            TxNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 48);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 48);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // btcargar
            // 
            btcargar.Location = new Point(469, 73);
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
            lbMostrar.Location = new Point(170, 128);
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
            // lbInscipcionMateria
            // 
            lbInscipcionMateria.AutoSize = true;
            lbInscipcionMateria.Location = new Point(161, 311);
            lbInscipcionMateria.Name = "lbInscipcionMateria";
            lbInscipcionMateria.Size = new Size(50, 20);
            lbInscipcionMateria.TabIndex = 17;
            lbInscipcionMateria.Text = "label1";
            // 
            // btInscribir
            // 
            btInscribir.Location = new Point(469, 259);
            btInscribir.Name = "btInscribir";
            btInscribir.Size = new Size(94, 29);
            btInscribir.TabIndex = 16;
            btInscribir.Text = "Inscribir";
            btInscribir.UseVisualStyleBackColor = true;
            btInscribir.Click += btInscribir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 232);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 15;
            label4.Text = "Año de materia";
            // 
            // txañoMateria
            // 
            txañoMateria.Location = new Point(319, 259);
            txañoMateria.Name = "txañoMateria";
            txañoMateria.Size = new Size(125, 27);
            txañoMateria.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 232);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 13;
            label3.Text = "Nombre de materia";
            // 
            // txnombreMateria
            // 
            txnombreMateria.Location = new Point(161, 259);
            txnombreMateria.Name = "txnombreMateria";
            txnombreMateria.Size = new Size(125, 27);
            txnombreMateria.TabIndex = 12;
            // 
            // ProyectoPOO
            // 
            AcceptButton = btcargar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbInscipcionMateria);
            Controls.Add(btInscribir);
            Controls.Add(label4);
            Controls.Add(txañoMateria);
            Controls.Add(label3);
            Controls.Add(txnombreMateria);
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
        private Label lbInscipcionMateria;
        private Button btInscribir;
        private Label label4;
        private TextBox txañoMateria;
        private Label label3;
        private TextBox txnombreMateria;
    }
}