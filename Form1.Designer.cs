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
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            button3 = new Button();
            labelCornometro = new Label();
            button4 = new Button();
            txt_temporizador = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(121, 180);
            button1.Name = "button1";
            button1.Size = new Size(75, 21);
            button1.TabIndex = 2;
            button1.Text = "Padrão";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(202, 180);
            button2.Name = "button2";
            button2.Size = new Size(96, 21);
            button2.TabIndex = 3;
            button2.Text = "Personalizado";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(147, 212);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Mostrar cronômetro";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(121, 110);
            button3.Name = "button3";
            button3.Size = new Size(75, 33);
            button3.TabIndex = 0;
            button3.Text = "Iniciar";
            button3.UseVisualStyleBackColor = false;
            // 
            // labelCornometro
            // 
            labelCornometro.AutoSize = true;
            labelCornometro.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelCornometro.Location = new Point(76, 9);
            labelCornometro.Name = "labelCornometro";
            labelCornometro.Size = new Size(275, 86);
            labelCornometro.TabIndex = 5;
            labelCornometro.Text = "11:11:11";
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.MouseDownBackColor = Color.OrangeRed;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(223, 110);
            button4.Name = "button4";
            button4.Size = new Size(75, 33);
            button4.TabIndex = 1;
            button4.Text = "Parar";
            button4.UseVisualStyleBackColor = false;
            // 
            // txt_temporizador
            // 
            txt_temporizador.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_temporizador.Location = new Point(120, 150);
            txt_temporizador.Name = "txt_temporizador";
            txt_temporizador.Size = new Size(178, 25);
            txt_temporizador.TabIndex = 6;
            txt_temporizador.Text = "11:11:11";
            txt_temporizador.TextAlign = HorizontalAlignment.Center;
            txt_temporizador.Visible = false;
            // 
            // telaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 249);
            Controls.Add(txt_temporizador);
            Controls.Add(button4);
            Controls.Add(labelCornometro);
            Controls.Add(button3);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "telaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pomodoro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private Button button3;
        private Label labelCornometro;
        private Button button4;
        private TextBox txt_temporizador;
    }
}