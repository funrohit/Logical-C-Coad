   internal class pro
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("Fact is = "+fact);
        }
    }
}