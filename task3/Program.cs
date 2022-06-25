//  Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
// 6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1

int prompt(string message)
{
    System.Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

void FillArray(int [] collection, int limitMIN, int limitMAX)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(limitMIN,limitMAX);
    }
}

void PrintArray(int[] printMas)
{
    int count = printMas.Length;
        for (int position = 0; position < count; position++)
    {
        System.Console.Write(printMas[position]);
    }
}

int elementArray = prompt("Введите число элементов массива -> ");
int limitMIN = prompt("Введите минимальный предел значений элементов -> ");
int limitMAX = prompt("Введите максимальный предел значений элементов -> ");

int[] massiv = new int[elementArray];


PrintArray(massiv);
FillArray(massiv, limitMIN, limitMAX);
System.Console.WriteLine();
PrintArray(massiv);