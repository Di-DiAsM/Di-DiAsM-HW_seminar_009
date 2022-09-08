// 071. Написать программу вычисления функции Аккермана

Console.Clear();

Console.WriteLine("Введите число больше 1: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число больше 1: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akerman(int a, int b)
{
  if (a == 0) return b + 1;
  else if ((a != 0) && (b == 0)) return Akerman(a - 1, 1);
  else return Akerman(a - 1, Akerman(a, b - 1));
}

Console.WriteLine(Akerman(m, n));