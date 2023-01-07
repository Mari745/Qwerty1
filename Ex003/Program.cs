int a, b;
Console.WriteLine("Введите два числа:");
a = 10;
b = 2;

if ( a > b )
{
   Console.WriteLine("{0} максимальное", a);
   Console.WriteLine("{0} минимальное" , b);
}

else
{
   Console.WriteLine("{0} минимальное", b);
   Console.WriteLine("{0} максимальное", a);
}
Console.ReadLine();