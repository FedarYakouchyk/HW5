/* Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
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

int sumNCH(int [] array)
{
    int rez = 0;
    for (int i = 0; i < array.Length; i= i+2)
    {
    rez = rez + array[i];
    }
    return rez;
}

int [] array = arrayFill(20, 1, 10);
printArray(array);
int rez = sumNCH(array);
System.Console.WriteLine($"Сумма элементов, находящихся на нечётных позициях: {rez}");