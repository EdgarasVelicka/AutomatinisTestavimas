using NUnit.Framework;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Uzduotis17_Kodas;

namespace Uzduotis17_Testai
{
    public class Testai
    {
        [Test]
        public void Patikrinimas()
        {
            int pirmSkaicius = 995;
            int antrSkaicius = 3;
            int laukiamasRez = 0;

            int gautasRez = Uzduotis17_Kodas.Skaiciuotuvas.Liekana(pirmSkaicius, antrSkaicius);

            Assert.AreEqual(laukiamasRez, gautasRez);
        }

        // Check if today is wednesday
        [Test]
        public void DayOfWeek()
        {
            string expectedDay = "Wednesday";

            string actualDay = Uzduotis17_Kodas.WeekDay.GetDayOfWeek();

            Assert.AreEqual(expectedDay, actualDay);
        }

        // Check if now is 13'th o'clock
        [Test]
        public void CurrentHour()
        {
            DateTime currentTime = DateTime.Now;
            int expectedHour = 13;
            int actualHour = Uzduotis17_Kodas.Hour.ReturnHour(currentTime);

            Assert.AreEqual(expectedHour, actualHour);
        }

        // Patikrinti, kiek yra lyginiu skaiciu intervale [1 - 10]
        [Test]
        public void LyginiaiSkaiciai()
        {
            int laukiamasRezultatas = 4;
            int gautasRezultatas = Uzduotis17_Kodas.LyginiaiSkaiciai.Lyginiai();

            Assert.AreEqual(laukiamasRezultatas, gautasRezultatas);
        }

    }
}
