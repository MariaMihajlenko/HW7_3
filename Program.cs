//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using System;
class Program
{
    static void Main()
    {
        double[,] array = new double[4,3];
        double[,] nums = {
                {1,4,7,2},
                {5,9,2,3},
                {8,4,2,4}
        };
        double summ = 0;
           for (int i = 0; i < 5; i++)
           {
                for (int j = 0; j < 3; j++)
                {
                    summ = (summ + nums[i,j]);
                }
                Console.WriteLine(summ/3);
                summ = 0;
           }
           
           
    }
}

    

        
        

    

