namespace Proyectofor
{
    partial class For
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtIniciar = new Button();
            TxDesde = new TextBox();
            TxHasta = new TextBox();
            TxPaso = new TextBox();
            LblRes = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtCerrar = new Button();
            SuspendLayout();
            // 
            // BtIniciar
            // 
            BtIniciar.Cursor = Cursors.Hand;
            BtIniciar.Location = new Point(646, 155);
            BtIniciar.Name = "BtIniciar";
            BtIniciar.Size = new Size(94, 29);
            BtIniciar.TabIndex = 0;
            BtIniciar.Text = "Iniciar";
            BtIniciar.UseVisualStyleBackColor = true;
            BtIniciar.Click += BtIniciar_Click;
            // 
            // TxDesde
            // 
            TxDesde.Location = new Point(176, 155);
            TxDesde.Name = "TxDesde";
            TxDesde.Size = new Size(125, 27);
            TxDesde.TabIndex = 1;
            // 
            // TxHasta
            // 
            TxHasta.Location = new Point(333, 155);
            TxHasta.Name = "TxHasta";
            TxHasta.Size = new Size(125, 27);
            TxHasta.TabIndex = 2;
            // 
            // TxPaso
            // 
            TxPaso.Location = new Point(491, 155);
            TxPaso.Name = "TxPaso";
            TxPaso.Size = new Size(125, 27);
            TxPaso.TabIndex = 3;
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Location = new Point(176, 237);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(28, 20);
            LblRes.TabIndex = 4;
            LblRes.Text = "res";
            LblRes.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 103);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 5;
            label2.Text = "Desde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 103);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 6;
            label3.Text = "Hasta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 103);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 7;
            label4.Text = "Paso";
            // 
            // BtCerrar
            // 
            BtCerrar.Cursor = Cursors.Hand;
            BtCerrar.Location = new Point(694, 12);
            BtCerrar.Name = "BtCerrar";
            BtCerrar.Size = new Size(94, 29);
            BtCerrar.TabIndex = 8;
            BtCerrar.Text = "Salir";
            BtCerrar.UseVisualStyleBackColor = true;
            BtCerrar.Click += BtCerrar_Click;
            // 
            // For
            // 
            AcceptButton = BtIniciar;
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(BtCerrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LblRes);
            Controls.Add(TxPaso);
            Controls.Add(TxHasta);
            Controls.Add(TxDesde);
            Controls.Add(BtIniciar);
            Name = "For";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto For";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtIniciar;
        private TextBox TxDesde;
        private TextBox TxHasta;
        private TextBox TxPaso;
        private Label LblRes;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtCerrar;
    }
}
