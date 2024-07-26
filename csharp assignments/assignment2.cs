using System;
namespace Datatype
{
    public class assignment2
    {
        public int getans(string s)
        {
            int min = 0, minindex = -1;
            for (int i = 0; i < s.Length - 4; i++)
            {
                int k = (int)s[i] - '0';
                int k2 = (int)s[i + 1] - '0';
                int k3 = (int)s[i + 2] - '0';
                int k4 = (int)s[i + 3] - '0';
                int p = k * k2 * k3 * k4;
                if (min < p)
                {
                    min = p;
                    minindex = i;
                }
            }
            return min;
        }
        public static void Main()
        {
            string s ="1234568987458744574664554";
            assignment2 s2 = new assignment2();
            int ans = s2.getans(s);
            Console.WriteLine("{0}",ans);
        }
    }
}