// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] != string.Empty) 
        Console.Write($"\"{array[i]}\", ");
    } 
    Console.Write($" \"{array[array.Length - 1]}\"]");
}   
string[] StringArrayCondition(string[] array)
{
    string[] ArrayCondition = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) ArrayCondition[i] = array[i];
        else ArrayCondition[i] = string.Empty;
    }
    return ArrayCondition;
}
string[] StringArray = {"1234", "56789", "-2", "o", "end", "computer science", "{}", "LKJHG"};
PrintArray(StringArray);
Console.Write(" ---> ");
string[] ResultStringArray = StringArrayCondition(StringArray);
PrintArray(ResultStringArray);