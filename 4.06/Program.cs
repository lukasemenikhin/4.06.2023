//pirveli

//{
//    switch (word.ToLower())
//    {
//        case "zero":
//            return 0;
//        case "one":
//            return 1;
//        case "two":
//            return 2;
//        case "three":
//            return 3;
//        case "four":
//            return 4;
//        case "five":
//            return 5;
//        case "six":
//            return 6;
//        case "seven":
//            return 7;
//    }





//mesame


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("shemoitanet mteli ricxvi:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int n))
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("shemoitanet mteli ricxvi:");
                string numberInput = Console.ReadLine();

                if (int.TryParse(numberInput, out int number))
                {
                    sum += number;
                }
            }

            double average = (double)sum / n;
            Console.WriteLine("mteli ricxvebis jami: " + sum);
            Console.WriteLine("sashualo: " + average);
        }
        













////mexute

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("shemoitanet ricxvi:");
//        if (int.TryParse(Console.ReadLine(), out int n))
//        {
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine("shemoitane ricxvi" );
//                if (int.TryParse(Console.ReadLine(), out int number))
//                {
//                    int square = number * number;
//                    Console.WriteLine("kvadrati: " + square);
//                }

//        }

//    }

