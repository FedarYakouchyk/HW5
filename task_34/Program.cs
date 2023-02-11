/* Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] arrayFill(int size, int leftRange, int rightRange)
{
int[] array = new int[size];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(leftRange, rightRange + 1);
}
return array;
}

void printArray(int[] array)
{
System.Console.WriteLine("[ " + String.Join(", ", array) + " ]");
}

int count(int [] array) 
{
    int num =0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i]%2==0)
       {
        num = num+1;
       }
       
    }
   return num;
}

int[] array = arrayFill(20, 100, 999);
printArray(array);
int c = count (array);
System.Console.WriteLine($"Количество чётных элементов массива: {c}");


