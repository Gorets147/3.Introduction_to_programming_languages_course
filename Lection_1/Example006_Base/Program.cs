int a = 1;
int b = 4;
int c = 6;
int d = 1;
int e = 3;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

System.Console.Write("max = ");
System.Console.WriteLine(max);
