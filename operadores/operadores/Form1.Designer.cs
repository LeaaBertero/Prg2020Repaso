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
            SuspendLayout();
            // 
            // btsumar
            // 
            btsumar.Cursor = Cursors.Hand;
            btsumar.Location = new Point(554, 136);
            btsumar.Name = "btsumar";
            btsumar.Size = new Size(107, 47);
            btsumar.TabIndex = 0;
            btsumar.Text = "sumar";
            btsumar.UseVisualStyleBackColor = true;
            btsumar.Click += btsumar_Click;
            // 
            // txnum1
            // 
            txnum1.Location = new Point(110, 146);
            txnum1.Name = "txnum1";
            txnum1.Size = new Size(143, 27);
            txnum1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 149);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 2;
            label1.Text = "+";
            // 
            // txnum2
            // 
            txnum2.Location = new Point(364, 146);
            txnum2.Name = "txnum2";
            txnum2.Size = new Size(143, 27);
            txnum2.TabIndex = 3;
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Location = new Point(110, 244);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(50, 20);
            lbresultado.TabIndex = 4;
            lbresultado.Text = "label2";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
