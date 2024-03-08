
namespace probando
{
    partial class HolaMundo
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
            button1 = new Button();
            BtCargar = new Button();
            txnombre = new TextBox();
            label1 = new Label();
            lbLista = new Label();
            btsalir = new Button();
            txedad = new TextBox();
            Lbedad = new Label();
            btmostrar = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(161, 29);
            button1.TabIndex = 0;
            button1.Text = "Clikeame amor !!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtCargar
            // 
            BtCargar.Cursor = Cursors.Hand;
            BtCargar.Location = new Point(164, 119);
            BtCargar.Name = "BtCargar";
            BtCargar.Size = new Size(94, 29);
            BtCargar.TabIndex = 1;
            BtCargar.Text = "Cargar";
            BtCargar.UseVisualStyleBackColor = true;
            BtCargar.Click += BtCargar_Click;
            // 
            // txnombre
            // 
            txnombre.Location = new Point(314, 119);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(162, 27);
            txnombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 96);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 3;
            label1.Text = "ingrese nombre";
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.Location = new Point(752, 123);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(50, 20);
            lbLista.TabIndex = 4;
            lbLista.Text = "label2";
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(893, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 5;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // txedad
            // 
            txedad.Location = new Point(510, 119);
            txedad.Name = "txedad";
            txedad.Size = new Size(162, 27);
            txedad.TabIndex = 6;
            // 
            // Lbedad
            // 
            Lbedad.AutoSize = true;
            Lbedad.Location = new Point(510, 96);
            Lbedad.Name = "Lbedad";
            Lbedad.Size = new Size(95, 20);
            Lbedad.TabIndex = 7;
            Lbedad.Text = "ingrese edad";
            // 
            // btmostrar
            // 
            btmostrar.Cursor = Cursors.Hand;
            btmostrar.Location = new Point(164, 187);
            btmostrar.Name = "btmostrar";
            btmostrar.Size = new Size(94, 29);
            btmostrar.TabIndex = 8;
            btmostrar.Text = "Mostrar";
            btmostrar.UseVisualStyleBackColor = true;
            btmostrar.Click += btmostrar_Click;
            // 
            // HolaMundo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 450);
            Controls.Add(btmostrar);
            Controls.Add(Lbedad);
            Controls.Add(txedad);
            Controls.Add(btsalir);
            Controls.Add(lbLista);
            Controls.Add(label1);
            Controls.Add(txnombre);
            Controls.Add(BtCargar);
            Controls.Add(button1);
            Name = "HolaMundo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HolaMundo";
            Load += HolaMundo_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button button1;
        private Button BtCargar;
        private TextBox txnombre;
        private Label label1;
        private Label lbLista;
        private Button btsalir;
        private TextBox txedad;
        private Label Lbedad;
        private Button btmostrar;
    }
}