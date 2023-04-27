using Atacado.BD.EF.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtacadoApi.Controllers;

public abstract class BaseController : ControllerBase
{
    protected AtacadoContext contexto;

    public BaseController() : base()
    {
    {
        string connectionString = "Data Source=cgr_lab15_maq13\\sqlexpress;Initial Catalog=bdAtacado;User=usrAtacado;Password=senha123;TrustServerCertificate=True;";
        var options = new DbContextOptionsBuilder<AtacadoContext>().UseSqlServer(connectionString).Options;
        this.contexto = new AtacadoContext();
        var contexto = new AtacadoContext(options);
    }

    }
}
