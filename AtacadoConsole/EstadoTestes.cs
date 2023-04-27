using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class EstadoTestes : BaseTestes
{
    public EstadoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("--- Exibindo Estados ---");
        foreach (Estado item in context.Estados.ToList())
         {
             Console.WriteLine($"{item.CodigoEstado} - {item.CodigoRegiao} - {item.Nome}");
         }
         Console.WriteLine("--- Finalizando Estados ---");
         Console.ReadLine();
    }
}