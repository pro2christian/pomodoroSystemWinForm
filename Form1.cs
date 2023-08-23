using System.Diagnostics;
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
        }

        private void buttonResert_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            buttonResert.Visible = false;
            buttonIniciar.Visible = true;

        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            buttonIniciar.Visible = false;
            buttonResert.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelCronometro.Text = string.Format("{0:mm\\:ss\\,ff}", stopwatch.Elapsed);

        }
    }
}