using System; 

class URI {

    static void Main(string[] args) { 


            int FabricaS, hora, minuto, segundo, sobras;
            FabricaS = int.Parse(Console.ReadLine());
            hora = FabricaS / 3600;
            sobras = FabricaS % 3600;
            minuto = sobras / 60;
            sobras = sobras % 60;
            segundo = sobras;

            Console.WriteLine(hora+":"+minuto+":"+segundo);
    }

}