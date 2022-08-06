/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.Write("Enter number: ");
string str = Console.ReadLine();
int[] arrNumb = str.Select(x => int.Parse(x.ToString())).ToArray();
int result = 0;
for (int i = 0; i < arrNumb.Length; i++)
{
    result += arrNumb[i];
}
Console.WriteLine($"{str} -> {result}");