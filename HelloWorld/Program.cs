namespace HelloWorld
{
    internal class Program
    {
        /// <summary>
        /// Day la ham main 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // OperatorExamples();
            TrySomeLoops();
        }

        private static void OperatorExamples()
        {
            int width = 3;

            width++;

            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            bool truthValue = true;
            Console.WriteLine(truthValue);
        }
        private static void TrySomeLoops()
        {
            int count = 0;
            while (count < 10)
            {
                count++;
            }
            for (int i = 0; i < 5; i++)
            {
                count--;
            }
            Console.WriteLine($"The answer is {count}.");
        }
    }
}