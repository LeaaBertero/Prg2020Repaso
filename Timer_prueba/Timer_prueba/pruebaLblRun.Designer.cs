namespace Timer_prueba
{
    partial class pruebaLblRun
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
            btcerrar = new Button();
            lbrojo = new Label();
            lbverde = new Label();
            btrojo = new Button();
            btverde = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btcerrar
            // 
            btcerrar.Cursor = Cursors.Hand;
            btcerrar.Location = new Point(652, 12);
            btcerrar.Name = "btcerrar";
            btcerrar.Size = new Size(94, 29);
            btcerrar.TabIndex = 0;
            btcerrar.Text = "Cerrar";
            btcerrar.UseVisualStyleBackColor = true;
            btcerrar.Click += btcerrar_Click;
            // 
            // lbrojo
            // 
            lbrojo.BackColor = Color.Red;
            lbrojo.Location = new Point(0, 144);
            lbrojo.Name = "lbrojo";
            lbrojo.Size = new Size(70, 66);
            lbrojo.TabIndex = 1;
            // 
            // lbverde
            // 
            lbverde.BackColor = Color.Green;
            lbverde.Location = new Point(686, 144);
            lbverde.Name = "lbverde";
            lbverde.Size = new Size(70, 66);
            lbverde.TabIndex = 2;
            // 
            // btrojo
            // 
            btrojo.Cursor = Cursors.Hand;
            btrojo.Location = new Point(201, 293);
            btrojo.Name = "btrojo";
            btrojo.Size = new Size(135, 29);
            btrojo.TabIndex = 3;
            btrojo.Text = "Etiqueta roja";
            btrojo.UseVisualStyleBackColor = true;
            btrojo.Click += btrojo_Click;
            // 
            // btverde
            // 
            btverde.Cursor = Cursors.Hand;
            btverde.Location = new Point(451, 293);
            btverde.Name = "btverde";
            btverde.Size = new Size(135, 29);
            btverde.TabIndex = 4;
            btverde.Text = "Etiqueta verde";
            btverde.UseVisualStyleBackColor = true;
            btverde.Click += btverde_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(201, 64);
            label1.Name = "label1";
            label1.Size = new Size(385, 53);
            label1.TabIndex = 5;
            label1.Text = "Desplazamiento de label  limitados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pruebaLblRun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 334);
            Controls.Add(label1);
            Controls.Add(btverde);
            Controls.Add(btrojo);
            Controls.Add(lbverde);
            Controls.Add(lbrojo);
            Controls.Add(btcerrar);
            Name = "pruebaLblRun";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pruebaLblRun";
            ResumeLayout(false);
        }

        #endregion

        private Button btcerrar;
        private Label lbrojo;
        private Label lbverde;
        private Button btrojo;
        private Button btverde;
        private Label label1;
    }
}