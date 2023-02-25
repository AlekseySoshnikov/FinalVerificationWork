// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо
// равна 3 символа. Петвоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении 
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello","2","world",":-)"] -> ["2",":-)"]
// ["1234","1567","-2","computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

//string[] array = new string[] {};
string[] array = new string[] {"hello","2","world",":-)"};
//string[] array = new string[] {"1234","1567","-2","computer science"};
//string[] array = new string[] {"Russia", "Denmark", "Kazan"};

PrintArray(array);
System.Console.Write(" -> ");
PrintArray(StringLengthSelection(array));

string[] StringLengthSelection(string[] array)
{     
    int count = 0;
    string[] arr;
    string[] arr_temp;
    arr = new string[count];
    arr_temp = new string[count];
        
    for(int i = 0; i < array.Length; i++)
    {        
        if(array[i].Length <= 3)
        {
            count++;
            arr_temp = new string[count];
            for(int j = 0; j < arr_temp.Length - 1; j++)
            {
                arr_temp[j] = arr[j]; 
            }                   
            arr_temp[count - 1] = array[i];                        
        }
        arr = arr_temp;        
    }
    return arr;
}

void PrintArray(string[] array)
{
    System.Console.Write("[");
    if(array.Length == 0)
    {
        System.Console.Write("]");
    }
    else
    {
        for(int i = 0; i < array.Length - 1; i++)
        {
            System.Console.Write($"\"{array[i]}\",");
        }
        System.Console.Write($"\"{array[array.Length - 1]}\"]");
    }
}
