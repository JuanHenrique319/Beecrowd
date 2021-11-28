using System; 

class URI {

    static void Main(string[] args) { 

     int a, b, c;
            int MaiorAb, Maiorfinal;
            String entrada =Console.ReadLine();
            String[] valor = entrada.Split(' ');

             a = int.Parse(valor[0]);
             b = int.Parse(valor[1]);
             c = int.Parse(valor[2]);
             
            MaiorAb = (a + b + Math.Abs(a - b)) / 2;
            Maiorfinal = (MaiorAb + c + Math.Abs(MaiorAb - c)) / 2;
            Console.WriteLine(Maiorfinal + " eh o maior");
    }

}