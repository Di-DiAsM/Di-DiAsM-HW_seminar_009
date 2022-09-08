// 067. Показать натуральные числа от N до 1, N задано

Console.Clear();

Console.WriteLine("Введите число больше 1: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;

//***********************************************************************************
string NumbersRecMinus(int a, int b)
{
    if (a == b) return $"{a} ";
    else return  NumbersRecMinus(a + 1, b) + $"{a} ";
}

Console.WriteLine(NumbersRecMinus(a, n));

//***********************************************************************************     
// string NumbersRecMinus(int a, int b)
// {
//     if (a <= b) return NumbersRecMinus(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }

// Console.WriteLine(NumbersRecMinus(a, n));

//***********************************************************************************

// void NumbersRecMinus(int n)
// {
//     if (a > n) 
//         return;
//     Console.Write($"{n} ");
//     NumbersRecMinus(n-1);
// }

// NumbersRecMinus(n);


