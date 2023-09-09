string array = Console.ReadLine();
string[] initial = (array.Split(" "));
int k = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[initial.Length];

for (int i = 0; i < initial.Length; i++)
{
    numbers[i] = Convert.ToInt32(initial[i]);
}

int[] result = new int[numbers.Length];

for (int i = 0;i < numbers.Length; i++)
{
    int rotation_index = i;
    for (int counter=0; counter<k; counter++)
    {
        rotation_index--;
        if (rotation_index < 0)
        {
            rotation_index = numbers.Length + rotation_index;
        }
        result[i] += numbers[rotation_index];
    }
}

foreach  (int i in result)
{
    Console.WriteLine(i);
}