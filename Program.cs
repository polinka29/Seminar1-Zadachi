/*Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Например:
4 -> 16 
-3 -> 9 
-7 -> 49
*/

//int number = Convert.ToInt32(Console.ReadLine());
//int square = number * number; // 5*2 = 25
//Console.WriteLine(" квадрат от числа " + number + " = "  + square);

/*Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/

//Console.Write("Введите первое число: ");
//int firstNumber = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int secondNumber = Convert.ToInt32(Console.ReadLine());
//if (firstNumber == secondNumber * secondNumber)
{
     //Console.WriteLine(firstNumber + " является квадратом от " + secondNumber);
}
//else Console.WriteLine(firstNumber + " не является квадратом от " + secondNumber);

/*Напишите программу, которая будет выдавать название дня недели по заданному номеру.
  3 -> Среда 
5 -> Пятница*/

/*Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"*/

int number = Convert.ToInt32(Console.ReadLine());
int negativeNumber = number*(-1);
while (negativeNumber <= number)
{
    Console.Write(negativeNumber + " ");
    negativeNumber++;
}
