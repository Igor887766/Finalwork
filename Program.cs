void MyPrintArray(string[] localArray)  // метод для вывода массивов
{
    Console.Write("[");
    for (int i =0; i < localArray.Length; i++)
    {
        Console.Write($"\"{localArray[i]}\""); 
        if (i != localArray.Length - 1) Console.Write(", ");  
    }
    Console.WriteLine("]");
}

Console.Clear();
Console.WriteLine("Добрый вечер! Будем переварачивать массив символов длина которых меньше, либо равна 3 символам");
Console.Write("Введите количество строк исходного массива n: ");
int n = Convert.ToInt32(Console.ReadLine()); // запрашиваем кол-во элементов массива

string [] iArray = new string [n];  

int m = 0;  
Console.WriteLine();
for (int i=0; i<iArray.Length; i++)  
{
    Console.Write($"Введите {i+1}-ю строку: "); // создаем массив
    iArray[i] = Console.ReadLine();
    if (iArray[i].Length<4)
    {
        m++;
    }
}
Console.WriteLine();
Console.WriteLine("Исходный массив: ");
MyPrintArray(iArray); // выводим исходный массив

string [] rArray = new string [m];

int k = 0; 

for(int i=0; i<iArray.Length; i++)
{
    if (iArray[i].Length<4) // проверяем массив на кол-во символов меньше 4
    {
        rArray[k] = iArray[i]; // создаем новый массив из символов меньше 4
        k++;
    }
}
Console.WriteLine();
Console.WriteLine("Перевернутый массив: ");
MyPrintArray(rArray); // выводим новый массив