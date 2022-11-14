﻿using System;
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
            //List<int> result = new List<int>();

            // this variable will be used to compare the user input to the answer.
            _gameOne.gameOneAnswer = int.Parse($"{_gameOne.digitOne}+{_gameOne.digitTwo}+{_gameOne.digitThree}+{_gameOne.digitFour}");

            Console.WriteLine("Let's play Mastermind console app! In this game, you will attempt to guess what the four digit combination is. A plus (+) sign indicates the number you guessed is the correct digit in the correct space, a minus (-) for the correct digit in the wrong place, and a blank space for incorrect digit and incorrect space. Let's begin!");

            Console.WriteLine($"Enter four digits between 1 and 6: ");
            int result = int.Parse(Console.ReadLine());
            int[] num = Array.ConvertAll(result.ToString("0").ToCharArray(), ch => ch - '0');
            while (Console.ReadLine().Length <= 4)
            {
                if (Convert.ToBoolean(num[0] == _gameOne.digitOne))
                {
                    Console.WriteLine("+");
                }
                else if (Convert.ToBoolean(num[1] == _gameOne.digitTwo))
                {
                    Console.WriteLine("+");
                }
                else if (Convert.ToBoolean(num[2] == _gameOne.digitThree))
                {
                    Console.WriteLine("+");
                }
                else if (Convert.ToBoolean(num[3] == _gameOne.digitFour))
                {
                    Console.WriteLine("+");
                }
                if (Convert.ToBoolean(num[0] == _gameOne.digitOne))
                {
                    Console.WriteLine("-");
                }
                else if (Convert.ToBoolean(num[1] == _gameOne.digitTwo))
                {
                    Console.WriteLine("-");
                }
                else if (Convert.ToBoolean(num[2] == _gameOne.digitThree))
                {
                    Console.WriteLine("-");
                }
                else if (Convert.ToBoolean(num[3] == _gameOne.digitFour))
                {
                    Console.WriteLine("-");
                }
                else if (Convert.ToBoolean(num[0] != _gameOne.digitOne))
                {
                    Console.WriteLine(" ");
                }
                else if (Convert.ToBoolean(num[1] != _gameOne.digitTwo))
                {
                    Console.WriteLine(" ");
                }
                else if (Convert.ToBoolean(num[2] != _gameOne.digitThree))
                {
                    Console.WriteLine(" ");
                }
                else if (Convert.ToBoolean(num[3] != _gameOne.digitFour))
                {
                    Console.WriteLine(" ");
                }

            }

        }

    }
}
