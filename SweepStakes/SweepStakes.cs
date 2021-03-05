using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name { get => name; }
        Random number;
        Random WonNumber;

        public SweepStakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;

        }
        public void RegisterContestant(Contestant contestant)
        {
            int registration;
            number = new Random();
            registration = number.Next(0, 100);
            contestants.Add(registration, contestant);
        }
        public Contestant PickWinner()
        {
            int winningNumber;
            WonNumber = new Random();
            winningNumber = WonNumber.Next(0, 100);
            foreach (KeyValuePair<int,Contestant> pair in contestants)
            {
                if (number == WonNumber)
                {
                    
                }
                return pair.Value;
                
            }
            return
        }
        public void PrintContestantinfo(Contestant winningContestant)
        {
            Console.WriteLine($"Here is todays winner {winningContestant.firstName +" "+ winningContestant.lastName} ");
        }
    }
}
