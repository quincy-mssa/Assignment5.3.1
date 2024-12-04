using System;

namespace Assignment5._3._1
{
    internal class Program
    {
        //1. You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.
        //Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n,
        //return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.
        //Example 1:
        //Input: flowerbed = [1, 0, 0, 0, 1], n = 1
        //Output: true
        //Example 2:
        //Input: flowerbed = [1, 0, 0, 0, 1], n = 2
        //Output: false
        static void Main(string[] args)
        {
            int[] flowerPots = { 1, 0, 0, 0, 1 };
            int n = 2;
            bool result = PlantFlower(flowerPots, n);
            Console.WriteLine(result);
        }

        static bool PlantFlower(int[] flowerPots, int n)
        {
            int plantablePots = 0;
            int rowOfpots = flowerPots.Length;

            for (int i = 0; i < rowOfpots; i++)
            {
                if (flowerPots[i] == 0 &&
                    (i == 0 || flowerPots[i - 1] == 0) && 
                    (i == rowOfpots - 1 || flowerPots[i + 1] == 0)) 
                {
                    flowerPots[i] = 1;
                    plantablePots++;

                    if (plantablePots >= n)
                    {
                        return true;
                    }
                }
            }
            return plantablePots >= n;
        }
    }
}
