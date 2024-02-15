namespace prueba02
{
    partial class frmSuma
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
            btcalcular = new Button();
            lbresultadoSuma = new Label();
            txnumSuma1 = new TextBox();
            txnumSuma2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(694, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 0;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btcalcular
            // 
            btcalcular.Cursor = Cursors.Hand;
            btcalcular.Location = new Point(485, 130);
            btcalcular.Name = "btcalcular";
            btcalcular.Size = new Size(94, 29);
            btcalcular.TabIndex = 1;
            btcalcular.Text = "calcular";
            btcalcular.UseVisualStyleBackColor = true;
            btcalcular.Click += btcalcular_Click;
            // 
            // lbresultadoSuma
            // 
            lbresultadoSuma.AutoSize = true;
            lbresultadoSuma.Location = new Point(629, 135);
            lbresultadoSuma.Name = "lbresultadoSuma";
            lbresultadoSuma.Size = new Size(50, 20);
            lbresultadoSuma.TabIndex = 2;
            lbresultadoSuma.Text = "label1";
            // 
            // txnumSuma1
            // 
            txnumSuma1.Location = new Point(126, 128);
            txnumSuma1.Name = "txnumSuma1";
            txnumSuma1.Size = new Size(125, 27);
            txnumSuma1.TabIndex = 3;
            // 
            // txnumSuma2
            // 
            txnumSuma2.Location = new Point(331, 130);
            txnumSuma2.Name = "txnumSuma2";
            txnumSuma2.Size = new Size(125, 27);
            txnumSuma2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 12F);
            label2.Location = new Point(141, 85);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 5;
            label2.Text = "Número 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kristen ITC", 12F);
            label3.Location = new Point(340, 85);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 6;
            label3.Text = "Número 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 133);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 7;
            label1.Text = "+";
            // 
            // frmSuma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 256);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txnumSuma2);
            Controls.Add(txnumSuma1);
            Controls.Add(lbresultadoSuma);
            Controls.Add(btcalcular);
            Controls.Add(btsalir);
            Name = "frmSuma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSuma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btcalcular;
        private Label lbresultadoSuma;
        private TextBox txnumSuma1;
        private TextBox txnumSuma2;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}