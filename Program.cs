int x = 1;
int y = 1;

do
{
   Console.WriteLine($"{x} AINDA MENOR QUE 500");
   Console.WriteLine($"{y} AINDA MENOR QUE 500");
   x = x+y;
   y = y+x;
    
} while (x < 500 );

Console.WriteLine($"{x}");
Console.WriteLine($"{y}");
