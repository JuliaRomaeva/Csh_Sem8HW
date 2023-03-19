/***Задача 67:**Напишите программу,
которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int Sum(int n){
    int sum = 0;
   if( n < 0){
    n = n * -1;
   }
   while(n > 0){
    sum = sum + n % 10;
    n /= 10;
   }
   return sum;
}
int result = Sum(n);
Console.Write($" {n} -> {result}");

int SumNumbers(int num)
{
    if (num == 0)
    return 0;
    return(num % 10 + SumNumbers(num / 10));
}
Console.WriteLine();
Console.WriteLine($" {n} -> {SumNumbers(n)}");