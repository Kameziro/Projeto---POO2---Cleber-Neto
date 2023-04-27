namespace Atacado.Repositorio;

public abstract class BaseRepositorio<TEntidade> where TEntidade : class
{
    //CRUD
    public abstract TEntidade Create(TEntidade obj);

    public abstract TEntidade Read(int codigo);

    public abstract List<TEntidade> Read();

    public abstract TEntidade Update(TEntidade obj);
    
    public abstract TEntidade Delete(int codigo);
}
