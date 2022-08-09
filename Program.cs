int arraySize=5;
int controlNumber=3;
string[] array = new string[arraySize];
System.Console.WriteLine("введите информацию");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
}

System.Console.WriteLine("Представлен массив состоящий из следующих элементов");
System.Console.WriteLine("[" + string.Join(" , ", array) + "]");

System.Console.WriteLine("Элементы с количеством символов меньше 3-");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= controlNumber)
    {
        System.Console.Write($"[ {array[i]} ]");
    }
}