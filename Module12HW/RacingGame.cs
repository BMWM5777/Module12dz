using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12HW
{
    class RacingGame
    {
        public event Car.RaceEventHandler StartRaceEvent; 

        public delegate void FinishRaceDelegate(string winner);
        public event FinishRaceDelegate FinishRaceEvent;

        public void StartRace()
        {
            Console.WriteLine("Гонка началась!");
            StartRaceEvent?.Invoke("Гонка началась!");
        }

        public void FinishRace(string winner)
        {
            Console.WriteLine($"Гонка окончена! Победитель: {winner}");
            FinishRaceEvent?.Invoke(winner);
        }
    }
}
