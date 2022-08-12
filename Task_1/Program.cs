// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3



Console.Write($"Введите количество элементов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] numMass = new int[m];

void NumOfElements(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        numMass[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int Comparison(int[] numMass)
{
    int count = 0;
    for (int i = 0; i < numMass.Length; i++)
    {
        if (numMass[i] > 0) count += 1;
    }
    return count;
}

NumOfElements(m);
int result = Comparison(numMass);

Console.WriteLine($"Введено чисел больше 0: {result} ");


