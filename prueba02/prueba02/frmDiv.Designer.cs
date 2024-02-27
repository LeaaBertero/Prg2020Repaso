namespace prueba02
{
    partial class frmDiv
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
            btdivCalcular = new Button();
            lbresultDiv = new Label();
            txnumMult1 = new TextBox();
            txnumMult2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            BtLimpiarDiv = new Button();
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
            // btdivCalcular
            // 
            btdivCalcular.Cursor = Cursors.Hand;
            btdivCalcular.Location = new Point(484, 134);
            btdivCalcular.Name = "btdivCalcular";
            btdivCalcular.Size = new Size(94, 29);
            btdivCalcular.TabIndex = 1;
            btdivCalcular.Text = "Calcular";
            btdivCalcular.UseVisualStyleBackColor = true;
            btdivCalcular.Click += btdivCalcular_Click;
            // 
            // lbresultDiv
            // 
            lbresultDiv.AutoSize = true;
            lbresultDiv.Location = new Point(639, 138);
            lbresultDiv.Name = "lbresultDiv";
            lbresultDiv.Size = new Size(50, 20);
            lbresultDiv.TabIndex = 2;
            lbresultDiv.Text = "label1";
            // 
            // txnumMult1
            // 
            txnumMult1.Location = new Point(77, 134);
            txnumMult1.Name = "txnumMult1";
            txnumMult1.Size = new Size(125, 27);
            txnumMult1.TabIndex = 3;
            // 
            // txnumMult2
            // 
            txnumMult2.Location = new Point(308, 136);
            txnumMult2.Name = "txnumMult2";
            txnumMult2.Size = new Size(125, 27);
            txnumMult2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 138);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 7;
            label3.Text = "/";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 12F);
            label1.Location = new Point(313, 75);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 9;
            label1.Text = "Número 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 12F);
            label2.Location = new Point(86, 75);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 8;
            label2.Text = "Número 1";
            // 
            // BtLimpiarDiv
            // 
            BtLimpiarDiv.Cursor = Cursors.Hand;
            BtLimpiarDiv.Location = new Point(77, 193);
            BtLimpiarDiv.Name = "BtLimpiarDiv";
            BtLimpiarDiv.Size = new Size(356, 29);
            BtLimpiarDiv.TabIndex = 10;
            BtLimpiarDiv.Text = "Limpiar Campos";
            BtLimpiarDiv.UseVisualStyleBackColor = true;
            BtLimpiarDiv.Click += BtLimpiarDiv_Click;
            // 
            // frmDiv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 270);
            Controls.Add(BtLimpiarDiv);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txnumMult2);
            Controls.Add(txnumMult1);
            Controls.Add(lbresultDiv);
            Controls.Add(btdivCalcular);
            Controls.Add(btsalir);
            Name = "frmDiv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDiv";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btdivCalcular;
        private Label lbresultDiv;
        private TextBox txnumMult1;
        private TextBox txnumMult2;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button BtLimpiarDiv;
    }
}