using System;
namespace PrimeNumber
{
    public class Program
    {
       public static void Main(string[]args)
        {
            // Traverse till i*i <= N instead of i <= N for
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt16(Console.ReadLine()); 
            int count = 0;
            
            for (int i = 1; i <=num; i++)

                
            {
                if(num % i == 0)
                {
                    count++;
                }
                

            }
            if(count==2)
            {
                Console.WriteLine("number is prime");
            }
            else
            {
                Console.WriteLine("number is not prime");
            }
        }
    }
}





