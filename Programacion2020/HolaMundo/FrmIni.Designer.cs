namespace HolaMundo
{
    partial class FrmIni
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
            btsalir = new Button();
            btini = new Button();
            lbnombre = new Label();
            btreestablecer = new Button();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(638, 30);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(133, 40);
            btsalir.TabIndex = 0;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btini
            // 
            btini.Cursor = Cursors.Hand;
            btini.Location = new Point(296, 279);
            btini.Name = "btini";
            btini.Size = new Size(227, 40);
            btini.TabIndex = 1;
            btini.Text = "comenzar";
            btini.UseVisualStyleBackColor = true;
            btini.Click += btini_Click;
            // 
            // lbnombre
            // 
            lbnombre.AutoSize = true;
            lbnombre.Font = new Font("Segoe UI", 18F);
            lbnombre.Location = new Point(206, 131);
            lbnombre.Name = "lbnombre";
            lbnombre.Size = new Size(401, 41);
            lbnombre.TabIndex = 2;
            lbnombre.Text = ">>> Click en comenzar <<<";
            // 
            // btreestablecer
            // 
            btreestablecer.Cursor = Cursors.Hand;
            btreestablecer.Location = new Point(296, 325);
            btreestablecer.Name = "btreestablecer";
            btreestablecer.Size = new Size(227, 40);
            btreestablecer.TabIndex = 3;
            btreestablecer.Text = "Reestablecer";
            btreestablecer.UseVisualStyleBackColor = true;
            btreestablecer.Click += btreestablecer_Click;
            // 
            // FrmIni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btreestablecer);
            Controls.Add(lbnombre);
            Controls.Add(btini);
            Controls.Add(btsalir);
            Name = "FrmIni";
            Text = "Primer formulario - HolaMundo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btini;
        private Label lbnombre;
        private Button btreestablecer;
    }
}