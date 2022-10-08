//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным. 
//Обязательно сделать проверку на ввод чисел меньше 1 и больше 7
Console.WriteLine("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);

while ((num < 1) || (num > 7))
{
    Console.WriteLine("Вы ввели не корректное число. Повторите ввод: ");
    num = int.Parse(Console.ReadLine()!);
}
switch (num)
{
    case 1:
        Console.WriteLine("Сегодня понедельник, не выходной день ");
        break;
    case 2:
        Console.WriteLine("Сегодня вторник, не выходной день ");
        break;
    case 3:
        Console.WriteLine("Сегодня среда, не выходной день ");
        break;
    case 4:
        Console.WriteLine("Сегодня четверг, не выходной день ");
        break;
    case 5:
        Console.WriteLine("Сегодня пятница, не выходной день ");
        break;
    case 6:
        Console.WriteLine("Сегодня суббота, выходной день ");
        break;
    case 7:
        Console.WriteLine("Сегодня воскресение, выходной день ");
        break;
}