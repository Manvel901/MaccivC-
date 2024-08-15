//int n = 10;
int[] arr = {3,4,1055,6,88,99,39,34,11,9};
//int j = 0;
int max = arr[0];
foreach (int e in arr)
{
    if (e > max)
    {
         max = e;
    }
   
}
Console.Write(max);    