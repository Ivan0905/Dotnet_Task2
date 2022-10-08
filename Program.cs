
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.WriteLine("Введите число от 1 до 100000: ");
int Number = int.Parse(Console.ReadLine()!);
if ((Number<1)||(Number>100000))
{
    Console.WriteLine("Введите число согласно условию");
}
else if (Number <= 100)
    {
        if (Number < 100)
        {
            Console.WriteLine($"В числе {Number} меньше трех цифр");
        }
        else
        {
            Console.WriteLine($"Третья цифра числа {Number} - '0'");
        }
    }
    else
    {
        int Number2 = Number;
        while (Number2 > 1000)       //12345
        {
            Number2 = Number2 / 10;
            //Console.WriteLine(Number2);
        }
        Number2 = (Number2 - 100) % 10;
        Console.WriteLine($"Третья цифра числа {Number} - '{Number2}' ");
    }



