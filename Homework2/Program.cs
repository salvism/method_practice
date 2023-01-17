using System;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region task1

            //- Verilmiş N tam ədədinin rəqəmləri cəmini tapan metod 

            //int n;
            //Console.Write("N: ");
            //string nStr = Console.ReadLine();
            //n = Convert.ToInt32(nStr);

            //var sum = SumOfDigits(n);

            //Console.WriteLine(sum);

            #endregion

            #region task2

            //- Verilmiş M dəyərindən verilmiş N dəyərinədək 21-ə bölünən ədədlərin ədədi ortasını tapan metod  

            //int m, n;
            //Console.Write("M: ");
            //string mStr = Console.ReadLine();
            //m = Convert.ToInt32(mStr);

            //Console.Write("N: ");
            //string nStr = Console.ReadLine();
            //n = Convert.ToInt32(nStr);

            //var averageOfMN = Average(m, n);

            //Console.WriteLine(averageOfMN);


            #endregion

            #region task3

            //- Verilmis yazıda a herfi olub olmadigini tapan metod


            Console.WriteLine("Enter something: ");
            string word = Console.ReadLine();

            var checkWord = findA(word);
            Console.WriteLine(checkWord);

           
            #endregion


        }

        static int SumOfDigits(int number)
        {
            int sumofDigits = 0;
            while (number > 0)
            {
                var lastDigit = number % 10;
                sumofDigits += lastDigit;
                number /= 10;
            }

            return sumofDigits;

        }

        static double Average(int num1, int num2)
        {
            int sum = 0;
            double count = 0;

            for (int i = num1; i < num2; i++)
            {
                if (i % 21 == 0)
                {
                    sum += i;
                    count++;
                }
            }

            if (count != 0)
            {
                var result = sum / count;
                return result;
            }
            else
            {
                return count;
            }
        }

        static bool findA(string word)
        {
            bool letterA = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'A')
                {
                    letterA = true;
                    break;
                }
            }

            if (letterA == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
