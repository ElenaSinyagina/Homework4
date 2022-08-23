// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. "Напишите ЦИКЛ"
// значит возводить в степень нужно циклом, а не методом 
// Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А:");

var numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите степень В:");

var numberB = int.Parse(Console.ReadLine()!);

int result = 1;
for(int i = 1; i <= numberB; i++)
{
    result *= numberA;    
}
Console.WriteLine("Число А в степени В равно " + result);