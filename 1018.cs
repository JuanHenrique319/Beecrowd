using System; 
using System.Globalization;
class URI {

    static void Main(string[] args) { 

           CultureInfo culture = new CultureInfo("pt-BR");

            int[] Notas = new int[] { 100, 50, 20, 10, 5, 2, 1 }, QtdNotasT = new int[7];     
            int valor;
            int.TryParse(Console.ReadLine(), out valor);
            int IMvalor = valor;
            for (int i = 0; i < Notas.Length; i++)
            {
                if ((IMvalor / Notas[i]) > 0)
                {
                    QtdNotasT[i] = (IMvalor / Notas[i]);
                    IMvalor = IMvalor % Notas[i];
                }
                else
                {
                    QtdNotasT[i] = 0;
                }
            }

            Console.WriteLine(String.Format("{0}", valor));
            for (int i = 0; i < Notas.Length; i++)
            {
                Console.WriteLine(String.Format("{0} nota(s) de R$ {1}", QtdNotasT[i], (double.Parse(Notas[i].ToString())).ToString("F2", culture)));
            }

    }

}