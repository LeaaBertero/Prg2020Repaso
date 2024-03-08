namespace CalculadoraV2
{
    partial class division
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
            btDivResultado = new Button();
            TdNumDiv1 = new TextBox();
            TxNumDiv2 = new TextBox();
            label1 = new Label();
            labelDivResultado = new Label();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(474, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 0;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btDivResultado
            // 
            btDivResultado.Cursor = Cursors.Hand;
            btDivResultado.Location = new Point(411, 129);
            btDivResultado.Name = "btDivResultado";
            btDivResultado.Size = new Size(113, 33);
            btDivResultado.TabIndex = 1;
            btDivResultado.Text = "División";
            btDivResultado.UseVisualStyleBackColor = true;
            btDivResultado.Click += btDivResultado_Click;
            // 
            // TdNumDiv1
            // 
            TdNumDiv1.Location = new Point(63, 129);
            TdNumDiv1.Name = "TdNumDiv1";
            TdNumDiv1.Size = new Size(125, 27);
            TdNumDiv1.TabIndex = 2;
            // 
            // TxNumDiv2
            // 
            TxNumDiv2.Location = new Point(250, 132);
            TxNumDiv2.Name = "TxNumDiv2";
            TxNumDiv2.Size = new Size(125, 27);
            TxNumDiv2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 132);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 4;
            label1.Text = "/";
            // 
            // labelDivResultado
            // 
            labelDivResultado.AutoSize = true;
            labelDivResultado.Location = new Point(63, 225);
            labelDivResultado.Name = "labelDivResultado";
            labelDivResultado.Size = new Size(50, 20);
            labelDivResultado.TabIndex = 5;
            labelDivResultado.Text = "label2";
            // 
            // division
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 294);
            Controls.Add(labelDivResultado);
            Controls.Add(label1);
            Controls.Add(TxNumDiv2);
            Controls.Add(TdNumDiv1);
            Controls.Add(btDivResultado);
            Controls.Add(btsalir);
            Name = "division";
            Text = "division";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btDivResultado;
        private TextBox TdNumDiv1;
        private TextBox TxNumDiv2;
        private Label label1;
        private Label labelDivResultado;
    }
}