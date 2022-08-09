string[] array = new string[5];
System.Console.WriteLine("введите информацию");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
}

System.Console.WriteLine("Представлен массив состоящий из следующих элементов");
    System.Console.WriteLine("[" + string.Join(" , ", array) + "]");

