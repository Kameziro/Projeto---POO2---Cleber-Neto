using Atacado.BD.EF.Database;
namespace AtacadoConsole;

public class SubcategoriaTestes : BaseTestes
{
    public SubcategoriaTestes(AtacadoContext contexto) : base (contexto)
    {}

    public override void Imprimir()
    {
        Console.WriteLine("--- Exibindo Subcategorias ---");
        foreach (Subcategoria item in context.Subcategorias.ToList())
         {
             Console.WriteLine($"{item.Codigo} - {item.CodigoCategoria} - {item.Descricao}");
         }
         Console.WriteLine("--- Finalizando Subcategorias ---");
         Console.ReadLine();
    }
}
