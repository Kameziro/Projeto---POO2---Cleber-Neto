using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class ProdutoTestes : BaseTestes
{
    public ProdutoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("--- Exibindo Produtos ---");
        foreach (Produto item in context.Produtos.ToList())
         {
             Console.WriteLine($"{item.Codigo} - {item.CodigoSubcategoria} - {item.Descricao}");
         }
         Console.WriteLine("--- Finalizando Produtos ---");
         Console.ReadLine();
    }
}
