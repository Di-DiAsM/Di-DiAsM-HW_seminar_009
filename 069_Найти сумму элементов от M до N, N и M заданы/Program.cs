// 069. Найти сумму элементов от M до N, N и M заданы

Console.Clear();

Console.WriteLine("Введите число больше 1: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число больше 1: ");
int n = Convert.ToInt32(Console.ReadLine());


int NumbersSumRec(int a, int b)
{
    if (a == b) return b;
    else return b + NumbersSumRec(a, b - 1);
}

Console.WriteLine(NumbersSumRec(m, n));

// 3 6 10 15 
// 1 2 3 4 5 

