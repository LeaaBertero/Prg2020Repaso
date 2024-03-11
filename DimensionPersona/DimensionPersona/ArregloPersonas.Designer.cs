namespace DimensionPersona
{
    partial class ArregloPersonas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btcargar = new Button();
            txnombre = new TextBox();
            lblista = new Label();
            btmostrar = new Button();
            SuspendLayout();
            // 
            // btcargar
            // 
            btcargar.Location = new Point(120, 118);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(94, 29);
            btcargar.TabIndex = 0;
            btcargar.Text = "cargar";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // txnombre
            // 
            txnombre.Location = new Point(292, 120);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(125, 27);
            txnombre.TabIndex = 1;
            // 
            // lblista
            // 
            lblista.AutoSize = true;
            lblista.Location = new Point(519, 123);
            lblista.Name = "lblista";
            lblista.Size = new Size(50, 20);
            lblista.TabIndex = 2;
            lblista.Text = "label1";
            // 
            // btmostrar
            // 
            btmostrar.Location = new Point(120, 153);
            btmostrar.Name = "btmostrar";
            btmostrar.Size = new Size(94, 29);
            btmostrar.TabIndex = 3;
            btmostrar.Text = "Mostrar";
            btmostrar.UseVisualStyleBackColor = true;
            btmostrar.Click += btmostrar_Click;
            // 
            // ArregloPersonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btmostrar);
            Controls.Add(lblista);
            Controls.Add(txnombre);
            Controls.Add(btcargar);
            Name = "ArregloPersonas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcargar;
        private TextBox txnombre;
        private Label lblista;
        private Button btmostrar;
    }
}
