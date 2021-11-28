using System; 
using static System.Console;
using System.Linq;
class URI {

    static void Main(string[] args) { 

            long ImparePares = long.Parse(ReadLine());
            long[] VetorIP = new long[ImparePares];
            for (long i = 0; i < VetorIP.Length; i++) {
                VetorIP[i] = long.Parse(ReadLine()); 
            }
            foreach (var X in VetorIP.Where(x => x % 2 == 0).OrderBy(x => x))
            {
                WriteLine(X);
            }
            foreach (var X in VetorIP.Where(x => x % 2 != 0).OrderByDescending(x => x))
            {
                WriteLine(X);
            }

    }

}