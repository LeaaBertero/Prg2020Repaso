namespace CargaProductos
{
    partial class FrmCarga
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
            btCargaProd = new Button();
            btSalir = new Button();
            txNombreProd = new TextBox();
            label1 = new Label();
            lbListaProd = new Label();
            txPrecioProd = new TextBox();
            btCargar = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btCargaProd
            // 
            btCargaProd.BackColor = Color.Red;
            btCargaProd.Cursor = Cursors.Hand;
            btCargaProd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btCargaProd.ForeColor = SystemColors.Control;
            btCargaProd.Location = new Point(131, 127);
            btCargaProd.Name = "btCargaProd";
            btCargaProd.Size = new Size(161, 40);
            btCargaProd.TabIndex = 3;
            btCargaProd.Text = "Cargar producto";
            btCargaProd.UseVisualStyleBackColor = false;
            btCargaProd.Click += btCargaProd_Click;
            // 
            // btSalir
            // 
            btSalir.BackColor = Color.Red;
            btSalir.Cursor = Cursors.Hand;
            btSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btSalir.ForeColor = SystemColors.Control;
            btSalir.Location = new Point(1089, 12);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(109, 34);
            btSalir.TabIndex = 5;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = false;
            btSalir.Click += btSalir_Click;
            // 
            // txNombreProd
            // 
            txNombreProd.Location = new Point(338, 135);
            txNombreProd.Name = "txNombreProd";
            txNombreProd.Size = new Size(125, 27);
            txNombreProd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(365, 22);
            label1.Name = "label1";
            label1.Size = new Size(294, 41);
            label1.TabIndex = 3;
            label1.Text = "Carga de productos";
            // 
            // lbListaProd
            // 
            lbListaProd.AutoSize = true;
            lbListaProd.BackColor = Color.Red;
            lbListaProd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbListaProd.ForeColor = SystemColors.Control;
            lbListaProd.Location = new Point(787, 144);
            lbListaProd.Name = "lbListaProd";
            lbListaProd.Size = new Size(59, 23);
            lbListaProd.TabIndex = 4;
            lbListaProd.Text = "label2";
            lbListaProd.Visible = false;
            // 
            // txPrecioProd
            // 
            txPrecioProd.Location = new Point(526, 135);
            txPrecioProd.Name = "txPrecioProd";
            txPrecioProd.Size = new Size(125, 27);
            txPrecioProd.TabIndex = 2;
            // 
            // btCargar
            // 
            btCargar.BackColor = Color.Red;
            btCargar.Cursor = Cursors.Hand;
            btCargar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btCargar.ForeColor = SystemColors.Control;
            btCargar.Location = new Point(141, 173);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(138, 40);
            btCargar.TabIndex = 4;
            btCargar.Text = "Mostrar Lista";
            btCargar.UseVisualStyleBackColor = false;
            btCargar.Click += btCargar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(321, 101);
            label2.Name = "label2";
            label2.Size = new Size(155, 23);
            label2.TabIndex = 7;
            label2.Text = "Nombre producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(521, 101);
            label3.Name = "label3";
            label3.Size = new Size(138, 23);
            label3.TabIndex = 8;
            label3.Text = "Precio producto";
            // 
            // FrmCarga
            // 
            AcceptButton = btCargar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1210, 531);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btCargar);
            Controls.Add(txPrecioProd);
            Controls.Add(lbListaProd);
            Controls.Add(label1);
            Controls.Add(txNombreProd);
            Controls.Add(btSalir);
            Controls.Add(btCargaProd);
            Name = "FrmCarga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCarga";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCargaProd;
        private Button btSalir;
        private TextBox txNombreProd;
        private Label label1;
        private Label lbListaProd;
        private TextBox txPrecioProd;
        private Button btCargar;
        private Label label2;
        private Label label3;
    }
}