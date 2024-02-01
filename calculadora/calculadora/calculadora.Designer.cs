namespace calculadora
{
    partial class Calculadora
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
            lbresultado = new Label();
            btsuma = new Button();
            btresta = new Button();
            btmultip = new Button();
            btdiv = new Button();
            txsuma1 = new TextBox();
            txsuma2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txresta2 = new TextBox();
            txresta1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txmult2 = new TextBox();
            txmult1 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txdiv2 = new TextBox();
            txdiv1 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btlimpiar = new Button();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(980, 26);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(142, 49);
            btsalir.TabIndex = 0;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Font = new Font("Segoe UI", 20F);
            lbresultado.Location = new Point(343, 588);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(109, 46);
            lbresultado.TabIndex = 1;
            lbresultado.Text = "label1";
            lbresultado.Visible = false;
            // 
            // btsuma
            // 
            btsuma.Cursor = Cursors.Hand;
            btsuma.Location = new Point(71, 476);
            btsuma.Name = "btsuma";
            btsuma.Size = new Size(152, 40);
            btsuma.TabIndex = 2;
            btsuma.Text = "resultado suma";
            btsuma.UseVisualStyleBackColor = true;
            btsuma.Click += btsuma_Click;
            // 
            // btresta
            // 
            btresta.Cursor = Cursors.Hand;
            btresta.Location = new Point(300, 476);
            btresta.Name = "btresta";
            btresta.Size = new Size(152, 40);
            btresta.TabIndex = 3;
            btresta.Text = "resultado resta";
            btresta.UseVisualStyleBackColor = true;
            btresta.Click += btresta_Click;
            // 
            // btmultip
            // 
            btmultip.Cursor = Cursors.Hand;
            btmultip.Location = new Point(494, 476);
            btmultip.Name = "btmultip";
            btmultip.Size = new Size(205, 40);
            btmultip.TabIndex = 4;
            btmultip.Text = "resultado multiplicacion";
            btmultip.UseVisualStyleBackColor = true;
            btmultip.Click += btmultip_Click;
            // 
            // btdiv
            // 
            btdiv.Cursor = Cursors.Hand;
            btdiv.Location = new Point(758, 476);
            btdiv.Name = "btdiv";
            btdiv.Size = new Size(205, 40);
            btdiv.TabIndex = 5;
            btdiv.Text = "resultado division";
            btdiv.UseVisualStyleBackColor = true;
            btdiv.Click += btdiv_Click;
            // 
            // txsuma1
            // 
            txsuma1.Location = new Point(71, 248);
            txsuma1.Name = "txsuma1";
            txsuma1.Size = new Size(125, 27);
            txsuma1.TabIndex = 6;
            // 
            // txsuma2
            // 
            txsuma2.Location = new Point(71, 359);
            txsuma2.Name = "txsuma2";
            txsuma2.Size = new Size(125, 27);
            txsuma2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 205);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 8;
            label1.Text = "numero 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 314);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 9;
            label2.Text = "numero 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 314);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 13;
            label3.Text = "numero 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 205);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 12;
            label4.Text = "numero 1";
            // 
            // txresta2
            // 
            txresta2.Location = new Point(300, 359);
            txresta2.Name = "txresta2";
            txresta2.Size = new Size(125, 27);
            txresta2.TabIndex = 11;
            // 
            // txresta1
            // 
            txresta1.Location = new Point(300, 248);
            txresta1.Name = "txresta1";
            txresta1.Size = new Size(125, 27);
            txresta1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(494, 314);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 17;
            label5.Text = "numero 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(494, 205);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 16;
            label6.Text = "numero 1";
            // 
            // txmult2
            // 
            txmult2.Location = new Point(494, 359);
            txmult2.Name = "txmult2";
            txmult2.Size = new Size(125, 27);
            txmult2.TabIndex = 15;
            // 
            // txmult1
            // 
            txmult1.Location = new Point(494, 248);
            txmult1.Name = "txmult1";
            txmult1.Size = new Size(125, 27);
            txmult1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(758, 314);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 21;
            label7.Text = "numero 2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(758, 205);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 20;
            label8.Text = "numero 1";
            // 
            // txdiv2
            // 
            txdiv2.Location = new Point(758, 359);
            txdiv2.Name = "txdiv2";
            txdiv2.Size = new Size(125, 27);
            txdiv2.TabIndex = 19;
            // 
            // txdiv1
            // 
            txdiv1.Location = new Point(758, 248);
            txdiv1.Name = "txdiv1";
            txdiv1.Size = new Size(125, 27);
            txdiv1.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(300, 26);
            label9.Name = "label9";
            label9.Size = new Size(448, 46);
            label9.TabIndex = 22;
            label9.Text = "PROYECTO - CALCULADORA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F);
            label10.Location = new Point(71, 121);
            label10.Name = "label10";
            label10.Size = new Size(103, 46);
            label10.TabIndex = 23;
            label10.Text = "Suma";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20F);
            label11.Location = new Point(300, 121);
            label11.Name = "label11";
            label11.Size = new Size(100, 46);
            label11.TabIndex = 24;
            label11.Text = "Resta";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20F);
            label12.Location = new Point(494, 121);
            label12.Name = "label12";
            label12.Size = new Size(230, 46);
            label12.TabIndex = 25;
            label12.Text = "Multiplicación";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20F);
            label13.Location = new Point(758, 121);
            label13.Name = "label13";
            label13.Size = new Size(137, 46);
            label13.TabIndex = 26;
            label13.Text = "División";
            // 
            // btlimpiar
            // 
            btlimpiar.Cursor = Cursors.Hand;
            btlimpiar.Location = new Point(300, 658);
            btlimpiar.Name = "btlimpiar";
            btlimpiar.Size = new Size(399, 45);
            btlimpiar.TabIndex = 27;
            btlimpiar.Text = "Limpiar datos";
            btlimpiar.UseVisualStyleBackColor = true;
            btlimpiar.Click += btlimpiar_Click;
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(1145, 715);
            Controls.Add(btlimpiar);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txdiv2);
            Controls.Add(txdiv1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txmult2);
            Controls.Add(txmult1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txresta2);
            Controls.Add(txresta1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txsuma2);
            Controls.Add(txsuma1);
            Controls.Add(btdiv);
            Controls.Add(btmultip);
            Controls.Add(btresta);
            Controls.Add(btsuma);
            Controls.Add(lbresultado);
            Controls.Add(btsalir);
            Name = "calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Label lbresultado;
        private Button btsuma;
        private Button btresta;
        private Button btmultip;
        private Button btdiv;
        private TextBox txsuma1;
        private TextBox txsuma2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txresta2;
        private TextBox txresta1;
        private Label label5;
        private Label label6;
        private TextBox txmult2;
        private TextBox txmult1;
        private Label label7;
        private Label label8;
        private TextBox txdiv2;
        private TextBox txdiv1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btlimpiar;
    }
}