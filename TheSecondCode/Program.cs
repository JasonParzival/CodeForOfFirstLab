using System.ComponentModel.Design;

//Установить, является ли последовательность цифр при просмотре их слева направо упорядоченной по возрастанию.
//Например, для последовательности 1,4,7,8 ответ положительный, для чисел 1,7,8,2 и 1,6,6,8 — отрицательный и т. п.

namespace TheSecondCode
{
    public class Logic
    {
        public static bool Check(string smth)
        {
            bool forif = true;
            for (int i = 1; i < smth.Length; i++)
            {
                if ((int)Char.GetNumericValue(smth[i - 1]) < (int)Char.GetNumericValue(smth[i]))
                {
                    forif = true;
                }
                else
                {
                    forif = false;
                    break;
                }
            }
            return forif;
        }

        public static string Message(string smth)
        {
            string message = "";

            if (Logic.Check(smth))
            {
                message = "Последовательность: " + smth + " положительна!";
            }
            else
            {
                message = "Последовательность: " + smth + " отрицательна!";
            }
            return message;
        }

        public static string IsDigitMessage(string smth)
        {
            string message;

            if (smth.All(char.IsDigit))
            {
                message = Logic.Message(smth);
            }
            else
            {
                message = "Введённая строка не являются цифрой";
            }
            return message;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string smth = Console.ReadLine();

            string message = Logic.IsDigitMessage(smth);  
            
            Console.WriteLine(message);
        }
    }
}
