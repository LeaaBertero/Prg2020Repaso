namespace ArrayDias
{
    partial class ArraysDias
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
            btdias = new Button();
            lbLunes = new Label();
            lbMartes = new Label();
            Lbmiercoles = new Label();
            LbJueves = new Label();
            LbViernes = new Label();
            lbSabado = new Label();
            LbDomingo = new Label();
            btLimpiar = new Button();
            Btsalir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btdias
            // 
            btdias.Cursor = Cursors.Hand;
            btdias.Location = new Point(227, 42);
            btdias.Name = "btdias";
            btdias.Size = new Size(181, 29);
            btdias.TabIndex = 0;
            btdias.Text = "Ver dias de la semana";
            btdias.UseVisualStyleBackColor = true;
            btdias.Click += btdias_Click;
            // 
            // lbLunes
            // 
            lbLunes.AutoSize = true;
            lbLunes.BackColor = Color.LimeGreen;
            lbLunes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbLunes.Location = new Point(23, 214);
            lbLunes.Name = "lbLunes";
            lbLunes.Size = new Size(70, 28);
            lbLunes.TabIndex = 1;
            lbLunes.Text = "label1";
            lbLunes.Visible = false;
            // 
            // lbMartes
            // 
            lbMartes.AutoSize = true;
            lbMartes.BackColor = Color.LimeGreen;
            lbMartes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbMartes.Location = new Point(143, 214);
            lbMartes.Name = "lbMartes";
            lbMartes.Size = new Size(70, 28);
            lbMartes.TabIndex = 2;
            lbMartes.Text = "label1";
            lbMartes.Visible = false;
            // 
            // Lbmiercoles
            // 
            Lbmiercoles.AutoSize = true;
            Lbmiercoles.BackColor = Color.LimeGreen;
            Lbmiercoles.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Lbmiercoles.Location = new Point(276, 214);
            Lbmiercoles.Name = "Lbmiercoles";
            Lbmiercoles.Size = new Size(70, 28);
            Lbmiercoles.TabIndex = 3;
            Lbmiercoles.Text = "label1";
            Lbmiercoles.Visible = false;
            // 
            // LbJueves
            // 
            LbJueves.AutoSize = true;
            LbJueves.BackColor = Color.LimeGreen;
            LbJueves.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LbJueves.Location = new Point(423, 214);
            LbJueves.Name = "LbJueves";
            LbJueves.Size = new Size(70, 28);
            LbJueves.TabIndex = 4;
            LbJueves.Text = "label1";
            LbJueves.Visible = false;
            // 
            // LbViernes
            // 
            LbViernes.AutoSize = true;
            LbViernes.BackColor = Color.LimeGreen;
            LbViernes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LbViernes.Location = new Point(566, 214);
            LbViernes.Name = "LbViernes";
            LbViernes.Size = new Size(70, 28);
            LbViernes.TabIndex = 5;
            LbViernes.Text = "label1";
            LbViernes.Visible = false;
            // 
            // lbSabado
            // 
            lbSabado.AutoSize = true;
            lbSabado.BackColor = Color.LimeGreen;
            lbSabado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbSabado.Location = new Point(724, 214);
            lbSabado.Name = "lbSabado";
            lbSabado.Size = new Size(70, 28);
            lbSabado.TabIndex = 6;
            lbSabado.Text = "label1";
            lbSabado.Visible = false;
            // 
            // LbDomingo
            // 
            LbDomingo.AutoSize = true;
            LbDomingo.BackColor = Color.LimeGreen;
            LbDomingo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LbDomingo.Location = new Point(870, 214);
            LbDomingo.Name = "LbDomingo";
            LbDomingo.Size = new Size(70, 28);
            LbDomingo.TabIndex = 7;
            LbDomingo.Text = "label1";
            LbDomingo.Visible = false;
            // 
            // btLimpiar
            // 
            btLimpiar.Cursor = Cursors.Hand;
            btLimpiar.Location = new Point(511, 42);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(181, 29);
            btLimpiar.TabIndex = 8;
            btLimpiar.Text = "dias semana";
            btLimpiar.UseVisualStyleBackColor = true;
            btLimpiar.Click += btLimpiar_Click;
            // 
            // Btsalir
            // 
            Btsalir.Cursor = Cursors.Hand;
            Btsalir.Location = new Point(829, 12);
            Btsalir.Name = "Btsalir";
            Btsalir.Size = new Size(147, 29);
            Btsalir.TabIndex = 9;
            Btsalir.Text = "Salir";
            Btsalir.UseVisualStyleBackColor = true;
            Btsalir.Click += Btsalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Kristen ITC", 20F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(227, 108);
            label1.Name = "label1";
            label1.Size = new Size(465, 45);
            label1.TabIndex = 10;
            label1.Text = "Los días de la semana son :";
            // 
            // ArraysDias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 268);
            Controls.Add(label1);
            Controls.Add(Btsalir);
            Controls.Add(btLimpiar);
            Controls.Add(LbDomingo);
            Controls.Add(lbSabado);
            Controls.Add(LbViernes);
            Controls.Add(LbJueves);
            Controls.Add(Lbmiercoles);
            Controls.Add(lbMartes);
            Controls.Add(lbLunes);
            Controls.Add(btdias);
            Name = "ArraysDias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ArraysDias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btdias;
        private Label lbLunes;
        private Label lbMartes;
        private Label Lbmiercoles;
        private Label LbJueves;
        private Label LbViernes;
        private Label lbSabado;
        private Label LbDomingo;
        private Button btLimpiar;
        private Button Btsalir;
        private Label label1;
    }
}