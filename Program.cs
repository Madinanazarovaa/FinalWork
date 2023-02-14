string[] FillArray()
{
    string[] array = new string[5] {"1", "12", "123", "1234", "12345"};
    return array;
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void NewArrayOutput(string[] array)
{
    int j = 0;
    string[] newArray = new string[array.Length];
    System.Console.Write(" ->  ");
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[j] = array[i];
            System.Console.Write(newArray[j] + " ");
            j++;
        }
    }
}

string[] array = FillArray();
PrintArray(array);
NewArrayOutput(array);