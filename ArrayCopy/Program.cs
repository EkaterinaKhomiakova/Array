// Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования
int[] a = { 1, 2, 3, 4 };
int[] b = new int[a.Length];
int[] c = new int[a.Length];
for (int i = 0; i < a.Length; i++)
  b[i] = a[i];
b[0] = -5;
Array.Copy(a, c, a.Length);
c[0] = 78;
Console.WriteLine($"[{string.Join(",", a)}]");
Console.WriteLine($"[{string.Join(",", b)}]");
Console.WriteLine($"[{string.Join(",", c)}]");