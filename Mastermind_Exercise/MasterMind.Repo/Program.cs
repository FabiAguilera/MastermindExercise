using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind_Exercise
{
    class Program
    {


       
    }

    public class RandomNum
    {
        // bring in GuessDigit_01 properties
        //public GuessDigit_01 _gameOne = new GuessDigit_01();

        // setting values to new instance of GuessDigit
        public RandomNum()
        {
            //ignore the following commented out code... figured out how to correctly impliment the Random class
            /* _gameOne.digitOne = 4;
             _gameOne.digitTwo = 1;
             _gameOne.digitThree = 6;
             _gameOne.digitFour = 5;
             //List<int> result = new List<int>();

             // this variable will be used to compare the user input to the answer.
             _gameOne.gameOneAnswer = int.Parse($"{_gameOne.digitOne}+{_gameOne.digitTwo}+{_gameOne.digitThree}+{_gameOne.digitFour}");*/

            Random random = new Random();
            int generatedNum = random.Next(1, 4);
            Console.WriteLine("Let's play Mastermind console app! In this game, you will attempt to guess what the four digit combination is. A plus (+) sign indicates the number you guessed is the correct digit in the correct space, a minus (-) for the correct digit in the wrong place, and a blank space for incorrect digit and incorrect space. Let's begin!");
            Console.ReadLine();

            Console.WriteLine($"Enter four digits between 1 and 6: ");
            int result = int.Parse(Console.ReadLine());
            int[] num = Array.ConvertAll(result.ToString("0").ToCharArray(), ch => ch - '0');

            // for setting user's guess limit to 10 attempts:

            // checking answer of user per index
            while (Console.ReadLine().Length <= 4)
            {
                if (Console.ReadLine().Length == 4)
                {
                    if (Convert.ToBoolean(num[0] == generatedNum))
                    {
                        Console.WriteLine("+");
                        Console.ReadLine();
                    }
                    else if (Convert.ToBoolean(num[1] == generatedNum))
                    {
                        Console.WriteLine("+");
                        Console.ReadLine();
                    }
                    else if (Convert.ToBoolean(num[2] == generatedNum))
                    {
                        Console.WriteLine("+");
                        Console.ReadLine();
                    }
                    else if (Convert.ToBoolean(num[3] == generatedNum))
                    {
                        Console.WriteLine("+");
                        Console.ReadLine();
                    }
                    if (Convert.ToBoolean(num[0] == generatedNum))
                    {
                        Console.WriteLine("-");
                        Console.ReadLine();
                    }
                    else if (Convert.ToBoolean(num[1] == generatedNum))
                    {
                        Console.WriteLine("-");
                        Console.ReadLine();
                    }
                    else if (Convert.ToBoolean(num[2] == generatedNum))
                    {
                        Console.WriteLine("-");
                        Console.ReadLine();
                    }
                    else if (Convert.ToBoolean(num[3] == generatedNum))
                    {
                        Console.WriteLine("-");
                        Console.ReadLine();
                    }
                    else if (Convert.ToBoolean(num[0] != generatedNum))
                    {
                        Console.WriteLine(" ");
                        Console.ReadLine();
                    }
                    else if (Convert.ToBoolean(num[1] != generatedNum))
                    {
                        Console.WriteLine(" ");
                        Console.ReadLine();
                    }
                    else if (Convert.ToBoolean(num[2] != generatedNum))
                    {
                        Console.WriteLine(" ");
                        Console.ReadLine();
                    }
                    else if (Convert.ToBoolean(num[3] != generatedNum))
                    {
                        Console.WriteLine(" ");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Uh oh! Please enter no more than four digits. Try again!");
                    result = int.Parse(Console.ReadLine());
                    Console.ReadLine();
                }
            }



        }
    }
}
