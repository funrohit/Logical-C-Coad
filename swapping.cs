   internal class pro
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("enter the number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the number");
            int num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;


            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}