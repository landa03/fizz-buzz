using System;

namespace fizz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int num = 1; num <= 100; num++)
            {
                if(num % 5 ==0 && num % 3 ==0) 
                {
                   Console.WriteLine("FIZZBUZZ");
                }    
                else if(num % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                
                else if(num % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
