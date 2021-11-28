using System; 
using System.Text;
using System.Linq;
using System.Collections.Generic;
class URI {

    static void Main(string[] args) { 


            string SentecaOriginal;
            StringBuilder Impressao = new StringBuilder();
            while (!string.IsNullOrEmpty(SentecaOriginal = Console.ReadLine()))
            {
                List<char> VetordeCaracteres = new List<char>();
                VetordeCaracteres.AddRange(SentecaOriginal);
                Dictionary<char, int> Dicionario = new Dictionary<char, int>();
                foreach (char caracter in VetordeCaracteres)
                {
                    if (Dicionario.ContainsKey(caracter))
                    {
                        Dicionario[caracter]++;
                    }
                    else
                    {
                        Dicionario.Add(caracter, 1);
                    }
                }
                foreach (KeyValuePair<char, int> caracter in Dicionario.OrderBy(d => d.Value))
                {
                    Impressao.AppendLine($"{(int)caracter.Key} {caracter.Value}");
                }
                Impressao.AppendLine();
            }
            Console.Write(Impressao);
        }

    }