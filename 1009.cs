using System; 
using System.Globalization;
class URI {

    static void Main(string[] args) { 

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            string Nome;
            double Salario;
            double Vendas;
            double Porcentual;
            Nome = Console.ReadLine();
            Salario = double.Parse(Console.ReadLine());            
            Vendas = double.Parse(Console.ReadLine());
            Porcentual = Vendas * (15.0 / 100.0);
            Salario = Salario + Porcentual;         
            Console.WriteLine("TOTAL = R$ "+ Salario.ToString("F2"));
    }

}