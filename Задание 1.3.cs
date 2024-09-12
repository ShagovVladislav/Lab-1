using System;
using System.Security.Cryptography;

namespace prject {
  class Program3 {

    public static void Main() {
      double r1 = 0;
      while(r1 <= 0){
        System.Console.WriteLine("Введите рвдиус первого круга: ");
        r1 = Convert.ToDouble(Console.ReadLine());}
      double r2 = 0;
      while(r2 <= 0){
        System.Console.WriteLine("Введите радиус второго круга: ");
        r2 = Convert.ToDouble(Console.ReadLine());}
      double x = Math.Round(Math.Abs((Math.PI * Math.Pow(r1, 2)) - (Math.PI * Math.Pow(r2, 2))), 2);
      if(r1 > r2){
        System.Console.WriteLine("Площадь первого круга больше площади второго примерно на {0}", x);
      }
      else if(r2 > r1){
        System.Console.WriteLine("Площадь второго круга больше площади первого примерно на {0}", x);}
      else{System.Console.WriteLine("Площадь первого круга равна площади второго");}
    }
  }
}
