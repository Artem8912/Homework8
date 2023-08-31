Console.WriteLine("Введите целое число №1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число №2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 <= 0 && number2 <= 0)
{
    Console.WriteLine("Сумму посчитать невозможно");
    return;
}
else if (number1 > number2 && number2 <= 0)
{
    while (number2 <= 0)
    {
        number2++;
    }

}
else
{
    while (number1 <= 0)
    {
        number1++;
    }
}
int SumOfNaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        return num2 + SumOfNaturalNumbers(num1, num2 + 1);
    }
    else if (num2 > num1)
    {
        return num1 + SumOfNaturalNumbers(num1 + 1, num2);
    }

    else
    {
        return num1;
    }
}
Console.WriteLine("Сумма натуральных чисел равна: ");
Console.WriteLine(SumOfNaturalNumbers(number1, number2));
