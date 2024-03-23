namespace SUMA_OPERACION
{
    partial class SUMA
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
            btSuma = new Button();
            btsalir = new Button();
            txnum1 = new TextBox();
            txNum2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btSuma
            // 
            btSuma.Location = new Point(144, 58);
            btSuma.Name = "btSuma";
            btSuma.Size = new Size(94, 29);
            btSuma.TabIndex = 0;
            btSuma.Text = "Calcular";
            btSuma.UseVisualStyleBackColor = true;
            btSuma.Click += btSuma_Click;
            // 
            // btsalir
            // 
            btsalir.Location = new Point(694, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 4;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // txnum1
            // 
            txnum1.Location = new Point(269, 58);
            txnum1.Name = "txnum1";
            txnum1.Size = new Size(125, 27);
            txnum1.TabIndex = 2;
            // 
            // txNum2
            // 
            txNum2.Location = new Point(509, 58);
            txNum2.Name = "txNum2";
            txNum2.Size = new Size(125, 27);
            txNum2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(439, 54);
            label1.Name = "label1";
            label1.Size = new Size(26, 28);
            label1.TabIndex = 4;
            label1.Text = "+";
            // 
            // SUMA
            // 
            AcceptButton = btSuma;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(800, 130);
            Controls.Add(label1);
            Controls.Add(txNum2);
            Controls.Add(txnum1);
            Controls.Add(btsalir);
            Controls.Add(btSuma);
            Name = "SUMA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SUMA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSuma;
        private Button btsalir;
        private TextBox txnum1;
        private TextBox txNum2;
        private Label label1;
    }
}