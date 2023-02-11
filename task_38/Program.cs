/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] arrayFill(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 2);
    }
    return array;
}
void printArray(double[] array)
{
    System.Console.WriteLine("[ " + String.Join("; ", array) + " ]");
}
double MAX(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double MIN(double[] array)
{
    double min = 10000;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min )
        {
            min = array[i];
        }
    }
    return min;
}

double[] array = arrayFill(5, 1, 10);
printArray(array);
double Rezult =  Math.Round(MAX(array) - MIN(array), 2);
System.Console.WriteLine($"Разница между максимальным и минимальным значением массива = {Rezult}");

