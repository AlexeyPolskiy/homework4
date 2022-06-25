//  Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int prompt(string message)
{
    System.Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int numberIntA = prompt("Введите число A -> ");
int numberIntB = prompt("Введите степень B -> ");
int answer = numberIntA;

for (int i = 1; i < numberIntB; i++)
{
    answer = answer * numberIntA;
}
System.Console.WriteLine($"Число {numberIntA} в степени {numberIntB} = {answer}");