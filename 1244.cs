using System; 
using System.Linq;
using System.Text;
class URI {

    static void Main(string[] args) { 

                StringBuilder Impressao = new StringBuilder();
                string SentencaOriginal;
                int Repeticao = int.Parse(Console.ReadLine());
                for (int i = 0; i < Repeticao; i++)
                    {
                        SentencaOriginal = Console.ReadLine();
                        string[] VetordeCaracteres = SentencaOriginal.Trim().Split();
                        StringBuilder SentencaMod = new StringBuilder();
                        var Ordem = from Sentenca in VetordeCaracteres orderby Sentenca.Length descending select Sentenca;
                        SentencaMod.Clear();
                        foreach (string X in Ordem)
                    {
                        SentencaMod.Append(X + " ");
                    }
                SentencaMod.Remove(SentencaMod.Length - 1, 1);
                Impressao.Append(SentencaMod + "\n");
                }
            Console.Write(Impressao);

    }

}