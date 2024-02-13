namespace MatrizEscalonada
{
    partial class FrmListaPrecio
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
            btaceptar = new Button();
            btlistar = new Button();
            txproducto = new TextBox();
            txprecio = new TextBox();
            txcodigo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblListaPrecio = new Label();
            btsalir = new Button();
            SuspendLayout();
            // 
            // btaceptar
            // 
            btaceptar.Cursor = Cursors.Hand;
            btaceptar.Location = new Point(508, 151);
            btaceptar.Name = "btaceptar";
            btaceptar.Size = new Size(94, 29);
            btaceptar.TabIndex = 4;
            btaceptar.Text = "ingresar";
            btaceptar.UseVisualStyleBackColor = true;
            btaceptar.Click += btaceptar_Click;
            // 
            // btlistar
            // 
            btlistar.Cursor = Cursors.Hand;
            btlistar.Location = new Point(640, 151);
            btlistar.Name = "btlistar";
            btlistar.Size = new Size(94, 29);
            btlistar.TabIndex = 6;
            btlistar.Text = "Listar";
            btlistar.UseVisualStyleBackColor = true;
            // 
            // txproducto
            // 
            txproducto.Location = new Point(151, 153);
            txproducto.Name = "txproducto";
            txproducto.Size = new Size(125, 27);
            txproducto.TabIndex = 2;
            // 
            // txprecio
            // 
            txprecio.Location = new Point(320, 151);
            txprecio.Name = "txprecio";
            txprecio.Size = new Size(125, 27);
            txprecio.TabIndex = 3;
            // 
            // txcodigo
            // 
            txcodigo.Location = new Point(39, 153);
            txcodigo.Name = "txcodigo";
            txcodigo.Size = new Size(81, 27);
            txcodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 117);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 5;
            label1.Text = "codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 117);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 117);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 7;
            label3.Text = "precio";
            // 
            // lblListaPrecio
            // 
            lblListaPrecio.AutoSize = true;
            lblListaPrecio.Location = new Point(39, 247);
            lblListaPrecio.Name = "lblListaPrecio";
            lblListaPrecio.Size = new Size(50, 20);
            lblListaPrecio.TabIndex = 8;
            lblListaPrecio.Text = "label4";
            lblListaPrecio.Visible = false;
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(694, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 7;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // FrmListaPrecio
            // 
            AcceptButton = btaceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btsalir);
            Controls.Add(lblListaPrecio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txcodigo);
            Controls.Add(txprecio);
            Controls.Add(txproducto);
            Controls.Add(btlistar);
            Controls.Add(btaceptar);
            Name = "FrmListaPrecio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaPrecio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btaceptar;
        private Button btlistar;
        private TextBox txproducto;
        private TextBox txprecio;
        private TextBox txcodigo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblListaPrecio;
        private Button btsalir;
    }
}