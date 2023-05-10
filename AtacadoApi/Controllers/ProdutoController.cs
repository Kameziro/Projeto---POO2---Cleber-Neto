using Atacado.BD.EF.Database;
using Atacado.Poco;
using Atacado.Servico;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtacadoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : BaseController
{
    private ProdutoServico servico;
    
    public ProdutoController() : base()
    {
        this.servico = new ProdutoServico(this.contexto);
    }

    [HttpGet]
    public List<ProdutoPoco> GetAll()
    {
        return this.servico.Listar();
    }

    [HttpGet("{id}")]
    public ProdutoPoco GetById(int id)
    {
        return this.servico.Ler(id);
    }

    [HttpPost]
    public ProdutoPoco Post([FromBody]ProdutoPoco poco)
    {
        return this.servico.Inserir(poco);
    }

    [HttpPut]
    public ProdutoPoco Put([FromBody]ProdutoPoco poco)
    {
        return this.servico.Alterar(poco);
    }

    [HttpDelete]
    public ProdutoPoco Delete(int chave)
    {
        return this.servico.Excluir(chave);
    }
}
