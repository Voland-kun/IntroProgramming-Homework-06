using System;
using System.Collections;

bool[] convertDecToBin(int number, int length)
{
    bool[] boolArray = new bool[length];
    for (int index = 0; index < length; index++)
    {
        boolArray[index] = number % 2 !=0;
        number /= 2;
    }
    return boolArray;
}

void printArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
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

int[] getRandomArray(int arrayLength, int startPoint, int endPoint)
{
    int[] randomArray = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        randomArray[i] = new Random().Next(startPoint, endPoint-1);
    }
    return randomArray;
}

Console.WriteLine("Введите длину массива");
int arrayLength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начало диапазона");
int start = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конец диапазона");
int end = Convert.ToInt32(Console.ReadLine());

int[] manualArray = getRandomArray(arrayLength, start, end);

Console.WriteLine("Введите сумму");
int arraySum = Convert.ToInt32(Console.ReadLine());

printArray(manualArray);



//Костыльный костыль, как перебрать все варианты нормально так и не придумал, видимо через рекурсию, но работающий вариант так и не смог сделать.
void getElements(int[] array, bool[] binaryArray, int sum)
{
    List<int> temp = new List<int>();
    //Вариант с массивом для наглядности какие именно элементы составляют сумму в случае когда элементы повторяются
    //int[] temp = new int[array.Length];
    //int count = 0;
    int summa = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (binaryArray[i] == true)
        {
            summa += array[i];
            temp.Add(array[i]);
            //заполнение массива и счетчика для проверки на сумму, а не одно число
            //temp[i] = array[i];
            //count++;
        }    
    }
    if(summa == sum && temp.Count > 1)
    //условие для варианта с массивом
    //if(summa == sum && count > 1)
    {
        for (int index = 0; index < temp.Count; index++)
        {
            Console.Write(temp[index] + " ");
        }
        
        //вывод варианта с массивом
        //printArray(temp);
        Console.WriteLine();
    }
}

for(int i = 0; i < Math.Pow(2, arrayLength); i++)
{
    bool[] arrayVariants = convertDecToBin(i, arrayLength);
    getElements(manualArray, arrayVariants, arraySum);
}