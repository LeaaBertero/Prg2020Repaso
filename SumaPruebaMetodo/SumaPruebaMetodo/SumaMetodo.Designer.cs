namespace SumaPruebaMetodo
{
    partial class SumaMetodo
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
            txoper1 = new TextBox();
            txoper2 = new TextBox();
            label1 = new Label();
            lbresultado = new Label();
            SuspendLayout();
            // 
            // btcalcular
            // 
            btcalcular.Location = new Point(72, 78);
            btcalcular.Name = "btcalcular";
            btcalcular.Size = new Size(94, 29);
            btcalcular.TabIndex = 0;
            btcalcular.Text = "Calcular";
            btcalcular.UseVisualStyleBackColor = true;
            btcalcular.Click += btcalcular_Click;
            // 
            // txoper1
            // 
            txoper1.Location = new Point(207, 79);
            txoper1.Name = "txoper1";
            txoper1.Size = new Size(125, 27);
            txoper1.TabIndex = 1;
            // 
            // txoper2
            // 
            txoper2.Location = new Point(412, 79);
            txoper2.Name = "txoper2";
            txoper2.Size = new Size(125, 27);
            txoper2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 82);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 3;
            label1.Text = "+";
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Location = new Point(207, 150);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(50, 20);
            lbresultado.TabIndex = 4;
            lbresultado.Text = "label2";
            lbresultado.Visible = false;
            // 
            // SumaMetodo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 194);
            Controls.Add(lbresultado);
            Controls.Add(label1);
            Controls.Add(txoper2);
            Controls.Add(txoper1);
            Controls.Add(btcalcular);
            Name = "SumaMetodo";
            Text = "SumaMetodo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcalcular;
        private TextBox txoper1;
        private TextBox txoper2;
        private Label label1;
        private Label lbresultado;
    }
}