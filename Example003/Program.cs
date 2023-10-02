// Задача 29: Напишите программу, которая принимает на вход длину массива и в последующих строках элементы массива.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]
int Prompt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Arr(int[] array)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
}

int length = Prompt("Введите длину массива: ")
Console.WriteLine($"Длина Вашего массива - {} символов;");
Console.WriteLine($"Массив - {}")