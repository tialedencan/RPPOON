﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    internal class FlexibleDiceRoller:IRollable, IStorable
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
