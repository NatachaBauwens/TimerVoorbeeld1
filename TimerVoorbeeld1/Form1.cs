using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimerVoorbeeld1
{
    public partial class Form1 : Form
    {

        DateTime tijd;
        Random rn;

        public Form1()
        {
            InitializeComponent();
            init();

        }

        private void init()
        {
            tijd = new DateTime(1, 1, 1, 0, 0, 0);
            rn = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            init();
        }

        private void tijdweergeven(object sender, EventArgs e)
        { //TICK_EVENT           
            tijd = tijd.AddMilliseconds(10);
            lbltijdTeller.Text = tijd.ToString("HH:mm:ss.fff");
            lbltijdNU.Text = DateTime.Now.ToString("dddd, dd-MMMM-yyyy HH:mm:ss.fff");
            if (tijd.Second % 5 == 0 && tijd.Millisecond==0) wijzigkleur();
        }

        private void wijzigkleur()
        {
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);
            Color kleur = Color.FromArgb(255, r, g, b);
            this.BackColor = kleur;
        }
    }
}
