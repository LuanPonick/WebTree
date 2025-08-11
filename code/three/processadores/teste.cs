using System;
using System.IO;
using System.Text.RegularExpressions;
class teste
{
    public void LogTest()
    {

        string caminhoArquivoBase = "C:/Users/usuario/Desktop/three patchs/code/three/src/fontes auxiliares/testeDeFuncoes.p";
        string conteudo = GetConteudoArquivo(caminhoArquivoBase);

        string padrao = @"(?is)^procedure\s+([\w-]+):.*?end\s+procedure\.";
        Regex regex = new Regex(padrao, RegexOptions.Compiled);
        MatchCollection matches = regex.Matches(conteudo);

        // foreach (Match match in matches)
        // {
        //     string nome = match.Groups[1].Value;
        //     int inicio = match.Index;
        //     int fim = match.Index + match.Length;
        //     Console.WriteLine($"{nome}: inicia em {inicio}, termina em {fim}");
        // }

    }

    private static string GetConteudoArquivo(string caminhoArquivoBase)
    {
        try
        {
            return File.ReadAllText(caminhoArquivoBase);
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um erro: " + e.Message);
            return "error";
        }
    }
}