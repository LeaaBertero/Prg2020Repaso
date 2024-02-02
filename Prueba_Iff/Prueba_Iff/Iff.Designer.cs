namespace Prueba_Iff
{
    partial class Iff
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
            btNuevo = new Button();
            btCerrar = new Button();
            BtIniciar = new Button();
            TxEdad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btcomenzar = new Button();
            label3 = new Label();
            TxingresoTXT = new TextBox();
            SuspendLayout();
            // 
            // btNuevo
            // 
            btNuevo.Location = new Point(1194, 12);
            btNuevo.Name = "btNuevo";
            btNuevo.Size = new Size(137, 57);
            btNuevo.TabIndex = 0;
            btNuevo.Text = "Ir a formulario --Nuevo";
            btNuevo.UseVisualStyleBackColor = true;
            btNuevo.Click += btNuevo_Click;
            // 
            // btCerrar
            // 
            btCerrar.Cursor = Cursors.Hand;
            btCerrar.Location = new Point(487, 399);
            btCerrar.Name = "btCerrar";
            btCerrar.Size = new Size(371, 39);
            btCerrar.TabIndex = 1;
            btCerrar.Text = "salir";
            btCerrar.UseVisualStyleBackColor = true;
            btCerrar.Click += btCerrar_Click;
            // 
            // BtIniciar
            // 
            BtIniciar.Location = new Point(7, 113);
            BtIniciar.Name = "BtIniciar";
            BtIniciar.Size = new Size(95, 48);
            BtIniciar.TabIndex = 2;
            BtIniciar.Text = "Iniciar";
            BtIniciar.UseVisualStyleBackColor = true;
            BtIniciar.Click += BtIniciar_Click;
            // 
            // TxEdad
            // 
            TxEdad.Location = new Point(119, 134);
            TxEdad.Name = "TxEdad";
            TxEdad.Size = new Size(163, 27);
            TxEdad.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(289, 37);
            label1.TabIndex = 4;
            label1.Text = "primera prueba --edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 97);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 5;
            label2.Text = "ingrese a edad";
            // 
            // btcomenzar
            // 
            btcomenzar.Location = new Point(487, 113);
            btcomenzar.Name = "btcomenzar";
            btcomenzar.Size = new Size(101, 48);
            btcomenzar.TabIndex = 6;
            btcomenzar.Text = "comenzar";
            btcomenzar.UseVisualStyleBackColor = true;
            btcomenzar.Click += btcomenzar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(464, 16);
            label3.Name = "label3";
            label3.Size = new Size(342, 37);
            label3.TabIndex = 7;
            label3.Text = "segunda prueba --nombres";
            // 
            // TxingresoTXT
            // 
            TxingresoTXT.Location = new Point(635, 124);
            TxingresoTXT.Name = "TxingresoTXT";
            TxingresoTXT.Size = new Size(125, 27);
            TxingresoTXT.TabIndex = 8;
            // 
            // Iff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(1343, 450);
            Controls.Add(TxingresoTXT);
            Controls.Add(label3);
            Controls.Add(btcomenzar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxEdad);
            Controls.Add(BtIniciar);
            Controls.Add(btCerrar);
            Controls.Add(btNuevo);
            Name = "Iff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btNuevo;
        private Button btCerrar;
        private Button BtIniciar;
        private TextBox TxEdad;
        private Label label1;
        private Label label2;
        private Button btcomenzar;
        private Label label3;
        private TextBox TxingresoTXT;
    }
}