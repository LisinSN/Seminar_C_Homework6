// Урок 6. Двумерные массивы и рекурсия. Домашняя работа. 
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine(" ");
Console.WriteLine("*** Давайте создадим массив и сосчитаем количество чисел больше нуля ***");
Console.WriteLine(" ");

// Функция создания и публикации массива из введенных чисел с подсчетом количества положительных
int[] CreateShowArray(int size)
{
    int result = 0;
    int[] array = new int[size];
    Console.WriteLine(" ");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"# Введите {i + 1} число массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) result += 1;
    }
    Console.Write("# Количество числел больше нуля: " + result);
    Console.WriteLine(" ");
    return array;
}
// Ввод данных // Ограничения количества цифр
Console.Write("# Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size <= 0) Console.Write("# Неверные условия ввода");
else
{
    int[] array = CreateShowArray(size);
}
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями  y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine(" ");
Console.WriteLine("*** Давайте найдем координаты пересечения прямых ***");
Console.WriteLine(" ");

void IntersectionPoint(int b1, int k1, int b2, int k2)
{
    double s = b2 - b1; // не понимаю почему подобная запись в одну строку считает не правильно 
    double d = k1 - k2; // double x =  (b2 - b1) / (k1 - k2) выдает 0
    double x = s/d;
    double f = k1 * x;
    double y = f + b1; // double y = (k1 * x) + b1 выдает 2
    Console.WriteLine($"# Координаты точки пересечения: Х= {x}, Y= {y}");
}

int b1 = 2, k1 = 5, b2 = 4, k2 = 9;
// Ввод данных // Точки прямых
//Console.Write ("# Введите координат точки b1: "); 
//int b1 = Convert.ToInt32(Console.ReadLine());
//Console.Write ("# Введите координат точки k1: "); 
//int k1 = Convert.ToInt32(Console.ReadLine());
//Console.Write ("# Введите координат точки b2: "); 
//int b2 = Convert.ToInt32(Console.ReadLine());
//Console.Write ("# Введите координат точки k2: "); 
//int k2 = Convert.ToInt32(Console.ReadLine());
IntersectionPoint(b1, k1, b2, k2);
