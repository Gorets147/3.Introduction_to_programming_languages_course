int a1 = 15;
int b1 = 78;
int c1 = 54;
int a2 = 43;
int b2 = 17;
int c2 = 14;
int a3 = 99;
int b3 = 11;
int c3 = 46;

int max = a1;

if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

System.Console.WriteLine(max);