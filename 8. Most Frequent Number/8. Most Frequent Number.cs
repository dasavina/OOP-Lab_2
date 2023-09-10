string[] array = Console.ReadLine().Split(" ");
int[] counters = new int[array.Length];
bool[] same = new bool[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if (!same[i])
    {
        for (int j = i++; j < counters.Length; j++)
        {
            if (!same[j] && j.Equals(array[i]))
            {
                same[j] = true;
                counters[i]++;
            }
        }
    }
}

Console.WriteLine(array[counters.Max()]);
