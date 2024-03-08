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
            btClick = new Button();
            Txingresar = new TextBox();
            lbRes = new Label();
            btlimpiar = new Button();
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
            btini.Location = new Point(95, 145);
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
            lbnombre.Location = new Point(27, 71);
            lbnombre.Name = "lbnombre";
            lbnombre.Size = new Size(401, 41);
            lbnombre.TabIndex = 2;
            lbnombre.Text = ">>> Click en comenzar <<<";
            // 
            // btreestablecer
            // 
            btreestablecer.Cursor = Cursors.Hand;
            btreestablecer.Location = new Point(95, 191);
            btreestablecer.Name = "btreestablecer";
            btreestablecer.Size = new Size(227, 40);
            btreestablecer.TabIndex = 3;
            btreestablecer.Text = "Reestablecer";
            btreestablecer.UseVisualStyleBackColor = true;
            btreestablecer.Click += btreestablecer_Click;
            // 
            // btClick
            // 
            btClick.Location = new Point(480, 145);
            btClick.Name = "btClick";
            btClick.Size = new Size(227, 40);
            btClick.TabIndex = 4;
            btClick.Text = ">>> Click <<<";
            btClick.UseVisualStyleBackColor = true;
            btClick.Click += btClick_Click;
            // 
            // Txingresar
            // 
            Txingresar.Location = new Point(516, 204);
            Txingresar.Name = "Txingresar";
            Txingresar.Size = new Size(151, 27);
            Txingresar.TabIndex = 5;
            // 
            // lbRes
            // 
            lbRes.AutoSize = true;
            lbRes.Font = new Font("Segoe UI", 18F);
            lbRes.Location = new Point(293, 295);
            lbRes.Name = "lbRes";
            lbRes.Size = new Size(291, 41);
            lbRes.TabIndex = 6;
            lbRes.Text = ">>> Resultado <<<";
            // 
            // btlimpiar
            // 
            btlimpiar.Cursor = Cursors.Hand;
            btlimpiar.Location = new Point(480, 237);
            btlimpiar.Name = "btlimpiar";
            btlimpiar.Size = new Size(227, 40);
            btlimpiar.TabIndex = 7;
            btlimpiar.Text = "Limpiar campo";
            btlimpiar.UseVisualStyleBackColor = true;
            btlimpiar.Click += btlimpiar_Click;
            // 
            // FrmIni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btlimpiar);
            Controls.Add(lbRes);
            Controls.Add(Txingresar);
            Controls.Add(btClick);
            Controls.Add(btreestablecer);
            Controls.Add(lbnombre);
            Controls.Add(btini);
            Controls.Add(btsalir);
            Name = "FrmIni";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Primer formulario - HolaMundo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btini;
        private Label lbnombre;
        private Button btreestablecer;
        private Button btClick;
        private TextBox Txingresar;
        private Label lbRes;
        private Button btlimpiar;
    }
}