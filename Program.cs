string[] input = { "hello", "2", "world", ":-)"};
int n = 3;

PrintArray(input);

string[] output = ElementsLengthLessOrEqualN(input, n);
PrintArray(output);

string[] ElementsLengthLessOrEqualN(string[] array, int n)
{
    int length = array.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        string str = array[i];
        if (str.Length <= n)
        {
            (array[i], array[count]) = (array[count], array[i]);
            count++;
        }
    }
    string[] result = new string[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = array[i];
    }
    return result;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1)
            {
                Console.Write($"{array[i]}, ");
            }
            else
            {
                Console.Write($"{array[i]}");
            }
        }
        Console.Write("]");
    }
    Console.WriteLine();
}