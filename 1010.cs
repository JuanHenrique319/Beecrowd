using System; 
using System.Globalization;
class URI {

    static void Main(string[] args) { 

   CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
             
        double total;

        String[] peca1 = Console.ReadLine().Split(' ');

        int Tipo = int.Parse(peca1[0]);
        int Qtd = int.Parse(peca1[1]);
        double valorUni = double.Parse(peca1[2]);

        String[] peca2 = Console.ReadLine().Split(' ');

        int Tipo2 = int.Parse(peca2[0]);
        int Qtd2 = int.Parse(peca2[1]);
        double valorUni2 = double.Parse(peca2[2]);

        total = (Qtd*valorUni) + (Qtd2 * valorUni2);
        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));


    }

}