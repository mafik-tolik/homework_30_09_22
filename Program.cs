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


