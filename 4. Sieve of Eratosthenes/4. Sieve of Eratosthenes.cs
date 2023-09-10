int n = Convert.ToInt32(Console.ReadLine());
int[] array = Enumerable.Range(0, n).ToArray();

for (int i = 2; i < array.Length; i++)
{
    if (array[i] != 0)
    {
        i = array[i];
    }
    for (int j = 2*i; j < array.Length; j+=i)
    {
        array[j] = 0;
    }
}

foreach (int i in array)
{
    if (i >1)
    { Console.WriteLine(i); }
}