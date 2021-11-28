using System; 
using System.Globalization;
class URI {

    static void Main(string[] args) { 

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            double[] Notas = { 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            int QtdNotasT;
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("NOTAS:");
            for (int i = 0; i < 6; i++)
            {
                QtdNotasT = (int)(valor / Notas[i]);
                Console.WriteLine(QtdNotasT + " nota(s) de R$ " + Notas[i].ToString("0.00"));
                valor -= QtdNotasT * Notas[i];
                valor = Math.Round(valor, 2);
            }
            Console.WriteLine("MOEDAS:");
            for (int i = 6; i < Notas.Length; i++)
            {
                QtdNotasT = (int)(valor / Notas[i]);
                Console.WriteLine(QtdNotasT + " moeda(s) de R$ " + Notas[i].ToString("0.00"));
                valor -= QtdNotasT * Notas[i];
                valor = Math.Round(valor, 2);
            }
    }

}