namespace DimensionPersona
{
    partial class Calcu
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
            btsuma = new Button();
            txoper1 = new TextBox();
            txoper2 = new TextBox();
            label1 = new Label();
            lbresultado = new Label();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.Location = new Point(694, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 0;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btsuma
            // 
            btsuma.Location = new Point(17, 117);
            btsuma.Name = "btsuma";
            btsuma.Size = new Size(134, 34);
            btsuma.TabIndex = 1;
            btsuma.Text = "Calcular";
            btsuma.UseVisualStyleBackColor = true;
            btsuma.Click += btsuma_Click;
            // 
            // txoper1
            // 
            txoper1.Location = new Point(184, 121);
            txoper1.Name = "txoper1";
            txoper1.Size = new Size(125, 27);
            txoper1.TabIndex = 2;
            // 
            // txoper2
            // 
            txoper2.Location = new Point(391, 124);
            txoper2.Name = "txoper2";
            txoper2.Size = new Size(125, 27);
            txoper2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 131);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 4;
            label1.Text = "+";
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Location = new Point(574, 131);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(50, 20);
            lbresultado.TabIndex = 5;
            lbresultado.Text = "label2";
            // 
            // Calcu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbresultado);
            Controls.Add(label1);
            Controls.Add(txoper2);
            Controls.Add(txoper1);
            Controls.Add(btsuma);
            Controls.Add(btsalir);
            Name = "Calcu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btsuma;
        private TextBox txoper1;
        private TextBox txoper2;
        private Label label1;
        private Label lbresultado;
    }
}