using System;
using System.Collections.Generic;

namespace nextGreater
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = "";
            int temp = 0;
            List<int> usrInts = new List<int>();
            Console.WriteLine("Enter array:");
            input = Console.ReadLine();
            foreach(char c in input)
            {
                if(Char.IsDigit(c))
                {
                    temp = int.Parse(c.ToString());
                    usrInts.Add(temp);
                }
            }
            int[] results = new int[usrInts.Count];
            for (int i = 0; i < usrInts.Count; i++)
            {
                for(int j = i; j < usrInts.Count; j++)
                {
                    if(usrInts[i] < usrInts[j])
                    {
                        results[i] = usrInts[j];
                        break;
                    }
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", results));
        }
    }
}