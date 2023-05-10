using Atacado.BD.EF.Database;
using Microsoft.EntityFrameworkCore;

namespace Atacado.Repositorio;

public class SubcategoriaRepo : BaseAtacadoContextoRepo<Subcategoria>
{
    public SubcategoriaRepo(AtacadoContext ctx) : base(ctx)
    {
    }

    public override Subcategoria Create(Subcategoria obj)
    {
        this.contexto.Subcategorias.Add(obj);
        this.contexto.SaveChanges();
        return obj;
    }

    public override Subcategoria Delete(int codigo)
    {
        Subcategoria alvo = this.Read(codigo);
        this.contexto.Subcategorias.Remove(alvo);
        this.contexto.SaveChanges();
        return alvo;
    }

    public override Subcategoria Read(int codigo)
    {
        return this.contexto.Subcategorias.SingleOrDefault(item => item.Codigo == codigo);
    }

    public override List<Subcategoria> Read()
    {
        return this.contexto.Subcategorias.ToList();
    }

    public override Subcategoria Update(Subcategoria obj)
    {
        this.contexto.Subcategorias.Attach(obj);
        this.contexto.Entry<Subcategoria>(obj).State = EntityState.Modified;
        this.contexto.SaveChanges();
        return obj;
    }
}