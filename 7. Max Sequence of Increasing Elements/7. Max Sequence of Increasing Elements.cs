string[] initial = (Console.ReadLine().Split(" "));
int[] numbers = new int[initial.Length];
for (int i = 0; i < initial.Length; i++)
{
    numbers[i] = Convert.ToInt32(initial[i]);
}

int start = 0, len = 1, best_start = 0, best_len = 0;
for (int pos = 1; pos < numbers.Length; pos++)
{
    if (numbers[pos] - numbers[pos-1]==1)
    {
        len++;
    }
    else
    {
        start = pos;
        len = 1;
    }

    if (len > best_len)
    {
        best_len = len;
        best_start = start;
    }
}

for (int pos = best_start; pos < best_start + best_len; pos++)
{
    Console.WriteLine(numbers[pos]);
}