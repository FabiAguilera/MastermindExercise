using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    internal class RandomNum
    {
        public GuessDigit_01 _gameOne = new GuessDigit_01();
        public RandomNum()
        {
            _gameOne.digitOne = 4;
            _gameOne.digitTwo = 1;
            _gameOne.digitThree = 6;
            _gameOne.digitFour = 5;
            _gameOne.gameOneAnswer = int.Parse($"{_gameOne.digitOne}+{_gameOne.digitTwo}+{_gameOne.digitThree}+{_gameOne.digitFour}");
            Console.WriteLine("Let's play Mastermind knockoff!");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 6;)
            {
                Console.WriteLine($"Enter a number between 1 and 6: {num}");
                Console.ReadKey();
                if (num <= 10)
                {
                    if (num == _gameOne.digitOne)
                    {
                        // outline:
                        // if correct, then "+"
                        // if correct but wrong space, then "-"
                        // if entirely incorrect, then blank space " "
                    }
                }
                else
                {
                    Console.WriteLine("You've played all of your attempts! Good bye! :)");
                    break;
                }
            }
        }

    }
}
