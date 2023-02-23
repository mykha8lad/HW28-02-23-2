using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW28_02_23_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1. Ввести с клавиатуры два 3-значных числа и поменять у них средние цифры (например, ввести 357 и 702 – получить и вывести числа 307 и 752).
            /*int num1;
            int num2;

            Console.WriteLine("Введите первое 3-значное число");    
            do
            {
                Console.Write("> ");
                num1 = Convert.ToInt32(Console.ReadLine());
            } while (num1 < 100 || num1 > 999);

            Console.WriteLine("Введите второе 3-значное число");
            do
            {
                Console.Write("> ");
                num2 = Convert.ToInt32(Console.ReadLine());
            } while (num2 < 100 || num2 > 999);                   
     
            int num1MiddleDigit = (num1 / 10) % 10;
            int num2MiddleDigit = (num2 / 10) % 10;
            
            int newNum1 = (num1 / 100) * 100 + num2MiddleDigit * 10 + num1 % 10;
            int newNum2 = (num2 / 100) * 100 + num1MiddleDigit * 10 + num2 % 10;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Первое число с замененными средними цифрами: {newNum1}");
            Console.WriteLine($"Второе число с замененными средними цифрами: {newNum2}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion

            #region 2.Ввести 4 - значное число и подсчитать сумму первой и третьей цифры и разность второй и четвертой цифры.
            /*int number;

            Console.WriteLine("Введите 4-значное число");
            do
            {
                Console.Write("> ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number < 1000 || number > 9999);

            int firstDigit = number / 1000;
            int secondDigit = (number / 100) % 10;
            int thirdDigit = (number / 10) % 10;
            int fourthDigit = number % 10;

            int sum = firstDigit + thirdDigit;
            int diff = secondDigit - fourthDigit;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;            
            Console.WriteLine($"Сумма первой и третьей цифры: {sum}");
            Console.WriteLine($"Разность второй и четвертой цифры: {diff}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion

            #region 3. Ввести с клавиатуры 3-значное число и удалить из него среднюю цифру (например, ввести 3, 5, 7 – получить и вывести число 37).
            /*int number;

            Console.WriteLine("Введите 3-значное число");
            do
            {
                Console.Write("> ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number < 100 || number > 999);

            int firstDigit = number / 100;
            int thirdDigit = number % 10;

            int resultNumber = firstDigit * 10 + thirdDigit;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Результат: {resultNumber}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion

            #region 4. Написать программу, которая предлагает пользователю ввести сумму денежного вклада в гривнах, а также процент годовых, которые выплачивает банк. Определить сумму денег, выплачиваемых банком вкладчику каждый месяц.
            /*double userDeposit;
            double yearPercentage;

            Console.WriteLine("Введите сумму вклада");
            do
            {
                Console.Write("> ");
                userDeposit = Convert.ToDouble(Console.ReadLine());
            } while (userDeposit <= 0);

            Console.WriteLine("Введите процент годовых");
            do
            {
                Console.Write("> ");
                yearPercentage = Convert.ToDouble(Console.ReadLine());
            } while (yearPercentage <= 0 || yearPercentage > 100);

            double monthlyPercentage = (yearPercentage / 100) / 12.0;
            double monthlyPayment = userDeposit * monthlyPercentage;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Сумма выплаты каждый месяц: {monthlyPayment} грн");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion

            #region 5. Сколько товара ценой Y можно купить на Х гривен и сколько получить сдачи?
            /*double productPrice;
            double yourPrice;

            Console.WriteLine("Введите цену товара");
            do
            {
                Console.Write("> ");
                productPrice = Convert.ToDouble(Console.ReadLine());
            } while (productPrice <= 0);

            Console.WriteLine("Введите сумму оплаты");
            do
            {
                Console.Write("> ");
                yourPrice = Convert.ToDouble(Console.ReadLine());
            } while (yourPrice <= 0 && yourPrice < productPrice);

            double countPayProduct = Math.Floor(yourPrice / productPrice);
            double remainderMoney = yourPrice % productPrice;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Кол-во приобретенного товара - {countPayProduct}");
            Console.WriteLine($"Сумма сдачи - {remainderMoney}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion

            #region 6. Написать программу, которая переводит фунты в килограммы. Один фунт – 405.9 грамма задается в программе как константа.
            /*const double onePound = 405.9;
            double pounds;

            Console.WriteLine("Введите кол-во фунтов");
            do
            {
                Console.Write("> ");
                pounds = Convert.ToDouble(Console.ReadLine());
            } while (pounds <= 0);

            double result = (pounds * onePound) / 1000;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{result} килограмм в {pounds} фунтах");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion

            #region 7. Ввести длину, ширину и высоту комнаты. Подсчитать, сколько краски уйдет на покраску стен этой комнаты, если на 1м2 стены приходится 0.5 литра краски и 20% поверхности стен занимают окна и двери.
            /*double length;
            double width;
            double height;
            const double notSurface = 0.2; // % отношение дверей и окон
            const double paintsOnOneMeter = 0.5; // л. краски на 1м2

            Console.WriteLine("Введите длину комнаты");
            do
            {
                Console.Write("> ");
                length = Convert.ToDouble(Console.ReadLine());
            } while (length <= 0);
            Console.WriteLine("Введите ширину комнаты");
            do
            {
                Console.Write("> ");
                width = Convert.ToDouble(Console.ReadLine());
            } while (width <= 0);
            Console.WriteLine("Введите высоту комнаты");
            do
            {
                Console.Write("> ");
                height = Convert.ToDouble(Console.ReadLine());
            } while (height <= 0);
            
            double wallArea = (height * width) + (height * length); // площадь комнаты
            double netWallArea = wallArea - (wallArea * notSurface); // площадь стен без учета дверей и окон
            double countAllPaints = netWallArea * paintsOnOneMeter; // всего краски уйдёт

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Площадь стен комнаты {netWallArea} м2");
            Console.WriteLine($"На покраску всех стен комнаты площадью {netWallArea} м2 уйдёт {countAllPaints} литров краски");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion

            #region 8. Ввести с клавиатуры 3-значное число и «перевернуть» его (например, ввести 357 – получить и вывести 753).
            /*int number;

            Console.WriteLine("Введите 3-значное число");
            do
            {
                Console.Write("> ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number < 100 || number > 999);

            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;

            int reversedNumber = thirdDigit * 100 + secondDigit * 10 + firstDigit;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Перевёрнутое число: {reversedNumber}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion

            #region 9. Ввести пятизначное число и сдвинуть его циклически вправо на 2 разряда (например, ввести число 12345 – получить и вывести 45123)
            /*int number;

            Console.WriteLine("Введите 5-значное число");
            do
            {
                Console.Write("> ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number < 10000 || number > 99999);
            
            int firstTwoDigits = number / 100;
            int lastThreeDigits = number % 100;
            int resultNumber = lastThreeDigits * 1000 + firstTwoDigits;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Число сдвинутое на два разряда вправо: {resultNumber}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion

            #region 10. Ввести пятизначное число и сдвинуть его циклически влево на 2 разряда (например, ввести число 12345 – получить и вывести 34512).
            int number;

            Console.WriteLine("Введите 5-значное число");
            do
            {
                Console.Write("> ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number < 10000 || number > 99999);

            int firstTwoDigits = number / 1000;
            int lastThreeDigits = number % 1000;
            int resultNumber = lastThreeDigits * 100 + firstTwoDigits;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Число сдвинутое на два разряда вправо: {resultNumber}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

        }
    }
}
