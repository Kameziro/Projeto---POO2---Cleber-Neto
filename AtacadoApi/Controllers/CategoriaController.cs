using Atacado.BD.EF.Database;
using Atacado.Poco;
using Atacado.Servico;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtacadoApi.Controllers;

[ApiController]
[Route("api/Atacado/Estoque/")]
public class CategoriaController : BaseController
{
    private CategoriaServico servico;
    public CategoriaController() : base()
    {
        this.servico = new CategoriaServico(this.contexto);
    }

    [HttpGet("Categorias")]
    public List<CategoriaPoco> GetAll()
    {
        return this.servico.Listar();
    }

    [HttpGet("[controller]/{id}")]
    public CategoriaPoco GetById(int id)
    {
        return this.servico.Ler(id);
    }

    [HttpPost("[controller]")]
    public CategoriaPoco Post([FromBody]CategoriaPoco poco)
    {
        return this.servico.Inserir(poco);
    }

    [HttpPut("[controller]")]
    public CategoriaPoco Put([FromBody] CategoriaPoco poco)
    {
        return this.servico.Alterar(poco);
    }

    [HttpDelete("[controller]/{chave}")]
    public CategoriaPoco Delete(int chave)
    {
        return this.servico.Excluir(chave);
    }
}
