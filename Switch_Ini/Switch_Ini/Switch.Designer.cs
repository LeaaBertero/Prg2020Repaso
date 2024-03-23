namespace Switch_Ini
{
    partial class Switch
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
            bt_nuevo = new Button();
            btsalir = new Button();
            btAceptar = new Button();
            txIngresar = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // bt_nuevo
            // 
            bt_nuevo.Location = new Point(399, 12);
            bt_nuevo.Name = "bt_nuevo";
            bt_nuevo.Size = new Size(158, 36);
            bt_nuevo.TabIndex = 0;
            bt_nuevo.Text = "Ej_Switch";
            bt_nuevo.UseVisualStyleBackColor = true;
            bt_nuevo.Click += bt_nuevo_Click;
            // 
            // btsalir
            // 
            btsalir.Location = new Point(12, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 1;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btAceptar
            // 
            btAceptar.Location = new Point(25, 120);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(138, 42);
            btAceptar.TabIndex = 2;
            btAceptar.Text = "comenzar";
            btAceptar.UseVisualStyleBackColor = true;
            btAceptar.Click += btAceptar_Click;
            // 
            // txIngresar
            // 
            txIngresar.Location = new Point(179, 135);
            txIngresar.Name = "txIngresar";
            txIngresar.Size = new Size(125, 27);
            txIngresar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(179, 104);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 4;
            label1.Text = "Ingrese nota:";
            // 
            // Switch
            // 
            AcceptButton = btAceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(569, 193);
            Controls.Add(label1);
            Controls.Add(txIngresar);
            Controls.Add(btAceptar);
            Controls.Add(btsalir);
            Controls.Add(bt_nuevo);
            Name = "Switch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Switch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_nuevo;
        private Button btsalir;
        private Button btAceptar;
        private TextBox txIngresar;
        private Label label1;
    }
}