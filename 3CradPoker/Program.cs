using System;
using System.Collections.Generic;
using System.Linq;
using _3CradPoker.ViewModels;

namespace _3CradPoker
{
    class Program
    {
        static void Main(string[] args)
        {
           var input =  Console.ReadLine();
           if (int.TryParse(input, out int result) && result> 0 && result<= 24)
           {
               var deck = new Deck();
               var dealtCards
                    = deck.Deal(result);
               Console.WriteLine("Hello World!");
           }
           else
           {
               Console.WriteLine("Not a valid input");
           }
      
        }
    }
}
