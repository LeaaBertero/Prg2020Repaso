namespace MiprimerArreglo
{
    partial class PrimerArreglo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimerArreglo));
            btCargar = new Button();
            txEdad = new TextBox();
            txNombre = new TextBox();
            label1 = new Label();
            Edad = new Label();
            lbLista = new Label();
            btMostrar = new Button();
            btCerrar = new Button();
            label2 = new Label();
            label3 = new Label();
            txDocumento = new TextBox();
            label4 = new Label();
            txCiudad = new TextBox();
            btBorrar = new Button();
            SuspendLayout();
            // 
            // btCargar
            // 
            btCargar.BackColor = Color.Gold;
            btCargar.Cursor = Cursors.Hand;
            btCargar.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCargar.Location = new Point(307, 157);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(94, 29);
            btCargar.TabIndex = 2;
            btCargar.Text = "Cargar";
            btCargar.UseVisualStyleBackColor = false;
            btCargar.Click += btCargar_Click;
            // 
            // txEdad
            // 
            txEdad.Location = new Point(153, 159);
            txEdad.Name = "txEdad";
            txEdad.Size = new Size(125, 27);
            txEdad.TabIndex = 1;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(22, 159);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(125, 27);
            txNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 136);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // Edad
            // 
            Edad.AutoSize = true;
            Edad.Location = new Point(153, 136);
            Edad.Name = "Edad";
            Edad.Size = new Size(43, 20);
            Edad.TabIndex = 4;
            Edad.Text = "Edad";
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.Location = new Point(603, 136);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(42, 20);
            lbLista.TabIndex = 4;
            lbLista.Text = "Lista:";
            lbLista.Visible = false;
            // 
            // btMostrar
            // 
            btMostrar.BackColor = Color.Gold;
            btMostrar.Cursor = Cursors.Hand;
            btMostrar.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMostrar.Location = new Point(407, 157);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(94, 29);
            btMostrar.TabIndex = 3;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = false;
            btMostrar.Click += btMostrar_Click;
            // 
            // btCerrar
            // 
            btCerrar.BackColor = Color.Gold;
            btCerrar.Cursor = Cursors.Hand;
            btCerrar.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCerrar.Location = new Point(694, 12);
            btCerrar.Name = "btCerrar";
            btCerrar.Size = new Size(94, 29);
            btCerrar.TabIndex = 5;
            btCerrar.Text = "Cerrar";
            btCerrar.UseVisualStyleBackColor = false;
            btCerrar.Click += btCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Kristen ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(317, 24);
            label2.TabIndex = 8;
            label2.Text = "Cargue aquí los datos personales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 195);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 10;
            label3.Text = "Documento";
            // 
            // txDocumento
            // 
            txDocumento.Location = new Point(22, 218);
            txDocumento.Name = "txDocumento";
            txDocumento.Size = new Size(125, 27);
            txDocumento.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 195);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 12;
            label4.Text = "Ciudad";
            // 
            // txCiudad
            // 
            txCiudad.Location = new Point(153, 218);
            txCiudad.Name = "txCiudad";
            txCiudad.Size = new Size(125, 27);
            txCiudad.TabIndex = 11;
            // 
            // btBorrar
            // 
            btBorrar.BackColor = Color.Gold;
            btBorrar.Cursor = Cursors.Hand;
            btBorrar.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btBorrar.Location = new Point(307, 122);
            btBorrar.Name = "btBorrar";
            btBorrar.Size = new Size(94, 29);
            btBorrar.TabIndex = 13;
            btBorrar.Text = "Borrar";
            btBorrar.UseVisualStyleBackColor = false;
            btBorrar.Click += btBorrar_Click;
            // 
            // PrimerArreglo
            // 
            AcceptButton = btCargar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(btBorrar);
            Controls.Add(label4);
            Controls.Add(txCiudad);
            Controls.Add(label3);
            Controls.Add(txDocumento);
            Controls.Add(label2);
            Controls.Add(btCerrar);
            Controls.Add(btMostrar);
            Controls.Add(lbLista);
            Controls.Add(Edad);
            Controls.Add(label1);
            Controls.Add(txNombre);
            Controls.Add(txEdad);
            Controls.Add(btCargar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PrimerArreglo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrimerArreglo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCargar;
        private TextBox txEdad;
        private TextBox txNombre;
        private Label label1;
        private Label Edad;
        private Label lbLista;
        private Button btMostrar;
        private Button btCerrar;
        private Label label2;
        private Label label3;
        private TextBox txDocumento;
        private Label label4;
        private TextBox txCiudad;
        private Button btBorrar;
    }
}