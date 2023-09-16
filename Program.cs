using System;
internal class Program
{
    private static void Main(string[] args)
    {
        double first_num, second_num, stepen;
        char operation;
        while (true)
        {
            Console.WriteLine("1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы");
            operation = Convert.ToChar(Console.ReadLine());
            if (operation == '1')
            {
                Console.WriteLine("Введите первое число:");
                first_num = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                second_num = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + (first_num + second_num));
            }
            else if (operation == '2')
            {
                Console.WriteLine("Введите первое число:");
                first_num = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                second_num = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + (second_num - first_num));
            }
            else if (operation == '3')
            {
                Console.WriteLine("Введите первое число:");
                first_num = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                second_num = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + second_num * first_num);
            }
            else if (operation == '4')
            {
                Console.WriteLine("Введите первое число:");
                first_num = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                second_num = double.Parse(Console.ReadLine());
                if (second_num == 0)
                {
                    Console.WriteLine("Ошибка деления");
                }
                else
                {
                    Console.WriteLine("Результат: " + first_num / second_num);
                }
            }
            else if (operation == '5')
            {
                Console.WriteLine("Введите число:");
                first_num = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите степень:");
                stepen = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + Math.Pow(first_num, stepen));
            }
            else if (operation == '6')
            {
                Console.WriteLine("Введите число:");
                first_num = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + Math.Sqrt(first_num));
            }
            else if (operation == '7')
            {
                Console.WriteLine("Введите число:");
                first_num = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + first_num / 100);
            }
            else if (operation == '8')
            {
                Console.WriteLine("Введите число:");
                first_num = double.Parse(Console.ReadLine());
                double factorial = 1;
                for (int var = 1; var <= first_num; var++)
                {
                    factorial *= var;
                }
                Console.WriteLine("Результат: " + factorial);
            }
            else if (operation == '9')
            {
                break;
            }
            else { Console.WriteLine("Не выбрано"); }
        }
    }
}