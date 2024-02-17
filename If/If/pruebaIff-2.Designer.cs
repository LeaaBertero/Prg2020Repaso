namespace If
{
    partial class pruebaIff_2
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
            btsalir2 = new Button();
            SuspendLayout();
            // 
            // btsalir2
            // 
            btsalir2.Cursor = Cursors.Hand;
            btsalir2.Location = new Point(342, 400);
            btsalir2.Name = "btsalir2";
            btsalir2.Size = new Size(94, 29);
            btsalir2.TabIndex = 0;
            btsalir2.Text = "salir";
            btsalir2.UseVisualStyleBackColor = true;
            btsalir2.Click += btsalir2_Click;
            // 
            // pruebaIff_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btsalir2);
            Name = "pruebaIff_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pruebaIff_2";
            ResumeLayout(false);
        }

        #endregion

        private Button btsalir2;
    }
}