using System;
using System.Collections.Generic;

namespace Практика4._5
{
    class Task1
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> countryLookup = new Dictionary<int, String>();
            countryLookup[44] = "United Kingdom"; 
            countryLookup[33] = "France"; 
            countryLookup[31] = "Netherlands"; 
            countryLookup[55] = "Brazil"; 
            countryLookup[64] = "New Zealand";

            Console.WriteLine("The 31 Code is for: {0}", countryLookup[31]);
            Console.WriteLine("The 33 Code is for: {0}", countryLookup[33]);
            Console.WriteLine("The 44 Code is for: {0}", countryLookup[44]);
            Console.WriteLine("The 55 Code is for: {0}", countryLookup[55]);
            Console.WriteLine("The 64 Code is for: {0}", countryLookup[64]);
            foreach (KeyValuePair<int, String> item in countryLookup)
            {
                int code = item.Key;
                string country = item.Value;
                Console.WriteLine("Code {0} = {1}", code, country);
            }

            Console.Read();

        }
    }
}
