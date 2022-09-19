// Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 
// Сумма элементов главной диагонали: 1+9+2 = 12

void foo()
{
    double[,] massExp = new double[3,4] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4} };
    PrintArray(massExp);
    Console.WriteLine("Сумма элементов, находящихся на главной диагонали: " + SumDiag(massExp));

    Console.WriteLine();

    double[,] massRand = new double[3,4];
    FillArray(massRand);
    // for (int i = 0; i < massRand.GetLength(0); i++)
    // {
    //     for (int j = 0; j < massRand.GetLength(1); j++)
    //     {
    //         massRand[i,j] = new Random().Next(-10,10);
    //     }
    // }
    PrintArray(massRand);
    Console.WriteLine("Сумма элементов, находящихся на главной диагонали: " + SumDiag(massRand));
}

void PrintArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

double SumDiag(double[,] mass)
{
    double Result=0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if(i == j) Result = Result + mass[i,j];           
        }        
    }
    return Result;
}

foo();