using System; 
using System.Collections.Generic;
class URI {

    static void Main(string[] args) { 


                   string SentencaOriginal;
           
            int Repeticao = 0;

            List<string> SentencaFinal = new List<string> { };           
            while (!string.IsNullOrWhiteSpace(SentencaOriginal = Console.ReadLine()))
            {
                bool CondVerificador = true;
                string SentencaMod = "";
                char[] VetordeCaracteres = SentencaOriginal.ToCharArray();
                for (int i = 0; i < VetordeCaracteres.Length; i++)
                {
                    if (VetordeCaracteres[i] != ' ')
                    {
                        if (CondVerificador)
                        {
                            SentencaMod += char.ToUpper(VetordeCaracteres[i]);
                        }
                        else
                        {
                            SentencaMod += char.ToLower(VetordeCaracteres[i]);
                           
                        }
                        CondVerificador = !CondVerificador;
                    }
                    else
                    {
                        SentencaMod += " ";
                    }
                }
                SentencaFinal.Insert(Repeticao, SentencaMod);
                Repeticao++;
            }
            for (int j = 0; j < Repeticao; j++)
            {
                Console.Write(SentencaFinal[j]);
                Console.WriteLine();
            }

    }

}