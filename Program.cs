void MyPrintArray(string[] localArray)  
{
    Console.Write("[");
    for (int i =0; i < localArray.Length; i++)
    {
        Console.Write($"\"{localArray[i]}\""); // Печатаем текущую строку массива в кавычках
        if (i != localArray.Length - 1) Console.Write(", ");  // после последнего элемента не печатаем ", "
    }
    Console.WriteLine("]");
}

Console.Clear();
Console.WriteLine("Итоговая проверочная работа.");
Console.Write("Введите количество строк исходного массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

string [] iArray = new string [n];  // Исходный массив

int m = 0;  

for (int i=0; i<iArray.Length; i++)  
{
    Console.Write($"Введите {i+1}-ю строку: ");
    iArray[i] = Console.ReadLine();
    if (iArray[i].Length<4)
    {
        m++;
    }
}

Console.WriteLine("Исходный массив: ");
MyPrintArray(iArray);

string [] rArray = new string [m];

int k = 0; 

for(int i=0; i<iArray.Length; i++)
{
    if (iArray[i].Length<4)
    {
        rArray[k] = iArray[i];
        k++;
    }
}

Console.WriteLine("Результирующий массив: ");
MyPrintArray(rArray);