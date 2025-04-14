using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace tamagochi.Entity
{
    public class Timer
    {
        public System.Timers.Timer timer;
        public StatsAndFunction tamagochi;
        public Refresh refresh;
        public Timer(StatsAndFunction tamagochi, Refresh refresh)
        {
            this.tamagochi = tamagochi;
            this.refresh = refresh;
        }

        public void use()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            tamagochi.Hungry = tamagochi.Hungry + 5;
            tamagochi.Happy = tamagochi.Happy - 5;
            tamagochi.Energy = tamagochi.Energy - 5;
            refresh();
        }

    }
}
