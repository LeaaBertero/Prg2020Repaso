namespace operadores
{
    partial class operadores1
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
            laresultado = new Label();
            txnum1 = new TextBox();
            txnum2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btsalir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btcalcular
            // 
            btcalcular.Location = new Point(520, 177);
            btcalcular.Name = "btcalcular";
            btcalcular.Size = new Size(94, 29);
            btcalcular.TabIndex = 3;
            btcalcular.Text = "calcular";
            btcalcular.UseVisualStyleBackColor = true;
            btcalcular.Click += btcalcular_Click;
            // 
            // laresultado
            // 
            laresultado.AutoSize = true;
            laresultado.Location = new Point(679, 186);
            laresultado.Name = "laresultado";
            laresultado.Size = new Size(50, 20);
            laresultado.TabIndex = 1;
            laresultado.Text = "label1";
            // 
            // txnum1
            // 
            txnum1.Location = new Point(151, 175);
            txnum1.Name = "txnum1";
            txnum1.Size = new Size(125, 27);
            txnum1.TabIndex = 1;
            // 
            // txnum2
            // 
            txnum2.Location = new Point(343, 175);
            txnum2.Name = "txnum2";
            txnum2.Size = new Size(125, 27);
            txnum2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(294, 172);
            label2.Name = "label2";
            label2.Size = new Size(31, 32);
            label2.TabIndex = 4;
            label2.Text = "+";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(151, 123);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 5;
            label3.Text = "numero 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(343, 123);
            label4.Name = "label4";
            label4.Size = new Size(125, 32);
            label4.TabIndex = 6;
            label4.Text = "numero 2";
            // 
            // btsalir
            // 
            btsalir.Location = new Point(758, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 7;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(790, 32);
            label1.TabIndex = 8;
            label1.Text = "Ejercicio de prueba de conversion de variables con método incluido";
            // 
            // operadores
            // 
            AcceptButton = btcalcular;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 450);
            Controls.Add(label1);
            Controls.Add(btsalir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txnum2);
            Controls.Add(txnum1);
            Controls.Add(laresultado);
            Controls.Add(btcalcular);
            Name = "operadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "operadores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcalcular;
        private Label laresultado;
        private TextBox txnum1;
        private TextBox txnum2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btsalir;
        private Label label1;
    }
}