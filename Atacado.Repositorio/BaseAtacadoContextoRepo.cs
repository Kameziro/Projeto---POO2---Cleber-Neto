using Atacado.BD.EF.Database;

namespace Atacado.Repositorio;

public abstract class BaseAtacadoContextoRepo<TTipo> : BaseRepositorio<TTipo> where TTipo : class
{
    protected AtacadoContext contexto;

    public BaseAtacadoContextoRepo(AtacadoContext ctx) : base()
    {
        this.contexto = ctx;
    }

}
