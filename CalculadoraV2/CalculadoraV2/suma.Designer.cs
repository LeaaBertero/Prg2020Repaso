namespace CalculadoraV2
{
    partial class Suma
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
            btres = new Button();
            txnum1 = new TextBox();
            txnum2 = new TextBox();
            label1 = new Label();
            lbres = new Label();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(605, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(98, 31);
            btsalir.TabIndex = 0;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btres
            // 
            btres.Cursor = Cursors.Hand;
            btres.Location = new Point(502, 149);
            btres.Name = "btres";
            btres.Size = new Size(110, 29);
            btres.TabIndex = 1;
            btres.Text = "resultado";
            btres.UseVisualStyleBackColor = true;
            btres.Click += btres_Click;
            // 
            // txnum1
            // 
            txnum1.Location = new Point(87, 150);
            txnum1.Name = "txnum1";
            txnum1.Size = new Size(125, 27);
            txnum1.TabIndex = 2;
            // 
            // txnum2
            // 
            txnum2.Location = new Point(327, 150);
            txnum2.Name = "txnum2";
            txnum2.Size = new Size(125, 27);
            txnum2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 153);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 4;
            label1.Text = "+";
            // 
            // lbres
            // 
            lbres.AutoSize = true;
            lbres.Location = new Point(653, 153);
            lbres.Name = "lbres";
            lbres.Size = new Size(50, 20);
            lbres.TabIndex = 5;
            lbres.Text = "label2";
            // 
            // Suma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 334);
            Controls.Add(lbres);
            Controls.Add(label1);
            Controls.Add(txnum2);
            Controls.Add(txnum1);
            Controls.Add(btres);
            Controls.Add(btsalir);
            Name = "Suma";
            Text = "suma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btres;
        private TextBox txnum1;
        private TextBox txnum2;
        private Label label1;
        private Label lbres;
    }
}