// Сортировка
double[] array = new double[8];
for (int i = 0; i < array.Length; i++)
  array[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2);

Array.Sort(array);

Console.WriteLine($"[{string.Join(";", array)}]");
Console.WriteLine(array[array.Length - 1] - array[0]);
