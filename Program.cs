// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberA > numberB)
{
    System.Console.WriteLine ($"max = {numberA}");  
}

else if (numberB > numberA)
{
    System.Console.WriteLine($"max = {numberB}");
}

else 
{
    System.Console.WriteLine("числа равны");
}