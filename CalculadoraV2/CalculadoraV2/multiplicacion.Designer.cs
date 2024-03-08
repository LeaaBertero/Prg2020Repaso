namespace CalculadoraV2
{
    partial class Multiplicacion
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
            BtDivResultado = new Button();
            txnumDiv1 = new TextBox();
            txnumDiv2 = new TextBox();
            label1 = new Label();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(499, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 0;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // BtDivResultado
            // 
            BtDivResultado.Cursor = Cursors.Hand;
            BtDivResultado.Location = new Point(393, 138);
            BtDivResultado.Name = "BtDivResultado";
            BtDivResultado.Size = new Size(123, 29);
            BtDivResultado.TabIndex = 1;
            BtDivResultado.Text = "Multiplicar";
            BtDivResultado.UseVisualStyleBackColor = true;
            BtDivResultado.Click += BtDivResultado_Click;
            // 
            // txnumDiv1
            // 
            txnumDiv1.Location = new Point(57, 139);
            txnumDiv1.Name = "txnumDiv1";
            txnumDiv1.Size = new Size(125, 27);
            txnumDiv1.TabIndex = 2;
            // 
            // txnumDiv2
            // 
            txnumDiv2.Location = new Point(247, 138);
            txnumDiv2.Name = "txnumDiv2";
            txnumDiv2.Size = new Size(125, 27);
            txnumDiv2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 141);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 4;
            label1.Text = "*";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(57, 220);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(50, 20);
            labelResultado.TabIndex = 5;
            labelResultado.Text = "label2";
            // 
            // Multiplicacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 303);
            Controls.Add(labelResultado);
            Controls.Add(label1);
            Controls.Add(txnumDiv2);
            Controls.Add(txnumDiv1);
            Controls.Add(BtDivResultado);
            Controls.Add(btsalir);
            Name = "Multiplicacion";
            Text = "multiplicacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button BtDivResultado;
        private TextBox txnumDiv1;
        private TextBox txnumDiv2;
        private Label label1;
        private Label labelResultado;
    }
}