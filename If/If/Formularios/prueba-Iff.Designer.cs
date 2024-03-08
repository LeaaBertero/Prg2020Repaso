namespace If
{
    partial class prueba_Iff
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
            btcomenzar = new Button();
            label1 = new Label();
            lbresultado = new Label();
            txnumero = new TextBox();
            label3 = new Label();
            btsalir = new Button();
            btprueba2Iff = new Button();
            btlimpiar = new Button();
            SuspendLayout();
            // 
            // btcomenzar
            // 
            btcomenzar.Cursor = Cursors.Hand;
            btcomenzar.Location = new Point(151, 179);
            btcomenzar.Name = "btcomenzar";
            btcomenzar.Size = new Size(117, 29);
            btcomenzar.TabIndex = 0;
            btcomenzar.Text = "Ejecutar";
            btcomenzar.UseVisualStyleBackColor = true;
            btcomenzar.Click += btcomenzar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(263, 41);
            label1.Name = "label1";
            label1.Size = new Size(267, 37);
            label1.TabIndex = 1;
            label1.Text = "Proyecto prueba Iff";
            // 
            // lbresultado
            // 
            lbresultado.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbresultado.Location = new Point(501, 176);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(83, 32);
            lbresultado.TabIndex = 2;
            lbresultado.Text = "label2";
            lbresultado.TextAlign = ContentAlignment.MiddleCenter;
            lbresultado.Visible = false;
            // 
            // txnumero
            // 
            txnumero.Location = new Point(313, 179);
            txnumero.Name = "txnumero";
            txnumero.Size = new Size(141, 27);
            txnumero.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 130);
            label3.Name = "label3";
            label3.Size = new Size(272, 20);
            label3.TabIndex = 4;
            label3.Text = "ingrese número menor a 7 y mayor a 20";
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(331, 354);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 5;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btprueba2Iff
            // 
            btprueba2Iff.Cursor = Cursors.Hand;
            btprueba2Iff.Location = new Point(301, 244);
            btprueba2Iff.Name = "btprueba2Iff";
            btprueba2Iff.Size = new Size(165, 27);
            btprueba2Iff.TabIndex = 6;
            btprueba2Iff.Text = "segunda prueba iff";
            btprueba2Iff.UseVisualStyleBackColor = true;
            btprueba2Iff.Click += btprueba2Iff_Click;
            // 
            // btlimpiar
            // 
            btlimpiar.Location = new Point(151, 226);
            btlimpiar.Name = "btlimpiar";
            btlimpiar.Size = new Size(117, 29);
            btlimpiar.TabIndex = 7;
            btlimpiar.Text = "Limpiar campo";
            btlimpiar.UseVisualStyleBackColor = true;
            btlimpiar.Click += btlimpiar_Click;
            // 
            // prueba_Iff
            // 
            AcceptButton = btcomenzar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 395);
            Controls.Add(btlimpiar);
            Controls.Add(btprueba2Iff);
            Controls.Add(btsalir);
            Controls.Add(label3);
            Controls.Add(txnumero);
            Controls.Add(lbresultado);
            Controls.Add(label1);
            Controls.Add(btcomenzar);
            Name = "prueba_Iff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "prueba_Iff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcomenzar;
        private Label label1;
        private Label lbresultado;
        private TextBox txnumero;
        private Label label3;
        private Button btsalir;
        private Button btprueba2Iff;
        private Button btlimpiar;
    }
}