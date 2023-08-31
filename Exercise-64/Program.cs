Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Вы ввели некорректное число");
    return;
}

void Numbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    Numbers(num - 1);

}

Numbers(number);

