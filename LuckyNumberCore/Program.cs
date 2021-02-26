using System;
using System.Linq;

namespace LuckyNumberCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! This is a lucky number game \n" +
        "You should enter a number from 4 to 8 digits \n" +
        "and we'll see if you are lucky. Good Luck!");

            while (true)
            {
                int[] numbersArray;

                while (true)
                {
                    Console.Write("Enter a ticket number: ");

                    string inpNumber = Console.ReadLine().ToString();

                    numbersArray = inpNumber.Select(number => int.Parse(new string(number, 1))).ToArray();

                    if (numbersArray.Length <= 8 && numbersArray.Length >= 4)
                        break;
                }

                if (numbersArray.Length % 2 != 0)
                {
                    int[] temp = new int[numbersArray.Length + 1];

                    for (int i = 1; i < temp.Length; i++)
                    {
                        temp[i] = numbersArray[i - 1];
                    }

                    numbersArray = temp.ToArray();
                }

                bool luckyNumber = false;

                int firstSum = 0;
                int secondSum = 0;

                for (int i = 0; i < numbersArray.Length; i++)
                {
                    if (i < numbersArray.Length / 2)
                        firstSum += numbersArray[i];
                    else
                        secondSum += numbersArray[i];
                }

                if (firstSum == secondSum)
                    luckyNumber = true;

                if (luckyNumber)
                    Console.WriteLine("Congratulations. You have got a lucky number ticket!");
                else
                    Console.WriteLine("Unfortunately you have not got a lucky number ticket, try next time!");

                string answer = "";

                while (true)
                {
                    Console.Write("If you want try more press [y], otherwise [n]: ");

                    answer = Console.ReadLine();

                    if (answer == "y" || answer == "n")
                        break;
                }

                if (answer == "n")
                    break;
            }
        }
    }
}
