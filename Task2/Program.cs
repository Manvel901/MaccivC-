int n = 4;
int[] arr = {6, 5, 56, 33};
int j = 0;
int sum = 0;
while (j<n)
{
    if (arr[j]%2==0)
    {
        sum += arr[j];
    }
    j++;
}
Console.Write($"{sum} ");