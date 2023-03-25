// **Задача 69:**Напишите программу,
// которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)

// A = 2; B = 3-> 8

Console.Clear();
Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень:");
int B = int.Parse(Console.ReadLine());

int Method(int a, int b)
{
  if (b == 0) return 1;
  if (b == 1) return a;
  return (a * Method(a, b - 1));
}

int res = Method(A,B);
Console.WriteLine($"A = {A},B = {B} -> {res}");


