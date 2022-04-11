   internal class pro
    {
        static void Main(string[] args)
        {
            int rem,rev=0;
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;

            }
            Console.WriteLine("rev is = "+rev);
           
        }
    }
}