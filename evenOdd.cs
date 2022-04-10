    internal class pro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            if (num%2==0)
            {
                Console.WriteLine("Number is even");

            }
            else
            {
                Console.WriteLine("number is not even");
            }

        }
    }

}