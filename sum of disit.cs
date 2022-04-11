    internal class pro
    {
        static void Main(string[] args)
        {
            int rem, sum = 0;
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }

            Console.WriteLine("sum of disit=="+sum);
        }
    }
}