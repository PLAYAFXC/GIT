using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть число X: ");
        int x = int.Parse(Console.ReadLine()); // Запрограмувати користувацький ввід числа Х

        if (x < 1)
        { // Перевірити, чи є введене число менше 1
            Console.WriteLine("Помилка: число має бути більше або дорівнювати 1.");
        }
        else
        {
            int a = 0, b = 1, c = 0;
            Console.Write("Послідовність чисел Фібоначчі: ");

            for (int i = 0; i < x; i++)
            { // Вивести послідовність чисел Фібоначчі до числа Х
                if (i == 0)
                {
                    Console.Write(a + " ");
                }
                else if (i == 1)
                {
                    Console.Write(b + " ");
                }
                else
                {
                    c = a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                }
            }
        }

        Console.ReadLine(); // Забезпечити можливість перегляду виведених результатів
    }
}