// Урок 7. Рекурсия 


// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.



{
static void Main()
{
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = SumFromMToN(m, n);
Console.WriteLine("Сумма натуральных элементов от M до N: " + sum);
}

static int SumFromMToN(int m, int n)
{
if (m > n)
{
throw new ArgumentException("Значение M должно быть меньше или равно N");
}

if (m == n)
{
return m;
}
else
{
return m + SumFromMToN(m + 1, n);
}
}
}


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int funkctionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {funkctionAkkerman} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

static void OutputReverseArray<T>(T[] a, int CurrentIteration)
int [] array = new int [size];
Random rand  new();
{ 
    if (CurrentIteration > a.Length - 1) 
        return; 
    OutputReverseArray(a, CurrentIteration + 1); 
    Console.Write(" " + a[CurrentIteration]); 
}


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.



int[] reverseArray(int[] arr, int x, int y)
{
    int[] arrDup = arr.Clone() as int[];
    if (x >= y)
    {
        return arrDup;
    }
    else
    {
        int t_y = y--;
        int t_x = x++;
        int temp = arrDup[t_y];
        arrDup[t_y] = arr[t_x];
        arrDup[t_x] = temp;
        return reverseArray(arrDup, t_x, t_y);
    }
}
void main(String[] args)
{
    int[] arrPass = { 1, 2, 3, 4, 5 };

    Console.WriteLine(string.Join(",", reverseArray(arrPass, 0, arrPass.Length - 1)));
}

