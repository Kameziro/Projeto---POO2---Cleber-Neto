using System.Linq.Expressions;
using Atacado.BD.EF.Database;
using Microsoft.EntityFrameworkCore;

namespace Atacado.Repositorio;

public class CategoriaRepo : BaseAtacadoContextoRepo<Categoria>
{
    public CategoriaRepo(AtacadoContext ctx) : base(ctx)
    {
    }

    public override Categoria Create(Categoria obj)
    {
        this.contexto.Categorias.Add(obj);
        this.contexto.SaveChanges();
        return obj;
    }

    public override Categoria Delete(int codigo)
    {
        Categoria alvo = this.Read(codigo);
        this.contexto.Categorias.Remove(alvo);
        this.contexto.SaveChanges();
        return alvo;
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override Categoria Read(int codigo)
    {
        return this.contexto.Categorias.SingleOrDefault(item => item.Codigo == codigo);
    }

    public override List<Categoria> Read()
    {
        return this.contexto.Categorias.ToList();
    }

    public override List<Categoria> Read(Expression<Func<Categoria, bool>> predicado)
    {
        return this.contexto.Categorias.Where(predicado).ToList();
    }

    public override Categoria Update(Categoria obj)
    {
        this.contexto.Categorias.Attach(obj);
        this.contexto.Entry<Categoria>(obj).State = EntityState.Modified;
        this.contexto.SaveChanges();
        return obj;
    }
}
