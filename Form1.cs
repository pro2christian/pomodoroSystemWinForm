using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;
namespace Pomodoro
{
    public partial class telaInicio : Form
    {
        Stopwatch stopwatch = new Stopwatch();

        public telaInicio()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            buttonIniciar.Visible = false;
            buttonContinuar.Visible = true;

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
                buttonContinuar.Visible=false;
                buttonIniciar.Visible=true;
            }
            else
            {               
                buttonContinuar.Visible = true;
            }
            
        }
        //registra na lista incio da atividades 
        private void buttonIniciar_Click(object sender, EventArgs e)
        {            
            stopwatch.Start();
            TimeSpan alerta = stopwatch.Elapsed;
           
            listRegisto.Items.Add(string.Format("Em atividade..."));
            buttonIniciar.Visible = false;
            buttonResert.Visible = true;

        }
        //controla o tempo decorrido
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelCronometro.Text = string.Format("{0:mm\\:ss\\,ff}", stopwatch.Elapsed);
           
            //pausa o cronometro assim que o tempo é atingido
            TimeSpan alerta = stopwatch.Elapsed;
            if (alerta.TotalSeconds >= 3)
            {
                stopwatch.Stop();
                timer1.Stop();
                buttonregPausa.Visible = true;
                timer1.Start();
                             
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