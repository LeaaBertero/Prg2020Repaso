namespace Switch_Ini
{
    partial class Ejercitacion_switch
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
            SuspendLayout();
            // 
            // btcerrar
            // 
            btcerrar.Location = new Point(604, 23);
            btcerrar.Name = "btcerrar";
            btcerrar.Size = new Size(155, 58);
            btcerrar.TabIndex = 0;
            btcerrar.Text = "salir";
            btcerrar.UseVisualStyleBackColor = true;
            btcerrar.Click += btcerrar_Click;
            // 
            // Ejercitacion_switch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btcerrar);
            Name = "Ejercitacion_switch";
            Text = "Ejercitacion_switch";
            ResumeLayout(false);
        }

        #endregion

        private Button btcerrar;
    }
}