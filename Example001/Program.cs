// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Multiplication (int basisDegree, int exponente)
{
    int multiplication = 1; 
    for (int i = 0; i < exponente; i++)
    {
        multiplication *= basisDegree;
    }
    return multiplication;
}

bool VerificationZero (int basisDegree)
{
    if (basisDegree < 0)
    {
        Console.WriteLine("Показатель степени не должен быть меньше нуля согласно условию!");
        return false;
    }
    return true;
}

int basisDegree = Prompt("Введите число А (основание степени): ");
int exponente = Prompt("Введите число B (показатель степени): ");

if (VerificationZero(basisDegree))
{
    Console.WriteLine($"{basisDegree} в степени {exponente} равно {Multiplication(basisDegree, exponente)}");
}