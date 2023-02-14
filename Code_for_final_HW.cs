Console.Clear();
Console.WriteLine("Введите длинну массива");
int N = Convert.ToInt32(Console.ReadLine()); // Ввод длинны массива

string[] arr = new string[N];

arr = InputText("Введите произвольные слова", arr); // Заполнение массива
PrintPlusNumber(arr);

int nums = LengthOfArr(arr); // определение количества слов с длинной менее или равно 3 символа

string[] arrOfLength3 = new string[nums + 1];
arrOfLength3 = FillArrLengthLow3(arr, nums); // создание нового массива состоящий только из слов длинной менее или равно 3
PrintPlusNumber(arrOfLength3);

string[] InputText(string Logo, string[] arr) // метод заполнения массива
{
    Console.WriteLine($"{Logo}");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine(); // вводится str, проверка не проводится на соответсвие типу
    }
    return arr;
}

int LengthOfArr(string[] arr) // метот определения количества слов с длинной менее или равной 3
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i].Length > 0) & (arr[i].Length <= 3)) // проверка на пустое значение и длинну меньше 3
        {
            count += 1;
        }
    }
    return count;
}

string[] FillArrLengthLow3(string[] arr, int num) // метод заполнения второго массива
{
    string[] arr1 = new string[num];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if ((arr[i].Length > 0) & (arr[i].Length <= 3)) // проверка на пустое значение и длинну меньше 3
        {
            arr1[count] = arr[i];
            count += 1;
        }
    }
    return arr1;
}

void PrintPlusNumber(string[] arr) // метот вывода на консоль
{
    string Kv = "\"";
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{Kv}{arr[i]}{Kv}, ");
    }
    Console.WriteLine($"{Kv}{arr[arr.Length-1]}{Kv}] -> {arr.Length}");
}