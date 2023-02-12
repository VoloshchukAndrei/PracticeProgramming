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

int max1 = Max(a, b, c);
int max2 = Max(d, e, f);
int max3 = Max(g, h, i);
int max = Max(max1, max2, max3);

Console.Write("max = ");
Console.Write(max);