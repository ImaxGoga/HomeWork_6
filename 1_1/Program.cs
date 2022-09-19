// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void foo()
{
    int len, res = 0;
    Console.WriteLine("Сколько чисел Вы хотите ввести?");
    len = Int32.Parse(Console.ReadLine());
    double[] mass = new double[len];
    for (int i = 0; i < len; i++)
    {
        Console.WriteLine("Введите " + i + "число: ");
        mass[i] = double.Parse(Console.ReadLine());
        if(mass[i] > 0) res++;
    }
    Console.WriteLine();
    Console.Write("Ваш массив [");
    for (int i = 0; i < len; i++)
    {
        if(i == len - 1)
        Console.WriteLine(mass[i] + "]");
        else Console.Write(mass[i] + ", ");
    }
    Console.WriteLine("Количество чисел больше 0: " + res);
}

foo();