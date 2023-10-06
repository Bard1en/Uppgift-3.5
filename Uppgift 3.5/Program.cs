using System;
  namespace Uppgift3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in två tal");
            string siffror = Console.ReadLine();
            int mellanslagsindex = siffror.IndexOf(" ");

            string tal3 = siffror[..mellanslagsindex];
            string tal4 = siffror[(mellanslagsindex + 1)..];
            int tal1 = int.Parse(tal3);
            int tal2 = int.Parse(tal4);
            Console.WriteLine("Välj ett räknesätt genom att skriva in numret framför räknesättet");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string räknesätt = Console.ReadLine();
            switch (räknesätt)
            {
                case "1":
                    {
                        Console.WriteLine(tal1 + tal2);
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine(tal1 - tal2);
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine(tal1 * tal2);
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine(tal1 / tal2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Du skrev inte in något av räknesätten");
                        break;
                    }
                    {
                        Console.ReadKey();
                    }

            }




        }
    }
}