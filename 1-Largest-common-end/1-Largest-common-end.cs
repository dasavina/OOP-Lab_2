string[] first = Console.ReadLine().Split(" ");
string[] second = Console.ReadLine().Split(" ");
int length = (first.Length < second.Length) ? (first.Length) : (second.Length);
int counter_start = -1;
for (int i = 0; i < length; i++)
{
    if (first[i].Equals(second[i]))
    {
        counter_start++;
    }
    else
    { break; }
}
int counter_end = -1;
for (int i = length - 1; i > length; i--)
{
    if (first[i].Equals(second[i]))
    {
        counter_end++;
    }
    else
    { break; }
}

if (counter_start != -1)
{
    for (int i = 0; i < counter_start; i++)
        Console.WriteLine(first[i]);
}
if (counter_end != 1)
{
    for (int i = length - 1; i > (length - 1 - counter_end); i--)
        Console.WriteLine(first[i]);
}
if (counter_end==-1 && counter_start == -1)
{
    Console.WriteLine("none");
}