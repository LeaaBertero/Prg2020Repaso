namespace holaMundo
{
    partial class HolaMundo
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
            btsalir = new Button();
            btcomenzar = new Button();
            lbTexto = new Label();
            btlimpiar = new Button();
            btTextoIni = new Button();
            btIniciar = new Button();
            txtexto = new TextBox();
            lbresultado = new Label();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            btBorrar = new Button();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.Cursor = Cursors.Hand;
            btsalir.Location = new Point(694, 12);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(94, 29);
            btsalir.TabIndex = 0;
            btsalir.Text = "salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // btcomenzar
            // 
            btcomenzar.Cursor = Cursors.Hand;
            btcomenzar.Location = new Point(82, 65);
            btcomenzar.Name = "btcomenzar";
            btcomenzar.Size = new Size(94, 29);
            btcomenzar.TabIndex = 1;
            btcomenzar.Text = "Comenzar";
            btcomenzar.UseVisualStyleBackColor = true;
            btcomenzar.Click += btcomenzar_Click;
            // 
            // lbTexto
            // 
            lbTexto.AutoSize = true;
            lbTexto.Location = new Point(240, 16);
            lbTexto.Name = "lbTexto";
            lbTexto.Size = new Size(280, 20);
            lbTexto.TabIndex = 2;
            lbTexto.Text = "click en comenzar para visualizar el texto";
            // 
            // btlimpiar
            // 
            btlimpiar.Cursor = Cursors.Hand;
            btlimpiar.Location = new Point(323, 65);
            btlimpiar.Name = "btlimpiar";
            btlimpiar.Size = new Size(94, 29);
            btlimpiar.TabIndex = 3;
            btlimpiar.Text = "Limpiar";
            btlimpiar.UseVisualStyleBackColor = true;
            btlimpiar.Click += btlimpiar_Click;
            // 
            // btTextoIni
            // 
            btTextoIni.Cursor = Cursors.Hand;
            btTextoIni.Location = new Point(551, 65);
            btTextoIni.Name = "btTextoIni";
            btTextoIni.Size = new Size(111, 29);
            btTextoIni.TabIndex = 4;
            btTextoIni.Text = "Texto inicial";
            btTextoIni.UseVisualStyleBackColor = true;
            btTextoIni.Click += btTextoIni_Click;
            // 
            // btIniciar
            // 
            btIniciar.Cursor = Cursors.Hand;
            btIniciar.Location = new Point(190, 303);
            btIniciar.Name = "btIniciar";
            btIniciar.Size = new Size(94, 29);
            btIniciar.TabIndex = 5;
            btIniciar.Text = "Iniciar";
            btIniciar.UseVisualStyleBackColor = true;
            btIniciar.Click += btIniciar_Click;
            // 
            // txtexto
            // 
            txtexto.Location = new Point(323, 304);
            txtexto.Name = "txtexto";
            txtexto.Size = new Size(125, 27);
            txtexto.TabIndex = 6;
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Location = new Point(520, 307);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(50, 20);
            lbresultado.TabIndex = 7;
            lbresultado.Text = "label1";
            lbresultado.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 159);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 8;
            label1.Text = "Ingrese la palabra correcta";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(180, 212);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hola";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(338, 212);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 24);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mundo";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(493, 212);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(69, 24);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "Visual";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // btBorrar
            // 
            btBorrar.Location = new Point(190, 338);
            btBorrar.Name = "btBorrar";
            btBorrar.Size = new Size(94, 29);
            btBorrar.TabIndex = 12;
            btBorrar.Text = "Borrar";
            btBorrar.UseVisualStyleBackColor = true;
            btBorrar.Click += btBorrar_Click;
            // 
            // HolaMundo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(btBorrar);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(lbresultado);
            Controls.Add(txtexto);
            Controls.Add(btIniciar);
            Controls.Add(btTextoIni);
            Controls.Add(btlimpiar);
            Controls.Add(lbTexto);
            Controls.Add(btcomenzar);
            Controls.Add(btsalir);
            Name = "HolaMundo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HolaMundo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btcomenzar;
        private Label lbTexto;
        private Button btlimpiar;
        private Button btTextoIni;
        private Button btIniciar;
        private TextBox txtexto;
        private Label lbresultado;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button btBorrar;
    }
}