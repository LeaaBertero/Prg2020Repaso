namespace prueba02
{
    partial class frmResta
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
            btcalcularRes = new Button();
            txnumRes1 = new TextBox();
            txnumRes2 = new TextBox();
            lbresultResta = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BtLimpiarResta = new Button();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(694, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 0;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btcalcularRes
            // 
            btcalcularRes.Cursor = Cursors.Hand;
            btcalcularRes.Location = new Point(487, 135);
            btcalcularRes.Name = "btcalcularRes";
            btcalcularRes.Size = new Size(94, 29);
            btcalcularRes.TabIndex = 1;
            btcalcularRes.Text = "Calcular";
            btcalcularRes.UseVisualStyleBackColor = true;
            btcalcularRes.Click += btcalcularRes_Click;
            // 
            // txnumRes1
            // 
            txnumRes1.Location = new Point(129, 135);
            txnumRes1.Name = "txnumRes1";
            txnumRes1.Size = new Size(125, 27);
            txnumRes1.TabIndex = 2;
            // 
            // txnumRes2
            // 
            txnumRes2.Location = new Point(321, 135);
            txnumRes2.Name = "txnumRes2";
            txnumRes2.Size = new Size(125, 27);
            txnumRes2.TabIndex = 3;
            // 
            // lbresultResta
            // 
            lbresultResta.AutoSize = true;
            lbresultResta.Location = new Point(619, 139);
            lbresultResta.Name = "lbresultResta";
            lbresultResta.Size = new Size(50, 20);
            lbresultResta.TabIndex = 4;
            lbresultResta.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 138);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 7;
            label3.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kristen ITC", 12F);
            label4.Location = new Point(330, 91);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 9;
            label4.Text = "Número 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kristen ITC", 12F);
            label5.Location = new Point(131, 91);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 8;
            label5.Text = "Número 1";
            // 
            // BtLimpiarResta
            // 
            BtLimpiarResta.Cursor = Cursors.Hand;
            BtLimpiarResta.Location = new Point(129, 184);
            BtLimpiarResta.Name = "BtLimpiarResta";
            BtLimpiarResta.Size = new Size(317, 29);
            BtLimpiarResta.TabIndex = 10;
            BtLimpiarResta.Text = "Limpiar campos";
            BtLimpiarResta.UseVisualStyleBackColor = true;
            BtLimpiarResta.Click += BtLimpiarResta_Click;
            // 
            // frmResta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 256);
            Controls.Add(BtLimpiarResta);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lbresultResta);
            Controls.Add(txnumRes2);
            Controls.Add(txnumRes1);
            Controls.Add(btcalcularRes);
            Controls.Add(btsalir);
            Name = "frmResta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmResta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btcalcularRes;
        private TextBox txnumRes1;
        private TextBox txnumRes2;
        private Label lbresultResta;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BtLimpiarResta;
    }
}