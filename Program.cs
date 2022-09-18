// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    if (array[array.Length - 1] != string.Empty) Console.Write($"\"{array[array.Length - 1]}\"]");
    else if (array[array.Length - 1] == string.Empty) Console.Write("]");
}
string[] StringArrayCondition(string[] array)
{
    string[] ArrayCondition;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    if (count != 0)
    {
        ArrayCondition = new string[count];
        int j = 0;
        while (j < count)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    ArrayCondition[j] = array[i];
                    j++;
                }
            }
        }
    }
    else
    {
        ArrayCondition = new string[1];
        ArrayCondition[0] = string.Empty;
    }
    return ArrayCondition;
}
//string[] StringArray = { "1234", "56789", "end", "computer science", "LKJHG" };
//string[] StringArray = {"1234", "56789", "computer science", "LKJHG"};
//string[] StringArray = {"Hello", "2", "world", ":-)"}; 
string[] StringArray = {"Russia", "Denmark", "Kazan"};
PrintArray(StringArray);
Console.Write(" ---> ");
string[] ResultStringArray = StringArrayCondition(StringArray);
PrintArray(ResultStringArray);