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
            btLimpiar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtIniciar
            // 
            BtIniciar.Cursor = Cursors.Hand;
            BtIniciar.Location = new Point(594, 179);
            BtIniciar.Name = "BtIniciar";
            BtIniciar.Size = new Size(94, 29);
            BtIniciar.TabIndex = 0;
            BtIniciar.Text = "Iniciar";
            BtIniciar.UseVisualStyleBackColor = true;
            BtIniciar.Click += BtIniciar_Click;
            // 
            // TxDesde
            // 
            TxDesde.Location = new Point(124, 179);
            TxDesde.Name = "TxDesde";
            TxDesde.Size = new Size(125, 27);
            TxDesde.TabIndex = 1;
            // 
            // TxHasta
            // 
            TxHasta.Location = new Point(281, 179);
            TxHasta.Name = "TxHasta";
            TxHasta.Size = new Size(125, 27);
            TxHasta.TabIndex = 2;
            // 
            // TxPaso
            // 
            TxPaso.Location = new Point(439, 179);
            TxPaso.Name = "TxPaso";
            TxPaso.Size = new Size(125, 27);
            TxPaso.TabIndex = 3;
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Font = new Font("Kristen ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblRes.Location = new Point(124, 261);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(59, 39);
            LblRes.TabIndex = 4;
            LblRes.Text = "res";
            LblRes.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 13.8F);
            label2.Location = new Point(141, 127);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 5;
            label2.Text = "Desde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kristen ITC", 13.8F);
            label3.Location = new Point(305, 127);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 6;
            label3.Text = "Hasta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kristen ITC", 13.8F);
            label4.Location = new Point(466, 127);
            label4.Name = "label4";
            label4.Size = new Size(66, 30);
            label4.TabIndex = 7;
            label4.Text = "Paso";
            // 
            // BtCerrar
            // 
            BtCerrar.Cursor = Cursors.Hand;
            BtCerrar.Location = new Point(784, 409);
            BtCerrar.Name = "BtCerrar";
            BtCerrar.Size = new Size(94, 29);
            BtCerrar.TabIndex = 8;
            BtCerrar.Text = "Salir";
            BtCerrar.UseVisualStyleBackColor = true;
            BtCerrar.Click += BtCerrar_Click;
            // 
            // btLimpiar
            // 
            btLimpiar.Location = new Point(694, 179);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(143, 29);
            btLimpiar.TabIndex = 9;
            btLimpiar.Text = "Limpiar campos";
            btLimpiar.UseVisualStyleBackColor = true;
            btLimpiar.Click += btLimpiar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Courier New", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(887, 66);
            label1.TabIndex = 10;
            label1.Text = "Proyecto estructura de ciclo For";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // For
            // 
            AcceptButton = BtIniciar;
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(911, 450);
            Controls.Add(label1);
            Controls.Add(btLimpiar);
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
        private Button btLimpiar;
        private Label label1;
    }
}
