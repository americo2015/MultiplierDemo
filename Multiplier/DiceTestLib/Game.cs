using DiceLib;
using System;

namespace DiceTestLib
{
    internal class Game
    {
        private Random random;
        private Dice firstDice;
        private Dice secondDice;
        private int _throwsMade = 0;


        public Game(Random random)
        {
            this.random = random;
            firstDice = new Dice(random);
            secondDice = new Dice(random);
        }

        public bool IsWinner
        {
            get
            {
                return NumberOfPoints == 7;
            }
        }
        public int NumberOfPoints
        {
            get
            {
                return firstDice.NumberOfPoints + secondDice.NumberOfPoints;
            }
        }

        public int ThrowsMade
        {
            get
            {
                return _throwsMade;
            }
        }

        public void ThrowDice()
        {
            firstDice.Throw();
            secondDice.Throw();
            _throwsMade++;
        }

        public override string ToString()
        {
            return $"Dice one: {firstDice.NumberOfPoints}, Dice two: {secondDice.NumberOfPoints}";
        }
    }
}