namespace CalculadoraV2
{
    partial class Resta
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
            btrestar = new Button();
            txres1 = new TextBox();
            txres2 = new TextBox();
            lbresta = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(593, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 33);
            btsalir.TabIndex = 0;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btrestar
            // 
            btrestar.Location = new Point(445, 132);
            btrestar.Name = "btrestar";
            btrestar.Size = new Size(94, 29);
            btrestar.TabIndex = 1;
            btrestar.Text = "restar";
            btrestar.UseVisualStyleBackColor = true;
            btrestar.Click += btrestar_Click;
            // 
            // txres1
            // 
            txres1.Location = new Point(86, 134);
            txres1.Name = "txres1";
            txres1.Size = new Size(125, 27);
            txres1.TabIndex = 2;
            // 
            // txres2
            // 
            txres2.Location = new Point(287, 136);
            txres2.Name = "txres2";
            txres2.Size = new Size(125, 27);
            txres2.TabIndex = 3;
            // 
            // lbresta
            // 
            lbresta.AutoSize = true;
            lbresta.Location = new Point(593, 137);
            lbresta.Name = "lbresta";
            lbresta.Size = new Size(50, 20);
            lbresta.TabIndex = 4;
            lbresta.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 137);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 5;
            label1.Text = "-";
            // 
            // resta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 299);
            Controls.Add(label1);
            Controls.Add(lbresta);
            Controls.Add(txres2);
            Controls.Add(txres1);
            Controls.Add(btrestar);
            Controls.Add(btsalir);
            Name = "resta";
            Text = "resta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btrestar;
        private TextBox txres1;
        private TextBox txres2;
        private Label lbresta;
        private Label label1;
    }
}