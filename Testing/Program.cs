using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testing
{
    class B : ICloneable
    {
        public int a;
        public int[,] b;
        public B(int a, int[,] b)
        {
            this.a = a;
            this.b = b;
        }
        public object Clone()
        {
            B bCopy = (B)this.MemberwiseClone();
            int[,] temp = new int[2, 3];
            Array.Copy(this.b, temp, this.b.Length);
            bCopy.b = temp;
            return bCopy;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int[,] arr = { {2, 3, 4}, {1, 3, 7} };
            B b = new B(3, arr);
            //int arr1 = (int)arr.Sum();
            B b1 = (B)b.Clone();
            b1.b[0, 0] = 4;
            b1.a = 8;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", b.b[i, j].ToString());
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
