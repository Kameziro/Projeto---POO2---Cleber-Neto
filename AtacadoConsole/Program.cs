namespace AtacadoConsole;

using Atacado.BD.EF.Database;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        //Criando a string de conexão com o banco de dados SQL Server.
        string connectionString = "Data Source=cgr_lab15_maq13\\sqlexpress;Initial Catalog=bdAtacado;User=usrAtacado;Password=senha123;TrustServerCertificate=True;";
        var options = new DbContextOptionsBuilder<AtacadoContext>().UseSqlServer(connectionString).Options;
        var contexto = new AtacadoContext(options);

        BaseTestes teste;

        // teste = new CategoriaTestes(contexto);
        // teste = new SubcategoriaTestes(contexto);
        // teste = new ProdutoTestes(contexto);
        // teste = new RegiaoTestes(contexto);
        // teste = new EstadoTestes(contexto);
        // teste = new CidadeTestes(contexto);
        // teste = new BancoTestes(contexto);
        // teste = new AreaConhecimentoTestes(contexto);
        // teste.Imprimir()
;
        // foreach (Categorium item in contexto.Categoria.ToList())
        // {
        //     Console.WriteLine($"{item.Codigo} - {item.Descricao}");
        // }

        //Executando a pesquisa para obter todos os registros de Categoria.
        //Em seguida, abrindo os resultados e exibindo um por um.
    //     Console.WriteLine("Executando pesquisa...");

    //     Console.WriteLine("--- Exibindo Regiões ---");
    //     foreach (Regiao item in contexto.Regioes)
    //     {
    //         Console.WriteLine($"{item.CodigoRegiao} - {item.Nome}");
    //     }
    //     Console.ReadLine();

    //     Console.WriteLine("--- Exibindo Estados ---");
    //     foreach (Estado item in contexto.Estados)
    //     {
    //         Console.WriteLine($"{item.CodigoEstado} - {item.Nome} - {item.UF} - {item.CodigoRegiao}");
    //     }
    //     Console.ReadLine();
        
    //     Console.WriteLine("--- Exibindo Cidades ---");
    //     foreach (Cidade item in contexto.Cidades)
    //     {
    //         Console.WriteLine($"{item.CodigoCidade} - {item.Nome} - {item.CodigoIBGE7} - {item.UF} - {item.CodigoEstado}");
    //     }
       
    //     Console.WriteLine("Fim do programa");
    //     Console.ReadLine();
    }
}