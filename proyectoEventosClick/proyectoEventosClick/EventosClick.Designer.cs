namespace proyectoEventosClick
{
    partial class EventosClick
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
            btIniciar = new Button();
            btbajar = new Button();
            btsalir = new Button();
            btsubir = new Button();
            btizquierda = new Button();
            SuspendLayout();
            // 
            // btIniciar
            // 
            btIniciar.BackColor = Color.LawnGreen;
            btIniciar.Cursor = Cursors.Hand;
            btIniciar.Font = new Font("Kristen ITC", 13.8F, FontStyle.Bold);
            btIniciar.ForeColor = Color.White;
            btIniciar.Location = new Point(12, 279);
            btIniciar.Name = "btIniciar";
            btIniciar.Size = new Size(284, 51);
            btIniciar.TabIndex = 0;
            btIniciar.Text = "Izquierda - Derecha";
            btIniciar.UseVisualStyleBackColor = false;
            btIniciar.MouseMove += btIniciar_MouseMove;
            // 
            // btbajar
            // 
            btbajar.BackColor = Color.LawnGreen;
            btbajar.Cursor = Cursors.Hand;
            btbajar.Font = new Font("Kristen ITC", 13.8F, FontStyle.Bold);
            btbajar.ForeColor = Color.White;
            btbajar.Location = new Point(675, 12);
            btbajar.Name = "btbajar";
            btbajar.Size = new Size(206, 51);
            btbajar.TabIndex = 1;
            btbajar.Text = "Arriba - Abajo";
            btbajar.UseVisualStyleBackColor = false;
            btbajar.MouseMove += button1_MouseMove;
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(1196, 531);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(80, 32);
            btsalir.TabIndex = 2;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btsubir
            // 
            btsubir.BackColor = Color.LawnGreen;
            btsubir.Cursor = Cursors.Hand;
            btsubir.Font = new Font("Kristen ITC", 13.8F, FontStyle.Bold);
            btsubir.ForeColor = Color.White;
            btsubir.Location = new Point(378, 512);
            btsubir.Name = "btsubir";
            btsubir.Size = new Size(206, 51);
            btsubir.TabIndex = 3;
            btsubir.Text = "Abajo - Arriba";
            btsubir.UseVisualStyleBackColor = false;
            btsubir.MouseMove += btsubir_MouseMove;
            // 
            // btizquierda
            // 
            btizquierda.BackColor = Color.LawnGreen;
            btizquierda.Cursor = Cursors.Hand;
            btizquierda.Font = new Font("Kristen ITC", 13.8F, FontStyle.Bold);
            btizquierda.ForeColor = Color.White;
            btizquierda.Location = new Point(992, 195);
            btizquierda.Name = "btizquierda";
            btizquierda.Size = new Size(284, 51);
            btizquierda.TabIndex = 4;
            btizquierda.Text = "Derecha - Izquierda";
            btizquierda.UseVisualStyleBackColor = false;
            btizquierda.MouseMove += btizquierda_MouseMove;
            // 
            // EventosClick
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1288, 575);
            Controls.Add(btizquierda);
            Controls.Add(btsubir);
            Controls.Add(btsalir);
            Controls.Add(btbajar);
            Controls.Add(btIniciar);
            Name = "EventosClick";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventosClick";
            ResumeLayout(false);
        }

        #endregion

        private Button btIniciar;
        private Button btbajar;
        private Button btsalir;
        private Button btsubir;
        private Button btizquierda;
    }
}