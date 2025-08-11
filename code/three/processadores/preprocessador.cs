using System;
using System.Text.RegularExpressions;

public class Preprocessador
{
    string caminhoArquivoBase = "";

    public Preprocessador(string caminhoArquivoBase)
    {
        this.caminhoArquivoBase = caminhoArquivoBase;
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
            return "";
        }
    }
    public string[] listarFuncoes()
    {
        string[] valorPreprocessado = this.fazerPreProcessamentoFuncoes();
        this.gerarTxtCacheArquivo(string.Join(Environment.NewLine, valorPreprocessado));
        return valorPreprocessado;
        
    }
    private void gerarTxtCacheArquivo(String conteudo)
    {
        //Trocar para fazer a limpa dos espaços em branco
        //string caminhoArquivoCache = this.caminhoArquivoBase + "/cache/";
        //fazer ele criar o caminho caso nao exista
        string caminhoArquivoCache = "C:/Users/usuario/Desktop/three patchs/code/three/src/fontes auxiliares/cache/testeDeFuncoes.txt";
        File.WriteAllText(caminhoArquivoCache, conteudo);
    }
    private string[] fazerPreProcessamentoFuncoes()
    {
        string conteudo = GetConteudoArquivo(this.caminhoArquivoBase);

        // conteudo = Regex.Replace(conteudo, @"[ \t]+", "");
        // Console.WriteLine(conteudo);
        string padrao = @"(?is)procedure\s+([\w-]+)\s*:\s*.*?end\s+procedure\.";
        Regex regex = new Regex(padrao, RegexOptions.Compiled);

        MatchCollection matches = regex.Matches(conteudo);

        foreach (Match match in matches)
        {
            string nome = match.Groups[1].Value;
            int inicio = match.Index;
            int fim = match.Index + match.Length;
            Console.WriteLine($"{nome}: inicia em {inicio}, termina em {fim}");
        }

        return regex.Matches(conteudo).Cast<Match>().Select(m => m.Groups[1].Value).ToArray();
    }

}