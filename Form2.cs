using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Audio
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string make = string.Empty;
            string mod = string.Empty;
            string conf = string.Empty;
            string content = string.Empty;
            make = lblCarAudioProject.carMake;
            mod = lblCarAudioProject.carModel;
            conf = lblCarAudioProject.setup;

            if (make == "Mercedes-Benz" & mod == "W210" & conf == "Ежедневна конфигурация")
            {
                shemaGovoriteli.Image = Properties.Resources.мерц_връзване;
                shemaSvurzvane.Image = Properties.Resources.мерц_говорители_стандарт;
                content = @"C:\Users\teodo\source\repos\Car Audio project\Car Audio\description\standard.txt";
                StreamReader stream = new StreamReader(content);
                string data = stream.ReadToEnd();
                label1.Text = data.ToString();
                stream.Close();
            }
            else if (make == "Mercedes-Benz" & mod == "W210" & conf == "Напреднала конфигурация")
            {
                shemaGovoriteli.Image = Properties.Resources.мерц_говорители_адвансед;
                shemaSvurzvane.Image = Properties.Resources.мерц_свързване_адвансед;
                content = @"C:\Users\teodo\source\repos\Car Audio project\Car Audio\description\advanced.txt";
                StreamReader stream = new StreamReader(content);
                string data = stream.ReadToEnd();
                label1.Text = data.ToString();
                stream.Close();
            }
            else if (make == "Mercedes-Benz" & mod == "W210" & conf == "Професионална конфигурация")
            {
                shemaGovoriteli.Image = Properties.Resources.mercedes_pro_speakers;
                shemaSvurzvane.Image = Properties.Resources.мерц_свързване_реално;
                content = @"C:\Users\teodo\source\repos\Car Audio project\Car Audio\description\pro.txt";
                StreamReader stream = new StreamReader(content);
                string data = stream.ReadToEnd();
                label1.Text = data.ToString();
                stream.Close();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            // if markata e = na mercedes i modela e = na w210
            //if konfiguraciqta e = na day/adv/pro da se izzprinti suotvetnata shema na govoritelite zza merc w210
        }

        private void shemaSvurzvane_Click(object sender, EventArgs e)
        {
            // if markata e = na mercedes i modela e = na w210
            //if konfiguraciqta e = na day/adv/pro da se izzprinti suotvetnata shema na svurzvane zza merc w210
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //if markata e = na mercedes i modela e = na w210
            //if konfiguraciqta e = na day/adv/pro da se izzprinti suotvetniq tekst za konmfiguraciqta
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
