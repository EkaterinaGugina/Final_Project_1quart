// /*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма*/

// Программа, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Console.Clear();
string[] array = { "Rus", "QA", "number", "163", "Hello world!", "qwe" };
string[] result = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) result[i] = array[i];
    else result[i] = string.Empty;
    if (result[i] != string.Empty) Console.Write($"{result[i]} ");
}



// Метод автоматического заполнения массива
string[] AutoFilling(int size, int elementLength)
{
    int next = 0;
    int length = 0;
    char symbol;
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        //Определение длины i-го элемента рандомного массива
        length = new Random().Next(1, elementLength + 1);
        for (int j = 0; j < length; j++)
        {
            //Определение символа для i-uj элемента рандомного массива
            next = new Random().Next(32, 128);
            symbol = (char)next;
            array[i] += symbol;
        }
    }
    return array;
}
// Метод создания результирющего массива
string[] CreateResultArray(string[] arr)
{
    string[] tempArray = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            tempArray[j] = arr[i];
            j++;
        }
    }
    string[] resultArray = new string[j];
    for (int i = 0; i < j; i++)
        resultArray[i] = tempArray[i];
    return resultArray;
}


    