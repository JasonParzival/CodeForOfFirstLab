namespace TheSecondCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var smth = 124345;
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
            if (forif)
            {
                Console.WriteLine("Последовательность: " + str + " положительна!");
            }
            else
            {
                Console.WriteLine("Последовательность: " + str + " отрицательна!");
            }
        }
    }
}
