using System.ComponentModel.Design;

namespace TheSecondCode
{
    public class Logic
    {
        public static bool check(int smth)
        {
            string str = smth.ToString();
            bool forif = true;
            for (int i = 1; i < str.Length; i++)
            {
                if ((int)Char.GetNumericValue(str[i - 1]) < (int)Char.GetNumericValue(str[i]))
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

        public static string Message(int smth)
        {
            string message = "";

            if (Logic.check(smth))
            {
                message = "Последовательность: " + smth + " положительна!";
            }
            else
            {
                message = "Последовательность: " + smth + " отрицательна!";
            }
            return message;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var smth = 12345;

            string message = Logic.Message(smth);
            
            Console.WriteLine(message);
        }
    }
}
