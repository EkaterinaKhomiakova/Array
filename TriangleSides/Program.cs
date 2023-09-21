// Напишите программу, которая принимает на вход три числа
// и проверяет может ли существовать треугольник
//  со сторонами такой длины(сумма двух сторон не должна быть больше третьей)
void ReleaseArray(int[] array)
{
  if (array[0] < array[1] + array[2]
      && array[1] < array[0] + array[2]
      && array[2] < array[0] + array[1])
    Console.Write("yes");
  else
    Console.Write("no");
}
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
ReleaseArray(array);
