using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Alarm_Clock
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_curret_time.Text = DateTime.Now.ToLongTimeString();
        }
        SoundPlayer sp;
       

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (tb_curret_time.Text == tb_alarm_time.Text)
            {
                if (cb_select_sound.SelectedIndex==0)
                {
                    string sountPath = Application.StartupPath + "\\musics\\alarm1.wav";
                    sp = new SoundPlayer(sountPath);
                    sp.Play();
                }
                else if (cb_select_sound.SelectedIndex==1)
                {
                    string sountPath = Application.StartupPath + "\\musics\\alarm2.wav";
                    sp = new SoundPlayer(sountPath);
                    sp.Play();
                }
               
                timer_alarm_time.Stop();
            }
        }

        private void set_Click(object sender, EventArgs e)
        {
            timer_curret_time.Start();
            tb_alarm_time.Text = DateTime.Now.ToLongTimeString();

        }

        private void stop_Click(object sender, EventArgs e)
        {

            timer_alarm_time.Stop();
            sp.Stop();
        }

        private void snooze_Click(object sender, EventArgs e)
        {
            string time = tb_snooze.Text;
            int timeint = Int32.Parse(time);
            string yenivaxt = DateTime.Now.AddSeconds(timeint).ToLongTimeString();
            stop_Click(sender, e);
            tb_alarm_time.Text = yenivaxt;
            set_Click(sender, e);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer_curret_time.Start();
            tb_alarm_time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
