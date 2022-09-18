// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма
Console.Clear();
string[] StringArray = {"1234", "56789", "-2", "o", "end", "computer science", "{}", "LKJHG"};
int length = StringArray.Length;
string[] StringArrayCondition = new string[length];
for (int i = 0; i < length; i++)
{
    if (StringArray[i].Length <= 3) StringArrayCondition[i] = StringArray[i];
    else StringArrayCondition[i] = string.Empty;
    if (StringArrayCondition[i] != string.Empty) Console.Write($"{StringArrayCondition[i]} ");
}