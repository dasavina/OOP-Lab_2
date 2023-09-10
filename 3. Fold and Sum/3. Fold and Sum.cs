string[] initial = Console.ReadLine().Split(" ");
if (initial.Length % 4 != 0)
{
    Console.WriteLine("кількість елементів не підходить для виконання задачі");
    Environment.Exit(0);
}

int k = initial.Length / 4;
int[] first_row = new int[k];
int[] second_row = new int[k];
for (int i = 0, j = initial.Length - 1; i < k; i++, j--)
{
    first_row[i] = Convert.ToInt32(initial[i]);
    first_row[first_row.Length - 1 - i] = Convert.ToInt32(initial[j]);
}
for (int i = k; i < initial.Length-k; i++)
{
    second_row[i-k]= Convert.ToInt32(initial[i]);
}

for (int i = 0; i < first_row.Length; i++)
{
    Console.WriteLine(first_row[i] + second_row[i]);
}