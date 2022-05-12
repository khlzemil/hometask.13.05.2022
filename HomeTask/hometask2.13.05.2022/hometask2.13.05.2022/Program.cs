using System;

public class Program
{

    public static void Main()
    {
        int[] StudentPoint = { 30, 35, 55, 65, 90, 85 };
        CalcAvg(StudentPoint);
    }

    public static void CalcAvg(int[] StudentPoint)
    {
        int counter = 0;
        float sum = 0;
        float avaragePoint = 0;
        foreach(int element in StudentPoint)
        {
            sum += element;
            counter++;
        }
        avaragePoint = sum / counter;
        Console.WriteLine(avaragePoint);
        if (avaragePoint > 60)
            Console.WriteLine("Məzun oldunuz");
        else
            Console.WriteLine("Məzun ola bilmədiniz");

    }

}