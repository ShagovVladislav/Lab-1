using System;

namespace prject {
  class Program2 {

    public static void Main() {
      string im = "";
      while(im == ""){
        System.Console.WriteLine("Ваше имя:");
        im = "" + Console.ReadLine();
      }
      double voz = 0;
      while(voz <= 0){
        System.Console.WriteLine("Ваш возраст:");
        voz = Convert.ToDouble(Console.ReadLine());}
      double sch = 0;
      while(sch <= 0){
        System.Console.WriteLine("Номер школы:");
        sch = Convert.ToDouble(Console.ReadLine());}
      int cl = 0;
      while(cl < 9 || cl > 11 || cl == 10){
        System.Console.WriteLine("Какой класс закончили: ");
        cl = Convert.ToInt32(Console.ReadLine());
        if(cl < 9 || cl > 11 || cl == 10){System.Console.WriteLine("Вы не окончили школу(");}
      }
      double x = 0;
      if(cl == 11){
        x = 2024 - (voz - 18);}
      else
      {
        x = 2024 - (voz - 16);
      }
      System.Console.WriteLine("Привет " + Convert.ToString(im) + "!\n" +
      "\n" +
      "Поздравляю с окончанием {0} класса школы №{1}\n" +
      "в {2} учебном году.", cl, sch, x);
    }
  }
}
