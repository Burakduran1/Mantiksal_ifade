// See https://aka.ms/new-console-template for more information

int x = 20;
int y = 13;
int z = 42;

bool islem = (23 == 55) && (76 > 45) && (5 < 12);
Console.WriteLine(islem);
bool islem1 = (23 >= 23) && (45 != 18);
Console.WriteLine(islem1);

bool islem2 = (x > y) && (z == y) && (z < x);
Console.WriteLine(islem2);
bool islem3 = (z > x) && (y < x);
Console.WriteLine(islem3);
bool islem4 = (x != z) || (y <= z);
Console.WriteLine(islem4);