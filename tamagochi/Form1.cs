using tamagochi.Entity;

namespace tamagochi
{
    public delegate void Refresh();

    public partial class Form1 : Form
    {
        public StatsAndFunction tamagochi = null;
        public tamagochi.Entity.Timer timer = null;

        public Form1()
        {
            InitializeComponent();
            tamagochi = new StatsAndFunction();
            timer = new tamagochi.Entity.Timer(tamagochi, UpdateStat);

            timer.use();
        }
        private void UpdateStat()
        {

            HappyValue.Text = Convert.ToString(tamagochi.Happy);
            EnergyValue.Text = Convert.ToString(tamagochi.Energy);
            HungryValue.Text = Convert.ToString(tamagochi.Hungry);

            GameOver();
        }
        private void CheckStan()
        {
            if (tamagochi.Happy == 100)
            {
                MessageBox.Show("Òâ³é óëþáëåíåöü ùàñëèâèé!", "Â³òàþ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (tamagochi.Energy <= 20)
            {
                MessageBox.Show("Â³í íàäòî âòîìëåíèé!", "Öå ïîãàíî!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GameOver()
        {
            if (tamagochi.Happy <= 0 || tamagochi.Hungry >= 100 || tamagochi.Energy <= 0)
            {
                timer.timer.Stop();
                DialogResult result = MessageBox.Show("Нажаль для вас все скінчено!", "Ви програли!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void Feed_Click(object sender, EventArgs e)
        {
            tamagochi.Feed();
            UpdateStat();
            CheckStan();
            GameOver();


        }

        private void Sleep_Click(object sender, EventArgs e)
        {
            tamagochi.Sleep();
            UpdateStat();
            CheckStan();
            GameOver();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            tamagochi.Play();
            UpdateStat();
            CheckStan();
            GameOver();
        }
    }
}
