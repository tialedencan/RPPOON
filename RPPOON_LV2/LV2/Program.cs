using System;
using System.Text;
using System.Collections.Generic;

namespace LV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DiceRoller diceRoller = new DiceRoller();
            ILogger logger = new ConsoleLogger();
            
            for (int i = 0; i < 20; i++)
            {
                diceRoller.InsertDie(new Die(6));
            }

            diceRoller.RollAllDice();

            StringBuilder stringBuilder = new StringBuilder();
            IList<int> rollingResults = diceRoller.GetRollingResults();

            foreach (int rollingResult in rollingResults)
            {
                stringBuilder.Append(rollingResult.ToString() + ", ");
            }

            Console.WriteLine(stringBuilder.ToString());
           
            FlexibleDiceRoller flexibleDiceRoller = new FlexibleDiceRoller();

            for (int i = 0; i < 4; i++)
            {
                flexibleDiceRoller.InsertDie(new Die(6));
                flexibleDiceRoller.InsertDie(new Die(12));
            }
            flexibleDiceRoller.RollAllDice();
            Console.WriteLine(flexibleDiceRoller.GetStringRepresentation());
            flexibleDiceRoller.RemoveDiceWithSpecificNumberOfSides(12);
            Console.WriteLine(flexibleDiceRoller.GetStringRepresentation());
        }
    }
}
