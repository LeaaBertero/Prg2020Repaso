namespace ArregloDias
{
    partial class Dias
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
            lbDias = new Label();
            btMostrar = new Button();
            label1 = new Label();
            btsalir = new Button();
            SuspendLayout();
            // 
            // lbDias
            // 
            lbDias.AutoSize = true;
            lbDias.BackColor = Color.Lime;
            lbDias.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbDias.Location = new Point(499, 94);
            lbDias.Name = "lbDias";
            lbDias.Size = new Size(65, 25);
            lbDias.TabIndex = 0;
            lbDias.Text = "label1";
            lbDias.Visible = false;
            // 
            // btMostrar
            // 
            btMostrar.BackColor = Color.LightSeaGreen;
            btMostrar.Cursor = Cursors.Hand;
            btMostrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btMostrar.Location = new Point(165, 90);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(134, 42);
            btMostrar.TabIndex = 1;
            btMostrar.Text = "Mostrar semana";
            btMostrar.UseVisualStyleBackColor = false;
            btMostrar.Click += btMostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(542, 50);
            label1.TabIndex = 2;
            label1.Text = "Ejercicio de Dias de la semana";
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(694, 313);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 3;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // Dias
            // 
            AcceptButton = btMostrar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(800, 354);
            Controls.Add(btsalir);
            Controls.Add(label1);
            Controls.Add(btMostrar);
            Controls.Add(lbDias);
            Name = "Dias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDias;
        private Button btMostrar;
        private Label label1;
        private Button btsalir;
    }
}