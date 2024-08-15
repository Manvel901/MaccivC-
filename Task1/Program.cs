int n = 15;
int[] array = new int [n];
int sum = 0;
int j = 0;
while (j<n)
{
    if (j % 2==0)
    {
        sum += j;
    }
     j++;
}
Console.Write(sum);
Console.Write(" ");