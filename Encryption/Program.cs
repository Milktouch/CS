using System;

namespace encryption__3._1
{
    public class encryption
    {
        public static string flipwhole(string m)
        {
            string nm = "";
            char b;
            int a = 0;
            for (int i = 0; i < m.Length; i++)
            {
                a = m.Length - i - 1;
                b = m[a];
                nm += (char)b;
            }
            return nm;
        }
        public static String zigzagen(String m)
        {
            String nm = "";

            for (int i = 0; i < m.Length; i++)
            {
                if (i % 2 == 0)
                {
                    nm += m[i];
                }

            }
            nm += " ";
            for (int i = 0; i < m.Length; i++)
            {
                if (i % 2 == 1)
                {
                    nm += m[i];
                }

            }
            return nm;
        }
        public static String zigzagde(String m)
        {
            String m1, m2, nm = "";
            String[] arr = m.Split(" ");
            m1 = arr[0];
            m2 = arr[1];
            for (int i = 0; i < m1.Length; i++)
            {
                nm += m1[i];
                if (i < m2.Length)
                {
                    nm += m2[i];

                }
            }
            return nm;
        }
        public static string flipword(string[] arr)
        {
            string m = "", nm = "";
            char a;
            int index;
            for (int j = 0; j < arr.Length; j++)
            {
                m = arr[j];
                for (int i = 0; i < m.Length; i++)
                {
                    index = m.Length - i - 1;
                    a = m[index];
                    nm += (char)a;
                }
            }
            return nm;
        }
        public static string addspace(string m)
        {
            int b = 0;
            string nm = "";
            for (int i = 0; i < m.Length; i++)
            {
                if (b == 4)
                {
                    nm += " ";
                    b = 0;
                }
                nm += (char)(m[i]);
                b++;
            }
            return nm;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            int c, s = 1;
            char a;
            String m, nm = "";
            Console.WriteLine("Enter the message:");
            m = Console.ReadLine();
           
            Console.WriteLine("Type 1 for encryption or 2 for decryption:");
            c = int.Parse(Console.ReadLine());
            if (c == 1)
            {
                for (int i = 0; i < m.Length; i++)
                {
                    a = m[i];
                    nm += (char)(a + s);
                    if (s > 0)
                    {
                        
                        
                        s += 1;
                    }
                    else if (s < 0)
                    {
                       
                        s -= 1;
                    }
                    s = -s;
                }
                nm = encryption.flipwhole(nm);
                
                nm = encryption.addspace(nm);
                String[] arr = nm.Split(" ");
                nm = encryption.flipword(arr);
                nm = encryption.zigzagen(nm);
            }
            if (c == 2)
            {
                m = encryption.zigzagde(m);
                m = encryption.addspace(m);
                String[] arr = m.Split(" ");
                m = encryption.flipword(arr);
                m = encryption.flipwhole(m);
                for (int i = 0; i < m.Length; i++)
                {
                    a = m[i];
                    nm += (char)(a -  s);
                    if (s > 0)
                    {
                        
                        s += 1;
                    }
                    else if (s < 0)
                    {
                        
                        s -= 1;
                    }
                    s = -s;
                }
                nm = nm.Replace(":", " ");
            }
            Console.WriteLine(nm);

        }
    }
}
