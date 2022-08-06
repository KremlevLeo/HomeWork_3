/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] arrNumb = new int[8];
Random rnd = new Random();
for (int i = 0; i < 8; i++)
{
    arrNumb[i] = rnd.Next(0, 101);
    Console.Write($"{arrNumb[i]} ");
}

