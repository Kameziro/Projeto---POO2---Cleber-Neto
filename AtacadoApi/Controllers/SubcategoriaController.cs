using Atacado.BD.EF.Database;
using Atacado.Poco;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtacadoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubcategoriaController : ControllerBase
{
    private AtacadoContext contexto;
    public SubcategoriaController() : base()
    {
        string connectionString = "Data Source=cgr_lab15_maq13\\sqlexpress;Initial Catalog=bdAtacado;User=usrAtacado;Password=senha123;TrustServerCertificate=True;";
        var options = new DbContextOptionsBuilder<AtacadoContext>().UseSqlServer(connectionString).Options;
        this.contexto = new AtacadoContext();
        var contexto = new AtacadoContext(options);
    }

    [HttpGet]
    public List<SubcategoriaPoco> GetAll()
    {
        List<SubcategoriaPoco> lista = new List<SubcategoriaPoco>();
        foreach (var item in this.contexto.Categorias)
        {
            SubcategoriaPoco poco = new SubcategoriaPoco();
            poco.Codigo = item.Codigo;
            poco.Descricao = item.Descricao;
            poco.Ativo = item.Ativo;
            poco.DataInclusao = item.DataInclusao;
            lista.Add(poco);
        }
        return lista;
    }
}
