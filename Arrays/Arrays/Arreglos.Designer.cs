namespace Arrays
{
    partial class Arreglos
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
            btcargar = new Button();
            lbLunes = new Label();
            lbMartes = new Label();
            lbMiercoles = new Label();
            lbJueves = new Label();
            lbViernes = new Label();
            lbsabado = new Label();
            lbDomingo = new Label();
            SuspendLayout();
            // 
            // btcerrar
            // 
            btcerrar.Cursor = Cursors.Hand;
            btcerrar.Location = new Point(641, 266);
            btcerrar.Name = "btcerrar";
            btcerrar.Size = new Size(147, 29);
            btcerrar.TabIndex = 0;
            btcerrar.Text = "Cerrar formulario";
            btcerrar.UseVisualStyleBackColor = true;
            btcerrar.Click += btcerrar_Click;
            // 
            // btcargar
            // 
            btcargar.Cursor = Cursors.Hand;
            btcargar.FlatStyle = FlatStyle.Flat;
            btcargar.Location = new Point(299, 12);
            btcargar.Name = "btcargar";
            btcargar.Size = new Size(236, 45);
            btcargar.TabIndex = 1;
            btcargar.Text = "Mostrar días de la semana";
            btcargar.UseVisualStyleBackColor = true;
            btcargar.Click += btcargar_Click;
            // 
            // lbLunes
            // 
            lbLunes.AutoSize = true;
            lbLunes.Location = new Point(95, 120);
            lbLunes.Name = "lbLunes";
            lbLunes.Size = new Size(50, 20);
            lbLunes.TabIndex = 4;
            lbLunes.Text = "label2";
            lbLunes.Visible = false;
            // 
            // lbMartes
            // 
            lbMartes.AutoSize = true;
            lbMartes.Location = new Point(182, 120);
            lbMartes.Name = "lbMartes";
            lbMartes.Size = new Size(50, 20);
            lbMartes.TabIndex = 5;
            lbMartes.Text = "label2";
            lbMartes.Visible = false;
            // 
            // lbMiercoles
            // 
            lbMiercoles.AutoSize = true;
            lbMiercoles.Location = new Point(281, 120);
            lbMiercoles.Name = "lbMiercoles";
            lbMiercoles.Size = new Size(50, 20);
            lbMiercoles.TabIndex = 6;
            lbMiercoles.Text = "label2";
            lbMiercoles.Visible = false;
            // 
            // lbJueves
            // 
            lbJueves.AutoSize = true;
            lbJueves.Location = new Point(374, 120);
            lbJueves.Name = "lbJueves";
            lbJueves.Size = new Size(50, 20);
            lbJueves.TabIndex = 7;
            lbJueves.Text = "label2";
            lbJueves.Visible = false;
            // 
            // lbViernes
            // 
            lbViernes.AutoSize = true;
            lbViernes.Location = new Point(467, 120);
            lbViernes.Name = "lbViernes";
            lbViernes.Size = new Size(50, 20);
            lbViernes.TabIndex = 8;
            lbViernes.Text = "label2";
            lbViernes.Visible = false;
            // 
            // lbsabado
            // 
            lbsabado.AutoSize = true;
            lbsabado.Location = new Point(561, 120);
            lbsabado.Name = "lbsabado";
            lbsabado.Size = new Size(50, 20);
            lbsabado.TabIndex = 9;
            lbsabado.Text = "label2";
            lbsabado.Visible = false;
            // 
            // lbDomingo
            // 
            lbDomingo.AutoSize = true;
            lbDomingo.Location = new Point(652, 120);
            lbDomingo.Name = "lbDomingo";
            lbDomingo.Size = new Size(50, 20);
            lbDomingo.TabIndex = 10;
            lbDomingo.Text = "label2";
            lbDomingo.Visible = false;
            // 
            // Arreglos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 307);
            Controls.Add(lbDomingo);
            Controls.Add(lbsabado);
            Controls.Add(lbViernes);
            Controls.Add(lbJueves);
            Controls.Add(lbMiercoles);
            Controls.Add(lbMartes);
            Controls.Add(lbLunes);
            Controls.Add(btcargar);
            Controls.Add(btcerrar);
            Name = "Arreglos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arreglos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcerrar;
        private Button btcargar;
        private TextBox txcargar;
        private Label label1;
        private Label lbLunes;
        private Label lbMartes;
        private Label lbMiercoles;
        private Label lbJueves;
        private Label lbViernes;
        private Label lbsabado;
        private Label lbDomingo;
    }
}