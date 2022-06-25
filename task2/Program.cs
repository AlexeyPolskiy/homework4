//  Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int prompt(string message)
{
    System.Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}
int numberIntA = prompt("Введите число A -> ");
int digitCount = (int)Math.Log10(numberIntA) + 1; // считаю количество цифр в числе
int unswer = 0;
int cut1 = 10;
int cut2 = 1;

for (int i = 0; i < digitCount; i++)
{
    unswer += numberIntA % cut1 / cut2;
    cut1 *= 10;
    cut2 *= 10;
}

System.Console.WriteLine($"Введенное число {numberIntA} состоит из {digitCount} цифр, их сумма {unswer}");
