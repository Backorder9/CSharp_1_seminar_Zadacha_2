Console.Write("Введите первое целое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{    
    Console.WriteLine($"Из двух введённых чисел {num1} и {num2} большим является число {num1}.");
}
if (num1 < num2)
{
    Console.WriteLine($"Из двух введённых чисел {num1} и {num2} большим является число {num2}.");
}
if (num1 == num2)
{
    Console.WriteLine($"Из двух введённых чисел {num1} и {num2} оба числа равны между собой.");
}