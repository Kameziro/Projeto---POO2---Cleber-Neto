using Atacado.BD.EF.Database;
using Atacado.Poco;
using Atacado.Servico;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtacadoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubcategoriaController : BaseController
{
    private SubcategoriaServico servico;
    public SubcategoriaController() : base()
    {
        this.servico = new SubcategoriaServico(this.contexto);
    }

    [HttpGet]
    public List<SubcategoriaPoco> GetAll()
    {
        return this.servico.Listar();
    }

    [HttpGet("{id}")]
    public SubcategoriaPoco GetById(int id)
    {
        return this.servico.Ler(id);
    }

    [HttpPost]
    public SubcategoriaPoco Post([FromBody]SubcategoriaPoco poco)
    {
        return this.servico.Inserir(poco);
    }

    [HttpPut]
    public SubcategoriaPoco Put([FromBody] SubcategoriaPoco poco)
    {
        return this.servico.Alterar(poco);
    }

    [HttpDelete]
    public SubcategoriaPoco Delete(int chave)
    {
        return this.servico.Excluir(chave);
    }
}
