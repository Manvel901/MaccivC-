int[] array = { 1, 555, 189, 889, 355 };
//int n = 5;
double sum = 0;
for (int j = 0; j < array.Length; j++)
{
    sum += array[j];
}
Console.Write($"{sum * 1 / 5} ");