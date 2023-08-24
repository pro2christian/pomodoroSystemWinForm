using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;
namespace Pomodoro
{
    public partial class telaInicio : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        private bool validacao;

        //controla às pausas
        public bool v
        {
            set { this.validacao = true; }
        }

        public telaInicio()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //em desenvolvimento
        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            if (labelCronometro.Text == string.Format("00:00,00"))
            {
                return;
            }
            else
            {
                stopwatch.Stop();
                buttonIniciar.Visible = false;
                buttonContinuar.Visible = true;
            }
        }

        private void buttonResert_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            DialogResult resultado = MessageBox.Show("Os dados na lista serão excluídos",
                                                     "Atenção!!!",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                stopwatch.Reset();
                listRegisto.Items.Clear();
                buttonResert.Visible = false;
                buttonContinuar.Visible = false;
                buttonIniciar.Visible = true;
            }
            else
            {
                buttonContinuar.Visible = true;
            }
        }
        //registra na lista incio da atividades 
        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            stopwatch.Reset();
            stopwatch.Start();
            validacao = false;
            TimeSpan alerta = stopwatch.Elapsed;

            listRegisto.Items.Add(string.Format("Em atividade..."));
            buttonIniciar.Visible = false;
            buttonResert.Visible = true;
            buttonParar.Visible = true;
        }
        //controla o tempo decorrido
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelCronometro.Text = string.Format("{0:mm\\:ss\\,ff}", stopwatch.Elapsed);

            //pausa o cronometro assim que o tempo é atingido
            TimeSpan alerta = stopwatch.Elapsed;
            //em atividade...
            if (alerta.TotalSeconds >= 2 && validacao != true)
            {
                stopwatch.Stop();
                timer1.Stop();
                MessageBox.Show("Tire sua pausa!!", "Pausa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                buttonParar.Visible = false;
                buttonResert.Visible = false;
                buttonregPausa.Visible = true;
                timer1.Start();
                validacao = true;
            }//em pausa...
            else if (alerta.TotalSeconds >= 3 && validacao == true)
            {
                stopwatch.Stop();
                timer1.Stop();
                MessageBox.Show("Voltar às atividades!!", "Pausa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                buttonIniciar.Visible = true;
            }
        }

        //registra na lista de atividades a pausa
        private void buttonregPausa_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            listRegisto.Items.Add(string.Format("Em pausa..."));
            buttonregPausa.Visible = false;
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            buttonContinuar.Visible = false;
            buttonResert.Visible = true;
        }
    }
}