using Atacado.BD.EF.Database;

namespace Atacado.Servico;

public abstract class BaseAtacadoContextoServico<T1, T2> : BaseServico<T1, T2> where T1 : class where T2 : class
{
    protected AtacadoContext contexto;

    public BaseAtacadoContextoServico(AtacadoContext ctx) : base()
    {
        this.contexto = ctx;
    }
}
