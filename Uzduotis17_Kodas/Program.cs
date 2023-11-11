

using System;

namespace Uzduotis17_Kodas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Patikrinimas ar dalijasi be liekanos
            Console.WriteLine("Liekana lygi: " + Skaiciuotuvas.Liekana(995, 3));

            // Dienos patikrinimas
            string dayOfWeek = WeekDay.GetDayOfWeek();
            Console.WriteLine("Today is " + dayOfWeek);

            // Valandos gavimas
            DateTime currentTime = DateTime.Now;
            int hour = Hour.ReturnHour(currentTime);
            Console.WriteLine(hour + " hour");

            // Patikrinti, kiek yra lyginių skaičių

            Console.WriteLine($"Nuo 1 iki 10 yra {LyginiaiSkaiciai.Lyginiai()} lyginiai skaičiai");
        }
    }
}
