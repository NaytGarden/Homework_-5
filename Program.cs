//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int N = new Random().Next(1,10);
int[] Arrey = new int[N];
int count = 0;

for (int i = 0; i < Arrey.Length; i++)
{
    Arrey[i] = new Random().Next(100,1000);
    if(Arrey[i] % 2 == 0){count++; Console.WriteLine(count);}
}
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int N = new Random().Next(1,10);
int[] Arrey = new int[N];
int sum = 0;

for (int i = 0; i < Arrey.Length; i++)
{
    Arrey[i] = new Random().Next();
    if(i % 2 != 0){sum += Arrey[i];Console.WriteLine(sum);}
    
}
*/


//Задача 38: Задайте массив натуральных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите число от 1 до 10");
int N = Convert.ToInt32(Console.ReadLine());
int[] Arrey = new int[N];
int temp;

for (int i = 0; i < Arrey.Length; i++)
{
    
    Arrey[i] = new Random().Next(1,101);

    for (int j = 0; j < Arrey.Length - 1 - i;j++)
    {
        if(Arrey[j] > Arrey [j + 1])
        {
            temp = Arrey[j];
            Arrey[j] = Arrey[j + 1];
            Arrey[j + 1] = temp;
        } 
    }
}

for (int i = 0; i < Arrey.Length; i++)
{
    Console.WriteLine(Arrey[i]);
    
}
Console.WriteLine(Arrey[Arrey.Length] - Arrey[0]);