int [] masUser = {15,77,13,24,56,16,77,8};

int n = masUser.Length;
int find = 77;

int index = 0;

while (index < n)
{
    if(masUser[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}