string word1 = Console.ReadLine();
char[] array1 = new char[Convert.ToInt32(word1.Length/2)+1];
for (int i = 0; i < word1.Length; i+=2)
{
    array1[i / 2] = word1[i];
}

string word2 = Console.ReadLine();
char[] array2 = new char[Convert.ToInt32(word2.Length/2)+1];
for (int i = 0; i < word2.Length; i+=2)
{
    array2[i / 2] = word2[i];
}

int length = (array1.Length<array2.Length) ? array1.Length : array2.Length;
bool first = (array1.Length < array2.Length) ? true : false;

for (int i = 0;i < length; i++)
{
    if (array1[i].Equals(array2[i]))
    { continue; }
    else if (array1[i] < (array2[i]))
    { first = true; break; }
    else { first = false; break; }
}

if (first)
{
    Console.WriteLine(array1.ToString);
    Console.WriteLine(array2.ToString);
}
else
{
    Console.WriteLine(array2.ToString);
    Console.WriteLine(array1.ToString);
}
