class GerenciadorLogico(string pastaRaiz, string arquivoBase, string linguagem)
{
    private string pastaRaiz = pastaRaiz;
    private string arquivoBase = arquivoBase;
    private string linguagem = linguagem;
    private Preprocessador preprocessador;

    public void listaDeFuncoes()
    {
        this.preprocessador = new Preprocessador(this.pastaRaiz + this.arquivoBase);
        string[] funcoes = this.preprocessador.listarFuncoes();
    }
}