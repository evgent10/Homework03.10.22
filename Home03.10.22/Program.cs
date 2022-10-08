Console.Clear();
// //Задача 34:
// // Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// Console.Write("Введите размер массива: ");
// int size = int.Parse(Console.ReadLine()!);
// int[] num = newRandom(size);
// int count = 0;

// Console.WriteLine($"В массиве {size} элементов, а именно в массиве: [{String.Join(", ", (num))}]");

// int[] newRandom(int size)
// {
//     int[] array = new int[size];
//     for (int i =0; i< array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// for (int nums = 0; nums < num.Length; nums++)
// {
//    if (num[nums] % 2 == 0)
//    count++;
// }
// Console.Write($"Колличество чётных чисел равно {count}");



// // Задача 36: 
// // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// // стоящих на нечётных позициях.   [3, 7, 23, 12] -> 19    [-4, -6, 89, 6] -> 0
// Console.Write("Введите длиннy массивa: ");
// int size = int.Parse(Console.ReadLine()!);
// int[] Array = NewArr(size);

// Console.WriteLine($"В массиве {size} элементов, в массиве:[{String.Join(", ", NewArr(size))}]");
// Console.Write($"Сумма элементов, нечётных позиций равна {NewArr(Array)}");

// int[] NewArr(int size)
// {
//     int[] array = new int[size];
//     for (int i =0; i< array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 11);
//     }
//     return array;
// }

// int NewArr(int[] array)
// {
//     int counter = 0;
//     for (int i =1; i < array.Length; i += 2)
//     {
//         counter += array[i];
//     }
//     return counter;
// }



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine()!);
int[] mass = new int[n];
Console.WriteLine($"В массиве состоящем из {n} элементов, а именно в: [{String.Join(", ", (mass))}]");

int[] newRandom(int n)
{
    int[] mass = new int[n];
    for (int i =0; i < n; i++)
    {
        mass[i] = new Random().Next(100, 1000);
    }
    return mass;
}

int min = 0;
int max = 0;
foreach (int i in mass)  // Оператор foreach: перечисляет элементы коллекции и 
                        // выполняет тело для каждого элемента коллекции.
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимум и минимум: {max - min}");

    