using System; 

class URI {

    static void Main(string[] args) { 

            int entrada, ano, mes, dias, sobras;
            entrada = int.Parse(Console.ReadLine());
            ano = entrada / 365;
            sobras = entrada % 365;
            mes = sobras / 30;
            dias = sobras % 30;
            

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dias+ " dia(s)");


            
            
           
    }

}