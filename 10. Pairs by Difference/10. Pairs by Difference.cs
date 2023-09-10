string[] array = Console.ReadLine().Split(" ");
int sum = Convert.ToInt32(Console.ReadLine());
int counter = 0;
bool[] taken = new bool[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if (!taken[i])
    {
        for (int j = i++; j < array.Length; j++)
        {
            if (!taken[j] && j.Equals(array[i]))
            {
                taken[j] = true;
                counter++;
            }
        }
    }
}

Console.WriteLine();