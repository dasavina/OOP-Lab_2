char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
string word = Console.ReadLine();
if (word == null)
{ Console.WriteLine("nothing was entered"); Environment.Exit(0); }
int[] nums = new int[word.Length];

for  (int i = 0; i < word.Length; i++)
{
    for (int j = 0; j < alphabet.Length; j++)
    {
        if (word.ElementAt(i).Equals(alphabet[j]))
        { nums[i] = j; break; }
    }
}

for  (int i = 0;i < nums.Length; i++)
{
    Console.WriteLine(word.ElementAt(i) + "->" + nums[i]);
}