// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


int getArraySize()
{
    Console.WriteLine("Введите количество элементов массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}
    
int[] keyboardArrayInput(int size)  
{
    int[] userArray = new int[size];  
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива: ");
        userArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return userArray;
}

void printArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}

int getPositiveNumbersCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int arraySize = getArraySize();
int[] manualArray = keyboardArrayInput(arraySize);
printArray(manualArray);
Console.WriteLine($"Чисел больше нуля: {getPositiveNumbersCount(manualArray)}");