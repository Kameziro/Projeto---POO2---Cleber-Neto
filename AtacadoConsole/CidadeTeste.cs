using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class CidadeTestes : BaseTestes
{
    public CidadeTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("--- Exibindo Cidades ---");
        foreach (Cidade item in context.Cidades.ToList())
         {
             Console.WriteLine($"{item.CodigoCidade} - {item.CodigoEstado} - {item.UF} - {item.Nome}");
         }
         Console.WriteLine("--- Finalizando Cidades ---");
         Console.ReadLine();
    }
}