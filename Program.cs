using System;
using System.Text;

namespace Cutcake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ans=new StringBuilder();
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                ans.AppendLine(Cut(N).ToString());  
            }
            Console.WriteLine(ans.ToString());
            
            
        }
        static int Cut(int N)
        {
            int i = 3,X;
            
            if (N <= 1) { return 0; }
            if (N == 2) { return 1; }
            else
            {
                X = 2;
                while (i <= N) 
                    {
                        i += X;
                        if (i > N)
                        {
                            return X;
                        }
                        X++;
                    }
                return X;
            }  
        }
    }
}



