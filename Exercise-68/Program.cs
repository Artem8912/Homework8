Console.WriteLine("Введите неотрицательное число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 <0 || number2<0 )
{
    Console.WriteLine("Вы ввели некорректные числа");
    return;
}

int Ack(int n, int m)
{
    if (n == 0)
    {
        return m+1;
    }
    else if (m==0)
    {
        return Ack(n-1,1);
    }
    else
    {
          return Ack(n-1,Ack(n,m-1));
    }
}

Console.WriteLine(Ack(number1,number2));
