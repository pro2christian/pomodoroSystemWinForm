namespace Pomodoro
{
    partial class telaInicio
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
            components = new System.ComponentModel.Container();
            buttonPadrao = new Button();
            buttonPersonalizado = new Button();
            checkBox1 = new CheckBox();
            buttonIniciar = new Button();
            buttonParar = new Button();
            txt_temporizador = new TextBox();
            buttonResert = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            labelCronometro = new Label();
            listRegisto = new ListBox();
            buttonregPausa = new Button();
            buttonContinuar = new Button();
            SuspendLayout();
            // 
            // buttonPadrao
            // 
            buttonPadrao.Location = new Point(95, 187);
            buttonPadrao.Name = "buttonPadrao";
            buttonPadrao.Size = new Size(75, 21);
            buttonPadrao.TabIndex = 2;
            buttonPadrao.Text = "Padrão";
            buttonPadrao.UseVisualStyleBackColor = true;
            buttonPadrao.Visible = false;
            // 
            // buttonPersonalizado
            // 
            buttonPersonalizado.Location = new Point(176, 187);
            buttonPersonalizado.Name = "buttonPersonalizado";
            buttonPersonalizado.Size = new Size(96, 21);
            buttonPersonalizado.TabIndex = 3;
            buttonPersonalizado.Text = "Personalizado";
            buttonPersonalizado.UseVisualStyleBackColor = true;
            buttonPersonalizado.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(121, 219);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Mostrar cronômetro";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // buttonIniciar
            // 
            buttonIniciar.BackColor = Color.Green;
            buttonIniciar.FlatAppearance.BorderSize = 0;
            buttonIniciar.FlatAppearance.MouseDownBackColor = Color.Lime;
            buttonIniciar.FlatStyle = FlatStyle.Flat;
            buttonIniciar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonIniciar.ForeColor = Color.White;
            buttonIniciar.Location = new Point(48, 99);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(75, 33);
            buttonIniciar.TabIndex = 0;
            buttonIniciar.Text = "Iniciar";
            buttonIniciar.UseVisualStyleBackColor = false;
            buttonIniciar.Click += buttonIniciar_Click;
            // 
            // buttonParar
            // 
            buttonParar.BackColor = Color.Red;
            buttonParar.FlatAppearance.BorderSize = 0;
            buttonParar.FlatAppearance.MouseDownBackColor = Color.Salmon;
            buttonParar.FlatStyle = FlatStyle.Flat;
            buttonParar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonParar.ForeColor = Color.White;
            buttonParar.Location = new Point(248, 99);
            buttonParar.Name = "buttonParar";
            buttonParar.Size = new Size(75, 33);
            buttonParar.TabIndex = 1;
            buttonParar.Text = "Pausar";
            buttonParar.UseVisualStyleBackColor = false;
            buttonParar.Click += buttonParar_Click;
            // 
            // txt_temporizador
            // 
            txt_temporizador.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_temporizador.Location = new Point(94, 157);
            txt_temporizador.Name = "txt_temporizador";
            txt_temporizador.Size = new Size(178, 25);
            txt_temporizador.TabIndex = 6;
            txt_temporizador.Text = "11:11:11";
            txt_temporizador.TextAlign = HorizontalAlignment.Center;
            txt_temporizador.Visible = false;
            // 
            // buttonResert
            // 
            buttonResert.BackColor = Color.Yellow;
            buttonResert.FlatAppearance.BorderSize = 0;
            buttonResert.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 0);
            buttonResert.FlatStyle = FlatStyle.Flat;
            buttonResert.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResert.Location = new Point(148, 99);
            buttonResert.Name = "buttonResert";
            buttonResert.Size = new Size(75, 34);
            buttonResert.TabIndex = 7;
            buttonResert.Text = "Resetar";
            buttonResert.UseVisualStyleBackColor = false;
            buttonResert.Visible = false;
            buttonResert.Click += buttonResert_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // labelCronometro
            // 
            labelCronometro.AutoSize = true;
            labelCronometro.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelCronometro.Location = new Point(48, 8);
            labelCronometro.Name = "labelCronometro";
            labelCronometro.Size = new Size(275, 86);
            labelCronometro.TabIndex = 8;
            labelCronometro.Text = "00:00,00";
            // 
            // listRegisto
            // 
            listRegisto.FormattingEnabled = true;
            listRegisto.ItemHeight = 15;
            listRegisto.Location = new Point(346, 20);
            listRegisto.Name = "listRegisto";
            listRegisto.Size = new Size(117, 199);
            listRegisto.TabIndex = 9;
            // 
            // buttonregPausa
            // 
            buttonregPausa.BackColor = Color.SkyBlue;
            buttonregPausa.FlatAppearance.BorderSize = 0;
            buttonregPausa.FlatAppearance.MouseDownBackColor = Color.Cyan;
            buttonregPausa.FlatStyle = FlatStyle.Flat;
            buttonregPausa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonregPausa.Location = new Point(48, 97);
            buttonregPausa.Name = "buttonregPausa";
            buttonregPausa.Size = new Size(75, 44);
            buttonregPausa.TabIndex = 10;
            buttonregPausa.Text = "Registrar pausa?";
            buttonregPausa.UseVisualStyleBackColor = false;
            buttonregPausa.Visible = false;
            buttonregPausa.Click += buttonregPausa_Click;
            // 
            // buttonContinuar
            // 
            buttonContinuar.BackColor = Color.SkyBlue;
            buttonContinuar.FlatAppearance.BorderSize = 0;
            buttonContinuar.FlatAppearance.MouseDownBackColor = Color.Yellow;
            buttonContinuar.FlatStyle = FlatStyle.Flat;
            buttonContinuar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonContinuar.Location = new Point(139, 99);
            buttonContinuar.Name = "buttonContinuar";
            buttonContinuar.Size = new Size(94, 34);
            buttonContinuar.TabIndex = 11;
            buttonContinuar.Text = "Continuar";
            buttonContinuar.UseVisualStyleBackColor = false;
            buttonContinuar.Visible = false;
            buttonContinuar.Click += buttonContinuar_Click;
            // 
            // telaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 249);
            Controls.Add(buttonContinuar);
            Controls.Add(buttonregPausa);
            Controls.Add(listRegisto);
            Controls.Add(labelCronometro);
            Controls.Add(buttonResert);
            Controls.Add(txt_temporizador);
            Controls.Add(buttonParar);
            Controls.Add(buttonIniciar);
            Controls.Add(checkBox1);
            Controls.Add(buttonPersonalizado);
            Controls.Add(buttonPadrao);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "telaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pomodoro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPadrao;
        private Button buttonPersonalizado;
        private CheckBox checkBox1;
        private Button buttonIniciar;
        private Button buttonParar;
        private TextBox txt_temporizador;
        private Button buttonResert;
        private System.Windows.Forms.Timer timer1;
        private Label labelCronometro;
        private ListBox listRegisto;
        private Button buttonregPausa;
        private Button buttonContinuar;
    }
}