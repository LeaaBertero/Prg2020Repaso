namespace InstruccionFor
{
    partial class ForIni
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
            btSalir = new Button();
            btIniciar = new Button();
            TXDesde = new TextBox();
            TxPaso = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxHasta = new TextBox();
            label3 = new Label();
            label4 = new Label();
            LbResultado = new Label();
            SuspendLayout();
            // 
            // btSalir
            // 
            btSalir.Cursor = Cursors.Hand;
            btSalir.Location = new Point(909, 12);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(105, 31);
            btSalir.TabIndex = 0;
            btSalir.Text = "salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // btIniciar
            // 
            btIniciar.Location = new Point(709, 212);
            btIniciar.Name = "btIniciar";
            btIniciar.Size = new Size(86, 27);
            btIniciar.TabIndex = 2;
            btIniciar.Text = "comenzar";
            btIniciar.UseVisualStyleBackColor = true;
            btIniciar.Click += btIniciar_Click;
            // 
            // TXDesde
            // 
            TXDesde.Location = new Point(212, 212);
            TXDesde.Name = "TXDesde";
            TXDesde.Size = new Size(125, 27);
            TXDesde.TabIndex = 3;
            // 
            // TxPaso
            // 
            TxPaso.Location = new Point(530, 212);
            TxPaso.Name = "TxPaso";
            TxPaso.Size = new Size(125, 27);
            TxPaso.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 189);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 5;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 189);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 6;
            label2.Text = "Paso";
            // 
            // TxHasta
            // 
            TxHasta.Location = new Point(366, 212);
            TxHasta.Name = "TxHasta";
            TxHasta.Size = new Size(125, 27);
            TxHasta.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28F);
            label3.Location = new Point(93, 73);
            label3.Name = "label3";
            label3.Size = new Size(871, 62);
            label3.TabIndex = 8;
            label3.Text = "Práctica de For (Estructura de repetición)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 189);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 9;
            label4.Text = "Hasta";
            // 
            // LbResultado
            // 
            LbResultado.AutoSize = true;
            LbResultado.Font = new Font("Segoe UI", 18F);
            LbResultado.Location = new Point(212, 308);
            LbResultado.Name = "LbResultado";
            LbResultado.Size = new Size(97, 41);
            LbResultado.TabIndex = 10;
            LbResultado.Text = "label5";
            LbResultado.Visible = false;
            // 
            // ForIni
            // 
            AcceptButton = btIniciar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 450);
            Controls.Add(LbResultado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxHasta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxPaso);
            Controls.Add(TXDesde);
            Controls.Add(btIniciar);
            Controls.Add(btSalir);
            Name = "ForIni";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForIni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSalir;
        private Button btIniciar;
        private TextBox TXDesde;
        private TextBox TxPaso;
        private Label label1;
        private Label label2;
        private TextBox TxHasta;
        private Label label3;
        private Label label4;
        private Label LbResultado;
    }
}