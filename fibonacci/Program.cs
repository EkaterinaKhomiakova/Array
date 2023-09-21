// Не используя рекурсию выведите первые N чисел фибоначчи
// Первые два числа фибоначчи:0 и 1
// Если N = 5 ->0 1 1 2 3
// Если N = 3 ->0 1 1
// Если N = 7 ->0 1 1 2 3 5 8
// Console.WriteLine("Hello, World!");

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a0 = 0, a1 = 1, x;
for (int i = 0; i < n; i++)
{
  Console.Write($"{a0}");
  x = a0 + a1;
  a0 = a1;
  a1 = x;
}