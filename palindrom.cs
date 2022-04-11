public class HelloWorld
{
    public static void Main(string[] args)
    {  int rem,rev=0,tempnum=0;
       Console.WriteLine("enter the number");
       int num= int.Parse(Console.ReadLine());
       while(num!=0){
       tempnum=num;
       rem=num%10;
       rev=rev*10+rem;
       num=num/10;
       }
       if (rev==tempnum){
           Console.WriteLine("number is palidrom");
       }
       else{
           Console.WriteLine("number is not palidrom");
       }
    }
}