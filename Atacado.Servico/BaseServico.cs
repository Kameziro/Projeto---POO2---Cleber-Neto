namespace Atacado.Servico;

public abstract class BaseServico<TPoco, TDominioEF> where TPoco : class where TDominioEF : class
{
    public abstract List<TPoco> Listar();

    public abstract TPoco Ler(int chave);

    public abstract TPoco Inserir(TPoco poco);

    public abstract TPoco Alterar(TPoco poco);

    public abstract TPoco Excluir(int chave);

    public abstract TPoco Converter(TDominioEF dom);

    public abstract TDominioEF Converter(TPoco poco);
}
