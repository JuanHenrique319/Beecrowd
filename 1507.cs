using System;
using System.Text;

class URI
{
    static void Main(string[] args)
    {
        int N, Z;
        N = int.Parse(Console.ReadLine());
        string R, S;

        for (int i = 0; i < N; i++)
        {

            R = Console.ReadLine();
            Z = int.Parse(Console.ReadLine());
            StringBuilder impressao = new StringBuilder();

            for (int j = 0; j < Z; j++)
            {

                S = Console.ReadLine();
                if (R.Contains(S))
                {
                    impressao.AppendLine("Yes");
                }
                else
                {
                    impressao.AppendLine("No");
                }
            }
            Console.WriteLine(impressao);

        }

    }
}