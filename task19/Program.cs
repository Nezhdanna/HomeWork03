// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("Введите пятизначное число: ");

int N = Convert.ToInt32(Console.ReadLine());

if (N >= 10000 && N < 100000)

{

    int first = N.ToString()[0] - '0';

    int second = N.ToString()[1] - '0';

    int third = N.ToString()[2] - '0';

    int fourth = N.ToString()[3] - '0';

    int fifth = N.ToString()[4] - '0';

    if (first == fifth && second == fourth)

    {

        Console.Write($"{N} является палиндромом");

    }

    else

    {

        Console.Write($"{N} не является палиндромом");

    }

}

else

{

    Console.Write("Введено некорректное число");
}    