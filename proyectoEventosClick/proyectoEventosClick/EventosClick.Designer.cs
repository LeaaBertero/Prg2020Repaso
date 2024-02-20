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
            btIniciar.Location = new Point(12, 170);
            btIniciar.Name = "btIniciar";
            btIniciar.Size = new Size(207, 46);
            btIniciar.TabIndex = 0;
            btIniciar.Text = "haca la derecha --->";
            btIniciar.UseVisualStyleBackColor = true;
            btIniciar.MouseMove += btIniciar_MouseMove;
            // 
            // btbajar
            // 
            btbajar.Location = new Point(326, 82);
            btbajar.Name = "btbajar";
            btbajar.Size = new Size(207, 46);
            btbajar.TabIndex = 1;
            btbajar.Text = "Hacia abajo";
            btbajar.UseVisualStyleBackColor = true;
            btbajar.MouseMove += button1_MouseMove;
            // 
            // btsalir
            // 
            btsalir.Location = new Point(581, 392);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(207, 46);
            btsalir.TabIndex = 2;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btsubir
            // 
            btsubir.Location = new Point(326, 278);
            btsubir.Name = "btsubir";
            btsubir.Size = new Size(207, 46);
            btsubir.TabIndex = 3;
            btsubir.Text = "Hacia arriba";
            btsubir.UseVisualStyleBackColor = true;
            btsubir.MouseMove += btsubir_MouseMove;
            // 
            // btizquierda
            // 
            btizquierda.Cursor = Cursors.Hand;
            btizquierda.Location = new Point(581, 170);
            btizquierda.Name = "btizquierda";
            btizquierda.Size = new Size(207, 46);
            btizquierda.TabIndex = 4;
            btizquierda.Text = "Izquierda";
            btizquierda.UseVisualStyleBackColor = true;
            btizquierda.MouseMove += btizquierda_MouseMove;
            // 
            // EventosClick
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
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