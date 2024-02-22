namespace ProyectoPOO
{
    partial class pruebaCargaPersonas
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
            txapellido = new TextBox();
            lbmostrar = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btcargar
            // 
            btcargar.Location = new Point(548, 151);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(94, 29);
            btcargar.TabIndex = 0;
            btcargar.Text = "cargar";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // txnombre
            // 
            txnombre.Location = new Point(221, 152);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(125, 27);
            txnombre.TabIndex = 1;
            // 
            // txapellido
            // 
            txapellido.Location = new Point(382, 152);
            txapellido.Name = "txapellido";
            txapellido.Size = new Size(125, 27);
            txapellido.TabIndex = 2;
            // 
            // lbmostrar
            // 
            lbmostrar.AutoSize = true;
            lbmostrar.Location = new Point(221, 285);
            lbmostrar.Name = "lbmostrar";
            lbmostrar.Size = new Size(50, 20);
            lbmostrar.TabIndex = 3;
            lbmostrar.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 109);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 4;
            label2.Text = "nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 109);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "apellido";
            // 
            // pruebaCargaPersonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbmostrar);
            Controls.Add(txapellido);
            Controls.Add(txnombre);
            Controls.Add(btcargar);
            Name = "pruebaCargaPersonas";
            Text = "pruebaCargaPersonas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcargar;
        private TextBox txnombre;
        private TextBox txapellido;
        private Label lbmostrar;
        private Label label2;
        private Label label3;
    }
}