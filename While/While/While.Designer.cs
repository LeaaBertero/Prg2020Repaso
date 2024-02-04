namespace While
{
    partial class While
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
            btejecutar = new Button();
            btsalir = new Button();
            SuspendLayout();
            // 
            // btejecutar
            // 
            btejecutar.Location = new Point(581, 35);
            btejecutar.Name = "btejecutar";
            btejecutar.Size = new Size(177, 44);
            btejecutar.TabIndex = 0;
            btejecutar.Text = "Ejemplo DoWhile";
            btejecutar.UseVisualStyleBackColor = true;
            btejecutar.Click += btejecutar_Click;
            // 
            // btsalir
            // 
            btsalir.Location = new Point(12, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(128, 44);
            btsalir.TabIndex = 1;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // While
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btsalir);
            Controls.Add(btejecutar);
            Name = "While";
            Text = "While";
            ResumeLayout(false);
        }

        #endregion

        private Button btejecutar;
        private Button btsalir;
    }
}