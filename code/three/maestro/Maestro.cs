class Maestro
{
    private GerenciadorLogico gerenciadorLogico;

    public void PrimeiraExecucao()
    {
        inicializacaoDoPrograma();
        this.gerenciadorLogico.listaDeFuncoes();
    }

    private void inicializacaoDoPrograma()
    {
        /*
            perguntas inciciais para definir o gerenciador lógico.
        */
        string Linguagem = "Progress";
        string caminhoArquivoBase = "C:/Users/usuario/Desktop/three patchs/code/three/src";
        string arquivo = "/fontes auxiliares/cc0300b.p";
        
        this.gerenciadorLogico = new GerenciadorLogico(caminhoArquivoBase, arquivo, Linguagem);
    }
}