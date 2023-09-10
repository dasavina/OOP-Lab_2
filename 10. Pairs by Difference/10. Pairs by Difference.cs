string[] array = Console.ReadLine().Split(" ");
int difference = Convert.ToInt32(Console.ReadLine());
int counter = 0;
bool[] taken = new bool[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if (!taken[i])
    {
        for (int j = i++; j < array.Length; j++)
        {
            if (!taken[j] && Convert.ToInt32(array[i])- Convert.ToInt32(array[j])==difference)
            {
                taken[j] = true;
                taken[i] = true;
                counter++;
            }
        }
    }
}

Console.WriteLine(counter);