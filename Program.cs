int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.Write("\n");
}

//Задача 1
/* bool IsValidTriangle(int kat1, int kat2, int kat3)
{
    return kat1 < kat2 + kat3 && kat2 < kat1 + kat3 && kat3 < kat1 + kat2;
}

Console.Write("Enter side 1: ");
int kat1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter side 2: ");
int kat2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter side 3: ");
int kat3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsValidTriangle(kat1, kat2, kat3));
*/
//Задача 2
/*
int[] GenerateFibonacci(int size, int firstNum, int secondNum)
{
    int[] array = new int[size];
    array[0] = firstNum;
    array[1] = secondNum;
    for(int i = 2; i < size; i++)
        array[i] = array[i - 1] + array[i - 2];
    return array;
}

Console.Write("Enter size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
int[] myFibonacci = GenerateFibonacci(size, firstNum, secondNum);
PrintArray(myFibonacci);
*/
//Задача 3
int[] CopyArray(int[] array)
{
    int[] copiedArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
        copiedArray[i] = array[i];
    return copiedArray;
}
Console.Write("Enter array size: ");
int size3 = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size3, 100, 999);
Console.Write("Initial array: ");
PrintArray(myArray);
int[] myArray2 = CopyArray(myArray);
Console.Write("Copied array: ");
PrintArray(myArray2);

