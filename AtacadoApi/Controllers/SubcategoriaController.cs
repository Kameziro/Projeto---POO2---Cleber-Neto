using Atacado.BD.EF.Database;
using Atacado.Poco;
using Atacado.Servico;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtacadoApi.Controllers;

[ApiController]
[Route("api/Atacado/Estoque/")]
public class SubcategoriaController : BaseController
{
    private SubcategoriaServico servico;
    public SubcategoriaController() : base()
    {
        this.servico = new SubcategoriaServico(this.contexto);
    }

    [HttpGet("Subcategorias")]
    public List<SubcategoriaPoco> GetAll()
    {
        return this.servico.Listar();
    }

    [HttpGet("Subcategorias/PorCategoria/{categoriaId}")]
    public List<SubcategoriaPoco> GetByCategoriaId(int categoriaId)
    {
        return this.servico.Listar(sub => sub.CodigoCategoria == categoriaId);
    }

    [HttpGet("[controller]/{id}")]
    public SubcategoriaPoco GetById(int id)
    {
        return this.servico.Ler(id);
    }

    [HttpPost("[controller]")]
    public SubcategoriaPoco Post([FromBody]SubcategoriaPoco poco)
    {
        return this.servico.Inserir(poco);
    }

    [HttpPut("[controller]")]
    public SubcategoriaPoco Put([FromBody] SubcategoriaPoco poco)
    {
        return this.servico.Alterar(poco);
    }

    [HttpDelete("[controller]/{chave}")]
    public SubcategoriaPoco Delete(int chave)
    {
        return this.servico.Excluir(chave);
    }
}
