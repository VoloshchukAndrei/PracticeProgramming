void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] Col)
{
    int count = Col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(Col[position]);
        position++;
    }
}

int indexOff(int[] collection, int fihd)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == fihd)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = indexOff(array, 44);
Console.WriteLine(pos);