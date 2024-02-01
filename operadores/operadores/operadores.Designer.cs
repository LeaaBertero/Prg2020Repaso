namespace operadores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btsumar = new Button();
            txnum1 = new TextBox();
            label1 = new Label();
            txnum2 = new TextBox();
            lbresultado = new Label();
            label2 = new Label();
            btlimpiar = new Button();
            btsalir = new Button();
            SuspendLayout();
            // 
            // btsumar
            // 
            btsumar.Cursor = Cursors.Hand;
            btsumar.Location = new Point(591, 150);
            btsumar.Name = "btsumar";
            btsumar.Size = new Size(126, 37);
            btsumar.TabIndex = 0;
            btsumar.Text = "sumar";
            btsumar.UseVisualStyleBackColor = true;
            btsumar.Click += btsumar_Click;
            // 
            // txnum1
            // 
            txnum1.Location = new Point(147, 155);
            txnum1.Name = "txnum1";
            txnum1.Size = new Size(143, 27);
            txnum1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 155);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 2;
            label1.Text = "+";
            // 
            // txnum2
            // 
            txnum2.Location = new Point(401, 155);
            txnum2.Name = "txnum2";
            txnum2.Size = new Size(143, 27);
            txnum2.TabIndex = 3;
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Font = new Font("Segoe UI", 22F);
            lbresultado.Location = new Point(147, 287);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(120, 50);
            lbresultado.TabIndex = 4;
            lbresultado.Text = "label2";
            lbresultado.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F);
            label2.Location = new Point(172, 21);
            label2.Name = "label2";
            label2.Size = new Size(438, 50);
            label2.TabIndex = 5;
            label2.Text = "PROYECTO OPERADORES";
            // 
            // btlimpiar
            // 
            btlimpiar.Cursor = Cursors.Hand;
            btlimpiar.Location = new Point(591, 206);
            btlimpiar.Name = "btlimpiar";
            btlimpiar.Size = new Size(126, 37);
            btlimpiar.TabIndex = 6;
            btlimpiar.Text = "limpiar";
            btlimpiar.UseVisualStyleBackColor = true;
            btlimpiar.Click += btlimpiar_Click;
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(729, 21);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(126, 37);
            btsalir.TabIndex = 7;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(867, 450);
            Controls.Add(btsalir);
            Controls.Add(btlimpiar);
            Controls.Add(label2);
            Controls.Add(lbresultado);
            Controls.Add(txnum2);
            Controls.Add(label1);
            Controls.Add(txnum1);
            Controls.Add(btsumar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formulario de operadores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsumar;
        private TextBox txnum1;
        private Label label1;
        private TextBox txnum2;
        private Label lbresultado;
        private Label label2;
        private Button btlimpiar;
        private Button btsalir;
    }
}
