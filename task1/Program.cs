int a = 2;
int b = 10;
int max = a;
int min = b;

if (a > max) max = a;
if (b > max) max = b;
if (a < min) min = a;
if (b < min) min = b;
Console.Write ("min = ");
Console.WriteLine (min);
Console.Write ("max = ");
Console.WriteLine (max);