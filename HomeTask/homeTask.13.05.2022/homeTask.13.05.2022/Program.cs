using System;
class Program

{
    
    public static void Main()
    {
         string number = Console.ReadLine();
        int n = int.Parse(number);

        if (IsPrime(n))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
        
    }
        public static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
}


