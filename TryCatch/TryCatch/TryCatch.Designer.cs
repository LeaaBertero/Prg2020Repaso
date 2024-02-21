namespace TryCatch
{
    partial class TryCatch
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
            btsumar = new Button();
            txnum1 = new TextBox();
            txnum2 = new TextBox();
            label1 = new Label();
            labelresultado = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            btsalir = new Button();
            SuspendLayout();
            // 
            // btsumar
            // 
            btsumar.Cursor = Cursors.Hand;
            btsumar.Location = new Point(539, 166);
            btsumar.Name = "btsumar";
            btsumar.Size = new Size(94, 29);
            btsumar.TabIndex = 3;
            btsumar.Text = "Resultado";
            btsumar.UseVisualStyleBackColor = true;
            btsumar.Click += btsumar_Click;
            // 
            // txnum1
            // 
            txnum1.Location = new Point(121, 168);
            txnum1.Name = "txnum1";
            txnum1.Size = new Size(125, 27);
            txnum1.TabIndex = 1;
            // 
            // txnum2
            // 
            txnum2.Location = new Point(344, 169);
            txnum2.Name = "txnum2";
            txnum2.Size = new Size(125, 27);
            txnum2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 171);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 3;
            label1.Text = "+";
            // 
            // labelresultado
            // 
            labelresultado.AutoSize = true;
            labelresultado.Location = new Point(698, 169);
            labelresultado.Name = "labelresultado";
            labelresultado.Size = new Size(50, 20);
            labelresultado.TabIndex = 4;
            labelresultado.Text = "label2";
            labelresultado.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 127);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 5;
            label3.Text = "Número 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 127);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 6;
            label4.Text = "Número 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(222, 12);
            label2.Name = "label2";
            label2.Size = new Size(364, 51);
            label2.TabIndex = 7;
            label2.Text = "Prueba Try Catch";
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(698, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 8;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // TryCatch
            // 
            AcceptButton = btsumar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 269);
            Controls.Add(btsalir);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelresultado);
            Controls.Add(label1);
            Controls.Add(txnum2);
            Controls.Add(txnum1);
            Controls.Add(btsumar);
            Name = "TryCatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TryCatch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsumar;
        private TextBox txnum1;
        private TextBox txnum2;
        private Label label1;
        private Label labelresultado;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button btsalir;
    }
}