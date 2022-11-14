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
        // bring in GuessDigit_01 properties
        public GuessDigit_01 _gameOne = new GuessDigit_01();

        // setting values to new instance of GuessDigit
        public RandomNum()
        {
            _gameOne.digitOne = 4;
            _gameOne.digitTwo = 1;
            _gameOne.digitThree = 6;
            _gameOne.digitFour = 5;
            List<int> result = new List<int>();

            // this variable will be used to compare the user input to the answer.
            //_gameOne.gameOneAnswer[] = ToString().Select(t => int.Parse(t.ToString())).ToArray();
            //int.Parse($"{_gameOne.digitOne}+{_gameOne.digitTwo}+{_gameOne.digitThree}+{_gameOne.digitFour}");

            Console.WriteLine("Let's play Mastermind console app!");

            Console.WriteLine($"Enter four digits between 1 and 6: ");

            int num = int.Parse(Console.ReadLine());
            while (Console.ReadLine().Length <= 4)
            {
                //num = int.Parse(Console.ReadLine());
                if(num == _gameOne.gameOneAnswer)
                {
                    Console.WriteLine($"You've guessed the correct four digit combination! {_gameOne.gameOneAnswer}");
                }
                else
                {
                    if (Convert.ToBoolean(num.CompareTo(_gameOne.digitOne)))
                    {

                    }
                }

            }

            /*
            
                // second IF for guessing correct digits
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
            }*/

        }

    }
}
