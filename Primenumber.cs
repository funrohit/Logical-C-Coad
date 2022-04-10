    internal class pro
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

         for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    c++;
                }

            }
            if (c == 2)
            {
                Console.WriteLine("Number is Prime");

            }
            else
            {
                Console.WriteLine("Number is not Prime");

            }
        }