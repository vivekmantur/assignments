using System;
using System.Runtime.Intrinsics.Arm;
using oops;

namespace assignment
{
    class assignment3
    {
        public static int bintoint(string s)
        {
            int decimalValue=0;
            int power=0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '1')
                {
                    decimalValue += (int)Math.Pow(2, power);
                }
                power++;
            }
            return decimalValue;
        }

        public static string floattobin(float n)
        {
            string a = "";
            while (n > 0)
            {
                n = n * 2;
                int k = (int)n;
                a += k;
                n -= k;
                if (a.Length > 32) break;
            }
            return a;
        }
        public static float bintofloat(string s)
        {
            int i = -1;
            float res = 0.0f;
            for (int j = 0; j < s.Length; j++)
            {
                int t = s[j] - '0';
                res += (float)(t * Math.Pow(2, i));
                i--;
            }
            return res;
        }
        public static string binadd(string a, string b)
        {
            int i = a.Length - 1, j = b.Length - 1;
            string st = "";
            int carry = 0;
            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (i >= 0) sum += a[i--] - '0';
                if (j >= 0) sum += b[j--] - '0';
                st = (sum % 2) + st;
                carry = sum / 2;
            }
            if (carry != 0)
            {
                st = carry + st;
            }
            return st;
        }

        public static string inttobin(int n)
        {
            string a = "";
            while (n > 0)
            {
                int r = n % 2;
                a = r + a;
                n = n / 2;
            }
            return a == "" ? "0" : a;
        }

        public static string reverse(string s)
        {
            string st = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                st = st + s[i];
            }
            return st;
        }
        public static string padZeros(string str, int length)
        {

            while (str.Length < length)
            {
                str = "0" + str;
            }
            return str;
        }
        public static int getmaxfractionalpartdigits(string s, string s1)
        {
            int l1 = s.IndexOf('.') + 1;
            int l2 = s1.IndexOf('.') + 1;
            int c1 = 0;
            int c2 = 0;
            while (l1 < s.Length)
            {
                c1++;
                l1++;
            }
            while (l2 < s1.Length)
            {
                c2++;
                l2++;
            }
            return Math.Max(c1, c2);
        }

        public static void Main()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            float m = float.Parse(input1);
            float n = float.Parse(input2);
            string s = m.ToString();
            string s1 = n.ToString();
            //converting m to binary
            string[] str = s.Split('.');
            int x = Convert.ToInt32(str[0]);
            float y = float.Parse("0." + str[1]);
            string sp1 = inttobin(x);
            string sp2 = floattobin(y);
            string sp = sp1 + "." + sp2;
            //cnverting n to binary
            string[] str1 = s1.Split('.');
            int x1 = Convert.ToInt32(str1[0]);
            float y1 = float.Parse("0." + str1[1]);
            string sk1 = inttobin(x1);
            string sk2 = floattobin(y1);
            string sk = sk1 + "." + sk2;
            //making the fraction part zero equal 
            int maxLength = Math.Max(sp2.Length, sk2.Length);
            sp2 = sp2.PadRight(maxLength, '0');
            sk2 = sk2.PadRight(maxLength, '0');
            sp = sp1 + "." + sp2;
            sk = sk1 + "." + sk2;
            char ch = '.';
            string spr = sp.Replace(ch.ToString(), "");
            string skr=sk.Replace(ch.ToString(), "");
            maxLength = Math.Max(sp1.Length + sp2.Length, sk1.Length + sk2.Length);
            string paddedSp2 = padZeros(spr, maxLength);
            string paddedSk2 = padZeros(skr, maxLength);
            string num = binadd(paddedSp2, paddedSk2);
            
            int dot = getmaxfractionalpartdigits(s, s1);
     
            string ipart = "";
            string fpart = "";
            for(int i=0;i<num.Length;i++)
            {
                if(i<num.Length-dot)
                {
                    ipart = ipart + num[i];
                }
                else
                {
                    fpart = fpart + num[i];
                }
            }
            int finalint = bintoint(ipart);
            float finalfloat = bintofloat(fpart);
            float f = finalint + finalfloat;
            Console.WriteLine("{0}",f);
        }
    }
}
