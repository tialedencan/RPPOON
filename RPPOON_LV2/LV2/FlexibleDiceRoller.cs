using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    internal class FlexibleDiceRoller:IDiceRoller, IDiceChanger
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        public void RemoveDiceWithSpecificNumberOfSides(int numberOfSides)
        {   
            for(int i = dice.Count-1; i >= 0; i--)
            {
                if(dice[i].GetNumberOfSides() == numberOfSides)
                {
                    this.dice.RemoveAt(i);
                    this.resultForEachRoll.RemoveAt(i);
                }
            }
        }
        public string GetStringRepresentation()
        {
            StringBuilder sb = new StringBuilder();

            foreach (int result in this.resultForEachRoll)
            {
                sb.Append(result +" ");
            }
            return sb.ToString();
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
    }
}
