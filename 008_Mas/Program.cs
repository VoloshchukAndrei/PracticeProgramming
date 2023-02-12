int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}

int a = 1;
int b = 8;
int c = 31;
int d = 6;
int e = 2;
int f = 13;
int g = 17;
int h = 4;
int i = 9;

int max = Max(Max(a, b, c), Max(d, e, f), Max(g, h, i));

Console.Write("max = ");
Console.Write(max);