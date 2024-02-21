namespace Timer_prueba
{
    partial class Timer
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lbTimer = new Label();
            btcerrar = new Button();
            btmovimiento = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lbTimer
            // 
            lbTimer.AutoSize = true;
            lbTimer.BackColor = Color.DarkOrange;
            lbTimer.Cursor = Cursors.No;
            lbTimer.Font = new Font("Kristen ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTimer.Location = new Point(190, 28);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new Size(119, 45);
            lbTimer.TabIndex = 0;
            lbTimer.Text = "label1";
            lbTimer.Visible = false;
            lbTimer.Click += lbTimer_Click;
            // 
            // btcerrar
            // 
            btcerrar.Cursor = Cursors.Hand;
            btcerrar.ForeColor = Color.Black;
            btcerrar.Location = new Point(634, 177);
            btcerrar.Name = "btcerrar";
            btcerrar.Size = new Size(94, 29);
            btcerrar.TabIndex = 1;
            btcerrar.Text = "Salir";
            btcerrar.UseVisualStyleBackColor = true;
            btcerrar.Click += btcerrar_Click;
            // 
            // btmovimiento
            // 
            btmovimiento.Cursor = Cursors.Hand;
            btmovimiento.Font = new Font("Segoe UI", 14F);
            btmovimiento.ForeColor = Color.Black;
            btmovimiento.Location = new Point(26, 142);
            btmovimiento.Name = "btmovimiento";
            btmovimiento.Size = new Size(428, 44);
            btmovimiento.TabIndex = 2;
            btmovimiento.Text = "formulario de label en movimiento";
            btmovimiento.UseVisualStyleBackColor = true;
            btmovimiento.Click += btmovimiento_Click;
            // 
            // Timer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(740, 218);
            Controls.Add(btmovimiento);
            Controls.Add(btcerrar);
            Controls.Add(lbTimer);
            ForeColor = Color.White;
            Name = "Timer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lbTimer;
        private Button btcerrar;
        private Button btmovimiento;
    }
}