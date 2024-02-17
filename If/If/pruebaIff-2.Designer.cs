namespace If
{
    partial class pruebaIff_2
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
            btsalir2 = new Button();
            btsumar2 = new Button();
            lbresultado = new Label();
            txnum1 = new TextBox();
            txoper = new TextBox();
            txnum2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btsalir2
            // 
            btsalir2.Cursor = Cursors.Hand;
            btsalir2.Location = new Point(342, 400);
            btsalir2.Name = "btsalir2";
            btsalir2.Size = new Size(94, 29);
            btsalir2.TabIndex = 5;
            btsalir2.Text = "salir";
            btsalir2.UseVisualStyleBackColor = true;
            btsalir2.Click += btsalir2_Click;
            // 
            // btsumar2
            // 
            btsumar2.Location = new Point(450, 175);
            btsumar2.Name = "btsumar2";
            btsumar2.Size = new Size(115, 33);
            btsumar2.TabIndex = 4;
            btsumar2.Text = "sumar";
            btsumar2.UseVisualStyleBackColor = true;
            btsumar2.Click += btsumar2_Click;
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Font = new Font("Segoe UI", 12F);
            lbresultado.Location = new Point(638, 177);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(65, 28);
            lbresultado.TabIndex = 2;
            lbresultado.Text = "label1";
            // 
            // txnum1
            // 
            txnum1.Location = new Point(104, 178);
            txnum1.Name = "txnum1";
            txnum1.Size = new Size(80, 27);
            txnum1.TabIndex = 1;
            // 
            // txoper
            // 
            txoper.Location = new Point(207, 178);
            txoper.Name = "txoper";
            txoper.Size = new Size(80, 27);
            txoper.TabIndex = 2;
            txoper.TextAlign = HorizontalAlignment.Center;
            // 
            // txnum2
            // 
            txnum2.Location = new Point(310, 178);
            txnum2.Name = "txnum2";
            txnum2.Size = new Size(80, 27);
            txnum2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 126);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 6;
            label1.Text = "Número 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 126);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 7;
            label2.Text = "Número 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 126);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 8;
            label3.Text = "operador";
            // 
            // pruebaIff_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txnum2);
            Controls.Add(txoper);
            Controls.Add(txnum1);
            Controls.Add(lbresultado);
            Controls.Add(btsumar2);
            Controls.Add(btsalir2);
            Name = "pruebaIff_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pruebaIff_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir2;
        private Button btsumar2;
        private Label lbresultado;
        private TextBox txnum1;
        private TextBox txoper;
        private TextBox txnum2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}