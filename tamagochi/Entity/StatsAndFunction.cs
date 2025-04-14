using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamagochi.Entity
{
    public class StatsAndFunction
    {
        public int Happy = 100;
        public int Energy = 100;
        public int Hungry = 0;
        public int MaxHappy = 100;
        public int MaxEnergy = 100;
        public int MaxHungry = 100;

        public StatsAndFunction()
        {
            this.Happy = 100;
            this.Energy = 100;
            this.Hungry = 0;
            this.MaxHappy = 100;   
            this.MaxEnergy = 100;
            this.MaxHungry = 100;
        }
        public void Sleep()
        {
            if (Happy >= 10)
            {
                Happy = Happy - 10;
            }
            if(Energy <= (MaxEnergy-10))
            {
                Energy = Energy + 10;
            }
            if (Hungry <= (MaxHungry-10))
            {
                Hungry = Hungry + 10;
            }

        }
        public void Feed()
        {
            if (Happy <= (MaxHappy - 5))
            {
                Happy = Happy + 5;
            }
            if (Energy <= (MaxEnergy - 5))
            {
                Energy = Energy + 5;
            }
            if (Hungry >= 10)
            {
                Hungry = Hungry - 10;
            }

        }
        public void Play()
        {
            if (Happy <= (MaxHappy - 10))
            {
                Happy = Happy + 10;
            }
            if (Energy >= 10)
            {
                Energy = Energy - 10;
            }
            if (Hungry <= (MaxHungry - 10))
            {
                Hungry = Hungry + 10;
            }

        }


    }
}
