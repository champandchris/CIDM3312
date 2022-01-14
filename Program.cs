using System;
using System.Collections.Generic;

namespace CIDM3312
{
    class Program
    {

        static void Main(string[] args)
        {

            List<int> ListNew = new List<int>();

            List<string> listOfstrings = new List<string>()  {"Soccer" , "Basketball", "football"};

            listOfstrings.Add("Baseball");
            listOfstrings.Add("Hockey");
            listOfstrings.Add("Water Polo");
                
               foreach (string element in listOfstrings)
            {
                Console.WriteLine (element);
            }

        }
    }
}
