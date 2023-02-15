//Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Enter first number");
string cat1 = Console.ReadLine();
int a = Convert.ToInt32(cat1);
Console.WriteLine("Enter second number");
string cat2 = Console.ReadLine();
int b = Convert.ToInt32(cat2);
Console.WriteLine("Enter third number");
string cat3 = Console.ReadLine();
int c = Convert.ToInt32(cat3);
int max = a;

if (a > b && a >c)
{
    Console.WriteLine(max = a);
}
if (b > a && b > c)
{
    Console.WriteLine(max = b);
}
else
{
    Console.WriteLine(max = c);
}