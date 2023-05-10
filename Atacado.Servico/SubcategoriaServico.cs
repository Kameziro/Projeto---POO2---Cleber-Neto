using Atacado.BD.EF.Database;
using Atacado.Poco;
using Atacado.Repositorio;

namespace Atacado.Servico;

public class SubcategoriaServico : BaseAtacadoContextoServico<SubcategoriaPoco, Subcategoria>
{
    private SubcategoriaRepo repo;
    public SubcategoriaServico(AtacadoContext ctx) : base(ctx)
    {
        this.repo = new SubcategoriaRepo(ctx);
    }

    public override SubcategoriaPoco Alterar(SubcategoriaPoco poco)
    {
        Subcategoria tupla = this.Converter(poco);
        Subcategoria alterado = this.repo.Update(tupla);
        SubcategoriaPoco alteradoPoco = this.Converter(alterado);
        return alteradoPoco;
    }

    public override SubcategoriaPoco Excluir(int chave)
    {
        Subcategoria tupla = this.repo.Delete(chave);
        SubcategoriaPoco apagado = this.Converter(tupla);
        return apagado;
    }

    public override SubcategoriaPoco Inserir(SubcategoriaPoco poco)
    {
        Subcategoria dom = this.Converter(poco);
        Subcategoria novo = this.repo.Create(dom);
        SubcategoriaPoco novoPoco = this.Converter(novo);
        return novoPoco;
    }

    public override SubcategoriaPoco Ler(int chave)
    {
        Subcategoria tupla = this.repo.Read(chave);
        if (tupla == null)
        {
            return null;
        }
        else
        {
            SubcategoriaPoco poco = this.Converter(tupla);
            return poco;
        }
    }

    public override List<SubcategoriaPoco> Listar()
    {
        return this.repo.Read().Select(tupla => this.Converter(tupla)).ToList<SubcategoriaPoco>();
    }

    public override SubcategoriaPoco Converter(Subcategoria dom)
    {
        return new SubcategoriaPoco()
        {
            Codigo = dom.Codigo,
            CodigoCategoria = dom.CodigoCategoria,
            Descricao = dom.Descricao,
            Ativo = dom.Ativo,
            DataInclusao = dom.DataInclusao
        };
    }

    public override Subcategoria Converter(SubcategoriaPoco poco)
    {
        return new Subcategoria()
        {
            Codigo = poco.Codigo,
            CodigoCategoria = poco.CodigoCategoria,
            Descricao = poco.Descricao,
            Ativo = poco.Ativo,
            DataInclusao = poco.DataInclusao
        };
    }
}
