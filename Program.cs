/*ReversArray(array);
Console.WriteLine(String.Join(",", array));


void ReversArray(int[] array){
for (int i = 0; i < array.Length / 2; i++)
{
    int k = array[i];
    array[i] = array[array.Length - i - 1];
    array[array.Length - i - 1] = k;
}
}

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(",", array));


int[] result = ReversArray2(array);
Console.WriteLine(String.Join(",", array));

int[] ReversArray2(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - i - 1];
    }
    return result;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}*/

//Напишите программу, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник с такими сторонами.

/*Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

if (a < b + c && b < a + c && c < a + b)
{
Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует!");
}
else
{
    Console.WriteLine($"Треугольника со сторонами {a}, {b}, {c} не существует!");
}*/

//Напишите программу, которая будет преобразовывать десятичное число в двоичное

/*Console.WriteLine("Введите десятичное число: ");
int item = int.Parse(Console.ReadLine()!);
Console.WriteLine(Convert.ToString(item, 2));*/

//Напишите программу, которая будет копировать заданный массив поэлементно.

/*int[] array = GetArray(10, 0, 10);
int[] arrayCopy = CopyArray(array);
Console.WriteLine("Изначальный массив: " + String.Join(",", array));
Console.WriteLine("Копия массива: " + String.Join(",", arrayCopy));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] collection){

    int[] arr= new int[collection.Length];
    int i = 0;
    foreach (int item in collection)
    {
        arr[i] = item;
        i++;
    }
    return arr;
}*/






//ДОМАШНЕЕ ЗАДАНИЕ-----------------------------------------------------------------------------------------------------------------------------










//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.



//искала в синтаксисе, как можно осуществить ввод с клавиатуры нескольких чисел сразу в массив, не знаю, можно ли проще сделать?



//Console.WriteLine("Введите числа: ");
//var numbers = Console.ReadLine()!.Split(new[]{" "},StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse);
//foreach(var n in numbers)
//    Console.WriteLine(n);

/*Console.Write("Введите числа: ");
int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

int count = 0;
 
for (int i = 0; i < numbers.Length; i++)
{
    if (i > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество чисел больше 0 равно {count}");*/ 



//не работает, не понимаю, в чём ошибка



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*Console.Write("Введите k1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = int.Parse(Console.ReadLine()!);
 
 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");*/

//нужно ли было с помощью метода решать эту задачу?


















