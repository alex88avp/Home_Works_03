// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if(number > 99)
{
    int index = 2;
    int array = number.ToString()[index] - '0';
    Console.WriteLine(array);
}
else{
    Console.WriteLine("Третьей цифры нет");
}
