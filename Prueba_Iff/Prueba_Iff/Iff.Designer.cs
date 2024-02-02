namespace Prueba_Iff
{
    partial class Iff
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
            btNuevo = new Button();
            btCerrar = new Button();
            SuspendLayout();
            // 
            // btNuevo
            // 
            btNuevo.Location = new Point(265, 162);
            btNuevo.Name = "btNuevo";
            btNuevo.Size = new Size(201, 70);
            btNuevo.TabIndex = 0;
            btNuevo.Text = "Ir a formulario --Nuevo";
            btNuevo.UseVisualStyleBackColor = true;
            btNuevo.Click += btNuevo_Click;
            // 
            // btCerrar
            // 
            btCerrar.Cursor = Cursors.Hand;
            btCerrar.Location = new Point(605, 369);
            btCerrar.Name = "btCerrar";
            btCerrar.Size = new Size(157, 54);
            btCerrar.TabIndex = 1;
            btCerrar.Text = "salir";
            btCerrar.UseVisualStyleBackColor = true;
            btCerrar.Click += btCerrar_Click;
            // 
            // Iff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(btCerrar);
            Controls.Add(btNuevo);
            Name = "Iff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iff";
            ResumeLayout(false);
        }

        #endregion

        private Button btNuevo;
        private Button btCerrar;
    }
}