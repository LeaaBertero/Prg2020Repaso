﻿namespace prueba02
{
    partial class frmMult
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
            btCalcularMult = new Button();
            txnumMult1 = new TextBox();
            txnumMult2 = new TextBox();
            lbResultMult = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btLimpiarMult = new Button();
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
            // btCalcularMult
            // 
            btCalcularMult.Cursor = Cursors.Hand;
            btCalcularMult.Location = new Point(496, 130);
            btCalcularMult.Name = "btCalcularMult";
            btCalcularMult.Size = new Size(94, 29);
            btCalcularMult.TabIndex = 1;
            btCalcularMult.Text = "Calcular";
            btCalcularMult.UseVisualStyleBackColor = true;
            btCalcularMult.Click += btCalcularMult_Click;
            // 
            // txnumMult1
            // 
            txnumMult1.Location = new Point(128, 131);
            txnumMult1.Name = "txnumMult1";
            txnumMult1.Size = new Size(125, 27);
            txnumMult1.TabIndex = 4;
            // 
            // txnumMult2
            // 
            txnumMult2.Location = new Point(334, 132);
            txnumMult2.Name = "txnumMult2";
            txnumMult2.Size = new Size(125, 27);
            txnumMult2.TabIndex = 5;
            // 
            // lbResultMult
            // 
            lbResultMult.AutoSize = true;
            lbResultMult.Location = new Point(633, 134);
            lbResultMult.Name = "lbResultMult";
            lbResultMult.Size = new Size(50, 20);
            lbResultMult.TabIndex = 6;
            lbResultMult.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 139);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 7;
            label3.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 12F);
            label1.Location = new Point(336, 89);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 9;
            label1.Text = "Número 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 12F);
            label2.Location = new Point(137, 89);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 8;
            label2.Text = "Número 1";
            // 
            // btLimpiarMult
            // 
            btLimpiarMult.Cursor = Cursors.Hand;
            btLimpiarMult.Location = new Point(128, 180);
            btLimpiarMult.Name = "btLimpiarMult";
            btLimpiarMult.Size = new Size(331, 29);
            btLimpiarMult.TabIndex = 10;
            btLimpiarMult.Text = "Limpiar campos";
            btLimpiarMult.UseVisualStyleBackColor = true;
            btLimpiarMult.Click += btLimpiarMult_Click;
            // 
            // frmMult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 256);
            Controls.Add(btLimpiarMult);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lbResultMult);
            Controls.Add(txnumMult2);
            Controls.Add(txnumMult1);
            Controls.Add(btCalcularMult);
            Controls.Add(btsalir);
            Name = "frmMult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMult";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btCalcularMult;
        private TextBox txnumMult1;
        private TextBox txnumMult2;
        private Label lbResultMult;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btLimpiarMult;
    }
}