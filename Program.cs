// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int InputInt(string massage)
{
    System.Console.WriteLine($"{massage} > ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void SumNutNumb(int num1, int num2, int sum)
{
  if (num1 > num2)
  {
    System.Console.WriteLine($"{sum}");
    return;
  }
  sum = sum + (num1++);
  SumNutNumb(num1, num2, sum);
}
int a = InputInt("Введите начальное число");
int b = InputInt("Введите конечное число");
System.Console.WriteLine($"Сумма числе от {a} до {b} равна ");
SumNutNumb(a, b, 0);
