using System;
using static System.Console;
namespace name{
    public static class some
    {
        public static string nothing(this long number)
        {
            if (number == 0) return "nol";
            if (number < 0) return "minus " + nothing(Math.Abs(number));
            string words = "";
            if ((number / 1000000000000000) > 0)
            {
                words += nothing(number / 1000000000000000) + " kvadrillion ";
                number %= 1000000000000000;
            }
            if ((number / 1000000000000) > 0)
            {
                words += nothing(number / 1000000000000) + " trillion ";
                number %= 1000000000000;
            }
            if ((number / 1000000000) > 0)
            {
                words += nothing(number / 1000000000) + " milliard ";
                number %= 1000000000;
            }
            if ((number / 1000000) > 0)
            {
                words += nothing(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += nothing(number / 1000) + " ming ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += nothing(number / 100) + " yuz ";
                number %= 100;
            }

            if (number > 0)
            {
                var birlik = new[] { "nol", "bir", "ikki", "uch", "to'rt", "besh", "olti", "yetti", "sakkiz", 
                "to'qqiz", "o'n", "o'n bir", "o'n ikki", "o'n uch", "o'n to'rt", 
                "o'n besh", "o'n olti", "o'n yetti", "o'n sakkiz", "o'n to'qqiz"};
                var onlik = new[] { "nol", "o'n ", "yigirma ", "o'ttiz ", 
                "qirq ", "ellik ", "oltmish ", "yetmish ", "sakson ", "to'qson " };

                if (number < 20) words += " "+birlik[number];
                else
                {
                    words += onlik[number / 10];
                    if ((number % 10) > 0)
                        words += birlik[number % 10];
                }
            }
            return words;
        }
    }
}
