Console.Clear();



// Ex25();
// Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Ex25()
{
    Console.WriteLine("Введите натуральное число A:");
    int numberA = Convert.ToInt32(Console.ReadLine());
    while (numberA < 1)
    {
        Console.WriteLine("Неверный ввод.Введите натуральное число A:");
        numberA = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Введите натуральное число B:");
    int numberB = Convert.ToInt32(Console.ReadLine());
    while (numberB < 1)
    {
        Console.WriteLine("Неверный ввод.Введите натуральное число B:");
        numberB = Convert.ToInt32(Console.ReadLine());
    }

    int result = numberA;

    for (int i = 1; i < numberB; i++)
    {
        result *= numberA;
    }
    Console.WriteLine($"{numberA} в степени {numberB} = {result}");
}



Ex27();
// Ex27_1(); // решение через массив. 
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Ex27()
{
    Console.WriteLine("Введите натуральное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    while (number < 1)
    {
        Console.WriteLine("Неверный ввод.Введите натуральное число:");
        number = Convert.ToInt32(Console.ReadLine());
    }

    int current_number1 = number;
    int count = 0;

    while (current_number1 > 0)
    {
        current_number1 = current_number1 / 10;
        count += 1;
    }

    Console.WriteLine($"Количество цифр в числе {number} равно: {count}");

    double sum = 0;
    double current_number2 = number;
    int current_count = count - 1;

    for (int i = 0; i < count; i++)
    {

        double stepen = Math.Pow(10, current_count); // путем деления или умножения на эту переменную мы получим нужный нам разряд числа. 

        double digit = Math.Floor(current_number2 / stepen); // здесь находим первую искомую цифру (начиная слева) и затем последующие.

        sum = sum + digit; // здесь подсчитываем итоговую сумму цифр нашего числа. 

        current_number2 = current_number2 - digit * stepen; // здесь убираем самый высокий разряд (чтобы на следующем цикле работать со следующим разрядом).

        current_count--; // уменьшаем на 1, чтобы на следущем цикле сделать степень на 1 меньше.
    }
    Console.WriteLine($"Cумма цифр в числе {number} равна: {sum}");
}

