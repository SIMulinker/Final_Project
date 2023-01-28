/*
    Написать программу, которая из имеющегося массива строк формирует
    новый массив из строк, длина которых меньше, либо равна 3 символам.
*/
string[] none_origin = { "Many", "Simbols", "Are", "Not", "Simple", "Unique",
                         "Text", "Where", "Use", "As", "Piece", "Of", "Art" };

Console.WriteLine(ArrayToString(none_origin));

Console.WriteLine(ArrayToString(LongStringLost(none_origin)));

// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

string[] LongStringLost(string[] inner)
{
    string[] result = new string[inner.Length];
    int newSize = 0;
    for (int i = 0; i < inner.Length; i++)
    {
        if (inner[i].Length <= 3)
        {
            result[newSize] = inner[i];
            newSize++;
        }
    }
    Array.Resize(ref result, newSize);
    return result;
}

string ArrayToString(string[] array)
{
    if (array.Length < 1)
    {
        return "This a empty array";
    }

    string str = "[ \"";
    for (int i = 0; i < array.GetUpperBound(0); i++)
    {
        str += array[i] + "\", \"";
    }
    str += array[array.GetUpperBound(0)] + "\" ]";

    return str;
}