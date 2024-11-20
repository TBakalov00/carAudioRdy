namespace Car_Audio
{
    public partial class lblCarAudioProject : Form
    {
        public static string carMake = string.Empty;            //инициализация на променливи, които ще
        public static string carModel = string.Empty;           //приемат избраните марка,модел и 
        public static string setup = string.Empty;              //конфигурация
        public static int setupCount = 0;           //инициализация на променлива за проверка на попълнени полета
        public lblCarAudioProject()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //зареждане на първа част на приложението
        }

        private void btnNext_Click(object sender, EventArgs e, lblCarAudioProject lblCarAudioProject)
        {
            //бутон за продъжаване към следваща стъпка
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //функция за добавяне на меню, за избиране марка на автомобил
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dayCheck_CheckedChanged(object sender, EventArgs e)
        {
            //добавяне на кутия за избиране на конфигурация
            if (dayCheck.Checked == true)       // проверка за избрана конфигурация
            {
                advCheck.Enabled = false;       //изключване на останалите опции 
                proCheck.Enabled = false;       //изключване на останалите опции
                setupCount++;                   
                if (modelBox.SelectedItem != null & markaBox.SelectedItem != null & setupCount == 1)    //проверка за отключване на бутон за преминаване
                {                                                                                       //към следваща част на приложението
                    btnNext.Enabled = true;
                }
            }
        }

        private void advCheck_CheckedChanged(object sender, EventArgs e)
        {
            //добавяне на кутия за избиране на конфигурация
            if (advCheck.Checked == true)       // проверка за избрана конфигурация
            {
                dayCheck.Enabled = false;       //изключване на останалите опции
                proCheck.Enabled = false;       //изключване на останалите опции
                setupCount++;
                if (modelBox.SelectedItem != null & markaBox.SelectedItem != null & setupCount == 1)    //проверка за отключване на бутон за преминаване
                {                                                                                       //към следваща част на приложението
                    btnNext.Enabled = true;
                }
            }
        }

        private void proCheck_CheckedChanged(object sender, EventArgs e)
        {
            //добавяне на кутия за избиране на конфигурация
            if (proCheck.Checked == true)       // проверка за избрана конфигурация
            {
                dayCheck.Enabled = false;       //изключване на останалите опции
                advCheck.Enabled = false;       //изключване на останалите опции
                setupCount++;
                if (modelBox.SelectedItem != null & markaBox.SelectedItem != null & setupCount == 1)    //проверка за отключване на бутон за преминаване
                {                                                                                       //към следваща част на приложението
                    btnNext.Enabled = true;
                }
            }
        }

        private void modelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //функция за добавяне на меню, за избиране модел на автомобил
        }

        private void marka_Click(object sender, EventArgs e)
        {
            //добавяне на текст към приложението
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //добавяне на текст към приложението
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //добавяне на текст към приложението
        }

        private void model_Click(object sender, EventArgs e)
        {
            //добавяне на текст към приложението
        }
    }
}
