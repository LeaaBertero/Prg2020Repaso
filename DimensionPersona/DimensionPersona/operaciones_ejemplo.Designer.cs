namespace DimensionPersona
{
    partial class operaciones_ejemplo
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
            btcalcular = new Button();
            txnumero1 = new TextBox();
            txnumero2 = new TextBox();
            resultado = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btcalcular
            // 
            btcalcular.Location = new Point(65, 104);
            btcalcular.Name = "btcalcular";
            btcalcular.Size = new Size(94, 29);
            btcalcular.TabIndex = 0;
            btcalcular.Text = "Calcular";
            btcalcular.UseVisualStyleBackColor = true;
            btcalcular.Click += btcalcular_Click;
            // 
            // txnumero1
            // 
            txnumero1.Location = new Point(196, 105);
            txnumero1.Name = "txnumero1";
            txnumero1.Size = new Size(76, 27);
            txnumero1.TabIndex = 1;
            // 
            // txnumero2
            // 
            txnumero2.Location = new Point(370, 105);
            txnumero2.Name = "txnumero2";
            txnumero2.Size = new Size(76, 27);
            txnumero2.TabIndex = 2;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(572, 109);
            resultado.Name = "resultado";
            resultado.Size = new Size(50, 20);
            resultado.TabIndex = 3;
            resultado.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 108);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 4;
            label1.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 62);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Número 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 62);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "Número 2";
            // 
            // operaciones_ejemplo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultado);
            Controls.Add(txnumero2);
            Controls.Add(txnumero1);
            Controls.Add(btcalcular);
            Name = "operaciones_ejemplo";
            Text = "operaciones_ejemplo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcalcular;
        private TextBox txnumero1;
        private TextBox txnumero2;
        private Label resultado;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}