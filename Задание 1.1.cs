using System;

namespace prject {
  class Program1 {

    public static void Main() {
      System.Console.WriteLine("Введите первое число:");
      double num1 = Convert.ToDouble(Console.ReadLine());
      System.Console.WriteLine("Введите второе число:");
      double num2 = Convert.ToDouble(Console.ReadLine());
      System.Console.WriteLine("Сумма: " + (num1 + num2));
      System.Console.WriteLine("Разность: " + Math.Abs(num1 - num2));
      System.Console.WriteLine("Произведение: " + num1 * num2);
      System.Console.WriteLine("Среднее арифметическое:" + (num1 + num2)/2);
      double num3 = Math.Abs(Math.Abs(num1)- Math.Abs(num2));
      System.Console.WriteLine("Разность модулей:" + num3);
    }
  }
}
