using System;

namespace assignment
{
    public class assignment1
    {
        public int getans(string s, string s2)
        {
            int count = 0;
            int l = s.Length;
            int l2 = s2.Length;
            for (int i = 0; i < l - l2; i++)
            {
                int j = i;
                string str = "";
                for (int k = j; k < i + l2; k++)
                {
                    str = str + s[k];
                }
                if (str == s2)
                {
                    Console.Write("{0} ", i);
                    count++;
                }

            }
            return count;
        }
        public static void Main(string[] args)
        {
            
            string s = Console.ReadLine();
            string s2 = Console.ReadLine();
            assignment1 g = new assignment1();
            int count = g.getans(s, s2);
            Console.WriteLine("\n{0}", count);

        }
    }
}
