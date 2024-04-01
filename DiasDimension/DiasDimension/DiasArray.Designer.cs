namespace DiasDimension
{
    partial class DiasArray
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
            btSemana = new Button();
            lbListaSemana = new Label();
            btsalir = new Button();
            txMostrar = new TextBox();
            label1 = new Label();
            btLimpiar = new Button();
            SuspendLayout();
            // 
            // btSemana
            // 
            btSemana.Location = new Point(307, 169);
            btSemana.Name = "btSemana";
            btSemana.Size = new Size(90, 27);
            btSemana.TabIndex = 0;
            btSemana.Text = "Ver días";
            btSemana.UseVisualStyleBackColor = true;
            btSemana.Click += btSemana_Click;
            // 
            // lbListaSemana
            // 
            lbListaSemana.AutoSize = true;
            lbListaSemana.BackColor = Color.YellowGreen;
            lbListaSemana.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbListaSemana.ForeColor = Color.DarkOliveGreen;
            lbListaSemana.Location = new Point(189, 263);
            lbListaSemana.Name = "lbListaSemana";
            lbListaSemana.Size = new Size(59, 23);
            lbListaSemana.TabIndex = 1;
            lbListaSemana.Text = "label1";
            lbListaSemana.Visible = false;
            // 
            // btsalir
            // 
            btsalir.Location = new Point(441, 468);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 2;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // txMostrar
            // 
            txMostrar.Location = new Point(164, 169);
            txMostrar.Name = "txMostrar";
            txMostrar.Size = new Size(125, 27);
            txMostrar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 122);
            label1.Name = "label1";
            label1.Size = new Size(346, 20);
            label1.TabIndex = 4;
            label1.Text = "Ingrese \"Ver\", para vusualizar los días de la semana";
            // 
            // btLimpiar
            // 
            btLimpiar.Location = new Point(307, 202);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(121, 27);
            btLimpiar.TabIndex = 5;
            btLimpiar.Text = "Limpiar campo";
            btLimpiar.UseVisualStyleBackColor = true;
            btLimpiar.Click += btLimpiar_Click;
            // 
            // DiasArray
            // 
            AcceptButton = btSemana;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(547, 509);
            Controls.Add(btLimpiar);
            Controls.Add(label1);
            Controls.Add(txMostrar);
            Controls.Add(btsalir);
            Controls.Add(lbListaSemana);
            Controls.Add(btSemana);
            Name = "DiasArray";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiasArray";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSemana;
        private Label lbListaSemana;
        private Button btsalir;
        private TextBox txMostrar;
        private Label label1;
        private Button btLimpiar;
    }
}