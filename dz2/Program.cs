﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

 Console.Write("Введите первое число: ");
 int number1 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите второе число: ");
 int number2 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите третье число: ");
 int number3 = Convert.ToInt32(Console.ReadLine());

 int max;

 if (number1 > number2 && number1 > number3)
        {
            Console.Write($"{max = number1}"   );
        }
 else if (number2 > number1 && number2 > number3)
        {
            Console.Write($"{max = number2} ");
        }

 else if (number3 > number1 && number3 > number2)
        {
            Console.Write($"{max = number3} ");
         }
    
