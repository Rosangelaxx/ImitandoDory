using System;
using System.Text;

class ImitandoDory
{
    static string TraduzirParaBaleies(string texto)
    {
        string vogais = "aeiouAEIOUáéíóúÁÉÍÓÚâêîôûÂÊÎÔÛãõÃÕ";
        StringBuilder resultado = new StringBuilder();

        foreach (char letra in texto)
        {
            if (vogais.IndexOf(letra) >= 0)
            {
                resultado.Append(letra, 3);
            }
            else
            {
                resultado.Append(letra);
            }
        }

        return resultado.ToString();
    }

    static void Main()
    {
        Console.Write("Digite o texto: ");
        string texto = Console.ReadLine() ?? "";

        string traduzido = TraduzirParaBaleies(texto);
        Console.WriteLine(traduzido);
    }
}